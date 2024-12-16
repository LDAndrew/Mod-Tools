using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GTTOD_Shards : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_Shards _003C_003E4__this;

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
		public _003CStart_003Ed__13(int _003C_003E1__state)
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

	public Vector2 ActivateTime;

	public Vector2 ScaleRange;

	public float PickupRange;

	public float DestroyTime;

	public int ShardCount;

	private GTTOD_Manager Manager;

	private Rigidbody ShardPhysics;

	private Transform Target;

	private Vector3 Midpoint;

	private bool Active;

	private bool PickingUp;

	private bool HitMidpoint;

	private float Speed;

	[IteratorStateMachine(typeof(_003CStart_003Ed__13))]
	private IEnumerator Start()
	{
		return null;
	}

	private void Update()
	{
	}
}
