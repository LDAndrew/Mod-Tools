using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[Serializable]
public class KeyBinding : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	public delegate void remap(KeyBinding key);

	[CompilerGenerated]
	private sealed class _003CWait_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public KeyBinding _003C_003E4__this;

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
		public _003CWait_003Ed__27(int _003C_003E1__state)
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

	public KeyAction keyAction;

	public KeyCode keyCode;

	public Text keyDisplay;

	public GameObject button;

	public Color toggleColor;

	private Image buttonImage;

	private Color originalColor;

	public bool AllowMouseButtons;

	public bool AllowGamepad;

	private bool reassignKey;

	private Event curEvent;

	private bool isHovering;

	public static event remap keyRemap
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void OnGUI()
	{
	}

	public void OnPointerEnter(PointerEventData data)
	{
	}

	public void OnPointerExit(PointerEventData data)
	{
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	public void LoadKeybinds()
	{
	}

	private void OnDisable()
	{
	}

	public void ChangeKeyCode(bool toggle)
	{
	}

	public void SaveKeyCode()
	{
	}

	private void PreventDoubleAssign(KeyBinding kb)
	{
	}

	public void UpdateKeyCode()
	{
	}

	[IteratorStateMachine(typeof(_003CWait_003Ed__27))]
	private IEnumerator Wait()
	{
		return null;
	}
}
