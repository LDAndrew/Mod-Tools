using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoCounter : MonoBehaviour
{
    private void Start()
    {
        this.GM = GameManager.GM;
        this.Scale = this.Root.localScale;
    }

    private void Update()
    {
        if (this.Weapon != null)
        {
            this.Root.localScale = new Vector3(this.Scale.x * (float)((false && this.Weapon.LeftHanded) ? (-1) : 1), this.Scale.y, this.Scale.z);
            if (this.AmmoText != null)
            {
                this.AmmoText.text = (false ? "∞" : this.Weapon.CurrentAmmo.ToString());
            }
            if (this.CoverSegments.Count > 0)
            {
                foreach (Image image in this.CoverSegments)
                {
                    image.fillAmount = (this.HeatBasedWeapon ? (1f - this.Weapon.CurrentHeat / 100f) : (1f - (float)this.Weapon.CurrentAmmo / (float)this.Weapon.MaxAmmo)) * this.MaxFill;
                }
            }
        }
    }

    public WeaponScript Weapon;

    public Transform Root;

    public Text AmmoText;

    public bool HeatBasedWeapon;

    [Range(0f, 1f)]
    public float MaxFill = 1f;

    public List<Image> CoverSegments;

    private GameManager GM;

    private Vector3 Scale;
}