using System;
using UnityEngine;

[Serializable]
public class DungeonShop
{
	public string ShopName;

	public GTTOD_Interactable ShopInteraction;

	public Transform ShopPoint;

	[HideInInspector]
	public int ID;

	[HideInInspector]
	public int Price;

	[HideInInspector]
	public bool Empty;
}
