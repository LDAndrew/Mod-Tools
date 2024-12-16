using System;
using UnityEngine;

[Serializable]
public class WeaponItem
{
	[Header("WEAPON IDENTIFICATION")]
	public string WeaponTitle;

	public int WeaponLevel;

	public string GenericName;

	[ConditionalField("HasSpecial", null)]
	public string SpecialName;

	[Header("WEAPON OBJECTS")]
	public WeaponScript GenericVarient;

	[ConditionalField("HasSpecial", null)]
	public WeaponScript SpecialVarient;

	public GameObject WeaponPickup;

	public Sprite WeaponIcon;

	[Space(10f)]
	public bool Accessible;

	public bool HasSpecial;

	public bool ModdedWeapon;
}
