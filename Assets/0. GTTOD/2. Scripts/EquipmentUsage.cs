using System;
using UnityEngine;

[Serializable]
public class EquipmentUsage
{
	public string UseName;

	[Header("EQUIPMENT VARIABLES")]
	public GameObject EquipmentItem;

	public int EquipmentUseSubtraction;

	public AudioClip EquipmentSound;

	public bool ShouldLower;

	public bool TimedEquipment;

	[ConditionalField("TimedEquipment", null)]
	public float EquipmentDuration;

	[Header("EQUIPMENT SHAKE")]
	public float InitialMagnitude;

	public float InitialRoughness;

	public float InitialFade;

	[Space(15f)]
	public float UseMagnitude;

	public float UseRoughness;

	public float UseFade;
}
