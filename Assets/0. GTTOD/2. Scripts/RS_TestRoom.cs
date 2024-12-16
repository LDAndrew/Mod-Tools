using System.Collections.Generic;
using UnityEngine;

public class RS_TestRoom : MonoBehaviour
{
	public GameObject Enemy;

	public int SpawnCount;

	public float SpawnDelay;

	public Transform SpawnPointParent;

	[HideInInspector]
	public List<Transform> SpawnPoints;

	private int RemainingSpawns;

	private float RemainingTime;

	private bool Spawning;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
