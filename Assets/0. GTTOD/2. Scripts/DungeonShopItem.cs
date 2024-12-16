using System;
using UnityEngine;

[Serializable]
public class DungeonShopItem
{
	public string ItemName;

	public string ItemInfo;

	public int ItemPrice;

	public GTTOD_DungeonShop.DungeonShopItemType ItemType;

	public GameObject ItemStoreObject;

	public GameObject ItemSpawnObject;

	[HideInInspector]
	public bool HasUsed;
}
