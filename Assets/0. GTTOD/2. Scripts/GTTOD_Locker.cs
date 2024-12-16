using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GTTOD_Locker : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CSequencePlayerItems_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_Locker _003C_003E4__this;

		private List<InventorySlot>.Enumerator _003C_003E7__wrap1;

		private List<HeldGridItem>.Enumerator _003C_003E7__wrap2;

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
		public _003CSequencePlayerItems_003Ed__20(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CSequenceStashItems_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_Locker _003C_003E4__this;

		private List<StashItem>.Enumerator _003C_003E7__wrap1;

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
		public _003CSequenceStashItems_003Ed__21(int _003C_003E1__state)
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

	public GTTOD_StashItemUI StashUI;

	public CanvasGroup Canvas;

	public RectTransform PlayerContent;

	public RectTransform LockerContent;

	public Sprite BlankIcon;

	public List<StashItem> PlayerItems;

	private GTTOD_Inventory InventoryManager;

	private GTTOD_MemoryManager Memory;

	private ac_OptionsMenu Options;

	private GTTOD_HUD HUDManager;

	private ac_CharacterController CharacterController;

	private InventoryScript Inventory;

	private Animator Anim;

	private bool LockerIsOpen;

	private bool HasAltered;

	private float AdjustedDelayTime;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void ToggleLocker()
	{
	}

	private void SequenceLocker()
	{
	}

	[IteratorStateMachine(typeof(_003CSequencePlayerItems_003Ed__20))]
	private IEnumerator SequencePlayerItems()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CSequenceStashItems_003Ed__21))]
	private IEnumerator SequenceStashItems()
	{
		return null;
	}

	public void StashItem(int Index)
	{
	}

	public void PullItem(int Index)
	{
	}
}
