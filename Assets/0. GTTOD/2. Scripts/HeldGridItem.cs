using System;
using UnityEngine;

[Serializable]
public class HeldGridItem
{
	public string ItemName;

	public string ItemDescription;

	public string ItemUseMonologue;

	public string HumanSacrificeMonologue;

	public GridItem.GridItemType ItemType;

	public Sprite ItemIcon;

	public GTTOD_ItemPickup ItemPickup;

	public int ItemCount;

	public int ItemID;

	public int HeldID;

	[HideInInspector]
	public GTTOD_GridItemUI ItemUI;
}
