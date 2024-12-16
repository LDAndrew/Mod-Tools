using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GTTOD_Waystation : MonoBehaviour
{
	public enum LoadType
	{
		LongLoad,
		QuickLoad,
		StatLoad,
		AmbushLoad
	}

	[CompilerGenerated]
	private sealed class _003CWaystationLoadRoutine_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool Loading;

		public GTTOD_Waystation _003C_003E4__this;

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
		public _003CWaystationLoadRoutine_003Ed__44(int _003C_003E1__state)
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

	public LoadType Load;

	public Animator DoorAnimator;

	public Transform CutscenePosition;

	public Animator WaystationAnimator;

	[Header("SHAFT VARIABLES")]
	public Transform WaystationShaft;

	public ParticleSystem WindEffect;

	public ParticleSystem ArriveEffect;

	public AudioSource ShaftAudio;

	public Light ShaftLight;

	public float ShaftSpeed;

	[Header("MISC VARIABLES")]
	public GameObject GenericObjects;

	public GameObject SpecialObjects;

	public List<EncounterPoint> Ambush;

	private GameManager GM;

	private ac_CharacterController CharacterController;

	private ac_CutsceneManager Cutscenes;

	private ac_ObjectPool ObjectPool;

	private AudioSource ShaftPass;

	private SustainedShake Shaker;

	private GTTOD_UpgradesManager Upgrades;

	private GTTOD_AIManager AIManager;

	private GTTOD_Manager Manager;

	private Vector3 StartingPosition;

	private float StartingIntensity;

	private float ShaftSpeedModifier;

	private float Progress;

	private float SpawnTime;

	private bool ShaftActive;

	private bool HasPassed;

	private bool SetToStop;

	private bool WaystationLoading;

	private bool Ambushing;

	private bool AmbushCompleted;

	private bool EffectPlayed;

	private bool Clear;

	private bool Empty;

	private int ExtraPasses;

	private int EnemiesToSpawn;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void UpdateAmbush()
	{
	}

	public void WaystationLoad()
	{
	}

	public void LoadSummitWaystation(float Offset)
	{
	}

	[IteratorStateMachine(typeof(_003CWaystationLoadRoutine_003Ed__44))]
	public IEnumerator WaystationLoadRoutine(bool Loading)
	{
		return null;
	}

	public void ToggleShaft(bool Active)
	{
	}

	public void DoorCutscene()
	{
	}
}
