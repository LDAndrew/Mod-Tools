using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class GTTOD_ScanObject : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_ScanObject _003C_003E4__this;

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
		public _003CStart_003Ed__15(int _003C_003E1__state)
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

	public GameObject CompassPrefab;

	public GameObject WaypointPrefab;

	public float ScanDistance;

	public bool DistanceRemove;

	[ConditionalField("DistanceRemove", null)]
	public float Distance;

	[ConditionalField("DistanceRemove", null)]
	public string Message;

	[ConditionalField("DistanceRemove", null)]
	public bool PermanentlyRemove;

	[HideInInspector]
	public Image ObjectImage;

	[HideInInspector]
	public Image ObjectWaypoint;

	private GTTOD_HUD HUDManager;

	private Transform Player;

	private bool Removed;

	private bool Messaged;

	public Vector2 position => default(Vector2);

	[IteratorStateMachine(typeof(_003CStart_003Ed__15))]
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
