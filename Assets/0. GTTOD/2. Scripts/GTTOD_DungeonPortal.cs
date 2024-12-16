using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GTTOD_DungeonPortal : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_DungeonPortal _003C_003E4__this;

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
		public _003CStart_003Ed__14(int _003C_003E1__state)
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

	public bool ActiveOnStart;

	[Range(0f, 100f)]
	public float ActiveChance;

	[Header("PORTAL VARIABLES")]
	public bool EscapePortal;

	public Transform PortalPoint;

	public GameObject PortalEffect;

	public GameObject BrokenPortal;

	public GameObject NormalPortal;

	[HideInInspector]
	public bool PortalActive;

	private Transform Player;

	private GTTOD_HUD HUDManager;

	private GTTOD_Manager Manager;

	private GTTOD_AIManager AIManager;

	private bool Loading;

	private bool PortalIsRepaired;

	[IteratorStateMachine(typeof(_003CStart_003Ed__14))]
	private IEnumerator Start()
	{
		return null;
	}

	private void Update()
	{
	}

	public void ActivatePortal()
	{
	}
}
