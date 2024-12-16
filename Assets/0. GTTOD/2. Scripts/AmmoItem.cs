using System;
using UnityEngine;

[Serializable]
public class AmmoItem
{
	public string AmmoName;

	public int CurrentAmmoCount;

	public int MaxAmmoCount;

	public bool Recharge;

	[ConditionalField("Recharge", null)]
	public float RechargeRate;

	[ConditionalField("Recharge", null)]
	public int RechargeAmount;

	[HideInInspector]
	public float RechargeTime;
}
