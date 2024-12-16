using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GTTOD_MeleePickup : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_MeleePickup _003C_003E4__this;

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
		public _003CStart_003Ed__12(int _003C_003E1__state)
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

	public string MeleeName;

	public float PickupDistance;

	private InventoryScript Inventory;

	private Rigidbody MeleePhysics;

	private GTTOD_InteractionManager Interactions;

	private GTTOD_Interactable Interactable;

	private Transform Player;

	private bool Active;

	private bool Frozen;

	private bool PickingUp;

	private bool HasAdded;

	private int Ammo;

	[IteratorStateMachine(typeof(_003CStart_003Ed__12))]
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

	public void SpawnMelee()
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
