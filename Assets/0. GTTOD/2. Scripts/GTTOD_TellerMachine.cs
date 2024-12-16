using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GTTOD_TellerMachine : MonoBehaviour
{
	public CanvasGroup Canvas;

	public Text PlayerShardsText;

	public Text TellerShardsText;

	public Text MessageText;

	public List<AudioClip> SFX;

	private GTTOD_Manager Manager;

	private GTTOD_MemoryManager Memory;

	private GTTOD_Localization Localization;

	private ac_OptionsMenu Options;

	private GTTOD_HUD HUDManager;

	private AudioSource Audio;

	private ac_CharacterController CharacterController;

	private InventoryScript Inventory;

	private bool TellerIsActive;

	private bool HasAltered;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void ToggleTeller()
	{
	}

	public void AdjustShards(bool Deposit)
	{
	}

	private void UpdateTexts()
	{
	}

	public void DisplayTellerMessage(int ID)
	{
	}
}
