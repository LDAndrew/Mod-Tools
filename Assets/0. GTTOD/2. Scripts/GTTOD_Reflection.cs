using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class GTTOD_Reflection : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_Reflection _003C_003E4__this;

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
		public _003CStart_003Ed__51(int _003C_003E1__state)
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
	private sealed class _003CSetUpGrid_003Ed__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_Reflection _003C_003E4__this;

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
		public _003CSetUpGrid_003Ed__53(int _003C_003E1__state)
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
	private sealed class _003CTutorialRoutine_003Ed__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_Reflection _003C_003E4__this;

		public int Index;

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
		public _003CTutorialRoutine_003Ed__56(int _003C_003E1__state)
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
	private sealed class _003CReturnToHarborDeep_003Ed__60 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_Reflection _003C_003E4__this;

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
		public _003CReturnToHarborDeep_003Ed__60(int _003C_003E1__state)
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

	[Header("REFLECTION SETTINGS")]
	public Color SunColor;

	public Transform MenuPoint;

	public Transform LoadPoint;

	public Text PreviousTimeText;

	public Text BestTimeText;

	[Header("TUTORIAL OBJECTS")]
	public GameObject ReturnEffect;

	public GameObject PortalEffect;

	public GameObject TargetEnemy;

	public GameObject HUB;

	public Transform ExitPoint;

	public Transform ProgressPoint;

	public List<ReflectionTutorial> Tutorials;

	[Header("QUICK PLAY OBJECTS")]
	public Vector2 EnemiesPerArena;

	public GTTOD_LeylineOffering LeylineOffering;

	public GameObject GrabAGun;

	public GameObject AlphaCache;

	public Transform GrabAGunPoints;

	public Transform AlphaCachePoints;

	public List<Transform> QuickPlayGrids;

	public List<GTTOD_QuickPlaySegment> QuickPlaySegments;

	[HideInInspector]
	public Transform Checkpoint;

	[HideInInspector]
	public GameObject[] SpawnPoints;

	[HideInInspector]
	public List<GameObject> NearSpawnPoints;

	private ac_CharacterController CharacterController;

	private GTTOD_Inventory InventoryManager;

	private GTTOD_UpgradesManager Upgrades;

	private InventoryScript Inventory;

	private GTTOD_HealthScript Health;

	private GTTOD_AIManager AIManager;

	private GTTOD_OSTManager OSTManager;

	private GTTOD_Manager Manager;

	private GTTOD_HUD HUDManager;

	private PlayerEffects Effects;

	private AudioRange SFXRange;

	private GameObject Player;

	private Color PreviousSunColor;

	private bool Timing;

	private bool CanTime;

	private bool RewardActive;

	private bool CanProgress;

	private bool Loading;

	private bool HasArmedPlayer;

	private bool InTutorial;

	private bool TutorialStarted;

	private float ElapsedTime;

	private float BestTime;

	private float TutorialStartDistance;

	private int CurrentTutorialIndex;

	private int CurrentEnemiesRemaining;

	private Transform CurrentEndPoint;

	[IteratorStateMachine(typeof(_003CStart_003Ed__51))]
	private IEnumerator Start()
	{
		return null;
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CSetUpGrid_003Ed__53))]
	public IEnumerator SetUpGrid()
	{
		return null;
	}

	private void ShuffleGrid<T>(List<T> list)
	{
	}

	public void PlayTutorial(int TutorialIndex)
	{
	}

	[IteratorStateMachine(typeof(_003CTutorialRoutine_003Ed__56))]
	private IEnumerator TutorialRoutine(int Index)
	{
		return null;
	}

	public void StartTimer()
	{
	}

	public void ResetPlayer()
	{
	}

	public void ReturnToHUB()
	{
	}

	[IteratorStateMachine(typeof(_003CReturnToHarborDeep_003Ed__60))]
	public IEnumerator ReturnToHarborDeep()
	{
		return null;
	}

	private Transform GetEnemySpawnPoint()
	{
		return null;
	}

	public Transform GetClosestSpawn(GameObject[] Points)
	{
		return null;
	}

	public void GainKill()
	{
	}

	public void CollectReward()
	{
	}
}
