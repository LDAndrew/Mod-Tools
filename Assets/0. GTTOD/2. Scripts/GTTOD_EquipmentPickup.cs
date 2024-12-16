using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GTTOD_EquipmentPickup : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_EquipmentPickup _003C_003E4__this;

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
		public _003CStart_003Ed__22(int _003C_003E1__state)
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

	public bool SpawnOnStart;

	public string EquipmentName;

	public Outline EquipmentOutline;

	public float PickupDistance;

	public bool Tactical;

	public Color InteractionColor;

	private GTTOD_HUD HUDManagement;

	private InventoryScript Inventory;

	private ac_OptionsMenu OptionsMenu;

	private Rigidbody EquipmentPhysics;

	private GTTOD_InteractionManager Interactions;

	private GTTOD_Interactable Interactable;

	private GTTOD_HUD HUDManager;

	private Transform Player;

	private Vector3 StartingPosition;

	private bool Active;

	private bool Frozen;

	private bool AutoPickup;

	private bool PickingUp;

	private bool HasAdded;

	private bool HasTeleported;

	private int Ammo;

	[IteratorStateMachine(typeof(_003CStart_003Ed__22))]
	private IEnumerator Start()
	{
		return null;
	}

	private void Update()
	{
	}

	public void Interact()
	{
	}

	public void SpawnEquipment()
	{
	}

	public void DropEquipment()
	{
	}

	public void SetSettings()
	{
	}

	public void Pickup()
	{
	}
}
