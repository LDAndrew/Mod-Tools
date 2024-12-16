using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class InventoryScript : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CSwitchWeapons_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InventoryScript _003C_003E4__this;

		public float SwitchTime;

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
		public _003CSwitchWeapons_003Ed__38(int _003C_003E1__state)
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
	private sealed class _003CApplyLoadout_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float DelayTime;

		public InventoryScript _003C_003E4__this;

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
		public _003CApplyLoadout_003Ed__52(int _003C_003E1__state)
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

	public WeaponScript CurrentWeapon;

	public WeaponScript OffhandWeapon;

	public WeaponScript TemporaryWeapon;

	public EquipmentScript LethalEquipment;

	public EquipmentScript TacticalEquipment;

	public MeleeScript MeleeWeapon;

	public MeleeScript TemporaryMeleeWeapon;

	public WeaponParent WeaponParent;

	public CameraParent CameraParent;

	public Transform SwayParent;

	public AudioSource MagAudio;

	[Space(15f)]
	public bool EquipOnStart;

	[ConditionalField("EquipOnStart", null)]
	public float StartingDelay;

	[ConditionalField("EquipOnStart", null)]
	public int StartingWeapon;

	[ConditionalField("EquipOnStart", null)]
	public int StartingMelee;

	[ConditionalField("EquipOnStart", null)]
	public int StartingLethal;

	[ConditionalField("EquipOnStart", null)]
	public int StartingTactical;

	[ConditionalField("EquipOnStart", null)]
	public bool StartingUpgraded;

	[ConditionalField("EquipOnStart", null)]
	public bool StartingSpecial;

	[Space(15f)]
	public List<WeaponItem> Guns;

	public List<EquipmentItem> Equipment;

	public List<MeleeItem> Melee;

	public List<AmmoItem> Ammo;

	[Space(15f)]
	[Header("Remove At")]
	public int Index;

	[HideInInspector]
	public List<string> FreezeList;

	[HideInInspector]
	public bool HoldReloadToInspect;

	[HideInInspector]
	public bool HoldReloadToDualWield;

	[HideInInspector]
	public bool DualWielding;

	private GameManager GM;

	private bool CurrentFrozen;

	private bool OffhandFrozen;

	private bool TemporaryFrozen;

	private bool SwitchingWeapons;

	private bool HasReleasedDualWield;

	private float DualwieldHoldTime;

	private GTTOD_Inventory InventoryManager;

	private void Start()
	{
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CSwitchWeapons_003Ed__38))]
	private IEnumerator SwitchWeapons(float SwitchTime)
	{
		return null;
	}

	public WeaponScript AssignGun(int ID, int AmmoAmount, bool Upgraded, bool Special, bool ShouldDestroy)
	{
		return null;
	}

	public WeaponScript AssignTemporaryGun(int ID, int AmmoAmount, bool Upgraded, bool Special, bool ShouldDestroy)
	{
		return null;
	}

	public void DropTemporaryGun()
	{
	}

	public void AcquireEquipment(int ID)
	{
	}

	public void AcquireMeleeWeapon(int ID)
	{
	}

	public void AcquireTemporaryMeleeWeapon(int ID)
	{
	}

	public void DropTemporaryMeleeWeapon()
	{
	}

	public void PurgeInventory()
	{
	}

	public void DropWeapon(int Index, bool Upgraded, bool Special, int AmmoIndex, int AmmoAmount)
	{
	}

	public void BumpWeapons(Vector3 BumpAmount)
	{
	}

	public void BumpWeaponSpeed(float NewSpeed, float NewResetTime)
	{
	}

	public void AdjustFreezeList(string FreezeSource, bool Add)
	{
	}

	public void ToggleDualWield(bool WieldState)
	{
	}

	[IteratorStateMachine(typeof(_003CApplyLoadout_003Ed__52))]
	public IEnumerator ApplyLoadout(float DelayTime)
	{
		return null;
	}

	public void AddAmmo(int Index, int Amount)
	{
	}

	public void CreateModGun(GTTOD_WeaponMod WeaponMod)
	{
	}

	public void AddGunToInventory()
	{
	}

	public void RemoveGunFromInventory()
	{
	}

	public void AddEquipmentToInventory()
	{
	}

	public void RemoveEquipmentFromInventory()
	{
	}

	public void SetWeaponListNames()
	{
	}
}
