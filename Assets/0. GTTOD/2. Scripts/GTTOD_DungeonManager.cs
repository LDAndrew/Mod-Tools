using System.Collections.Generic;
using UnityEngine;

public class GTTOD_DungeonManager : MonoBehaviour
{
	public GameObject RewardDungeon;

	public GameObject ShopDungeon;

	public List<DungeonLayer> DungeonLayers;

	[HideInInspector]
	public List<Dungeon> PotentialDungeons;

	private Transform Player;

	private GTTOD_MemoryManager Memory;

	private GTTOD_Manager Manager;

	private int CurrentLayer;

	public void CreateDungeon()
	{
	}

	public void SaveDungeon()
	{
	}
}
