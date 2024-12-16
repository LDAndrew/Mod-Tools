using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AmmoPickup _003C_003E4__this;

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

	public string AmmoName;

	public WeaponScript.WeaponAmmoType AmmoType;

	public Vector2 AmmoAmountRange;

	public Transform AmmoParticle;

	public GameObject AmmoObject;

	public float AmmoDistance;

	private Transform Player;

	private Rigidbody AmmoPhysics;

	private InventoryScript Inventory;

	private GTTOD_UpgradesManager Upgrades;

	private GTTOD_Inventory InventoryManager;

	private GTTOD_HUD HUDManager;

	private bool Collecting;

	private bool Active;

	[IteratorStateMachine(typeof(_003CStart_003Ed__14))]
	private IEnumerator Start()
	{
		return null;
	}

	private void Update()
	{
	}
}
