using System.Collections;
using System.Collections.Generic;
using EZCameraShake;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{
    private void Awake()
    {
        this.Anim = base.GetComponent<Animator>();
        this.SetFireMode(0);
        this.CycleIndex = (this.RandomCycle ? Random.Range(0, this.CycleCount) : 0);
        this.AttackIndex = (this.RandomAttack ? Random.Range(0, this.AttackCount) : 0);
        this.StartingScale = base.transform.localScale;
        if (this.Offhand != null)
        {
            this.ArmScale = this.Offhand.localScale;
        }
    }

    private void OnEnable()
    {
        this.Draw();
    }

    private IEnumerator Start()
    {
        this.EndOfFrame = false;
        yield return new WaitForSeconds(0.15f);
        this.EndOfFrame = true;
        yield break;
    }

    private void Update()
    {
        if (this.Active && this.EndOfFrame)
        {
            this.InputUpdate();
            this.StateUpdate();
            this.MovementUpdate();
        }
        this.WeaponAttackUpdate();
    }

    private void InputUpdate()
    {
        if (!this.DualWielding || (this.DualWielding && this.LeftHanded))
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                this.Attack(this.Inserting);
            }
            else if (this.CurrentFireMode != WeaponScript.Mode.Cycle)
            {
                this.Released = true;
            }
        }
        else if (this.DualWielding && !this.LeftHanded)
        {
            if (Input.GetKey(KeyCode.Mouse1))
            {
                this.Attack(this.Inserting);
            }
            else if (this.CurrentFireMode != WeaponScript.Mode.Cycle)
            {
                this.Released = true;
            }
        }
        if (Input.GetKey(KeyCode.Mouse1))
        {
            if (!this.DualWielding && !this.TransitionProtection)
            {
                this.TransitionStart();
            }
            this.TransitionProtection = true;
        }
        else
        {
            this.TransitionProtection = false;
        }
        if (Input.GetKey(KeyCode.Mouse1) || (Input.GetKey(KeyCode.Mouse0) && !this.Released))
        {
            this.CycleStart();
        }
        if (Input.GetKey(KeyCode.R) && !this.CurrentDrawFromPool)
        {
            this.ReloadStart();
        }
        if (Input.GetKey(KeyCode.I))
        {
            this.Inspect();
        }
    }

    private void StateUpdate()
    {
        this.DualLowered = (this.DualWielding) || (this.DualWielding);
        this.Engaged = this.Sprinting || this.WeaponCycling || this.Switching || this.Reloading || this.Inspecting || this.DualHandFiring || this.Occupied;
        this.OffhandOn = !this.DualWielding;
        Sprinting = false;
        this.StatePosition = (this.DualWielding ? this.DualPosition : ((Input.GetKey(KeyCode.LeftControl) && !this.Reloading && !this.Inspecting) ? this.CrouchPosition : this.IdlePosition));
        this.StateRotation = (this.DualWielding ? this.DualRotation : ((Input.GetKey(KeyCode.LeftControl) && !this.Reloading && !this.Inspecting) ? this.CrouchRotation : this.IdleRotation));
        if (this.OldState != this.StatePosition)
        {
            this.BumpSpeed(3.5f, 0.5f);
            this.OldState = this.StatePosition;
        }
        if (this.Offhand != null)
        {
            bool flag = this.WeaponCycling || this.Reloading || this.DualHandFiring;
            this.Offhand.localScale = ((this.OffhandOn || flag) ? Vector3.Lerp(this.Offhand.localScale, this.ArmScale, 25f * Time.deltaTime) : Vector3.Lerp(this.Offhand.localScale, Vector3.zero, 25f * Time.deltaTime));
        }
    }

    private void MovementUpdate()
    {
        this.Anim.SetBool("Sprinting", this.Sprinting);
        this.movementX = -Input.GetAxis("Mouse X") * this.SwayMultiplier;
        this.movementY = -Input.GetAxis("Mouse Y") * this.SwayMultiplier / 2f;
        this.movementX = Mathf.Clamp(this.movementX, -this.MaxSway, this.MaxSway);
        this.movementY = Mathf.Clamp(this.movementY, -this.MaxSway, this.MaxSway);
        this.LeftRight = (((Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D)) || (!(Input.GetKey(KeyCode.A)) && !(Input.GetKey(KeyCode.D))) ? 0 : ((Input.GetKey(KeyCode.D) ? 1 : (-1)))));
        this.ForwardBack = (((Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.S)) || (!(Input.GetKey(KeyCode.W)) && !(Input.GetKey(KeyCode.S))) ? 0 : ((Input.GetKey(KeyCode.S) ? (-1) : 1))));
        Vector3 vector = new Vector3(this.movementX, this.movementY, 0f);
        Vector3 vector2 = new Vector3(this.movementY / 5f, -this.movementX / 5f, 0f);
        Vector3 vector3 = new Vector3((this.StatePosition.x + this.AlteredMovement * (float)this.LeftRight) * (float)((this.DualWielding && this.LeftHanded) ? (-1) : 1), this.StatePosition.y + ((false) ? this.AlteredMovement : 0f), this.StatePosition.z + this.AlteredMovement * (float)this.ForwardBack);
        Vector3 vector4 = vector2 * 250f + new Vector3(this.StateRotation.x, this.StateRotation.y * (float)((this.DualWielding && this.LeftHanded) ? (-1) : 1), this.StateRotation.z * (float)((this.DualWielding && this.LeftHanded) ? (-1) : 1)) + new Vector3(this.AdjustedFirePose * -7.5f, 0f, 0f);
        base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, vector + vector3, Time.deltaTime * (this.SwaySpeed * this.SwayModifier));
        base.transform.localRotation = Quaternion.Lerp(base.transform.localRotation, Quaternion.Euler(vector4), Time.deltaTime * (this.SwaySpeed * this.SwayModifier));
        base.transform.localScale = new Vector3(this.StartingScale.x * (float)((this.DualWielding && this.LeftHanded) ? (-1) : 1), this.StartingScale.y, this.StartingScale.z);
        this.SwayModifier = ((this.SwayResetTime <= 0f) ? 1f : this.SwayModifier);
        this.SwayResetTime = ((this.SwayResetTime > 0f) ? (this.SwayResetTime -= Time.deltaTime) : 0f);
    }

    private void WeaponAttackUpdate()
    {
        this.AdjustedRateOfFire = ((!this.CurrentWeaponRateOfFireRamp) ? this.CurrentWeaponRateOfFire : ((Input.GetKey(KeyCode.Mouse0) || this.CurrentAmmo <= 0) ? Mathf.Lerp(this.AdjustedRateOfFire, this.CurrentWeaponRateOfFire, this.CurrentWeaponRateOfFireAcceleration.y * Time.deltaTime) : this.AdjustedRateOfFire));
        this.CanFire = this.RateOfFire <= 0f && ((!this.CurrentDrawFromPool && this.CurrentAmmo > 0) || this.CurrentDrawFromPool) && this.Released && !this.Reloading && !this.Engaged && !this.Bursting && !this.WeaponCycling && !this.Charging && this.BurstTime <= 0f;
        this.RateOfFire = ((this.RateOfFire > 0f) ? (this.RateOfFire -= Time.deltaTime * 1) : 0f);
        this.CurrentFirePose = ((this.CurrentFirePose > 0f) ? (this.CurrentFirePose -= Time.deltaTime * 15f) : 0f);
        this.AdjustedFirePose = Mathf.Lerp(this.AdjustedFirePose, this.CurrentFirePose, 15f * Time.deltaTime);
        if (this.CurrentFireMode == WeaponScript.Mode.Burst)
        {
            if (this.BurstTime <= 0f)
            {
                if (this.Bursting)
                {
                    this.Attack(true);
                }
            }
            else
            {
                this.BurstTime -= Time.deltaTime;
            }
        }
        if (this.CurrentHeat > 0f)
        {
            this.CurrentHeat -= Time.deltaTime * 30f;
            if (this.CurrentHeat >= 100f && !this.Reloading)
            {
                this.CurrentAmmo = 0;
                this.CurrentHeat = 110f;
                this.ForceReload();
            }
        }
        this.FireModes[this.CurrentFireModeIndex].AmmoInWeapon = this.CurrentAmmo;
    }

    private void Attack(bool Override)
    {
        if (this.CanFire || (Override && ((!this.CurrentDrawFromPool && this.CurrentAmmo > 0) || (this.CurrentDrawFromPool && 1 > 0))))
        {
            if (this.CurrentFireMode == WeaponScript.Mode.SemiAuto || this.CurrentFireMode == WeaponScript.Mode.Cycle || this.CurrentFireMode == WeaponScript.Mode.Burst)
            {
                this.Released = false;
            }
            if (this.CurrentFireMode == WeaponScript.Mode.FullAuto)
            {
                this.Released = true;
            }
            if (this.CurrentFireMode == WeaponScript.Mode.Burst)
            {
                if (!this.Bursting)
                {
                    this.BurstCount = this.CurrentWeaponBurstCount;
                    this.Bursting = true;
                }
                this.BurstCount--;
                this.BurstTime = this.AdjustedRateOfFire;
                this.Bursting = this.BurstCount > 0;
                this.BurstTime = (this.Bursting ? this.AdjustedRateOfFire : this.CurrentWeaponBurstRecovery);
            }
            this.CanFire = false;
            this.Inserting = false;
            this.Reloading = false;
            this.WeaponCycling = false;
            this.Inspecting = false;
            this.AdjustedRateOfFire = (false ? (this.CurrentWeaponRateOfFireRamp ? this.CurrentWeaponMaxRateOfFire : this.CurrentWeaponRateOfFire) : (this.CurrentWeaponRateOfFireRamp ? ((this.AdjustedRateOfFire - this.CurrentWeaponRateOfFireAcceleration.x <= this.CurrentWeaponMaxRateOfFire) ? this.CurrentWeaponMaxRateOfFire : (this.AdjustedRateOfFire - this.CurrentWeaponRateOfFireAcceleration.x)) : this.CurrentWeaponRateOfFire));
            this.RateOfFire = this.AdjustedRateOfFire;
            base.StartCoroutine(this.FireProjectile(this.CurrentProjectileDelayTime));
        }
    }

    private IEnumerator FireProjectile(float DelayTime)
    {
        if (DelayTime >= 0f && !this.Charging)
        {
            this.Anim.SetTrigger("Charge");
            this.Charging = true;
        }
        yield return new WaitForSeconds(DelayTime);
        if (this.CurrentDrawFromPool || this.CurrentAmmo >= this.CurrentProjectileConsumption)
        {
            this.Anim.SetFloat("AttackBlend", (float)this.AttackIndex);
            this.Anim.SetTrigger("Attack");
            this.CurrentFirePose = 1f;
            this.CurrentFirePose = ((this.CurrentFirePose > 1f) ? 1f : this.CurrentFirePose);
            this.AttackIndex = (this.RandomAttack ? Random.Range(0, this.AttackCount) : ((this.AttackIndex >= this.AttackCount - 1) ? 0 : (this.AttackIndex + 1)));
            this.CurrentHeat += this.CurrentProjectileHeat * (1f);
            this.CurrentAmmo -= ((this.CurrentDrawFromPool) ? 0 : ((this.CurrentFireMode == WeaponScript.Mode.Cycle) ? 0 : this.CurrentProjectileConsumption));
            this.BonusEffectAmmo -= ((this.BonusEffectAmmo <= 0) ? 0 : this.CurrentProjectileConsumption);
            this.UpdateAmmo();
            int currentProjectileCount = this.CurrentProjectileCount;
        }
        this.Charging = false;
        if (1 <= 0 && this.Bursting && this.CurrentDrawFromPool)
        {
            this.Bursting = false;
            this.BurstCount = 0;
            this.BurstTime = 0f;
        }
        if (this.CurrentAmmo <= 0 && this.CurrentFireMode != WeaponScript.Mode.Cycle)
        {
            base.StartCoroutine(this.AutoReload());
            this.Bursting = false;
            this.BurstCount = 0;
            this.BurstTime = 0f;
        }
        yield break;
    }

    private void CycleStart()
    {
        if (!this.Reloading && !this.Engaged && this.RateOfFire <= 0f && this.CurrentAmmo > 0 && this.CurrentFireMode == WeaponScript.Mode.Cycle)
        {
            this.CurrentAmmo--;
            this.Anim.SetFloat("CycleBlend", (float)this.CycleIndex);
            this.Anim.SetTrigger("Cycle");
            this.WeaponCycling = true;
            this.UpdateAmmo();
            this.CycleIndex = (this.RandomCycle ? Random.Range(0, this.CycleCount) : ((this.CycleIndex >= this.CycleCount - 1) ? 0 : (this.CycleIndex + 1)));
        }
    }

    public void CycleEnd()
    {
        this.Released = true;
        this.WeaponCycling = false;
        this.ReloadAfterCycle = false;
        if (this.ReloadAfterCycle || this.CurrentAmmo <= 0)
        {
            base.StartCoroutine(this.AutoReload());
        }
    }

    private IEnumerator AutoReload()
    {
        if ((this.DualWielding && 1 <= 0) || !this.DualWielding)
        {
            yield return new WaitForSeconds(this.CurrentWeaponRateOfFire * 2f);
            this.ReloadStart();
        }
        yield break;
    }

    public void ReloadStart()
    {
        ForceReload();
        /*        if (((this.DualWielding && true && this.CurrentAmmo < this.MaxAmmo) || (this.DualWielding &&  == this && this.Inventory.CurrentWeapon.CurrentAmmo == this.Inventory.CurrentWeapon.MaxAmmo) || (this.DualWielding && this.Inventory.OffhandWeapon == this && this.Inventory.CurrentWeapon.CurrentAmmo <= 0) || !this.DualWielding) && ((this.DualWielding && this.Inventory.CurrentWeapon == this && !this.Inventory.OffhandWeapon.Reloading) || (this.DualWielding && this.Inventory.OffhandWeapon == this && !this.Inventory.CurrentWeapon.Reloading) || !this.DualWielding) && !this.Reloading && this.CurrentAmmo != this.MaxAmmo && !this.Engaged && !this.WeaponCycling && !this.Bursting && this.Inventory.Ammo[(int)this.CurrentWeaponAmmoType].CurrentAmmoCount > 0 && this.RateOfFire <= 0f)
                {
                }*/
    }

    private void ForceReload()
    {
        if (!this.Reloading)
        {
            if (!this.Released && this.CurrentFireMode == WeaponScript.Mode.Cycle)
            {
                this.CycleStart();
                this.ReloadAfterCycle = true;
                return;
            }
            this.Anim.SetFloat("ReloadStartBlend", (float)((this.CurrentAmmo <= 0) ? 1 : 0));
            this.Anim.SetTrigger("ReloadStart");
            this.EmptyReload = this.CurrentAmmo == 0;
            this.WeaponCycling = false;
            this.Reloading = true;
            this.Bursting = false;
            this.BurstCount = 0;
            this.BurstTime = 0f;
        }
    }

    public void ReloadInsert()
    {
        if (this.Reloading)
        {
            if (this.CurrentAmmo < this.MaxAmmo && 1 > 0)
            {
                this.Inserting = true;
                int num = 0;
                int num2 = 0;
                foreach (ReloadType reloadType in this.ReloadTypes)
                {
                    if (num2 <= reloadType.AmmoCount && reloadType.AmmoCount <= this.MaxAmmo - this.CurrentAmmo && reloadType.AmmoCount <= 1)
                    {
                        num = this.ReloadTypes.IndexOf(reloadType);
                        num2 = reloadType.AmmoCount;
                    }
                }
                this.Anim.SetFloat("ReloadInsertBlend", (float)num);
                this.Anim.SetTrigger("ReloadInsert");
                return;
            }
            this.ReloadReturn();
        }
    }

    public void ReloadIncreaseAmmo(int AmmoAmount)
    {
        int num = ((AmmoAmount > this.MaxAmmo - this.CurrentAmmo) ? (this.MaxAmmo - this.CurrentAmmo) : AmmoAmount);
        this.CurrentAmmo += Mathf.Clamp(num, 0, MaxAmmo);
        this.UpdateAmmo();
    }

    public void ReloadSpendAmmo(int AmmoAmount)
    {
        int num = ((AmmoAmount <= this.CurrentAmmo) ? AmmoAmount : this.CurrentAmmo);
        this.CurrentAmmo += num;
        this.UpdateAmmo();
    }

    public void FreeRefill()
    {
        this.CurrentAmmo = this.MaxAmmo;
        this.UpdateAmmo();
    }

    public void ReloadDetail(string ReloadType)
    {
        if (ReloadType == "EjectShell" && this.CurrentAmmo >= this.CurrentProjectileConsumption)
        {
            this.CurrentAmmo -= this.CurrentProjectileConsumption;
        }
        if (ReloadType == "RemoveMagazine" && this.CurrentAmmo >= this.CurrentProjectileConsumption)
        {
            this.EjectedMagazineAmmo = this.CurrentAmmo - this.CurrentProjectileConsumption;
            this.CurrentAmmo = this.CurrentProjectileConsumption;
        }
        if (ReloadType == "ChamberRound")
        {
            this.CurrentAmmo += this.CurrentProjectileConsumption;
        }
        if (ReloadType == "InsertMagazine")
        {
            this.CurrentAmmo += this.EjectedMagazineAmmo;
            this.CurrentAmmo = ((this.CurrentAmmo >= this.MaxAmmo) ? this.MaxAmmo : this.CurrentAmmo);
        }
        this.UpdateAmmo();
    }

    private void ReloadReturn()
    {
        if (this.Reloading)
        {
            this.Anim.SetFloat("ReloadEndBlend", (float)(this.EmptyReload ? 1 : 0));
            this.Anim.SetTrigger("ReloadEnd");
        }
    }

    public void ReloadEnd()
    {
        if (this.Reloading)
        {
            this.WeaponCycling = false;
            this.Reloading = false;
            this.Inserting = false;
            this.UpdateAmmo();
        }
    }

    public void UpdateAmmo()
    {
        /*        if (this.Inventory.CurrentWeapon != null)
                {
                    if (this.CurrentDrawFromPool)
                    {
                        this.CurrentAmmo = ((this.Inventory.Ammo[(int)this.CurrentWeaponAmmoType].CurrentAmmoCount >= this.MaxAmmo) ? this.MaxAmmo : this.Inventory.Ammo[(int)this.CurrentWeaponAmmoType].CurrentAmmoCount);
                    }
                    this.HUD.AdjustWeaponInformation(this.Inventory.Guns[this.WeaponID].WeaponIcon, this.WeaponName + (this.Upgraded ? "+" : ""), this.GM.RapidFire ? "∞" : (this.CurrentDrawFromPool ? "" : this.CurrentAmmo.ToString()), (this.CurrentWeaponAmmoType == WeaponScript.WeaponAmmoType.Basic) ? "∞" : this.Inventory.Ammo[(int)this.CurrentWeaponAmmoType].CurrentAmmoCount.ToString(), (float)this.CurrentAmmo / (float)this.MaxAmmo, this.DualWielding && !this.LeftHanded);
                    if (!this.Inspecting && !this.Reloading)
                    {
                        this.Anim.SetFloat("CurrentAmmo", (float)this.CurrentAmmo);
                    }
                    if (this.BonusEffectAmmo <= 0)
                    {
                        this.CurrentBonusEffect = Projectile.BulletEffect.None;
                    }
                }
        */
        this.Anim.SetFloat("CurrentAmmo", (float)this.CurrentAmmo);
    }

    public void TransitionEnd()
    {
        this.Switching = false;
    }

    private void TransitionStart()
    {
        if (this.TransitionIsInteract)
        {
            if (this.TransitionIsInteract && !this.Engaged && !this.Switching && !this.Bursting && this.RateOfFire <= 0f)
            {
                this.Anim.SetTrigger("Transition");
                this.Switching = true;
                return;
            }
        }
        else if (this.FireModes.Count > 1 && !this.Engaged && !this.Switching && !this.Bursting && this.RateOfFire <= 0f)
        {
            int modeIndex = this.ModeIndex;
            this.ModeIndex = ((this.ModeIndex >= this.FireModes.Count - 1) ? 0 : (this.ModeIndex + 1));
            if (this.CurrentAmmo >= this.FireModes[this.ModeIndex].AmmoConsumption)
            {
                this.Anim.SetTrigger("Transition");
                this.SetFireMode(this.ModeIndex);
                this.Switching = true;
                return;
            }
            this.ModeIndex = modeIndex;
        }
    }

    private void Inspect()
    {
        if (!this.Inspecting && !this.Engaged && !this.DualWielding)
        {
            if (this.InspectRoutine != null)
            {
                base.StopCoroutine(this.InspectRoutine);
            }
            this.Anim.SetTrigger("Inspect");
            this.Inspecting = true;
        }
    }

    /*    private IEnumerator InspectWeaponRoutine()
        {
            this.HUD.CornerPopUp("DESIGNATION: " + this.WeaponName, 20, 2f);
            yield return new WaitForSeconds(1f);
            this.HUD.CornerPopUp("MODE: " + this.FireModes[this.CurrentFireModeIndex].ModeName, 20, 2f);
            yield return new WaitForSeconds(1f);
            this.HUD.CornerPopUp("DAMAGE: " + (this.CurrentProjectileDamage * (this.Upgraded ? 1.5f : 1f)).ToString(), 20, 2f);
            yield return new WaitForSeconds(1f);
            this.HUD.CornerPopUp("SHIELD EFFECTIVENESS: " + (this.CurrentProjectileShieldPercentage * (this.Upgraded ? 1.5f : 1f)).ToString() + "%", 20, 2f);
            yield return new WaitForSeconds(1f);
            this.HUD.CornerPopUp("RANGE: " + (this.CurrentProjectileRange * (this.Upgraded ? 1.5f : 1f)).ToString(), 20, 2f);
            yield return new WaitForSeconds(1f);
            this.HUD.CornerPopUp("INACCURACY: " + (this.CurrentWeaponInaccuracy * (this.Upgraded ? 0.5f : 1f)).ToString(), 20, 2f);
            yield return new WaitForSeconds(1f);
            this.HUD.CornerPopUp("PROJECTILES PER SHOT: " + this.CurrentProjectileCount.ToString(), 20, 2f);
            yield break;
        }*/

    public void InspectEnd()
    {
        this.Inspecting = false;
    }

    public void SetFireMode(int Index)
    {
        if (this.CurrentFireModeIndex != Index)
        {
            this.CurrentFireModeIndex = Index;
        }
        foreach (ModeSetting modeSetting in this.FireModes)
        {
            this.Anim.SetLayerWeight(this.FireModes.IndexOf(modeSetting) + 1, 0f);
        }
        this.Anim.SetLayerWeight(this.CurrentFireModeIndex + 1, 1f);
        this.CurrentEffect = this.FireModes[this.CurrentFireModeIndex].Effect;
        this.CurrentFireMode = this.FireModes[this.CurrentFireModeIndex].FireMode;
        this.CurrentProjectile = this.FireModes[this.CurrentFireModeIndex].Projectile;
        this.CurrentWeaponAmmoType = this.FireModes[this.CurrentFireModeIndex].AmmoType;
        this.IdlePosition = this.FireModes[this.CurrentFireModeIndex].IdlePosition;
        this.IdleRotation = this.FireModes[this.CurrentFireModeIndex].IdleRotation;
        this.CrouchPosition = this.FireModes[this.CurrentFireModeIndex].CrouchPosition;
        this.CrouchRotation = this.FireModes[this.CurrentFireModeIndex].CrouchRotation;
        this.DualPosition = this.FireModes[this.CurrentFireModeIndex].DualPosition;
        this.DualRotation = this.FireModes[this.CurrentFireModeIndex].DualRotation;
        this.CurrentDrawFromPool = this.FireModes[this.CurrentFireModeIndex].DrawFromPool;
        this.RecoilMagnitude = this.FireModes[this.CurrentFireModeIndex].RecoilMagnitude;
        this.RecoilRoughness = this.FireModes[this.CurrentFireModeIndex].RecoilRoughness;
        this.RecoilFadeIn = this.FireModes[this.CurrentFireModeIndex].RecoilFadeIn;
        this.RecoilFadeOut = this.FireModes[this.CurrentFireModeIndex].RecoilFadeOut;
        this.CurrentBulletObject = this.FireModes[this.CurrentFireModeIndex].BulletObject;
        this.CurrentHitEffect = this.FireModes[this.CurrentFireModeIndex].HitEffect;
        this.CurrentMissEffect = this.FireModes[this.CurrentFireModeIndex].MissEffect;
        this.CurrentProjectileDamage = this.FireModes[this.CurrentFireModeIndex].Damage;
        this.CurrentProjectileShieldPercentage = this.FireModes[this.CurrentFireModeIndex].ShieldPercentage;
        this.CurrentProjectileSpeed = this.FireModes[this.CurrentFireModeIndex].Speed;
        this.CurrentProjectileHeat = this.FireModes[this.CurrentFireModeIndex].Heat;
        this.CurrentProjectileRange = this.FireModes[this.CurrentFireModeIndex].Range;
        this.CurrentProjectileDelayTime = this.FireModes[this.CurrentFireModeIndex].Delay;
        this.CurrentProjectileCount = this.FireModes[this.CurrentFireModeIndex].ProjectileCount;
        this.CurrentPierceCount = this.FireModes[this.CurrentFireModeIndex].PierceCount;
        this.CurrentProjectileConsumption = this.FireModes[this.CurrentFireModeIndex].AmmoConsumption;
        this.CurrentWeaponInaccuracy = this.FireModes[this.CurrentFireModeIndex].Inaccuracy;
        this.CurrentWeaponRateOfFire = this.FireModes[this.CurrentFireModeIndex].RateOfFire;
        this.CurrentWeaponRateOfFireRamp = this.FireModes[this.CurrentFireModeIndex].CanRampRateOfFire;
        this.CurrentWeaponMaxRateOfFire = this.FireModes[this.CurrentFireModeIndex].MaxRateOfFire;
        this.CurrentWeaponRateOfFireAcceleration = this.FireModes[this.CurrentFireModeIndex].RateOfFireAcceleration;
        this.CurrentWeaponBurstRecovery = this.FireModes[this.CurrentFireModeIndex].BurstRecovery;
        this.CurrentWeaponBurstCount = this.FireModes[this.CurrentFireModeIndex].BurstCount;
        this.AdjustedRateOfFire = this.CurrentWeaponRateOfFire;
        if (this.SeparateAmmoPools)
        {
            this.CurrentAmmo = this.FireModes[this.CurrentFireModeIndex].AmmoInWeapon;
        }
        this.WeaponMaterial.CopyPropertiesFromMaterial(this.FireModes[this.CurrentFireModeIndex].ModeMaterial);
        this.UpdateAmmo();
    }

    public void Draw()
    {
        this.RateOfFire = 0.15f;
        this.BumpSpeed(5f, 0.5f);
        this.CurrentHeat = ((this.CurrentHeat <= 15f) ? 0f : (this.CurrentHeat - 15f));
        base.transform.localPosition = new Vector3(this.IdlePosition.x, this.IdlePosition.y - 5f, this.IdlePosition.z - 5f);
        this.CurrentAmmo = (this.CurrentDrawFromPool ? 100 : this.CurrentAmmo);
        this.UpdateAmmo();
        base.StartCoroutine(this.DelayDraw());
        if (this.NewWeapon && !this.DualWielding)
        {
            bool flag = false;
            foreach (ModeSetting modeSetting in this.FireModes)
            {
                if (modeSetting.AmmoType != this.FireModes[0].AmmoType || modeSetting.DrawFromPool != this.FireModes[0].DrawFromPool)
                {
                    flag = true;
                }
                if (!modeSetting.DrawFromPool)
                {
                    modeSetting.AmmoInWeapon = this.MaxAmmo;
                }
                else
                {
                    modeSetting.AmmoInWeapon = 100;
                }
            }
            this.SeparateAmmoPools = flag;
        }
        if (this.CurrentAmmo <= 0)
        {
            base.StartCoroutine(this.AutoReload());
        }
        this.Active = true;
        this.Charging = false;
        this.Reloading = false;
        this.Sprinting = false;
        this.Switching = false;
        this.Inspecting = false;
        this.WeaponCycling = false;
        this.DualHandFiring = false;
        this.ReloadAfterCycle = false;
        this.SetFireMode(this.ModeIndex);
    }

    private IEnumerator DelayDraw()
    {
        yield return new WaitForEndOfFrame();
        if ((this.NewWeapon && !this.DualWielding))
        {
            this.Anim.SetTrigger("Draw");
            this.NewWeapon = false;
        }
        yield break;
    }

    public void DrawEnd()
    {
        this.NewWeapon = false;
    }

    public void ToggleUpgrade(bool IsUpgraded)
    {
        this.Upgraded = IsUpgraded;
        if (this.UpgradedObjects != null)
        {
            this.UpgradedObjects.SetActive(IsUpgraded);
        }
        if (this.GenericObjects != null)
        {
            this.GenericObjects.SetActive(!IsUpgraded);
        }
    }

    public void ToggleBonusEffect(Projectile.BulletEffect Effect)
    {
        this.CurrentBonusEffect = Effect;
        this.BonusEffectAmmo += this.MaxAmmo;
    }

    public void RefreshWeapon()
    {
        this.NewWeapon = true;
    }

    public void DualHanding()
    {
        this.DualHandFiring = true;
    }

    public void DualHandingEnd()
    {
        this.DualHandFiring = false;
    }

    public void Lower()
    {
        base.transform.localPosition = new Vector3(this.StatePosition.x, this.StatePosition.y - 5f, this.StatePosition.z - 5f);
        this.Active = false;
    }

    public void Raise()
    {
        base.transform.localPosition = new Vector3(this.StatePosition.x, this.StatePosition.y - 2f, this.StatePosition.z - 3f);
        this.BumpSpeed(3.5f, 0.65f);
        this.Active = true;
        if (this.NewWeapon)
        {
            this.Draw();
        }
    }

    public void BumpSpeed(float NewSpeed, float NewResetTime)
    {
        this.SwayModifier = NewSpeed;
        this.SwayResetTime = NewResetTime;
    }

    public void BumpPosition(Vector3 BumpAmount)
    {
        base.transform.localPosition = new Vector3(base.transform.localPosition.x + BumpAmount.x, base.transform.localPosition.y + BumpAmount.y, base.transform.localPosition.z + BumpAmount.z);
    }

    public void DualWield(bool LeftHanding)
    {
        this.BumpPosition(new Vector3(0f, -5f, -5f));
        this.SetFireMode(0);
        this.DualWielding = true;
        this.LeftHanded = LeftHanding;
    }

    public void SingleWield()
    {
        this.BumpPosition(new Vector3(0f, -5f, -5f));
        this.DualWielding = false;
    }

    public void CopyWeaponStats()
    {
        if (this.CanCopyStats && this.WeaponToCopy != null && this.WeaponToCopy.FireModes.Count > this.FireModeIndex)
        {
            this.FireModes[this.FireModeIndex] = this.WeaponToCopy.FireModes[this.FireModeIndex];
        }
    }

    public void SetBabeFromCopy()
    {
        if (this.CanCopyStats && this.WeaponToCopy != null && this.WeaponToCopy.FireModes.Count > this.FireModeIndex)
        {
            this.FireModes[this.FireModeIndex].Damage = this.WeaponToCopy.FireModes[this.FireModeIndex].Damage * 2f;
            this.FireModes[this.FireModeIndex].Range = this.WeaponToCopy.FireModes[this.FireModeIndex].Range * 2f;
            this.FireModes[this.FireModeIndex].Inaccuracy = this.WeaponToCopy.FireModes[this.FireModeIndex].Inaccuracy / 2f;
            this.FireModes[this.FireModeIndex].ShieldPercentage = this.WeaponToCopy.FireModes[this.FireModeIndex].ShieldPercentage * 2f;
            this.FireModes[this.FireModeIndex].ShieldPercentage = ((this.FireModes[this.FireModeIndex].ShieldPercentage >= 500f) ? 500f : this.FireModes[this.FireModeIndex].ShieldPercentage);
        }
    }

    [Tooltip("Can this weapon copy stats from another weapon? Usually for BABEd guns")]
    public bool CanCopyStats;

    [ConditionalField("CanCopyStats", null)]
    public WeaponScript WeaponToCopy;

    [ConditionalField("CanCopyStats", null)]
    public int FireModeIndex;

    [Header("WEAPON STATS")]
    [Tooltip("The name of the weapon, keep it in ALL CAPS")]
    public string WeaponName;

    [Tooltip("Should the attack blend value be random?")]
    public bool RandomAttack;

    [Tooltip("Should the cycle blend value be random?")]
    public bool RandomCycle;

    [Tooltip("The maximum amount of ammo this weapon can hold in a mag")]
    public int MaxAmmo;

    [Tooltip("The amount of attack animations this weapon has")]
    public int AttackCount = 1;

    [Tooltip("The amount of cycle animations this weapon has")]
    public int CycleCount = 1;

    [Tooltip("I dunno what this does, leave it at 1")]
    public float SwayMultiplier = 1;

    [Tooltip("The maximum amount the weapon can sway when the camera moves. Changing it is not recommended.")]
    public float MaxSway = .1f;

    [Tooltip("The speed at which the weapon sways. Changing it is not recommended.")]
    public float SwaySpeed = 3;

    [Tooltip("The inspect camera animation, there are 4 of them I don't know why. You can blend between them by using a decimal.")]
    [Range(0, 3)]
    public float InspectBlend;

    [HideInInspector]
    public float ZoomMultiplier = 2f;

    [HideInInspector]
    public float AmmoCounterDividend = 0.25f;

    [HideInInspector]
    public float WeaponZoomMultiplier = 10f;

    [Tooltip("The weapon's material, this is used to change the color of the weapon")]
    public Material WeaponMaterial;

    [Tooltip("A game object that should only be active when it's not upgraded")]
    public GameObject GenericObjects;

    [Tooltip("A game object that should only be active when it's upgraded")]
    public GameObject UpgradedObjects;

    [Tooltip("The location projectiles come from. The object you put here should be a child of the gun on your rig. If the muzzle moves separately from the rest of the gun then it should be a child of the muzzle on the rig.")]
    public Transform MuzzleLocation;

    [Tooltip("The left arm of the view model on the rig, named Arm.L on the standard gttod rig")]
    public Transform Offhand;

    [Tooltip("The mesh of the hands, named KRV-Hands-V2 on the standard gttod rig. Needed for cozy mode")]
    public SkinnedMeshRenderer Arms;

    [Tooltip("Can you dual wield it?")]
    public bool CanDualWield;

    [Tooltip("Allows for right click (by default) to play the transition animation but not switch fire modes")]
    public bool TransitionIsInteract;

    [Header("VARIABLES")]
    public List<ReloadType> ReloadTypes;

    public List<ModeSetting> FireModes;

    [HideInInspector]
    public float CurrentHeat;

    [HideInInspector]
    public int WeaponID;

    [HideInInspector]
    public int CurrentAmmo;

    [HideInInspector]
    public bool CanFire = true;

    [HideInInspector]
    public bool IsModdedWeapon;

    [HideInInspector]
    public bool LeftHanded;

    [HideInInspector]
    public bool Upgraded;

    [HideInInspector]
    public bool Occupied;

    [HideInInspector]
    public bool Special;

    [HideInInspector]
    public bool Engaged;

    [HideInInspector]
    public bool Reloading;

    [HideInInspector]
    public WeaponScript.WeaponAmmoType CurrentWeaponAmmoType;

    [HideInInspector]
    public int CurrentFireModeIndex;

    [HideInInspector]
    public int ModeIndex;

    private WeaponScript.Mode CurrentFireMode;

    private Projectile.BulletEffect CurrentEffect;

    private Projectile.BulletEffect CurrentBonusEffect;

    private Projectile.BulletType CurrentProjectile;

    private GameObject CurrentBulletObject;

    private GameObject CurrentHitEffect;

    private GameObject CurrentMissEffect;

    private bool CurrentDrawFromPool;

    private float CurrentProjectileDamage;

    private float CurrentProjectileShieldPercentage;

    private float CurrentProjectileSpeed;

    private float CurrentProjectileHeat;

    private float CurrentProjectileRange;

    private float CurrentProjectileDelayTime;

    private int CurrentPierceCount;

    private int CurrentProjectileCount;

    private int CurrentProjectileConsumption;

    private float CurrentWeaponInaccuracy;

    private float CurrentWeaponRateOfFire;

    private bool CurrentWeaponRateOfFireRamp;

    private float CurrentWeaponMaxRateOfFire;

    private Vector2 CurrentWeaponRateOfFireAcceleration;

    private float CurrentWeaponBurstRecovery;

    private int CurrentWeaponBurstCount;

    private GameManager GM;

    private GameObject Player;

    private ac_ObjectPool ObjectPool;

    private Animator Anim;

    private Coroutine InspectRoutine;

    private Vector3 IdlePosition;

    private Vector3 IdleRotation;

    private Vector3 CrouchPosition;

    private Vector3 CrouchRotation;

    private Vector3 DualPosition;

    private Vector3 DualRotation;

    private bool Active;

    private bool Released = true;

    private bool Bursting;

    private bool Charging;

    private bool NewWeapon = true;

    private bool OffhandOn = true;

    private bool Switching;

    private bool Sprinting;

    private bool Inspecting;

    private bool EmptyReload;

    private bool WeaponCycling;

    private bool ReloadAfterCycle;

    private bool TransitionProtection;

    private bool DualHandFiring;

    private bool DualWielding;

    private bool DualLowered;

    private bool Inserting;

    private bool TheLoversEnabled;

    private bool SeparateAmmoPools;

    private bool EndOfFrame;

    private float movementX;

    private float movementY;

    private float RateOfFire;

    private float AlteredMovement = -0.1f;

    private float SwayModifier = 1f;

    private float SwayResetTime;

    private float BurstTime;

    private float AdjustedRateOfFire;

    private float CurrentFirePose;

    private float AdjustedFirePose;

    private float RecoilMagnitude;

    private float RecoilRoughness;

    private float RecoilFadeIn;

    private float RecoilFadeOut;

    private float WeaponEffectiveness = 1f;

    private float InspectHoldTime = 1.5f;

    private float InventoryDelay = 0.35f;

    private int LeftRight;

    private int BurstCount;

    private int CycleIndex;

    private int AttackIndex;

    private int ForwardBack;

    private int EjectedMagazineAmmo;

    private int BonusEffectAmmo;

    private Quaternion BulletSpreadDirection;

    private Vector3 StartingScale;

    private Vector3 StatePosition;

    private Vector3 StateRotation;

    private Vector3 OldState;

    private Vector3 ArmScale;

    public enum Mode
    {
        SemiAuto = 1,
        FullAuto,
        Burst,
        Cycle
    }

    public enum WeaponAmmoType
    {
        Basic,
        Pistol,
        SMG,
        Heavy,
        Rifle,
        Shotgun,
        Grenade,
        Rockets,
        PlasmaCartridge,
        Cells
    }
}


[System.Serializable]
public class ReloadType
{
    public string ReloadName;
    public int AmmoCount;
}
[System.Serializable]
public class ModeSetting
{
    [Tooltip("The name of the fire mode, keep it ALL CAPS")]
    public string ModeName;

    [Tooltip("The material of the weapon glow when in this mode. The weapon glow is determined by the material set above the fire modes.")]
    public Material ModeMaterial;

    [Space(10f)]
    [Header("POSITION SETTINGS")]
    public Vector3 IdlePosition;

    public Vector3 IdleRotation;

    [Space(5f)]
    public Vector3 CrouchPosition;

    public Vector3 CrouchRotation;

    [Space(3f)]
    [Tooltip("Only needed if dual wielding is enabled")]
    public Vector3 DualPosition;

    [Tooltip("Only needed if dual wielding is enabled")]
    public Vector3 DualRotation;

    [Space(10f)]
    [Header("FIRE SETTINGS")]
    public WeaponScript.Mode FireMode;

    public Projectile.BulletEffect Effect;

    public Projectile.BulletType Projectile;

    public WeaponScript.WeaponAmmoType AmmoType;

    [Tooltip("For when you don't have a magazine")]
    public bool DrawFromPool;

    [Tooltip("The amount camera and weapon movement when you shoot")]
    public float RecoilMagnitude = 0;

    [Tooltip("The amount camera shake")]
    public float RecoilRoughness = 0;

    public float RecoilFadeIn = .1f;

    public float RecoilFadeOut = .1f;

    [Space(10f)]
    [Header("BULLET SETTINGS")]
    [Tooltip("The bullet prefab, you can set this to an empty prefab if you don't want to have a visual.")]
    public GameObject BulletObject;

    [Tooltip("The effect when the bullet hits an enemy, you can set this to an empty prefab if you don't want to have a visual.")]
    public GameObject HitEffect;

    [Tooltip("The effect when the bullet misses, you can set this to an empty prefab if you don't want to have a visual.")]
    public GameObject MissEffect;

    [Tooltip("The amount of damage per projectile")]
    public float Damage = 50f;

    [Range(10f, 500f)]
    [Tooltip("The shield multiplier as a percent value")]
    public float ShieldPercentage = 100f;

    [Tooltip("The speed of the projectile when using projectiles that don't have instant travel")]
    public float Speed = 100f;

    [Tooltip("The amount of heat generated by the weapon when firing")]
    public float Heat;

    [Tooltip("The range of the weapon")]
    public float Range = 50f;

    [Tooltip("The length of your charge animation if you have one")]
    public float Delay;

    [Tooltip("How many enemies the bullet can pierce through before stopping. Only applies to piercing bullets.")]
    public int PierceCount = 1;

    [Tooltip("How many projectiles are fired per shot")]
    public int ProjectileCount = 1;

    [Tooltip("The amount of ammo consumed per shot")]
    public int AmmoConsumption = 1;

    [Tooltip("The rate that the weapon loses accuracy, the max bloom is determined by the fire rate.")]
    public float Inaccuracy = 0.2f;

    [Tooltip("The rate of fire of the weapon")]
    public float RateOfFire;

    [Tooltip("Does the rate of fire speed up over time?")]
    public bool CanRampRateOfFire;

    [ConditionalField("CanRampRateOfFire", null)]
    [Tooltip("The maximum rate of fire the weapon can reach. The minimum is the rate of fire set above.")]
    public float MaxRateOfFire;

    [ConditionalField("CanRampRateOfFire", null)]
    [Tooltip("X is how fast the weapon ramps up to the max rate of fire. Y is how fast it comes back down to the standard rate after you stop shooting.")]
    public Vector2 RateOfFireAcceleration;

    [Tooltip("The time between shots when doing a burst. Only applies when on burst fire mode")]
    public float BurstRecovery;

    [Tooltip("The amount of shots in a burst. Only applies when on burst fire mode")]
    public int BurstCount;

    [HideInInspector]
    public int AmmoInWeapon;

    [HideInInspector]
    public bool SeparatePools;
}
