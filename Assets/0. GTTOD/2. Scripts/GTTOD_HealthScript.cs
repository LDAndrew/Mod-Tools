using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GTTOD_HealthScript : MonoBehaviour
{
	public enum HealthType
	{
		ShieldSystem,
		ArmorSystem
	}

	[CompilerGenerated]
	private sealed class _003CStart_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_HealthScript _003C_003E4__this;

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

	[CompilerGenerated]
	private sealed class _003CInvulnerability_003Ed__58 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_HealthScript _003C_003E4__this;

		public float Time;

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
		public _003CInvulnerability_003Ed__58(int _003C_003E1__state)
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

	public HealthType HealthSystem;

	public AudioSource ShieldSFX;

	public AudioSource LowHealthSFX;

	public GameObject ShieldBreakEffect;

	public GameObject ReviveEffect;

	public GameObject DeathObject;

	[Space(15f)]
	public int Lives;

	public float Health;

	public float Shield;

	public float Overshield;

	[Space(10f)]
	public bool HealthRegen;

	[ConditionalField("HealthRegen", null)]
	public float HealthRegenMaxMultiplier;

	[ConditionalField("HealthRegen", null)]
	public float HealthRegenDelay;

	[ConditionalField("HealthRegen", null)]
	public float HealthRegenSpeed;

	public bool ShieldRegen;

	[ConditionalField("ShieldRegen", null)]
	public float ShieldRegenMaxMultiplier;

	[ConditionalField("ShieldRegen", null)]
	public float ShieldRegenDelay;

	[ConditionalField("ShieldRegen", null)]
	public float ShieldRegenSpeed;

	public List<AnimationSFX> SFX;

	[HideInInspector]
	public bool PreventingHealing;

	[HideInInspector]
	public bool Weakened;

	[HideInInspector]
	public bool Invincible;

	[HideInInspector]
	public bool Dead;

	[HideInInspector]
	public bool DeathDefiance;

	[HideInInspector]
	public bool PhoenixRevival;

	[HideInInspector]
	public float MaxHealth;

	[HideInInspector]
	public float MaxShield;

	[HideInInspector]
	public float MaxOvershield;

	[HideInInspector]
	public float ShieldRegenTime;

	[HideInInspector]
	public float HealthRegenTime;

	[HideInInspector]
	public float DamageModifier;

	private GameManager GM;

	private GTTOD_MemoryManager Memory;

	private GTTOD_HUD HUD;

	private ac_ObjectPool ObjectPool;

	private ac_CutsceneManager Cutscenes;

	private ac_CharacterController CharacterController;

	private GTTOD_UpgradesManager Upgrades;

	private GTTOD_Inventory InventoryManager;

	private GTTOD_Manager Manager;

	private InventoryScript Inventory;

	private PlayerEffects Effects;

	private Coroutine InvulnerabilityRoutine;

	private bool Invulnerable;

	private bool HealthActivated;

	private float DeathDefianceTimer;

	[IteratorStateMachine(typeof(_003CStart_003Ed__48))]
	private IEnumerator Start()
	{
		return null;
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	public void DamageArea(Vector3 Position, float Range, float AreaDamage)
	{
	}

	public void Damage(float Damage)
	{
	}

	public void Heal(float HealAmount, bool ShouldOvercharge)
	{
	}

	public void Charge(float ChargeAmount, bool ShouldOvercharge)
	{
	}

	public void Overcharge(float ChargeAmount)
	{
	}

	public void IncreaseHealth(int Type, float IncreaseAmount)
	{
	}

	public void SetInvulnerability(float Time)
	{
	}

	[IteratorStateMachine(typeof(_003CInvulnerability_003Ed__58))]
	public IEnumerator Invulnerability(float Time)
	{
		return null;
	}

	public void PlaySoundEffect(int SoundID)
	{
	}

	public void Die()
	{
	}

	public void FireEffects()
	{
	}

	public void StaticEffects()
	{
	}

	public void WeaknessEffects()
	{
	}

	public void FrostEffects()
	{
	}

	public void SetHealthSystem(HealthType System, bool HasHealthRegen, bool HasShieldRegen)
	{
	}
}
