using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

public class LudeoStartupHandler : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CFireStartUpEvent_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LudeoStartupHandler _003C_003E4__this;

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
		public _003CFireStartUpEvent_003Ed__10(int _003C_003E1__state)
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

	private const string LUDEO_ID_PATTERN = "ludeoid";

	private static bool skippedNormalFlow;

	public bool testStartupFlow;

	public UnityEvent onLudeoGameStartupStepOne;

	public UnityEvent onLudeoGameStartupStepTwo;

	public static bool SkippedNormalFlow => false;

	private void Start()
	{
	}

	private void CheckSteamCommandLine()
	{
	}

	private void SkipNormalStartup()
	{
	}

	[IteratorStateMachine(typeof(_003CFireStartUpEvent_003Ed__10))]
	private IEnumerator FireStartUpEvent()
	{
		return null;
	}
}
