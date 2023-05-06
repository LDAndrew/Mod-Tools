using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GTTOD_Mod : MonoBehaviour
{
    public string SteamID = "ENTER YOUR STEAM ID HERE";
    public enum ModType
    {
        AudioMod = 0, WeaponMod = 1, ObjectMod = 2, MapMod = 3, MeleeMod = 4, EquipmentMod = 5, EnemyMod = 6
    }
    public enum ParentType
    {
        Nothing = 0, Level = 1, HarborDeep = 2, Waystation = 3
    }

    [Header("MOD VARIABLES:")]
    public ModType Type;
    public ParentType Parent;
    public Vector3 Position;
    public Vector3 Rotation;
    public Vector3 LocalScale;
    public string Level;

    [Header("MOD ASSETS")]
    public string WorkshopName;
    [TextArea(5, 15)] public string WorkshopDescription;
    public Texture2D WorkshopThumbnail;
}