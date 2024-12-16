using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

public class GTTOD_BladeSentinel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_BladeSentinel _003C_003E4__this;

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
		public _003CStart_003Ed__51(int _003C_003E1__state)
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
	private sealed class _003CAttackLoop_003Ed__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_BladeSentinel _003C_003E4__this;

		private List<GTTOD_SentinelBlade>.Enumerator _003C_003E7__wrap1;

		private GTTOD_SentinelBlade _003CBlade_003E5__3;

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
		public _003CAttackLoop_003Ed__54(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CDeathSequence_003Ed__59 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_BladeSentinel _003C_003E4__this;

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
		public _003CDeathSequence_003Ed__59(int _003C_003E1__state)
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
	private sealed class _003CDodge_003Ed__60 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_BladeSentinel _003C_003E4__this;

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
		public _003CDodge_003Ed__60(int _003C_003E1__state)
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

	public Transform BladeRoot;

	public Transform AttackPoint;

	public ParticleSystem SliceEffect;

	public GameObject BladeObject;

	public GameObject ShieldBreakEffect;

	public GameObject DeathEffects;

	public int AttackCount;

	public float AttackDistance;

	public float ShieldChargeAmount;

	public GTTOD_BladeSentinelArena Arena;

	public List<BladeSentinelPhase> Phases;

	public List<GTTOD_SentinelBlade> Blades;

	private GameManager GM;

	private Transform Player;

	private Animator Anim;

	private NavMeshAgent Agent;

	private GTTOD_EnergyShield EnergyShield;

	private ac_CharacterController CharacterController;

	private GTTOD_AIManager AIManager;

	private GTTOD_HealthScript PlayerHealth;

	private GTTOD_UpgradesManager Upgrades;

	private GTTOD_Story StoryManager;

	private GTTOD_HUD HUDManager;

	private GTTOD_Enemy EnemyBase;

	private Transform Target;

	private AudioRange BladeAudio;

	private Coroutine AttackRoutine;

	private float CrumbTime;

	private float AttackTime;

	private float DodgeBuffer;

	private float CurrentDamage;

	private float Distance;

	private bool Active;

	private bool Dodging;

	private bool BladesOn;

	private bool Attacking;

	private bool Blocking;

	private bool Dead;

	private bool CanShield;

	private bool ActivatingBlades;

	private float BladeAttackSpeed;

	private float BladeAttackTime;

	private int BladeMaxAttacks;

	private int BladeAttackCount;

	private int BladeAttackType;

	private int CurrentPhase;

	[IteratorStateMachine(typeof(_003CStart_003Ed__51))]
	private IEnumerator Start()
	{
		return null;
	}

	private void Update()
	{
	}

	private void AttackUpdate()
	{
	}

	[IteratorStateMachine(typeof(_003CAttackLoop_003Ed__54))]
	private IEnumerator AttackLoop()
	{
		return null;
	}

	private void SetPhase(int PhaseIndex)
	{
	}

	public void BreakShield()
	{
	}

	private void ToggleBlock(bool IsBlocking)
	{
	}

	public void Damage()
	{
	}

	[IteratorStateMachine(typeof(_003CDeathSequence_003Ed__59))]
	private IEnumerator DeathSequence()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CDodge_003Ed__60))]
	private IEnumerator Dodge()
	{
		return null;
	}

	public void TriggerAttack()
	{
	}

	public void Interrupt()
	{
	}

	public void Death()
	{
	}

	public void ToggleBlades()
	{
	}
}
