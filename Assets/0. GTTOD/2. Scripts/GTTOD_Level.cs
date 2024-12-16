using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GTTOD_Level : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStartLevel_003Ed__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_Level _003C_003E4__this;

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
		public _003CStartLevel_003Ed__51(int _003C_003E1__state)
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

	public bool SafeLevel;

	public bool HasWaystation;

	public bool UncappedBunkers;

	public int Zone;

	public int EdgeColor;

	public int Cutscene;

	public Vector3 CutsceneStartPoint;

	public string LevelName;

	public float LevelStartDistance;

	public float LevelResetPoint;

	[Header("LEVEL OBJECTS")]
	public GTTOD_OrangeDoor DoorPlatform;

	public GameObject EmptyBunker;

	public GameObject GrabAGun;

	public GameObject KeyJar;

	public GameObject AlphaCache;

	public Color SunColor;

	public Transform Fog;

	public Transform SunPoint;

	public Transform MenuPoint;

	[Header("OBJECT PARENTS")]
	public Transform DoorParent;

	public Transform GrabAGunsParent;

	public Transform KeyJarsParent;

	public Transform BunkersParent;

	public Transform AlphaCacheParent;

	[HideInInspector]
	public GTTOD_GrabAGun SpawnedGrabAGun;

	[HideInInspector]
	public GameObject SpawnedAlphaCache;

	[HideInInspector]
	public bool LevelCompleted;

	[HideInInspector]
	public bool LevelStarted;

	[HideInInspector]
	public List<Transform> AvailableBunkerPoints;

	[HideInInspector]
	public List<Transform> LockedChestPoints;

	[HideInInspector]
	public List<Transform> GrabAGunPoints;

	[HideInInspector]
	public List<Transform> KeyJarPoints;

	[HideInInspector]
	public List<Transform> BunkerPoints;

	[HideInInspector]
	public List<GameObject> LevelBunkers;

	[HideInInspector]
	public List<Transform> AlphaCachePoints;

	private GameManager GM;

	private GTTOD_MemoryManager Memory;

	private ac_CharacterController CharacterController;

	private PlayerEffects Effects;

	private Rigidbody PlayerPhysics;

	private GTTOD_UpgradesManager Upgrades;

	private ac_CutsceneManager Cutscenes;

	private GTTOD_AIManager AIManager;

	private GTTOD_HealthScript Health;

	private GTTOD_Manager Manager;

	private GTTOD_HUD HUDManager;

	private Transform Player;

	private Transform Checkpoint;

	private bool LevelSetUp;

	private void Start()
	{
	}

	public void SetUp()
	{
	}

	[IteratorStateMachine(typeof(_003CStartLevel_003Ed__51))]
	public IEnumerator StartLevel()
	{
		return null;
	}

	private void Update()
	{
	}

	public void SetUpLevel()
	{
	}

	public void SetCheckpoint(Transform NewCheckpoint)
	{
	}

	public void ResetPlayer()
	{
	}
}
