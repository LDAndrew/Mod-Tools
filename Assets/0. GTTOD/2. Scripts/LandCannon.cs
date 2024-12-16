using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LandCannon : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CLaunchCooldown_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LandCannon _003C_003E4__this;

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
		public _003CLaunchCooldown_003Ed__12(int _003C_003E1__state)
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

	public float UpForce;

	public float ForwardForce;

	public float ActivationDistance;

	public bool KillMomentum;

	public float CooldownTime;

	private Rigidbody Player;

	private ac_CharacterController CharacterController;

	private AudioRange Audio;

	private bool HasLaunched;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Launch()
	{
	}

	[IteratorStateMachine(typeof(_003CLaunchCooldown_003Ed__12))]
	private IEnumerator LaunchCooldown()
	{
		return null;
	}
}
