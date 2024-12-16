using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CInvulnerability_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HealthScript _003C_003E4__this;

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
		public _003CInvulnerability_003Ed__27(int _003C_003E1__state)
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

	[Space(15f)]
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
	public bool Dead;

	private ac_CharacterController CharacterController;

	private Coroutine InvulnerabilityRoutine;

	private float MaxHealth;

	private float MaxShield;

	private float MaxOvershield;

	private float ShieldRegenTime;

	private float HealthRegenTime;

	private bool Invulnerable;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void DamageArea(Vector3 Position, float Range, float AreaDamage)
	{
	}

	public void Damage(float Damage)
	{
	}

	public void SetInvulnerability(float Time)
	{
	}

	[IteratorStateMachine(typeof(_003CInvulnerability_003Ed__27))]
	public IEnumerator Invulnerability(float Time)
	{
		return null;
	}

	private void Die()
	{
	}
}
