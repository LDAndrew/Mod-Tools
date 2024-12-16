using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GTTOD_Nest : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CFireProjectiles_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_Nest _003C_003E4__this;

		private float _003CProjectileCount_003E5__2;

		private int _003Ci_003E5__3;

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
		public _003CFireProjectiles_003Ed__19(int _003C_003E1__state)
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

	public bool Friendly;

	public Transform AttackPoint;

	public EnemyProjectile Projectile;

	public GameObject ProjectileEffect;

	public Vector2 ProjectileCountRange;

	public Vector2 RateOfFireRange;

	public float ProjectileDamage;

	public float ProjectileZone;

	public float RateOfFire;

	private GTTOD_AIManager AIManager;

	private GTTOD_Enemy EnemyBase;

	public Transform Target;

	private float AttackTime;

	private float TargetTime;

	private bool Attacking;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private Transform FindEnemyTarget()
	{
		return null;
	}

	public void TriggerAttack()
	{
	}

	[IteratorStateMachine(typeof(_003CFireProjectiles_003Ed__19))]
	private IEnumerator FireProjectiles()
	{
		return null;
	}
}
