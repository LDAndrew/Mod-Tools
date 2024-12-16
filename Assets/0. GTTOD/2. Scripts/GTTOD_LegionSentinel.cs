using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

public class GTTOD_LegionSentinel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDodge_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_LegionSentinel _003C_003E4__this;

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
		public _003CDodge_003Ed__38(int _003C_003E1__state)
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

	public LayerMask PotentialLayers;

	[Space(15f)]
	public Vector2 EnemyRefreshRate;

	public Vector2 TargetRange;

	public Vector2 ScaleRange;

	public Vector2 AttackRange;

	public Transform AttackPoint;

	public EnemyProjectile Projectile;

	public ParticleSystem SliceEffect;

	public GTTOD_Hound CinderHound;

	public GTTOD_LegionSentinelArena Arena;

	public int AttackCount;

	public float AttackDistance;

	public bool ShouldSpeak;

	public List<LegionSentinelPhase> Phases;

	private GameManager GM;

	private Animator Anim;

	private NavMeshAgent Agent;

	private GTTOD_AIManager AIManager;

	private GTTOD_HealthScript PlayerHealth;

	private GTTOD_HUD HUDManager;

	private GTTOD_UpgradesManager Upgrades;

	private GTTOD_Story StoryManager;

	private GTTOD_Enemy EnemyBase;

	private Transform Target;

	private AudioRange ScytheAudio;

	private float CrumbTime;

	private float AttackTime;

	private float HoundTime;

	private float CurrentDamage;

	private float Distance;

	private bool Dodging;

	private bool Dead;

	private int CurrentPhase;

	private int MaxHounds;

	private int CurrentHounds;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Damage()
	{
	}

	[IteratorStateMachine(typeof(_003CDodge_003Ed__38))]
	private IEnumerator Dodge()
	{
		return null;
	}

	private void SetPhase(int PhaseIndex)
	{
	}

	private void SpawnHound()
	{
	}

	public void RemoveHound()
	{
	}

	public void TriggerAttack()
	{
	}

	public void TriggerRangedAttack()
	{
	}

	public void Interrupt()
	{
	}

	public void Death()
	{
	}
}
