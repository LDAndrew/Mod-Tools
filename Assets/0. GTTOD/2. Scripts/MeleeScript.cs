using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MeleeScript : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MeleeScript _003C_003E4__this;

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
		public _003CStart_003Ed__35(int _003C_003E1__state)
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
	private sealed class _003CMelee_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool Blank;

		public MeleeScript _003C_003E4__this;

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
		public _003CMelee_003Ed__38(int _003C_003E1__state)
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

	public string WeaponName;

	public Vector3 WeaponPosition;

	public Vector3 WeaponRotation;

	public Vector3 WeaponIdlePosition;

	public float WeaponResetTime;

	public float WeaponLungeDistance;

	public float WeaponLungeSpeed;

	public float WeaponDamageModifier;

	public GameObject WeaponAttackObject;

	public SkinnedMeshRenderer Arms;

	public bool HasAirAttack;

	[Space(15f)]
	public List<MeleeAttack> Attacks;

	[HideInInspector]
	public bool Attacking;

	[HideInInspector]
	public int MeleeID;

	private GameManager GM;

	private Transform Player;

	private ac_CharacterController CharacterController;

	private GTTOD_InteractionManager Interactions;

	private GTTOD_Manager Manager;

	private GTTOD_AIManager AIManager;

	private GTTOD_UpgradesManager Upgrades;

	private InventoryScript Inventory;

	private AimScript Aimer;

	private Transform AttackPoint;

	private Animator Anim;

	private Coroutine InspectRoutine;

	private DamageZone Attack;

	private bool Active;

	private bool CanAttack;

	private bool Stepping;

	private bool Inspecting;

	private bool DropkickProtection;

	private int Cycle;

	private float InteractTimer;

	private float ResetTime;

	[IteratorStateMachine(typeof(_003CStart_003Ed__35))]
	private IEnumerator Start()
	{
		return null;
	}

	public void Update()
	{
	}

	public void UseMelee()
	{
	}

	[IteratorStateMachine(typeof(_003CMelee_003Ed__38))]
	private IEnumerator Melee(bool Blank)
	{
		return null;
	}

	public void TriggerAttack()
	{
	}

	public void TryInspect()
	{
	}

	public void EndInspect()
	{
	}

	private void OnDestroy()
	{
	}
}
