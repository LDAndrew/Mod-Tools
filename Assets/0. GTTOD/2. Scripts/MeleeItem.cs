using System;
using UnityEngine;

[Serializable]
public class MeleeItem
{
	[Header("MELEE IDENTIFICATION")]
	public string MeleeName;

	[Header("MELEE OBJECTS")]
	public MeleeScript Melee;

	public GameObject MeleePickup;

	public Sprite MeleeIcon;

	public int MeleeLevel;

	[Space(10f)]
	public bool Accessible;
}
