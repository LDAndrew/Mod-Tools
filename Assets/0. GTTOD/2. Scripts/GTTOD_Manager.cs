using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GTTOD_Manager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CBeginSceneTransition_003Ed__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_Manager _003C_003E4__this;

		public int Index;

		public float DelayTime;

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
		public _003CBeginSceneTransition_003Ed__53(int _003C_003E1__state)
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
	private sealed class _003CBeginSceneTransition_003Ed__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_Manager _003C_003E4__this;

		public string SceneName;

		public float DelayTime;

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
		public _003CBeginSceneTransition_003Ed__56(int _003C_003E1__state)
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
	private sealed class _003CCompleteLevelLoop_003Ed__65 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_Manager _003C_003E4__this;

		private string _003CNextLevel_003E5__2;

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
		public _003CCompleteLevelLoop_003Ed__65(int _003C_003E1__state)
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

	public bool Regenerate;

	public bool CozyMode;

	public int AspectLevel;

	public int HarborScrolls;

	public int JadeVines;

	public int Shards;

	[Header("LEVEL MANAGEMENT")]
	public GTTOD_Waystation Waystation;

	public List<GameSet> Games;

	public List<GameObject> DefaultBunkers;

	[Header("MANAGER OBJECTS")]
	public AudioSource ManagerSource;

	public Transform HarborDeepLoadPoint;

	public List<AudioClip> ManagerAudio;

	public List<string> SacrificeLinks;

	[Header("RUNS")]
	public List<string> GeneratedRun;

	[HideInInspector]
	public float TransitionSpeed;

	[HideInInspector]
	public float FogMultiplier;

	[HideInInspector]
	public int ShardsMultiplier;

	[HideInInspector]
	public int LevelsCompleted;

	[HideInInspector]
	public int ModeID;

	[HideInInspector]
	public int SceneID;

	[HideInInspector]
	public int SessionKills;

	[HideInInspector]
	public GTTOD_Level CurrentLevel;

	[HideInInspector]
	public GTTOD_TempZone CurrentTempZone;

	[HideInInspector]
	public List<GameObject> Listeners;

	[HideInInspector]
	public bool GameStarted;

	[HideInInspector]
	public bool HasLooped;

	[HideInInspector]
	public bool AtShop;

	[HideInInspector]
	public bool DungeonArenaCleared;

	[HideInInspector]
	public string LastLoadedScene;

	private GameManager GM;

	private GTTOD_MemoryManager Memory;

	private GTTOD_UpgradesManager Upgrades;

	private ac_CutsceneManager Cutscenes;

	private GTTOD_AIManager AIManager;

	private GTTOD_Inventory Inventory;

	private GTTOD_HealthScript Health;

	private GTTOD_HUD HudManager;

	private GTTOD_OSTManager OST;

	private GTTOD_ModManager ModManager;

	private ac_CharacterController CharacterController;

	private Transform Player;

	private AsyncOperation Operation;

	private Transform LoadPosition;

	private bool PortalActive;

	private float Fog;

	private float FogTarget;

	private bool Active;

	private bool Transitioning;

	private string CustomLevelTag;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void SetWorld(Material Skybox, bool HasSunShafts, Transform SunShaftPoint, Color SunShaftColor)
	{
	}

	[IteratorStateMachine(typeof(_003CBeginSceneTransition_003Ed__53))]
	public IEnumerator BeginSceneTransition(int Index, float DelayTime)
	{
		return null;
	}

	public void SetLoadPosition(Transform PositionToSet)
	{
	}

	public void LoadScene(string SceneName, float NewTransitionSpeed, Color NewTransitionColor, float DelayTime)
	{
	}

	[IteratorStateMachine(typeof(_003CBeginSceneTransition_003Ed__56))]
	public IEnumerator BeginSceneTransition(string SceneName, float DelayTime)
	{
		return null;
	}

	public bool SceneExists(string sceneName)
	{
		return false;
	}

	public void GenerateRun()
	{
	}

	public void AddLevelToIndex(int ActIndex, int SceneIndex)
	{
	}

	public void GainKill()
	{
	}

	public void AdjustJadeVines(int VinesToAdd)
	{
	}

	public void AdjustShards(int ShardsToAdd)
	{
	}

	public void PorgressDoorEvent(int ChargeAmount)
	{
	}

	public void CompleteLevel()
	{
	}

	[IteratorStateMachine(typeof(_003CCompleteLevelLoop_003Ed__65))]
	private IEnumerator CompleteLevelLoop()
	{
		return null;
	}

	public void PlayAudio(int Index)
	{
	}

	public void AttemptRestart()
	{
	}

	public void RestartDead()
	{
	}

	public void Restart()
	{
	}

	public void UpdateListeners(string Update)
	{
	}

	public void UpdateListeners(string Update, float Variable)
	{
	}

	public void AdjustListener(GameObject Listener, bool AddListener)
	{
	}
}
