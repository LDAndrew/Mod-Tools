using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GTTOD_BladeSentinelArena : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStartEncounter_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_BladeSentinelArena _003C_003E4__this;

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
		public _003CStartEncounter_003Ed__21(int _003C_003E1__state)
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

	public GameObject TheBladeSentinel;

	public GameObject MausoleumBlocker;

	public Animator MausoleumLanding;

	public Transform Checkpoint;

	public ParticleSystem SpawnEffect;

	public float EncounterRadius;

	public float MausoRadius;

	private Transform Player;

	private Vector3 StartingPosition;

	private ac_CharacterController CharacterController;

	private GTTOD_UpgradesManager Upgrades;

	private GTTOD_AIManager AIManager;

	private GTTOD_OSTManager OST;

	private GTTOD_HUD HUDManager;

	private GTTOD_Level Level;

	private AudioSource Audio;

	private bool EncounterStarted;

	private bool EncounterFinished;

	private bool MausoUnlocked;

	private void Start()
	{
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CStartEncounter_003Ed__21))]
	private IEnumerator StartEncounter()
	{
		return null;
	}

	public void EndEncounter()
	{
	}
}
