using UnityEngine;
using UnityEngine.UI;

public class GTTOD_GearCard : MonoBehaviour
{
	public string CardName;

	[Header("CARD SETTINGS")]
	public string CardWeapon;

	public bool CardWeaponUpgraded;

	public bool CardWeaponSpecial;

	public string CardMeleeWeapon;

	public string CardLethalEquipment;

	public string CardTacticalEquipment;

	public string CardBlessing;

	public string CardCurse;

	public GameObject CardObject;

	[Header("CARD INTERFACE")]
	public Image CardFillUI;

	public Text CardNameUI;

	private GTTOD_GearCardManager Manager;

	private AudioSource Audio;

	private InventoryScript Inventory;

	private GTTOD_UpgradesManager Upgrades;

	private GTTOD_Inventory GTTODInventory;

	private float BufferTime;

	private float Progress;

	private int CardIndex;

	private int Count;

	private bool Clicking;

	private void Start()
	{
	}

	public void SetUpCard(int Index, int CardCount)
	{
	}

	private void Update()
	{
	}

	public void ToggleClick(bool ClickToggle)
	{
	}

	public void UseGearCard()
	{
	}
}
