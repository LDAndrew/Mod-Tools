using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GTTOD_Dungeon : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CSetUpDungeon_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_Dungeon _003C_003E4__this;

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
		public _003CSetUpDungeon_003Ed__45(int _003C_003E1__state)
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
	private sealed class _003CAcceptReward_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_Dungeon _003C_003E4__this;

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
		public _003CAcceptReward_003Ed__50(int _003C_003E1__state)
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

	[Header("DUNGEON STATS")]
	public Transform RewardPoint;

	public Transform StartPoint;

	public Transform LoadPoint;

	public Vector2 RewardRange;

	public Vector2 EnemyRange;

	public float LevelResetDistance;

	public float BunkerChance;

	public float LootChance;

	public float DungeonDelay;

	public bool PreUnlocked;

	[Header("DUNGEON OBJECTS")]
	public ParticleSystem RewardActivateEffect;

	public GameObject ChuteCollider;

	public GameObject EmptyBunker;

	public GameObject GrabAGun;

	public GameObject Water;

	public Animator Chute;

	[Header("OBJECT PARENTS")]
	public Transform RewardParent;

	public Transform GrabAGunsParent;

	public Transform BunkersParent;

	public Transform LootParent;

	[Header("DUNGEON BUNKERS")]
	public List<GameObject> Bunkers;

	[HideInInspector]
	public GTTOD_GrabAGun SpawnedGrabAGun;

	[HideInInspector]
	public List<Transform> BunkerPoints;

	[HideInInspector]
	public List<Transform> GrabAGunPoints;

	[HideInInspector]
	public List<Transform> LootObjects;

	[HideInInspector]
	public List<Transform> AvailableBunkerPoints;

	private PlayerEffects Effects;

	private ac_CharacterController CharacterController;

	private GTTOD_UpgradesManager Upgrades;

	private GTTOD_AIManager AIManager;

	private GTTOD_Manager Manager;

	private GTTOD_HUD HUDManager;

	private Transform Player;

	private Rigidbody PlayerPhysics;

	private GTTOD_DungeonManager DungeonManager;

	[HideInInspector]
	public GameObject[] SpawnPoints;

	private bool Active;

	private bool Progressing;

	private bool DungeonCleared;

	private bool AcceptingReward;

	private bool HasCollectedReward;

	private bool ChuteOpen;

	private int EnemiesRemaining;

	private void Start()
	{
	}

	public void AssignManager(GTTOD_DungeonManager Manager)
	{
	}

	[IteratorStateMachine(typeof(_003CSetUpDungeon_003Ed__45))]
	private IEnumerator SetUpDungeon()
	{
		return null;
	}

	private void Update()
	{
	}

	public void ResetPlayer()
	{
	}

	public void BeginDungeon()
	{
	}

	public void CompleteDungeon()
	{
	}

	[IteratorStateMachine(typeof(_003CAcceptReward_003Ed__50))]
	public IEnumerator AcceptReward()
	{
		return null;
	}

	public void GainKill()
	{
	}

	private void FindPoints()
	{
	}

	public Transform GetClosestPoint(GameObject[] Points)
	{
		return null;
	}
}
