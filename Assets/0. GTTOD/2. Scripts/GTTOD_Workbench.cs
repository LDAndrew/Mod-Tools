using UnityEngine;
using UnityEngine.UI;

public class GTTOD_Workbench : MonoBehaviour
{
	public Transform WeaponParent;

	public AudioSource BenchAudio;

	public GameObject CombineButton;

	public int UpgradeCost;

	public int CraftCost;

	public int KeyCost;

	public Text ErrorText;

	public CanvasGroup ErrorGroup;

	public CanvasGroup SelectionsGroup;

	public HorizontalLayoutGroup Layout;

	private Animator Anim;

	private GTTOD_Manager Manager;

	private InventoryScript Inventory;

	private GTTOD_Inventory InventoryManager;

	private GTTOD_UpgradesManager Upgrades;

	private GTTOD_WeaponPickup WeaponPickUp;

	private bool Active;

	private bool CanCombine;

	private int RecipeIndex;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void ActivateSelections()
	{
	}

	public void AttemptUpgrade()
	{
	}

	public void CompleteUpgrade()
	{
	}

	public void AttemptCombine()
	{
	}

	public void AttemptKey()
	{
	}

	public void LeaveWorkbench()
	{
	}

	public void RemoveWeapon()
	{
	}

	private void BumpError(string ErrorMessage)
	{
	}
}
