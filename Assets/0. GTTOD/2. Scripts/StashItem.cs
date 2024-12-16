using System;
using UnityEngine;

[Serializable]
public class StashItem
{
	public enum ItemTypes
	{
		Gun,
		Equipment,
		Melee,
		Item,
		Apparel
	}

	public string ItemName;

	public ItemTypes ItemType;

	public Sprite ItemIcon;

	public int ItemID;

	public int ItemCount;

	public int InventoryIndex;

	public bool ItemIsUpgraded;

	public bool ItemIsSpecial;
}
