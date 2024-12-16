using System.Collections.Generic;
using UnityEngine;

public class GTTOD_Loot : MonoBehaviour
{
	[Range(0f, 100f)]
	public float OverallLootChance;

	[Header("BASIC LOOT")]
	public List<AmmoSpawn> AmmoPickups;

	public List<LootSpawn> LootPickups;

	[Header("ADVANCED LOOT")]
	[Range(0f, 100f)]
	public float GunChance;

	[Range(0f, 100f)]
	public float UpgradeChance;

	[Range(0f, 100f)]
	public float SpecialChance;

	[Range(0f, 100f)]
	public float MeleeChance;

	[Range(0f, 100f)]
	public float EquipmentChance;

	[Header("SPAWN SETTINGS")]
	[Range(1f, 10f)]
	public int CycleCount;

	[Range(0f, 1f)]
	public float CycleDelay;

	[HideInInspector]
	public List<int> PotentialWeapons;

	[HideInInspector]
	public List<int> PotentialMelee;

	[HideInInspector]
	public List<int> PotentialEquipment;

	private float CycleTime;

	private bool Active;

	private GameManager GM;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void Spawn()
	{
	}
}
