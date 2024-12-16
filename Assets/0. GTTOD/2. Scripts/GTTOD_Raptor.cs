using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

public class GTTOD_Raptor : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CBreakShieldRoutine_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_Raptor _003C_003E4__this;

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
		public _003CBreakShieldRoutine_003Ed__30(int _003C_003E1__state)
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

	public bool Elite;

	public LayerMask PotentialLayers;

	[Header("GENERAL SETTINGS")]
	public Transform EnemyMuzzle;

	public GTTOD_EnergyShield EnemyShield;

	public Vector2 EnemyRefreshRate;

	public Vector2 ScaleRange;

	public Vector2 TargetRange;

	public Vector2 PanicRange;

	public Vector2 EnemyBurstCount;

	[Space(15f)]
	[Header("PROJECTILE SETTINGS")]
	public EnemyProjectile Projectile;

	public float EnemyProjectileDamage;

	public float EnemyAccuracyModifier;

	public float EnemyRateOfFire;

	public float EnemyShieldHealth;

	private GameManager GM;

	private GTTOD_Enemy EnemyBase;

	private GTTOD_AIManager AIManager;

	private Transform Target;

	private Animator Anim;

	private NavMeshAgent Agent;

	private bool ShieldBroken;

	private float CrumbTime;

	private float RateOfFire;

	private float EnemySpeed;

	private int ShotsFired;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void UpdateAttacks()
	{
	}

	public void Interrupt()
	{
	}

	public void BreakShield()
	{
	}

	[IteratorStateMachine(typeof(_003CBreakShieldRoutine_003Ed__30))]
	private IEnumerator BreakShieldRoutine()
	{
		return null;
	}

	public void RecoverShield()
	{
	}
}
