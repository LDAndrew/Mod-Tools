using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class GTTOD_Scriptorium : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_Scriptorium _003C_003E4__this;

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
		public _003CStart_003Ed__25(int _003C_003E1__state)
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

	public int CutsceneID;

	public int UnlockLevel;

	public GameObject ScriptoriumUI;

	public GTTOD_ScriptoriumUI EntryUI;

	public RectTransform CatalogueContent;

	public CanvasGroup CatalogueGroup;

	public CanvasGroup EntryGroup;

	public Text FolderNameText;

	public Text EntryNameText;

	public Text EntryDescription;

	public GameObject Joystick;

	public List<ScriptoriumFolder> Folders;

	private GTTOD_HUD HUD;

	private GTTOD_Manager Manager;

	private ac_CutsceneManager CutsceneManager;

	private VerticalLayoutGroup Layout;

	private Animator Anim;

	private bool ScreenEnabled;

	private bool IsActive;

	private bool Animating;

	private bool InEntry;

	private float CurrentArea;

	private float AreaLerp;

	private float StartingSpacing;

	private int CurrentFolder;

	[IteratorStateMachine(typeof(_003CStart_003Ed__25))]
	private IEnumerator Start()
	{
		return null;
	}

	private void Update()
	{
	}

	public void MoveJoystick(int Direction)
	{
	}

	private void KeyAdjustment(bool Up)
	{
	}

	public void SequenceUI(int Folder)
	{
	}

	private void SetContentPosition()
	{
	}

	public void ActivateScriptorium()
	{
	}

	public void SelectEntry(int EntryIndex)
	{
	}

	public void EndAnimation()
	{
	}

	public void EnableScreen()
	{
	}

	private void DeactivateScriptorium()
	{
	}
}
