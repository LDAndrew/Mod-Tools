using System;
using UnityEngine;

[Serializable]
public class AmmoSpawn
{
	public string AmmoName;

	public WeaponScript.WeaponAmmoType AmmoType;

	public GameObject AmmoPickupObject;

	[Range(0f, 100f)]
	public float AmmoChance;
}
