using System.Collections.Generic;
using UnityEngine;

public class GTTOD_BuildABang : MonoBehaviour
{
	public GTTOD_Colosseum Colosseum;

	public bool Locked;

	public Transform SpawnPoint;

	public float Range;

	public int Price;

	public List<AudioClip> SFX;

	private Transform Player;

	private GTTOD_Manager Manager;

	private InventoryScript Inventory;

	private GTTOD_Inventory Wheel;

	private GTTOD_HUD HUD;

	private AudioSource Audio;

	private Animator Anim;

	private int WeaponID;

	private float Distance;

	private bool WeaponReady;

	private bool CreatingWeapon;

	private bool Animating;

	private bool FullyUpgraded;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Interact()
	{
	}

	public void NearShake()
	{
	}

	public void FinishWeapon()
	{
	}

	public void PlayAudio(int AudioID)
	{
	}

	public void ToggleAnimation(int IsAnimating)
	{
	}
}
