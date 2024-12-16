using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GrappleHook : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CResetAbilities_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GrappleHook _003C_003E4__this;

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
		public _003CResetAbilities_003Ed__40(int _003C_003E1__state)
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

	public LayerMask AvailableLayers;

	[Header("EditedVariables")]
	public Transform GrappleRoot;

	public AudioSource GrappleAudio;

	public LineRenderer GrappleWire;

	public GameObject GrappleHit;

	public GameObject GrappleUI;

	[Header("GRAPPLE VARIABLES")]
	public float GrappleSpeed;

	public float GrappleAcceleration;

	public float GrappleGravity;

	public float GrappleRange;

	public float GrappleSpring;

	public float GrappleDampening;

	private ac_CharacterController CharacterController;

	private ac_CutsceneManager Cutscenes;

	private Rigidbody PlayerPhysics;

	private SpringJoint PlayerSpring;

	private SustainedShake Screenshake;

	private Camera PlayerCamera;

	private Transform LookDirection;

	private Transform GrappleHitObject;

	private Transform LastHitObject;

	private EquipmentScript Equipment;

	private Animator Anim;

	private float AdjustedGrappleSpeed;

	private float AngleBump;

	private float GravitySave;

	private float SmoothLeftRight;

	private float SmoothUpDown;

	private float GrappleAngle;

	private bool Enemy;

	private bool Grappling;

	private bool Grounded;

	private bool Above;

	private Vector3 GrappleHitPos;

	private Coroutine ResetRoutine;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void TryGrapple()
	{
	}

	private void Grapple(RaycastHit GrappleHitPoint)
	{
	}

	private void UnGrapple(bool ResetAbiltiies)
	{
	}

	[IteratorStateMachine(typeof(_003CResetAbilities_003Ed__40))]
	private IEnumerator ResetAbilities()
	{
		return null;
	}

	private void UpdateGrapple()
	{
	}

	private void FixedUpdate()
	{
	}

	private void LateUpdate()
	{
	}

	private void UpdateAnimations()
	{
	}

	private void UpdateWire()
	{
	}
}
