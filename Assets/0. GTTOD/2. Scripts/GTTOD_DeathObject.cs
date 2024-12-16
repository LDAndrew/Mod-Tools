using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GTTOD_DeathObject : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_DeathObject _003C_003E4__this;

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
		public _003CStart_003Ed__20(int _003C_003E1__state)
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

	public Transform Body;

	public Transform Rotation;

	public Rigidbody Ragdoll;

	public Transform CameraAimPoint;

	public CanvasGroup Fade;

	public float CameraFollowSpeed;

	public float RotationDegrees;

	private GameManager GM;

	private ac_CharacterController CharacterController;

	private ac_CutsceneManager Cutscenes;

	private InventoryScript Inventory;

	private Rigidbody Player;

	private GTTOD_HUD HUD;

	private float RotateAmount;

	private float FollowSpeed;

	private float CameraX;

	private float CameraY;

	private bool Fading;

	private bool HasLoaded;

	[IteratorStateMachine(typeof(_003CStart_003Ed__20))]
	private IEnumerator Start()
	{
		return null;
	}

	private void Update()
	{
	}
}
