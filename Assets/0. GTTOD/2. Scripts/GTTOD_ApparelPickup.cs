using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GTTOD_ApparelPickup : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_ApparelPickup _003C_003E4__this;

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
		public _003CStart_003Ed__18(int _003C_003E1__state)
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

	public string ApparelName;

	public Outline ItemOutline;

	public float PickupDistance;

	public Color InteractionColor;

	private Rigidbody ItemPhysics;

	private GTTOD_InteractionManager Interactions;

	private GTTOD_Interactable Interactable;

	private GTTOD_Inventory Inventory;

	private GTTOD_HUD HUDManager;

	private Transform Player;

	private Vector3 StartingPosition;

	private bool Active;

	private bool Frozen;

	private bool AutoPickup;

	private bool PickingUp;

	private bool HasAdded;

	private bool HasTeleported;

	[IteratorStateMachine(typeof(_003CStart_003Ed__18))]
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

	public void SpawnItem()
	{
	}

	public void DropItem()
	{
	}

	public void SetSettings()
	{
	}

	public void Pickup()
	{
	}
}
