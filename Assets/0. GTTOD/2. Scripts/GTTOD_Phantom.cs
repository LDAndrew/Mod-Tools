using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GTTOD_Phantom : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_Phantom _003C_003E4__this;

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
		public _003CStart_003Ed__10(int _003C_003E1__state)
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

	public LayerMask AvailableLayers;

	public GameObject ReviveEffect;

	public float GroundOffset;

	public float ReviveTime;

	[HideInInspector]
	public GTTOD_Enemy SavedEnemy;

	private GTTOD_Enemy Enemy;

	private Respawner EnemyRespawner;

	private Transform Player;

	private bool EnemyRevived;

	private bool Active;

	[IteratorStateMachine(typeof(_003CStart_003Ed__10))]
	private IEnumerator Start()
	{
		return null;
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}
}
