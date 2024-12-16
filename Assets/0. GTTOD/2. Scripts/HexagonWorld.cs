using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class HexagonWorld : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDisableFaces_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HexagonWorld _003C_003E4__this;

		private List<GameObject>.Enumerator _003C_003E7__wrap1;

		private GameObject _003Cface_003E5__3;

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
		public _003CDisableFaces_003Ed__9(int _003C_003E1__state)
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

	public bool Active;

	public List<GameObject> Faces;

	[Space(30f)]
	public CanvasGroup FadeUI;

	private RandomItemSpawner ItemSpawner;

	private bool FadingIn;

	private float FadeSpeed;

	private int AudioDividend;

	private void Start()
	{
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CDisableFaces_003Ed__9))]
	private IEnumerator DisableFaces()
	{
		return null;
	}
}
