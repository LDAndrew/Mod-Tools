using System.Collections.Generic;
using UnityEngine;

public class AmmoSpawner : MonoBehaviour
{
	public List<AmmoSpawn> AmmoPickups;

	public List<GameObject> PowerUpPickups;

	public List<GameObject> LowTierPickUps;

	public List<GameObject> HighTierPickups;

	public float PowerUpChance;

	public float LowTierChance;

	public float HighTierChance;

	private GTTOD_Inventory Inventory;

	private GameManager GM;

	private void Start()
	{
	}
}
