using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GTTOD_Sanctuary : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCycleShard_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_Sanctuary _003C_003E4__this;

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
		public _003CCycleShard_003Ed__28(int _003C_003E1__state)
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

	public GTTOD_TheSummit TheSummit;

	public ParticleSystem SanctuaryParticles;

	public Transform CenterPoint;

	public Animator ChargeShard;

	public GameObject FrostZone;

	public Vector2 WeightRange;

	public float BlizzardDistance;

	public float ZoneSize;

	public int TimeLimit;

	public List<Transform> ShardPoints;

	private GTTOD_AIManager AIManager;

	private GTTOD_Manager Manager;

	private GTTOD_HUD HUDManager;

	private Transform Player;

	private ac_CharacterController CharacterController;

	private PlayerEffects Effects;

	private Coroutine ShardRoutine;

	private float ChargeRequired;

	private float MaxChargeRequired;

	private float ChallengeTimeLimit;

	private bool ShardActive;

	private bool InZone;

	private bool ChallengeComplete;

	private int SecondsRemaining;

	private int ShardPointIndex;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void BeginChallenge()
	{
	}

	[IteratorStateMachine(typeof(_003CCycleShard_003Ed__28))]
	private IEnumerator CycleShard()
	{
		return null;
	}

	public void GainKill()
	{
	}

	public void Progress(float Amount)
	{
	}

	public void CompleteChallenge(bool Success)
	{
	}
}
