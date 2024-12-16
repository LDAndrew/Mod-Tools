using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GTTOD_FishingSpot : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CFishRoutine_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_FishingSpot _003C_003E4__this;

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
		public _003CFishRoutine_003Ed__13(int _003C_003E1__state)
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

	public float WaterOffset;

	public int UnlockLevel;

	[Range(0f, 100f)]
	public float DefaultChance;

	public Transform CutsceneRoot;

	public List<GTTOD_CatchableObject> CatchableObjects;

	private GTTOD_Inventory InventoryManager;

	private ac_CutsceneManager Cutscenes;

	private GTTOD_FishingRod FishingRod;

	private GTTOD_AIManager AIManager;

	private GTTOD_Manager Manager;

	private GTTOD_HUD HUDManager;

	private void Start()
	{
	}

	public void TryFishing()
	{
	}

	[IteratorStateMachine(typeof(_003CFishRoutine_003Ed__13))]
	private IEnumerator FishRoutine()
	{
		return null;
	}

	public void CatchObject()
	{
	}
}
