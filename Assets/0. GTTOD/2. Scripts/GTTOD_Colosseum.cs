using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GTTOD_Colosseum : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CChallengeSequence_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_Colosseum _003C_003E4__this;

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
		public _003CChallengeSequence_003Ed__31(int _003C_003E1__state)
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
	private sealed class _003CCycleShard_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_Colosseum _003C_003E4__this;

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
		public _003CCycleShard_003Ed__35(int _003C_003E1__state)
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

	public Vector2 KillsRequiredRange;

	public int WeightModifier;

	public string Message;

	public GTTOD_BuildABang BuildABang;

	public Animator ChargeShard;

	public Transform Zone;

	public int TimeLimit;

	public int TrialZone;

	public List<Transform> ShardPoints;

	private PlayerEffects PlayerEffects;

	private GTTOD_AIManager AIManager;

	private GTTOD_Manager Manager;

	private GTTOD_HUD HUDManager;

	private GTTOD_OSTManager OST;

	private Transform Player;

	private AudioSource Audio;

	private Coroutine ShardRoutine;

	private float ChallengeTimeLimit;

	private bool HasWarned;

	private bool TrialActive;

	private bool BeginningTrial;

	private bool TrialCompleted;

	private bool FirstCharge;

	private bool ShardActive;

	private int KillsRequired;

	private int MaxKillsRequired;

	private int SecondsRemaining;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void TryShard()
	{
	}

	public void StartTrial()
	{
	}

	[IteratorStateMachine(typeof(_003CChallengeSequence_003Ed__31))]
	public IEnumerator ChallengeSequence()
	{
		return null;
	}

	public void BeginChallenge()
	{
	}

	public void ActivateShard()
	{
	}

	public void ActivateShard(int Point)
	{
	}

	[IteratorStateMachine(typeof(_003CCycleShard_003Ed__35))]
	private IEnumerator CycleShard()
	{
		return null;
	}

	public void GainKill()
	{
	}

	public void CompleteChallenge(bool Success)
	{
	}
}
