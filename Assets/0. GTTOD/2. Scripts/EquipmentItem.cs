using System;
using UnityEngine;

[Serializable]
public class EquipmentItem
{
	[Header("EQUIPMENT IDENTIFICATION")]
	public string EquipmentTitle;

	public string EquipmentName;

	public bool EquipmentLethal;

	public int EquipmentLevel;

	[Header("EQUIPMENT OBJECTS")]
	public EquipmentScript Equipment;

	public GameObject EquipmentPickup;

	public Sprite EquipmentIcon;

	[Space(10f)]
	public bool Accessible;
}
