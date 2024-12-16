using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class GTTOD_MainMenu : MonoBehaviour
{
	public enum StartTypes
	{
		PrologueStart,
		HarborStart,
		DeadStart,
		LoadedStart,
		QuickPlayStart
	}

	[CompilerGenerated]
	private sealed class _003CForcePlayLevel_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_MainMenu _003C_003E4__this;

		public string level;

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
		public _003CForcePlayLevel_003Ed__35(int _003C_003E1__state)
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
	private sealed class _003CPlayRoutine_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_MainMenu _003C_003E4__this;

		public bool Continue;

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
		public _003CPlayRoutine_003Ed__37(int _003C_003E1__state)
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

	public bool MamaInfoAvailable;

	public StartTypes StartType;

	[Header("MENU STUFF")]
	public CanvasGroup MenuGroup;

	public CanvasGroup OptionsGroup;

	public CanvasGroup PatchNotesGroup;

	public CanvasGroup PlayOptionsGroup;

	public GameObject LudeoGalleryButton;

	public Text DescriptionText;

	public Text PatchNotesDate;

	public Text PatchNotes;

	public Text SaveNameText;

	public InputField SeedInput;

	public GameObject QuickPlay;

	public GameObject Continue;

	public GameObject NewRun;

	public GameObject Playables;

	[Header("GAME STUFF")]
	public AudioSource MenuAudio;

	public List<string> Links;

	[HideInInspector]
	public GTTOD_TheExclusionZone ExclusionZone;

	[HideInInspector]
	public bool StartInQuickPlay;

	private GameManager GM;

	private ac_CharacterController CharacterController;

	private ac_CutsceneManager Cutscenes;

	private GTTOD_Manager Manager;

	private GTTOD_UpgradesManager Upgrades;

	private GameObject Player;

	private Animator Anim;

	private ac_OptionsMenu Options;

	private bool PastLogo;

	private bool Active;

	public void StartMainMenu(StartTypes MenuStartType)
	{
	}

	private void Update()
	{
	}

	public void SetScene()
	{
	}

	public void PlayGame(bool Continue)
	{
	}

	[IteratorStateMachine(typeof(_003CForcePlayLevel_003Ed__35))]
	public IEnumerator ForcePlayLevel(string level)
	{
		return null;
	}

	public void SelectQuickPlay()
	{
	}

	[IteratorStateMachine(typeof(_003CPlayRoutine_003Ed__37))]
	private IEnumerator PlayRoutine(bool Continue)
	{
		return null;
	}

	public void SelectOptionsMenu(int Menu)
	{
	}

	public void SetDescription(string Text)
	{
	}

	public void UpdateSeedInput(bool MasterSeed)
	{
	}

	public void ToggleOptionsList(bool OptionsOn)
	{
	}

	public void TogglePlayOptionsList(bool PlayOptionsOn)
	{
	}

	public void TogglePatchNotes(bool PatchNotesOn)
	{
	}

	public void ClickLink(int Index)
	{
	}
}
