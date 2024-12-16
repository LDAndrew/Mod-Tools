using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[Serializable]
public class InventorySlot
{
	public enum SlotType
	{
		Stored,
		Current,
		Offhand
	}

	public string SlotName;

	public bool SlotActive;

	public WeaponScript Weapon;

	[Space(15f)]
	public RectTransform SlotObject;

	public CanvasGroup SlotGroup;

	public EventTrigger SlotEvent;

	public Image WeaponIcon;

	public Image SlotIcon;

	public SlotType Type;
}
