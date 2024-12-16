using System.Collections.Generic;
using UnityEngine;

public class GTTOD_FishedObject : MonoBehaviour
{
	public enum ObjectType
	{
		Fish,
		CardPack,
		HarborScroll,
		Key,
		Vine,
		Object,
		LevelOneGun
	}

	public ObjectType FishedObjectType;

	public GameObject SpawnEffect;

	public GameObject GiveObject;

	public float Gravity;

	[HideInInspector]
	public List<int> WeaponIDs;

	private Transform Player;

	private Rigidbody ObjectPhysics;

	private GTTOD_HUD HUDManager;

	private InventoryScript Inventory;

	private GTTOD_Inventory GameInventory;

	private bool Spawned;

	private float PickupTime;

	private int WeaponIndex;

	private void Start()
	{
	}

	public void SpawnObject()
	{
	}

	private void Update()
	{
	}

	private void PickUpObject()
	{
	}
}
