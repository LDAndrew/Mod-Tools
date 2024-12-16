using System.Collections.Generic;
using UnityEngine;

public class GTTOD_Shrine : MonoBehaviour
{
	public string ShrineName;

	public float ShrineChance;

	public GameObject Doors;

	public ParticleSystem UnlockEffect;

	public List<ShrineObject> ShrineObjects;

	public List<GTTOD_Beacon> Beacons;

	private GTTOD_HUD HUDManager;

	private GameManager GM;

	private float CheckTime;

	private bool Unlocked;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void Unlock()
	{
	}
}
