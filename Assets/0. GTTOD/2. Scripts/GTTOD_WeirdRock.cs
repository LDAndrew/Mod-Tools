using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GTTOD_WeirdRock : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CInteractionPause_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_WeirdRock _003C_003E4__this;

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
		public _003CInteractionPause_003Ed__14(int _003C_003E1__state)
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
	private sealed class _003CBossFightEnd_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_WeirdRock _003C_003E4__this;

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
		public _003CBossFightEnd_003Ed__15(int _003C_003E1__state)
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

	public GameObject GupArmy;

	public GameObject ProgressBlocker;

	public List<string> Thoughts;

	private GTTOD_HUD HUDManager;

	private GTTOD_Manager Manager;

	private GTTOD_AIManager AIManager;

	private GTTOD_OSTManager OSTManager;

	private bool BossRushStarted;

	private bool BossRushFinished;

	private int ThoughtIndex;

	private float BattleEndTime;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void TriggerWeirdRock()
	{
	}

	[IteratorStateMachine(typeof(_003CInteractionPause_003Ed__14))]
	private IEnumerator InteractionPause()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CBossFightEnd_003Ed__15))]
	private IEnumerator BossFightEnd()
	{
		return null;
	}
}
