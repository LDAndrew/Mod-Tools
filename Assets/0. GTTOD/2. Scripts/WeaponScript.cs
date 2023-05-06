using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{
    public enum Mode
    {
        SemiAuto = 1, FullAuto = 2, Burst = 3, Cycle = 4
    }
    public enum WeaponAmmoType
    {
        Basic = 0, Pistol = 1, SMG = 2, Heavy = 3, Rifle = 4, Shotgun = 5, Grenade = 6, Rockets = 7, Cells = 8
    }


    [Header("WEAPON STATS")]

    public string WeaponName;
    public bool RandomAttack = false;
    public bool RandomCycle = false;
    public bool HasScope = true;
    public int MaxAmmo;
    public int AttackCount = 1;
    public int CycleCount = 1;
    public float SwayMultiplier;
    public float MaxSway;
    public float SwaySpeed;
    public float InspectBlend = 0;
    public float ZoomMultiplier = 2;
    public float AmmoCounterDividend = 0.25f;
    public float WeaponZoomMultiplier = 10;
    public Material WeaponMaterial;
    public GameObject GenericObjects;
    public GameObject UpgradedObjects;
    public Transform MuzzleLocation;
    public Transform ADSLocation;
    public Transform Offhand;
    public bool CanDualWield = false;

    [Header("VARIABLES")]

    public List<ReloadType> ReloadTypes;
    public List<ModeSetting> FireModes;


    public void DrawEnd()
    {

    }
    public void CycleEnd()
    {

    }
    public void InspectEnd()
    {

    }
    public void TransitionEnd()
    {

    }
    public void ReloadInsert()
    {

    }
    public void ReloadIncreaseAmmo(int AmmoAmount)
    {

    }
    public void FreeRefill()
    {

    }
    public void ReloadDetail(string ReloadType)
    {

    }
    public void ReloadEnd()
    {

    }
    public void RefreshWeapon()
    {

    }
    public void DualHanding()
    {

    }
    public void DualHandingEnd()
    {

    }










    //____________________________________________________________________SOON I WILL BE MAKING ALL OF THIS ACTUALLY FUNCTION, I AM JUST SUPER LAZY RN
    //____________________________________________________________________SOON I WILL BE MAKING ALL OF THIS ACTUALLY FUNCTION, I AM JUST SUPER LAZY RN
    //____________________________________________________________________SOON I WILL BE MAKING ALL OF THIS ACTUALLY FUNCTION, I AM JUST SUPER LAZY RN
    //____________________________________________________________________SOON I WILL BE MAKING ALL OF THIS ACTUALLY FUNCTION, I AM JUST SUPER LAZY RN
    //____________________________________________________________________SOON I WILL BE MAKING ALL OF THIS ACTUALLY FUNCTION, I AM JUST SUPER LAZY RN
    //____________________________________________________________________SOON I WILL BE MAKING ALL OF THIS ACTUALLY FUNCTION, I AM JUST SUPER LAZY RN













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
    public string ModeName;
    public Material ModeMaterial;

    [Space(10)]
    [Header("POSITION SETTINGS")]

    public Vector3 IdlePosition;
    public Vector3 IdleRotation;
    [Space(5)]
    public Vector3 CrouchPosition;
    public Vector3 CrouchRotation;
    [Space(3)]
    public Vector3 DualPosition;
    public Vector3 DualRotation;

    [Space(10)]
    [Header("FIRE SETTINGS")]

    public WeaponScript.Mode FireMode;
    public Projectile.BulletEffect Effect;
    public Projectile.BulletType Projectile;
    public WeaponScript.WeaponAmmoType AmmoType;
    public bool DrawFromPool;

    public float RecoilMagnitude;
    public float RecoilRoughness;
    public float RecoilFadeIn;
    public float RecoilFadeOut;

    [Space(10)]
    [Header("BULLET SETTINGS")]

    public GameObject BulletObject;
    public GameObject HitEffect;
    public GameObject MissEffect;
    public float Damage = 50;
    [Range(0f, 200f)] public float ShieldPercentage = 15;
    public float Speed = 100;
    public float Heat = 0f;
    public float Range = 50;
    public float Delay = 0;
    public int PierceCount = 6;
    public int ProjectileCount = 1;
    public int AmmoConsumption = 1;
    public float Inaccuracy = 0.5f;
    public float RateOfFire;
    public float BurstRecovery;
    public int BurstCount;

    [HideInInspector] public int AmmoInWeapon;
    [HideInInspector] public bool SeparatePools;
}