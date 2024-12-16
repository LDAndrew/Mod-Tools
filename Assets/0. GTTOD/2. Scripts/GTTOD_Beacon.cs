using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GTTOD_Beacon : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CEncounterEffect_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_Beacon _003C_003E4__this;

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
		public _003CEncounterEffect_003Ed__44(int _003C_003E1__state)
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
	private sealed class _003CTriggerEncounters_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_Beacon _003C_003E4__this;

		private List<GTTOD_Beacon>.Enumerator _003C_003E7__wrap1;

		private GTTOD_Beacon _003Cencounter_003E5__3;

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
		public _003CTriggerEncounters_003Ed__45(int _003C_003E1__state)
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

	public LayerMask AvailableLayers;

	public bool AutoAdjustHeight;

	[Space(15f)]
	[Range(0f, 500f)]
	public float SpawnRadius;

	[Range(0f, 150f)]
	public float HoverHeight;

	[Range(0f, 240f)]
	public float HeatAddition;

	[Space(15f)]
	public Transform PointsParent;

	public GameObject ImpactEffect;

	public MeshRenderer Beacon;

	public GameObject CrystalObject;

	public GameObject DefaultEnemy;

	public bool IgnoreWeight;

	[Space(15f)]
	public List<EncounterPoint> SpawnPoints;

	public List<GTTOD_Beacon> AdditionalEncounters;

	public Material[] AdjustedMaterials;

	public int RemainingEnemies;

	public bool BeaconCleared;

	public int EnemiesToSpawn;

	public bool Setting;

	public bool Primed;

	public bool Empty;

	public bool Clear;

	private GameManager GM;

	private Transform Player;

	private Animator Anim;

	private GTTOD_Manager Manager;

	private ac_ObjectPool ObjectPool;

	private GTTOD_AIManager AIManager;

	private GTTOD_HealthScript Health;

	private GTTOD_UpgradesManager Upgrades;

	private Material[] OriginalMaterials;

	private Vector3 StartingPosition;

	private bool HasActivated;

	private bool HasSpawned;

	private bool EffectPlayed;

	private bool Blind;

	private float HoverAmount;

	private float MovementSpeed;

	private float Progress;

	private float SpawnTime;

	private void OnDrawGizmosSelected()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void UpdateEncounter()
	{
	}

	public void BeginEncounter()
	{
	}

	[IteratorStateMachine(typeof(_003CEncounterEffect_003Ed__44))]
	public IEnumerator EncounterEffect()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CTriggerEncounters_003Ed__45))]
	public IEnumerator TriggerEncounters()
	{
		return null;
	}

	public void SwitchMaterials(bool Revert)
	{
	}

	public void SuckUpPoints()
	{
	}

	public void FillWithDefault()
	{
	}

	public void RemoveEnemy()
	{
	}

	public void ClearEncounter()
	{
	}

	public void ForceRefreshEncounter()
	{
	}
}
