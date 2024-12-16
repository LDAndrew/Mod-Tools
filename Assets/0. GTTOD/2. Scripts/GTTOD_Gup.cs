using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

public class GTTOD_Gup : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_Gup _003C_003E4__this;

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
		public _003CStart_003Ed__26(int _003C_003E1__state)
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

	public LayerMask PotentialLayers;

	public Vector2 EnemyRefreshRate;

	public Vector2 TargetRange;

	public Vector2 ScaleRange;

	public float HopSpeed;

	public float Deacceleration;

	public GameObject AttackObject;

	public Transform AttackPoint;

	public float AttackDistance;

	public float AtackDelay;

	public bool Elite;

	private GTTOD_UpgradesManager Upgrades;

	private GTTOD_AIManager AIManager;

	private GTTOD_Enemy EnemyBase;

	private NavMeshAgent EnemyAgent;

	private GTTOD_HealthScript PlayerHealth;

	private GameObject Target;

	private Rigidbody GupPhysics;

	private float CrumbTime;

	private float AttackTime;

	private float Speed;

	private float TargetTime;

	private float FallTime;

	private bool Falling;

	private int CyclesBeforeDeath;

	[IteratorStateMachine(typeof(_003CStart_003Ed__26))]
	private IEnumerator Start()
	{
		return null;
	}

	private GameObject FindEnemyTarget()
	{
		return null;
	}

	private void Update()
	{
	}

	public void TogglePhysics(bool PhysicsOn)
	{
	}

	public void Hop()
	{
	}

	public void TriggerAttack()
	{
	}
}
