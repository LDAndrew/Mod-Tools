using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GTTOD_WeaponPickup : MonoBehaviour
{
    public string WeaponName;
    public Outline WeaponOutline;
    public float PickupDistance = 5f;
    public bool Upgraded = false;
    public bool Special = false;
    public List<Color> Colors;
}
