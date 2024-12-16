using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
	public string Name;

	public string DumbfuckName;

	public float MaxHealth;

	public bool ShouldRevive;

	public Transform HealthPosition;

	public List<GameObject> DisableObjects;

	private GameManager GM;

	private GTTOD_UpgradesManager Upgrades;

	private GTTOD_Inventory InventoryManager;

	private GTTOD_HUD PlayerHUD;

	private InventoryScript Inventory;

	private Animator Anim;

	private bool Dead;

	private float CurrentHealth;

	private void Start()
	{
	}

	public void Damage(float Damage)
	{
	}

	private void Die()
	{
	}

	public void Revive()
	{
	}
}
