using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class GTTOD_Inventory : MonoBehaviour
{
	public enum KarmaSelectionType
	{
		None,
		Upgrading,
		Cleansing
	}

	[CompilerGenerated]
	private sealed class _003CApplyLoadout_003Ed__72 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float DelayTime;

		public GTTOD_Inventory _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CApplyLoadout_003Ed__72(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public int InventorySlots;

	public int ItemSlots;

	public int KeyCount;

	public CanvasGroup InventoryGroup;

	[Header("RADIAL INVENTORY")]
	public RectTransform Indicator;

	public Image IndicatorFill;

	public Image ApparelIcon;

	public CanvasGroup StatGroup;

	public Text SlotStats;

	public InventorySlot FakeSlot;

	public List<InventorySlot> Slots;

	public List<Color> SlotColors;

	public List<Sprite> SlotSprites;

	public List<float> Angles;

	public Sprite EmptySprite;

	[Space(15f)]
	public bool EquipOnStart;

	[ConditionalField("EquipOnStart", null)]
	public float StartingDelay;

	[ConditionalField("EquipOnStart", null)]
	public int StartingWeapon;

	[ConditionalField("EquipOnStart", null)]
	public int StartingLethal;

	[ConditionalField("EquipOnStart", null)]
	public int StartingTactical;

	[ConditionalField("EquipOnStart", null)]
	public int StartingMelee;

	[ConditionalField("EquipOnStart", null)]
	public bool StartingUpgraded;

	[ConditionalField("EquipOnStart", null)]
	public bool StartingSpecial;

	[Space(15f)]
	[Header("GRID INVENTORY")]
	public Text ItemText;

	public Transform GridContent;

	public GTTOD_GridItemUI ItemUI;

	public List<GridItem> GridItems;

	public List<HeldGridItem> CurrentItems;

	public List<ApparelItem> ApparelItems;

	[Space(15f)]
	public bool ItemObjects;

	[ConditionalField("ItemObjects", null)]
	public GameObject HarborPortal;

	[ConditionalField("ItemObjects", null)]
	public GTTOD_ApparelPickup DefaultApparelPickup;

	[Space(15f)]
	public bool ItemOnStart;

	[ConditionalField("ItemOnStart", null)]
	public int StartingItem;

	[ConditionalField("ItemOnStart", null)]
	public int StartingItemAmount;

	[HideInInspector]
	public bool Full;

	[HideInInspector]
	public bool InInventory;

	[HideInInspector]
	public bool SelectingKarma;

	[HideInInspector]
	public List<int> PotentialWeapons;

	private GameManager GM;

	private GTTOD_Manager Manager;

	private GTTOD_UpgradesManager Upgrades;

	private GTTOD_HUD HUDManager;

	private GTTOD_AIManager AIManager;

	private GTTOD_HealthScript Health;

	private GTTOD_GearCardManager CardManager;

	private ac_CharacterController CharacterController;

	private InventoryScript Inventory;

	private ac_OptionsMenu Options;

	private Transform Player;

	private Animator GridAnimator;

	public KarmaSelectionType CurrentSelectionType;

	public string CurrentApparel;

	private bool InventoryProtection;

	private bool Rotating;

	private bool ClickDown;

	private bool RightClick;

	private bool ControllerSelected;

	private bool GridOpen;

	private bool HasAnimatedGrid;

	private float SwitchTime;

	private float ClickTime;

	private float TimeScale;

	private int RotatingIndex;

	private int CurrentSwapIndex;

	private int ClickIndex;

	private int PreviousSelectedControllerIndex;

	private Sprite EmptyApparelSprite;

	[Space(35f)]
	public int SelectedControllerIndex;

	private RectTransform RotatingSlot;

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CApplyLoadout_003Ed__72))]
	public IEnumerator ApplyLoadout(float DelayTime)
	{
		return null;
	}

	private void Update()
	{
	}

	public void InventoryUpdate()
	{
	}

	private void ControllerUpdate()
	{
	}

	public void ToggleInventory(bool Active)
	{
	}

	public void StartSwap(int Index)
	{
	}

	public void EndSwap()
	{
	}

	public void OnClickDown(int SlotIndex)
	{
	}

	public void OnHover(int SlotIndex)
	{
	}

	public void OffHover()
	{
	}

	public void OnClickUp()
	{
	}

	public void SwapCurrentWeapon(int Index)
	{
	}

	public void SwitchCurrentWeapon(int Index)
	{
	}

	public void SwitchOffhandWeapon(int Index)
	{
	}

	public void AcquireGun(int ID, int AmmoAmount, bool Upgraded, bool Special)
	{
	}

	public WeaponScript AssignGun(int ID, int AmmoAmount, bool Upgraded, bool Special)
	{
		return null;
	}

	public void RemoveWeapon(int RemovedSlot, bool Drop)
	{
	}

	public void DropCurrentWeapon(bool DropPickup)
	{
	}

	public void DropOffhandWeapon(bool DropPickup)
	{
	}

	public void ActivateApparel(string ApparelName, bool DropApparel)
	{
	}

	public void DeactivateApparel()
	{
	}

	public bool ApparelActive(string ApparelName)
	{
		return false;
	}

	public float ApparelModifier(string ApparelName)
	{
		return 0f;
	}

	public GameObject ApparelObject(string ApparelName)
	{
		return null;
	}

	public void AdjustApparel()
	{
	}

	public void ApparelDefine(bool Hover)
	{
	}

	public void PurgeInventory(bool Drop)
	{
	}

	public void AdjustSlots()
	{
	}

	public void WheelOfFortuneCycle()
	{
	}

	public bool CanAcquireItem(int ID, int ItemAmount)
	{
		return false;
	}

	public void AcquireItem(int ID, int ItemAmount)
	{
	}

	public void UseItem(int HeldIndex)
	{
	}

	public void ToggleKarmaSelect(bool IsSelecting, KarmaSelectionType SelectionType)
	{
	}

	public void SelectKarma(int ID, bool Blessing)
	{
	}

	public void RemoveItem(int HeldIndex, int ItemsToRemove, bool DropItem, bool LogItem)
	{
	}

	public void RemoveKey(int KeysToRemove)
	{
	}

	public void UpdateHeldItems()
	{
	}

	public Transform GetClosestPortalPoint(GameObject[] Points)
	{
		return null;
	}
}
