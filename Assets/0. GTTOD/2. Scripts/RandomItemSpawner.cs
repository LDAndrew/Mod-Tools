using System.Collections.Generic;
using UnityEngine;

public class RandomItemSpawner : MonoBehaviour
{
	[Range(0f, 100f)]
	public float OverallChance;

	public bool SpawnOnStart;

	public bool DestroyOnSpawn;

	public List<GameObject> SpawnObjects;

	private void Start()
	{
	}

	public void Spawn()
	{
	}
}
