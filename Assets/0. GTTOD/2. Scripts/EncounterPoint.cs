using System;
using UnityEngine;

[Serializable]
public class EncounterPoint
{
	public Transform SpawnPoint;

	public GameObject EnemyToSpawn;

	public float SpawnDelay;

	public bool Buffed;

	public bool Marked;
}
