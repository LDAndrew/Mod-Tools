using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(BodyIK))]
public class RS_Enemy : MonoBehaviour
{
	public enum EnemyState
	{
		Idle,
		Wandering,
		Attacking
	}

	[CompilerGenerated]
	private sealed class _003CAnimateAgent_003Ed__82 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RS_Enemy _003C_003E4__this;

		public bool ApplyRootMotion;

		public bool CanInterupt;

		public string Animation;

		public float AnimationTime;

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
		public _003CAnimateAgent_003Ed__82(int _003C_003E1__state)
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
	private sealed class _003CDelayDamageRoutine_003Ed__89 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float DelayTime;

		public RS_Enemy _003C_003E4__this;

		public float DelayedDamage;

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
		public _003CDelayDamageRoutine_003Ed__89(int _003C_003E1__state)
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

	public bool StartInGround;

	public LayerMask PotentialLayers;

	public EnemyState State;

	[Header("ENEMY PROPERTIES")]
	public string EnemyName;

	public Vector2 EnemyRefreshRate;

	public Vector2 SpeedRange;

	public Vector2 ScaleRange;

	public float Health;

	public float Speed;

	public float AttackSpeed;

	public float AttackRange;

	[Header("ENEMY OBJECTS")]
	public Transform HealthPoint;

	public GameObject ImpactEffects;

	public GameObject AttackObject;

	public GameObject DeathEffects;

	public GameObject Footstep;

	public Transform AttackPosition;

	public Transform LeftFoot;

	public Transform RightFoot;

	public SkinnedMeshRenderer Skin;

	[Header("ENEMY LISTS")]
	public List<Rigidbody> RagdollSegments;

	public List<Mesh> EnemySkins;

	private GameManager GM;

	private GTTOD_HUD PlayerHUD;

	private Transform EnemyTarget;

	private NavMeshAgent EnemyAgent;

	private Animator EnemyAnimation;

	private Rigidbody EnemyPhysics;

	private AudioSource EnemyAudio;

	private BodyIK EnemyRotation;

	private Vector3 PushPosition;

	private Vector3 PhasePosition;

	private bool Active;

	private bool Frozen;

	private bool Dead;

	private bool SetToDie;

	private bool Pushing;

	private bool Phasing;

	private bool PushImpact;

	private bool Staggered;

	private bool StaggerBuffer;

	private bool Animating;

	private bool UnlockedAnimation;

	private bool PhysicsSave;

	private bool Attacking;

	private bool Crippled;

	private float StepTime;

	private float AttackTime;

	private float SpeedSave;

	private float ForwardBack;

	private float LeftRight;

	private float PushTime;

	private float PhaseTime;

	private float CrumbTime;

	private float PushSpeed;

	private float PhaseSpeed;

	private float MaxHealth;

	private float MaxX;

	private float MaxZ;

	private int SpeedModifier;

	private void Start()
	{
	}

	public void EnemySetUp(float EnemyMaxSpeed, int EnemySpeedModifer, bool UpdateRotation)
	{
	}

	private void Update()
	{
	}

	public void UpdateEnemyPositioning()
	{
	}

	public void UpdateEnemyNavigation()
	{
	}

	public void Navigate()
	{
	}

	public void SetDestination(Vector3 Position)
	{
	}

	public void StopNavigation()
	{
	}

	public void SetTarget()
	{
	}

	public void SetTarget(int Index)
	{
	}

	private void FaceTarget()
	{
	}

	private void SnapToTarget(Vector3 Target)
	{
	}

	public void Push(float Distance, float Speed, Vector3 Direction)
	{
	}

	public void Push(Vector3 Position, float Speed)
	{
	}

	public void Phase(Vector3 StartPosition, Vector3 EndPosition, float Speed, float Time)
	{
	}

	public void Stagger(float StaggerDistance)
	{
	}

	public void Enter(bool AnimateEntry, Vector3 StartingPosition, Vector3 EndPosition, float Speed, float Time, float Blend)
	{
	}

	public void Cripple(RS_Limb.LimbType LimbType)
	{
	}

	public void UpdateEnemyAnimation()
	{
	}

	private void UpdateEnemyAttacks()
	{
	}

	public void AttackBarrier()
	{
	}

	[IteratorStateMachine(typeof(_003CAnimateAgent_003Ed__82))]
	public IEnumerator AnimateAgent(string Animation, float AnimationTime, bool CanInterupt, bool ApplyRootMotion)
	{
		return null;
	}

	public void Step(int Right)
	{
	}

	public void TriggerAttack()
	{
	}

	public void TriggerDamageArea()
	{
	}

	public void Freeze()
	{
	}

	public void UnFreeze()
	{
	}

	private void DelayDamage(float DelayTime, float DelayedDamage)
	{
	}

	[IteratorStateMachine(typeof(_003CDelayDamageRoutine_003Ed__89))]
	private IEnumerator DelayDamageRoutine(float DelayTime, float DelayedDamage)
	{
		return null;
	}

	public void Damage(float Damage)
	{
	}

	public void Die()
	{
	}
}
