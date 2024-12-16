using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GTTOD_ModManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CLoadPath_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_ModManager _003C_003E4__this;

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
		public _003CLoadPath_003Ed__28(int _003C_003E1__state)
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
	private sealed class _003CSequenceAllMods_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_ModManager _003C_003E4__this;

		private List<Coroutine> _003CUnpackingRoutines_003E5__2;

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
		public _003CSequenceAllMods_003Ed__29(int _003C_003E1__state)
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
	private sealed class _003C_003Ec__DisplayClass30_0
	{
		public AssetBundleCreateRequest BundleToLoadRequest;

		public GTTOD_ModManager _003C_003E4__this;

		public bool loadingFinished;

		internal void _003CUnpackModAsync_003Eb__0(AsyncOperation operation)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CUnpackModAsync_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_ModManager _003C_003E4__this;

		public GTTODMod Mod;

		private _003C_003Ec__DisplayClass30_0 _003C_003E8__1;

		private string _003CPath_003E5__2;

		private AssetBundleRequest _003CAssetRequest_003E5__3;

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
		public _003CUnpackModAsync_003Ed__30(int _003C_003E1__state)
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
	private sealed class _003CWaitForAllMods_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public List<Coroutine> CurrentRoutines;

		public GTTOD_ModManager _003C_003E4__this;

		private List<Coroutine>.Enumerator _003C_003E7__wrap1;

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
		public _003CWaitForAllMods_003Ed__31(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CRunMods_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_ModManager _003C_003E4__this;

		private bool _003CShouldRegenerateRun_003E5__2;

		private List<GTTODMod>.Enumerator _003C_003E7__wrap2;

		private GTTODMod _003CMod_003E5__4;

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
		public _003CRunMods_003Ed__32(int _003C_003E1__state)
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

	public GTTOD_ModContainer ModContainer;

	public string PlayerID;

	public bool ModsEnabled;

	public string CustomModsPath;

	public string WorkshopModsPath;

	public float LoadSpeed;

	[Header("WORKSHOP VARIABLES")]
	public bool ShowWorkshopVariables;

	[ConditionalField("ShowWorkshopVariables", null)]
	public string ItemTitle;

	[ConditionalField("ShowWorkshopVariables", null)]
	public string ItemDescription;

	[ConditionalField("ShowWorkshopVariables", null)]
	public string ItemTag;

	[ConditionalField("ShowWorkshopVariables", null)]
	public string ItemThumbnail;

	[ConditionalField("ShowWorkshopVariables", null)]
	public string ItemContent;

	[ConditionalField("ShowWorkshopVariables", null)]
	public bool Updating;

	[Header("UPLOAD VARIABLES")]
	public bool AllowUpload;

	[ConditionalField("AllowUpload", null)]
	public int UploadIndex;

	[HideInInspector]
	public List<string> ItemTags;

	[HideInInspector]
	public List<GTTODMod> LocalUserCreatedMods;

	[HideInInspector]
	public List<AssetBundle> LoadedBundles;

	[HideInInspector]
	public int UpdateSteamID;

	[HideInInspector]
	public bool HasLoadedMods;

	[HideInInspector]
	public bool ReplaceShaders;

	[HideInInspector]
	public Action OnFoundAnyMods;

	[HideInInspector]
	public Action OnFinishedLoadedMods;

	private GTTOD_HUD HUDManager;

	private int modsLoaded;

	private uint PageNumber;

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CLoadPath_003Ed__28))]
	public IEnumerator LoadPath()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CSequenceAllMods_003Ed__29))]
	private IEnumerator SequenceAllMods()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CUnpackModAsync_003Ed__30))]
	private IEnumerator UnpackModAsync(GTTOD_ModManager instance, GTTODMod Mod)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWaitForAllMods_003Ed__31))]
	private IEnumerator WaitForAllMods(List<Coroutine> CurrentRoutines)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CRunMods_003Ed__32))]
	private IEnumerator RunMods()
	{
		return null;
	}

	private bool AllModsLoaded(List<GTTODMod> mods)
	{
		return false;
	}

	public void UploadMod(GTTODMod NewMod)
	{
	}

	public string CreateWorkshopThumbnail(GTTODMod NewMod)
	{
		return null;
	}

	public void CreateWorkshopItem_Start()
	{
	}

	public void UpdateWorkshopItem()
	{
	}

	public void StageUpload()
	{
	}

	public void SetUpdate(ulong UpdatedID)
	{
	}

	public void SetCustomModPath(string NewPath)
	{
	}
}
