using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GTTOD_UltimateAbility : MonoBehaviour
{
	public enum UltimateType
	{
		Reflex,
		UniversalPause,
		VoidBurst,
		FlameRelease,
		FrostBeam,
		StormCall,
		Mirror,
		Possess,
		TemporalShift,
		WorldStep
	}

	[CompilerGenerated]
	private sealed class _003CBeginUltimate_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_UltimateAbility _003C_003E4__this;

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
		public _003CBeginUltimate_003Ed__41(int _003C_003E1__state)
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

	public UltimateType Ultimate;

	public string UltimateName;

	public Transform UltimatePoint;

	public Light ChargeLight;

	public SkinnedMeshRenderer Arms;

	public Vector3 UltimatePosition;

	public Vector3 UltimateRotation;

	public Vector3 UltimateIdlePosition;

	public float UltimateChargeAmount;

	public float UltimateDrainSpeed;

	public List<UltimateUsage> UltimateUsages;

	[HideInInspector]
	public int UltimateID;

	[HideInInspector]
	public bool UltimateActive;

	private GameManager GM;

	private Animator Anim;

	private SustainedShake Shake;

	private ac_CutsceneManager Cutscenes;

	private ac_CharacterController CharacterController;

	private InventoryScript Inventory;

	private GTTOD_HealthScript Health;

	private GTTOD_Manager Manager;

	private PlayerEffects Effects;

	private GTTOD_UpgradesManager Upgrades;

	private GameObject PreviousItem;

	private GTTOD_Inventory InventoryManager;

	private AudioSource ChargeAudio;

	private float HoldTime;

	private float ChargeRate;

	private float TransformTime;

	private float LightModifier;

	private float FlickerTime;

	private int Cycle;

	private bool CanToggle;

	private bool Charging;

	private bool ChargeRelease;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void ToggleUltimate()
	{
	}

	public void ToggleCharge(int ChargeOn)
	{
	}

	public void EndCharge()
	{
	}

	[IteratorStateMachine(typeof(_003CBeginUltimate_003Ed__41))]
	private IEnumerator BeginUltimate()
	{
		return null;
	}

	public void TriggerUltimate()
	{
	}

	public void EndUltimate()
	{
	}
}
