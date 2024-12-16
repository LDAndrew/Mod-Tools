using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GTTOD_MemoryManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_MemoryManager _003C_003E4__this;

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
		public _003CStart_003Ed__34(int _003C_003E1__state)
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
	private sealed class _003CSaveGameRoutine_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_MemoryManager _003C_003E4__this;

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
		public _003CSaveGameRoutine_003Ed__37(int _003C_003E1__state)
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
	private sealed class _003CLoadGameRoutine_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_MemoryManager _003C_003E4__this;

		private string _003CFilePath_003E5__2;

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
		public _003CLoadGameRoutine_003Ed__39(int _003C_003E1__state)
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
	private sealed class _003CPullPersistentPlayerRoutine_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_MemoryManager _003C_003E4__this;

		private List<GunSave>.Enumerator _003C_003E7__wrap1;

		private List<ItemSave>.Enumerator _003C_003E7__wrap2;

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
		public _003CPullPersistentPlayerRoutine_003Ed__41(int _003C_003E1__state)
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

		private void _003C_003Em__Finally2()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public bool LoadOnStart;

	public static GTTOD_MemoryManager Memory;

	[Header("MEMORY SETUP")]
	public bool ShowSetUp;

	[ConditionalField("ShowSetUp", null)]
	public GameManager GM;

	[ConditionalField("ShowSetUp", null)]
	public GTTOD_HUD HUDManager;

	[ConditionalField("ShowSetUp", null)]
	public GTTOD_Manager Manager;

	[ConditionalField("ShowSetUp", null)]
	public GTTOD_MainMenu MainMenu;

	[ConditionalField("ShowSetUp", null)]
	public GTTOD_Inventory Inventory;

	[ConditionalField("ShowSetUp", null)]
	public GTTOD_AIManager AIManager;

	[ConditionalField("ShowSetUp", null)]
	public GTTOD_ModManager ModManager;

	[ConditionalField("ShowSetUp", null)]
	public GTTOD_UpgradesManager Upgrades;

	[ConditionalField("ShowSetUp", null)]
	public GTTOD_GearCardManager GearCards;

	[ConditionalField("ShowSetUp", null)]
	public GTTOD_HealthScript Health;

	[ConditionalField("ShowSetUp", null)]
	public InventoryScript InventoryStorage;

	[Header("MEMORIZED VARIABLES")]
	public GTTODSaveGame SavedGame;

	private string SaveFileName;

	private string SavedFileType;

	private bool HasPulled;

	private bool DelayedLoad;

	private bool HasLoaded;

	private bool ShouldStartMenu;

	private bool IsSaving;

	private bool IsLoading;

	private bool IsPulling;

	private bool HasLoadedEmptyScene;

	private float SaveDelay;

	private float LoadDelay;

	private float MenuLoadDelay;

	private float EmptySceneLoadDelay;

	public bool EnableSaving { get; set; }

	private void Awake()
	{
	}

	[IteratorStateMachine(typeof(_003CStart_003Ed__34))]
	private IEnumerator Start()
	{
		return null;
	}

	private void Update()
	{
	}

	public void SaveGame()
	{
	}

	[IteratorStateMachine(typeof(_003CSaveGameRoutine_003Ed__37))]
	private IEnumerator SaveGameRoutine()
	{
		return null;
	}

	public void LoadGame()
	{
	}

	[IteratorStateMachine(typeof(_003CLoadGameRoutine_003Ed__39))]
	private IEnumerator LoadGameRoutine()
	{
		return null;
	}

	public void PullPersistentPlayer()
	{
	}

	[IteratorStateMachine(typeof(_003CPullPersistentPlayerRoutine_003Ed__41))]
	private IEnumerator PullPersistentPlayerRoutine()
	{
		return null;
	}

	public void SetInheritedSeed()
	{
	}

	public void DeleteCurrentSave()
	{
	}
}
