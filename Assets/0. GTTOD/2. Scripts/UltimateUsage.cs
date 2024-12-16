using System;
using UnityEngine;

[Serializable]
public class UltimateUsage
{
	public string UseName;

	[Header("ULTIMATE VARIABLES")]
	public GameObject UltimateItem;

	public int UltimateUseSubtraction;

	public float UltimateDuration;

	[Header("ULTIMATE SHAKE")]
	public float InitialMagnitude;

	public float InitialRoughness;

	public float InitialFade;

	[Space(15f)]
	public float UseMagnitude;

	public float UseRoughness;

	public float UseFade;

	[Space(15f)]
	public bool SustainUltimate;

	public bool ShouldLower;
}
