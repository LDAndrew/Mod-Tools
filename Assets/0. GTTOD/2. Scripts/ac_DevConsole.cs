using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ac_DevConsole : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CGetTransform_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ac_DevConsole _003C_003E4__this;

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
		public _003CGetTransform_003Ed__22(int _003C_003E1__state)
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

	public bool ConsoleActive;

	public CanvasGroup ConsoleGroup;

	public InputField ConsoleInput;

	private GameManager GM;

	private ac_OptionsMenu OptionsMenu;

	private ac_CutsceneManager Cutscenes;

	private InventoryScript Inventory;

	private GTTOD_Inventory GTTODInventory;

	private GTTOD_UpgradesManager Upgrades;

	private GTTOD_Manager Manager;

	private GTTOD_HUD HUD;

	private ac_CharacterController CharacterController;

	private bool CanOpen;

	private bool HasReleased;

	private bool CheatsActive;

	private bool HasBlit;

	private string[] Digits;

	private string LastSubmission;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void ToggleConsole(bool Active)
	{
	}

	public void Submit(string ConsoleSubmission)
	{
	}

	[IteratorStateMachine(typeof(_003CGetTransform_003Ed__22))]
	private IEnumerator GetTransform()
	{
		return null;
	}
}
