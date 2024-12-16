using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GTTOD_HealthPickup : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_HealthPickup _003C_003E4__this;

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
		public _003CStart_003Ed__16(int _003C_003E1__state)
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

	public Vector2 ScaleRange;

	public Vector2 DelayRange;

	public float PickupDistance;

	public float Health;

	public bool Overcharge;

	public AudioClip SFX;

	public bool ShouldSpawn;

	public bool ShouldDestroy;

	[ConditionalField("ShouldDestroy", null)]
	public float DestroyTime;

	private ac_ObjectPool ObjectPool;

	private GTTOD_HealthScript PlayerHealth;

	private Rigidbody PickupPhysics;

	private Transform Player;

	private AudioRange Audio;

	private bool Active;

	private bool PickingUp;

	[IteratorStateMachine(typeof(_003CStart_003Ed__16))]
	private IEnumerator Start()
	{
		return null;
	}

	private void Update()
	{
	}

	private void Pickup()
	{
	}

	private void OnCollisionEnter(Collision Col)
	{
	}
}
