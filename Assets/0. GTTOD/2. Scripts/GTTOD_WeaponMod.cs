using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GTTOD_WeaponMod : MonoBehaviour
{
    public enum Level
    {
        AllLevels = 0, Level1AndUnder = 1, Level2AndUnder = 2, Level3AndUnder = 3, Level4AndUnder = 4, Level5AndUnder = 5, Level6AndUnder = 6, Level7AndUnder = 7, Level8AndUnder = 8, Level9AndUnder = 9, Level10AndUnder = 10,
    }
    public Level WeaponLevel;
    public string GenericName;
    [ConditionalField("HasSpecial")] public string SpecialName;
    public WeaponScript GenericWeapon;
    [ConditionalField("HasSpecial")] public WeaponScript SpecialWeapon;
    public GameObject Pickup;
    public Sprite Icon;
    public bool HasSpecial = true;
}