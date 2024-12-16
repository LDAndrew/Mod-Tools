using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

public class GTTOD_Mantis : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_Mantis _003C_003E4__this;

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
		public _003CStart_003Ed__48(int _003C_003E1__state)
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

	public bool ShouldRepool;

	public bool Elite;

	[ConditionalField("Elite", null)]
	public float SpawnTime;

	[ConditionalField("Elite", null)]
	public Transform Spawn;

	[ConditionalField("Elite", null)]
	public GTTOD_Mantis BossMantis;

	[ConditionalField("Elite", null)]
	public GameObject LandingExplosion;

	public bool FlyOnStart;

	public LayerMask PotentialLayers;

	public Vector2 EnemyRefreshRate;

	public Vector2 TargetRange;

	public Vector2 ScaleRange;

	public Vector2 FlightRange;

	[Header("PROJECTILE SETTINGS")]
	public Vector2 EnemyBurstCount;

	public Transform Muzzle;

	public EnemyProjectile Projectile;

	public float EnemyProjectileDamage;

	public float EnemyAccuracyModifier;

	public float EnemyRateOfFire;

	[Header("MELEE SETTINGS")]
	public float MeleeDistance;

	public float MeleeTime;

	public float MeleeDamage;

	[Header("FLIGHT VARIABLES")]
	public float FlyingBumpOff;

	public float FlyingSpeed;

	public float FlyingDistance;

	public float MaxFlightSpeed;

	public float ObstacleDetection;

	public float FlightOffset;

	public float FlightDampening;

	public float FlightChance;

	private GameManager GM;

	private GTTOD_AIManager AIManager;

	private GTTOD_Enemy EnemyBase;

	private GTTOD_HealthScript PlayerHealth;

	private Transform Target;

	private Rigidbody MantisPhysics;

	private NavMeshAgent MantisAgent;

	private bool Flying;

	private bool Falling;

	private float AttackDelay;

	private float RateOfFire;

	private float CrumbTime;

	private float AT;

	private float StateTimer;

	private float FlightRepool;

	private float MantisSpawnTime;

	private int ShotsFired;

	private Vector3 Direction;

	private Vector3 PreviousPosition;

	[IteratorStateMachine(typeof(_003CStart_003Ed__48))]
	private IEnumerator Start()
	{
		return null;
	}

	private void Update()
	{
	}

	private void Pathfinding()
	{
	}

	public void UpdateAttacks()
	{
	}

	public void Fall()
	{
	}

	public void TogglePhysics(bool Grounded)
	{
	}

	public void TriggerAttack()
	{
	}
}
