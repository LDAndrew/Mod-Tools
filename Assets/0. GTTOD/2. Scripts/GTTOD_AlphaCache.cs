using System.Collections.Generic;
using UnityEngine;

public class GTTOD_AlphaCache : MonoBehaviour
{
	public Vector3 FloorChances;

	public Vector3 CeilingChances;

	public Vector2 PriceRange;

	public GameObject SpawnEffect;

	public Transform SpawnRoot;

	public bool Locked;

	[HideInInspector]
	public List<int> PotentialWeapons;

	private GameManager GM;

	private GTTOD_Manager Manager;

	private GTTOD_Interactable Interactable;

	private GTTOD_UpgradesManager Upgrades;

	private InventoryScript Inventory;

	private Animator Anim;

	private int Price;

	private int WeaponID;

	private bool Empty;

	private bool Special;

	private bool Upgraded;

	public void Start()
	{
	}

	private void OnEnable()
	{
	}

	public string GenerateItem(int floorPrice, int ceilingPrice, int price, float luckModifier)
	{
		return null;
	}

	public void Interact()
	{
	}

	public void SpawnObject()
	{
	}

	public void Unlock()
	{
	}
}
