using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GTTOD_GearCardItem : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_GearCardItem _003C_003E4__this;

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

	public bool RandomWeapon;

	[ConditionalField("RandomWeapon", null)]
	public Vector2 RarityChance;

	public bool RandomLethal;

	public bool RandomTactical;

	public bool RandomBlessing;

	public bool RandomCurse;

	public float ActivationDelay;

	private GameManager GM;

	private InventoryScript Inventory;

	private GTTOD_Inventory InventoryManager;

	private GTTOD_UpgradesManager UpgradesManager;

	[HideInInspector]
	public List<int> PotentialWeapons;

	[IteratorStateMachine(typeof(_003CStart_003Ed__12))]
	private IEnumerator Start()
	{
		return null;
	}
}
