using System.Collections.Generic;
using UnityEngine;

public class GTTOD_DungeonShop : MonoBehaviour
{
	public enum DungeonShopItemType
	{
		Overcharge,
		JadeVines,
		AmmoCrate,
		Keys,
		ExtraLife,
		Curse,
		Blessing
	}

	public List<DungeonShop> Shops;

	public List<DungeonShopItem> ShopItems;

	[HideInInspector]
	public List<int> PotentialItems;

	private GTTOD_Manager Manager;

	private GTTOD_HUD HUDManager;

	private void Start()
	{
	}

	public void AttemptPurchase(int ShopIndex)
	{
	}
}
