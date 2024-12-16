using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GTTOD_Crate : MonoBehaviour
{
	public enum GTTOD_CrateType
	{
		LootCrate = 0,
		WeaponCrate = 1,
		EquipmentCrate = 2,
		MeleeCrate = 3,
		ItemChest = 4,
		ApparelDrawer = 5,
		DeadDrop = 7
	}

	[CompilerGenerated]
	private sealed class _003CStart_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_Crate _003C_003E4__this;

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
		public _003CStart_003Ed__40(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CRegenerateLoop_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_Crate _003C_003E4__this;

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
		public _003CRegenerateLoop_003Ed__45(int _003C_003E1__state)
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

	public bool Locked;

	public string CrateName;

	public GTTOD_CrateType CrateType;

	public int CratePrice;

	public Outline CrateOutline;

	public GameObject CrateLock;

	public SpriteRenderer CrateIcon;

	public GameObject SpawnEffect;

	public Transform SpawnRoot;

	public float ChanceToSpawn;

	public float ChanceToUpgrade;

	public float ChanceToSpecial;

	public float RegenerateTime;

	public bool ChoiceItem;

	[ConditionalField("ChoiceItem", null)]
	public int LootID;

	[ConditionalField("ChoiceItem", null)]
	public int WeaponID;

	[ConditionalField("ChoiceItem", null)]
	public int EquipmentID;

	[ConditionalField("ChoiceItem", null)]
	public int MeleeID;

	[ConditionalField("ChoiceItem", null)]
	public int ItemID;

	[ConditionalField("ChoiceItem", null)]
	public int ApparelID;

	public List<GameObject> LootObjects;

	[HideInInspector]
	public List<int> PotentialWeapons;

	[HideInInspector]
	public List<int> PotentialEquipment;

	[HideInInspector]
	public List<int> PotentialMelee;

	[HideInInspector]
	public List<int> PotentialItems;

	[HideInInspector]
	public List<int> PotentialApparel;

	private GameManager GM;

	private GTTOD_Interactable Interactable;

	private GTTOD_Inventory InventoryManager;

	private InventoryScript Inventory;

	private GTTOD_Manager Manager;

	private GTTOD_HUD HUD;

	private Animator Anim;

	private int InitialPrice;

	private bool Empty;

	private bool HasMessaged;

	private bool Regenerating;

	private bool WeaponIsUpgraded;

	private bool WeaponIsSpecial;

	[IteratorStateMachine(typeof(_003CStart_003Ed__40))]
	private IEnumerator Start()
	{
		return null;
	}

	private void OnEnable()
	{
	}

	private void SetCrates()
	{
	}

	public void Interact()
	{
	}

	public void SpawnObject()
	{
	}

	[IteratorStateMachine(typeof(_003CRegenerateLoop_003Ed__45))]
	private IEnumerator RegenerateLoop()
	{
		return null;
	}

	public void Lock()
	{
	}

	public void Unlock()
	{
	}
}
