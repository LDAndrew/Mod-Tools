using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GTTOD_AIManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_AIManager _003C_003E4__this;

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
		public _003CStart_003Ed__56(int _003C_003E1__state)
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

	public string DifficultyName;

	public float MaximumHeat;

	public float CurrentHeat;

	public int MaximumWeight;

	public int AdjustedMaximumWeight;

	public float CurrentWeight;

	public int StartingThreatLevel;

	public float EnemyDifficultyModifier;

	public Vector2 SpawnDistanceRange;

	public bool EventsEnabled;

	[Header("THREAT LEVELS")]
	public List<AISpawn> Fodder;

	public List<AISpawn> Nobles;

	public List<AISpawn> Special;

	public List<AISpawn> Miniboss;

	public List<AISpawn> Boss;

	public List<EventSpawn> Events;

	public List<AIDifficultySettings> Difficulties;

	[HideInInspector]
	public float Awareness;

	[HideInInspector]
	public int VineRewards;

	[HideInInspector]
	public List<GameObject> PotentialObjects;

	[HideInInspector]
	public List<GameObject> NearSpawnPoints;

	[HideInInspector]
	public List<Respawner> CurrentEnemies;

	[HideInInspector]
	public int CurrentThreatLevel;

	[HideInInspector]
	public int WeightModifier;

	[HideInInspector]
	public GameObject[] SpawnPoints;

	[HideInInspector]
	public bool DoorEventActive;

	[HideInInspector]
	public bool ForceQuickSpawn;

	[HideInInspector]
	public bool ForceEnemyBuff;

	[HideInInspector]
	public bool ForceEnemyElite;

	[HideInInspector]
	public bool PryingEye;

	[HideInInspector]
	public bool DungeonSpawn;

	[HideInInspector]
	public bool Spawning;

	[HideInInspector]
	public bool ForceSummitSpawning;

	[HideInInspector]
	public float EnemyCount;

	[HideInInspector]
	public bool WaitingForClear;

	[HideInInspector]
	public bool GainLifeFromDeath;

	[HideInInspector]
	public int WheelOfFortuneProgression;

	[HideInInspector]
	public float SpawnDelay;

	[HideInInspector]
	public float SpawnTime;

	[HideInInspector]
	public float EffectTime;

	[HideInInspector]
	public float WaitTime;

	[HideInInspector]
	public float ThreatTime;

	[HideInInspector]
	public float RepoolTime;

	private GameManager GM;

	private GTTOD_UpgradesManager Upgrades;

	private GTTOD_Manager GTTODManager;

	private GTTOD_HealthScript Health;

	private ac_ObjectPool ObjectPool;

	private GTTOD_HUD HUDManager;

	private Transform Player;

	private Transform CurrentSpawnPoint;

	private GameObject LastSpawnEffect;

	private float BaseDifficulty;

	private float MaxDifficulty;

	private bool Active;

	private bool SpawningEnemy;

	[IteratorStateMachine(typeof(_003CStart_003Ed__56))]
	private IEnumerator Start()
	{
		return null;
	}

	private void Update()
	{
	}

	public void BumpHeat(float BumpAmount)
	{
	}

	public void UpdateWeight()
	{
	}

	public void StartSpawning()
	{
	}

	public void StopSpawning()
	{
	}

	public void FindPoints()
	{
	}

	public bool CanRepool()
	{
		return false;
	}

	public void ClearLevel()
	{
	}

	public void ViolentClearLevel()
	{
	}

	public void ClearOutsideOfPoint(Vector3 Point, float Radius)
	{
	}

	public void AddEnemy(int EnemyWeight, Respawner NewEnemy)
	{
	}

	public void RemoveEnemy(int EnemyWeight, Respawner EnemyToRemove)
	{
	}

	public void DefeatEnemy(bool attributeToPlayer)
	{
	}

	private Transform GetEnemySpawnPoint()
	{
		return null;
	}

	public Transform GetClosestSpawn(GameObject[] Points)
	{
		return null;
	}

	public Transform GetFurthestSpawn(GameObject[] Points)
	{
		return null;
	}

	public GameObject GetEnemySpawn()
	{
		return null;
	}

	public void ChooseEvent()
	{
	}

	public void StartEvent(int EventIndex)
	{
	}

	public void SetDifficultyLevel(int Difficulty)
	{
	}

	public void SetThreatLevel(int LevelToSet, bool AllowDelay)
	{
	}
}
