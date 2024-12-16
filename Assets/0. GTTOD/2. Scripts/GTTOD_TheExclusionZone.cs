using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GTTOD_TheExclusionZone : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStartLevel_003Ed__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_TheExclusionZone _003C_003E4__this;

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
		public _003CStartLevel_003Ed__56(int _003C_003E1__state)
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
	private sealed class _003CBeginCombat_003Ed__62 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_TheExclusionZone _003C_003E4__this;

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
		public _003CBeginCombat_003Ed__62(int _003C_003E1__state)
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
	private sealed class _003CSpawnRoutine_003Ed__65 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_TheExclusionZone _003C_003E4__this;

		private List<GameObject>.Enumerator _003C_003E7__wrap1;

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
		public _003CSpawnRoutine_003Ed__65(int _003C_003E1__state)
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

	[Header("LEVEL STATS")]
	public string LevelName;

	public float LevelStartDistance;

	public float LevelResetPoint;

	public int Zone;

	public int EdgeColor;

	public bool StartWithScene;

	[ConditionalField("StartWithScene", null)]
	public int CutsceneID;

	[ConditionalField("StartWithScene", null)]
	public Vector3 CutscenePosition;

	[Header("LEVEL ART")]
	public Color SunColor;

	public Transform Fog;

	public Transform SunPoint;

	public CanvasGroup Fader;

	[Header("LEVEL OBJECTS")]
	public Transform MenuPoint;

	public Animator AnimatedObjects;

	public Transform BlackHolePoint;

	public AudioSource TenseNote;

	public Transform PlayerHook;

	public GameObject Interiors;

	public GameObject Exteriors;

	public GameObject Level;

	public List<GameObject> Enemies;

	[Header("INTERIOR OBJECTS")]
	public GameObject InteractiveDropPod;

	public ParticleSystem Sparks;

	public GameObject CombatSpawns;

	[HideInInspector]
	public GTTOD_DropPod DropPodCutscene;

	private GameManager GM;

	private ac_CharacterController CharacterController;

	private ac_CutsceneManager Cutscenes;

	private GTTOD_MainMenu MainMenu;

	private GTTOD_Manager Manager;

	private GTTOD_HUD HUDManager;

	private GTTOD_OSTManager OST;

	private ac_OptionsMenu Options;

	private PlayerEffects Effects;

	private Transform Player;

	private Rigidbody PlayerPhysics;

	private Transform Checkpoint;

	private AudioRange SparksAudio;

	private bool LevelStarted;

	private bool CutsceneEnded;

	private bool SceneStarted;

	private bool PlayerHooked;

	private bool Teleporting;

	private bool Unfade;

	private bool Spawning;

	private bool FirstDoorOpened;

	private bool SecondDoorOpened;

	private bool FirstIslandSucked;

	private bool SecondIslandSucked;

	private bool FinishedLevel;

	private float SparkTime;

	private float SpeedSave;

	private float NoteVolume;

	private int Stage;

	private int Ability;

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CStartLevel_003Ed__56))]
	public IEnumerator StartLevel()
	{
		return null;
	}

	private void Update()
	{
	}

	public void SetCheckpoint(Transform NewCheckpoint)
	{
	}

	public void ResetPlayer()
	{
	}

	public void Damage(float Damage)
	{
	}

	public void GrabPipe()
	{
	}

	[IteratorStateMachine(typeof(_003CBeginCombat_003Ed__62))]
	private IEnumerator BeginCombat()
	{
		return null;
	}

	public void LandOnPlatform()
	{
	}

	public void BeginSpawning()
	{
	}

	[IteratorStateMachine(typeof(_003CSpawnRoutine_003Ed__65))]
	private IEnumerator SpawnRoutine()
	{
		return null;
	}

	public void TransitionToLevel()
	{
	}

	public void EnterLevelSegment()
	{
	}

	public void FinishLevel()
	{
	}

	public void HookPlayer()
	{
	}

	public void WeakenPlayer()
	{
	}

	public void AddAbility()
	{
	}
}
