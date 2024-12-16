using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GTTOD_LootPickup : MonoBehaviour
{
	public enum LootType
	{
		Key,
		CardPack,
		EnduranceCrystal,
		JadeVine,
		HarborScroll
	}

	[CompilerGenerated]
	private sealed class _003CStart_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_LootPickup _003C_003E4__this;

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
		public _003CStart_003Ed__14(int _003C_003E1__state)
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

	public LootType PickupType;

	public int PickupCount;

	public float WaitTime;

	public GameObject PickupEffect;

	public string PickupMessage;

	public bool AutoPickup;

	private GTTOD_Manager Manager;

	private GTTOD_HUD HUD;

	private Rigidbody LootPhysics;

	private Transform Player;

	private bool Active;

	private bool Frozen;

	private bool PickingUp;

	[IteratorStateMachine(typeof(_003CStart_003Ed__14))]
	private IEnumerator Start()
	{
		return null;
	}

	private void Update()
	{
	}

	public void Pickup()
	{
	}
}
