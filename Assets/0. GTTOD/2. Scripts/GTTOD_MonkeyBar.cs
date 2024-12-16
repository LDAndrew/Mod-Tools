using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GTTOD_MonkeyBar : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CSwingCooldown_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_MonkeyBar _003C_003E4__this;

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
		public _003CSwingCooldown_003Ed__18(int _003C_003E1__state)
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

	[Header("SET-UP")]
	public GameObject Hook;

	public Transform FrontSide;

	public Transform BackSide;

	[Header("SOUNDS AND FORCES")]
	public AudioClip StartSFX;

	public AudioClip EndSFX;

	public float ForwardForce;

	public float UpwardsForce;

	private Transform Player;

	private Rigidbody PlayerPhysics;

	private ac_CharacterController CharacterController;

	private Animator Anim;

	private AudioSource Audio;

	private bool OnPole;

	private bool CoolingDown;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void StartSwing()
	{
	}

	public void EndSwing()
	{
	}

	[IteratorStateMachine(typeof(_003CSwingCooldown_003Ed__18))]
	private IEnumerator SwingCooldown()
	{
		return null;
	}
}
