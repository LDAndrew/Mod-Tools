using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoCounter : MonoBehaviour
{
    public WeaponScript Weapon;
    public Transform Root;
    public Text AmmoText;
    public bool HeatBasedWeapon = false;
    public List<Image> CoverSegments;
}
