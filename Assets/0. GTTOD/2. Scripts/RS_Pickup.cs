using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RS_Pickup : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RS_Pickup _003C_003E4__this;

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
		public _003CStart_003Ed__7(int _003C_003E1__state)
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

	private Transform Target;

	private float Speed;

	private float MidpointModifier;

	private Vector3 AdjustedMidpoint;

	private Vector3 FinalScale;

	private bool HasHitMidpoint;

	private bool Collecting;

	[IteratorStateMachine(typeof(_003CStart_003Ed__7))]
	private IEnumerator Start()
	{
		return null;
	}

	private void Update()
	{
	}

	private void Collect()
	{
	}
}
