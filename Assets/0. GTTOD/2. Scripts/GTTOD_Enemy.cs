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
public class GTTOD_Enemy : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAnimateAgent_003Ed__97 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_Enemy _003C_003E4__this;

		public bool ApplyRootMotion;

		public bool CanInterupt;

		public string Animation;

		public float AnimationTime;

		public bool RestartNavigation;

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
		public _003CAnimateAgent_003Ed__97(int _003C_003E1__state)
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
	private sealed class _003CDelayDamageRoutine_003Ed__108 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float DelayTime;

		public GTTOD_Enemy _003C_003E4__this;

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
		public _003CDelayDamageRoutine_003Ed__108(int _003C_003E1__state)
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

	[Header("ENEMY PROPERTIES")]
	public bool ShowEnemyProperties;

	[ConditionalField("ShowEnemyProperties", null)]
	public string Name;

	[ConditionalField("ShowEnemyProperties", null)]
	public string DumbfuckName;

	[ConditionalField("ShowEnemyProperties", null)]
	public float Health;

	[ConditionalField("ShowEnemyProperties", null)]
	public int ChargePercentage;

	[ConditionalField("ShowEnemyProperties", null)]
	public bool CanStagger;

	[ConditionalField("ShowEnemyProperties", null)]
	public bool CanDash;

	[ConditionalField("ShowEnemyProperties", null)]
	public bool CanBuff;

	[ConditionalField("ShowEnemyProperties", null)]
	public bool CanRevive;

	[Header("ENEMY OBJECTS")]
	public bool ShowEnemyObjects;

	[ConditionalField("ShowEnemyObjects", null)]
	public SkinnedMeshRenderer Skin;

	[ConditionalField("ShowEnemyObjects", null)]
	public ParticleSystem DashParticles;

	[ConditionalField("ShowEnemyObjects", null)]
	public GameObject ImpactEffects;

	[ConditionalField("ShowEnemyObjects", null)]
	public GameObject AttackObject;

	[ConditionalField("ShowEnemyObjects", null)]
	public GameObject DamageEffects;

	[ConditionalField("ShowEnemyObjects", null)]
	public GameObject DeathEffects;

	[ConditionalField("ShowEnemyObjects", null)]
	public Transform AttackPosition;

	[ConditionalField("ShowEnemyObjects", null)]
	public Transform HealthPosition;

	[ConditionalField("ShowEnemyObjects", null)]
	public Transform Root;

	public List<Material> EnemyMaterials;

	public List<AnimationSFX> EnemySFX;

	[HideInInspector]
	public string AdjustedName;

	[HideInInspector]
	public bool Invulnerable;

	[HideInInspector]
	public bool Engaged;

	[HideInInspector]
	public bool PreventDeath;

	[HideInInspector]
	public float MaxHealth;

	[HideInInspector]
	public GTTOD_Beacon Beacon;

	[HideInInspector]
	public Transform EnemyTarget;

	[HideInInspector]
	public bool CalculateHealthPerDifficultyOnStart;

	private GameManager GM;

	private ac_ObjectPool ObjectPool;

	private Outline EnemyOutline;

	private GTTOD_HUD PlayerHUD;

	private GTTOD_AIManager AIManager;

	private GTTOD_Manager GTTODManager;

	private GTTOD_UpgradesManager Upgrades;

	private GTTOD_Inventory InventoryManager;

	private InventoryScript Inventory;

	private NavMeshAgent EnemyAgent;

	private Animator EnemyAnimation;

	private Rigidbody EnemyPhysics;

	private Respawner EnemyRespawner;

	private AudioSource EnemyAudio;

	private AudioLowPassFilter Filter;

	private BodyIK EnemyRotation;

	private Transform PushTarget;

	private Transform RepoolPoint;

	private Vector3 PushPosition;

	private Vector3 RootScale;

	private bool Active;

	private bool Frozen;

	private bool Dead;

	private bool SetToDie;

	private bool SetToDieAttributeToPlayer;

	private bool Pushing;

	private bool Targeting;

	private bool Grounded;

	private bool PushImpact;

	private bool Staggered;

	private bool StaggerBuffer;

	private bool Animating;

	private bool UnlockedAnimation;

	private bool ShouldRotate;

	private bool Buffed;

	private bool Marked;

	private bool Repooling;

	private bool IsFrosted;

	private float InvincibilityTime;

	private float RepoolTimer;

	private float RepoolDistance;

	private float StepTime;

	private float AttackTime;

	private float SpeedSave;

	private float ForwardBack;

	private float LeftRight;

	private float PushTime;

	private float PushSpeed;

	private float UntargetDistance;

	private float ShardTime;

	public void EnemySetUp(bool UpdateRotation, float Scale, Transform Target)
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void UpdateEnemyPositioning()
	{
	}

	public void SetDestination(Vector3 Position)
	{
	}

	public bool TryDestination(Vector3 Position)
	{
		return false;
	}

	public void StopNavigation()
	{
	}

	public void FaceTarget()
	{
	}

	public void SnapToTarget(Vector3 Target)
	{
	}

	public void Push(float Distance, float Speed, Vector3 Direction)
	{
	}

	public void Push(Vector3 Position, float Speed)
	{
	}

	public void Push(Vector3 Position, float Speed, float NewUntargetDistance)
	{
	}

	public void Push(Vector3 Position, float Speed, Transform NewPushTarget, float NewUntargetDistance)
	{
	}

	public void Stagger(float StaggerDistance)
	{
	}

	public void SelfStagger(float StaggerDistance, float StaggerTime)
	{
	}

	public void ForceStagger(float StaggerDistance, float StaggerTime)
	{
	}

	public void UpdateEnemyAnimation()
	{
	}

	[IteratorStateMachine(typeof(_003CAnimateAgent_003Ed__97))]
	public IEnumerator AnimateAgent(string Animation, float AnimationTime, bool CanInterupt, bool ApplyRootMotion, bool RestartNavigation)
	{
		return null;
	}

	public void TogglePhysics(bool IsGrounded)
	{
	}

	public void BuffEnemy()
	{
	}

	public void UnBuffEnemy()
	{
	}

	public void MarkEnemy()
	{
	}

	public void BumpInvincibilityTime()
	{
	}

	public void ToggleFrost(bool Frosted)
	{
	}

	public void Freeze()
	{
	}

	public void UnFreeze()
	{
	}

	public void MeleeDamage()
	{
	}

	private void DelayDamage(float DelayTime, float DelayedDamage)
	{
	}

	[IteratorStateMachine(typeof(_003CDelayDamageRoutine_003Ed__108))]
	private IEnumerator DelayDamageRoutine(float DelayTime, float DelayedDamage)
	{
		return null;
	}

	public void Damage(float Damage)
	{
	}

	public void Obliterate()
	{
	}

	public void Die(bool attributeToPlayer = false)
	{
	}

	public void Revive()
	{
	}

	public void DeactivateEnemy()
	{
	}

	public void PlayGlobalSoundEffect(int SoundID)
	{
	}

	public void PlayLocalSoundEffect(int SoundID)
	{
	}
}
