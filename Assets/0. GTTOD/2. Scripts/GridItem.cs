using System;
using UnityEngine;

[Serializable]
public class GridItem
{
	public enum GridItemType
	{
		BasicItem,
		GearCard,
		HarborScroll,
		EnduranceCrystal,
		VulcanHammer,
		WorldFruit,
		EmpoweredWhetstone,
		RemoteIdentifier,
		Medkit,
		ShieldBank,
		TyphoonTrigger,
		EmberEpoxy,
		ImmersionMagnet,
		CleansingCharm,
		ChippedSapphire,
		OrdinaryRuby,
		FlawlessDiamond,
		QuantiteShard,
		NytriumFiber,
		CinditeChunk,
		AmbrosisDrop,
		Key
	}

	public string ItemName;

	public string ItemDescription;

	public string ItemUseMonologue;

	public string HumanSacrificeMonologue;

	public Vector2 PriceRange;

	public GridItemType ItemType;

	public Sprite ItemIcon;

	public int ItemStackLimit;

	public GTTOD_ItemPickup ItemPickup;

	public bool Accessible;

	public bool RequiresLevel;
}
