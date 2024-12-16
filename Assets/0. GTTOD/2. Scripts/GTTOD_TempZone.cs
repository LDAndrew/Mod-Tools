using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GTTOD_TempZone : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_TempZone _003C_003E4__this;

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
		public _003CStart_003Ed__36(int _003C_003E1__state)
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
	private sealed class _003CAreaMessages_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_TempZone _003C_003E4__this;

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
		public _003CAreaMessages_003Ed__40(int _003C_003E1__state)
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

	public float DelayTime;

	public Material Skybox;

	public Transform SunPoint;

	public GameObject TeleportObject;

	public string AreaName;

	public string AreaMessage;

	public int Zone;

	public int EdgeColor;

	public bool ReverseDirection;

	public bool FallEscape;

	public Color SunColor;

	public List<GameObject> RandomObjects;

	private GTTOD_HUD HUD;

	private GTTOD_OSTManager OST;

	private GTTOD_Manager Manager;

	private GTTOD_AIManager AIManager;

	private GTTOD_HealthScript Health;

	private ac_CharacterController CharacterController;

	private Transform Player;

	private Transform Checkpoint;

	private bool HasSetUp;

	private GTTOD_TempZone PreviousTempZone;

	private Transform PreviousSunPoint;

	private Material PreviousSkybox;

	private Vector3 PreviousPosition;

	private Color PreviousSunColor;

	private float PreviousHeat;

	private float PreviousRotation;

	private int PreviousEdgeColor;

	private int PreviousZone;

	private bool WasSpawning;

	private bool WasQuickSpawning;

	private bool WasDungeonSpawn;

	private bool DoorEventWasActive;

	private bool WaystationWasOn;

	private bool TrackWasPlaying;

	[IteratorStateMachine(typeof(_003CStart_003Ed__36))]
	private IEnumerator Start()
	{
		return null;
	}

	public void Update()
	{
	}

	public void SetUpTempZone()
	{
	}

	public void ToggleTempZone(bool On)
	{
	}

	[IteratorStateMachine(typeof(_003CAreaMessages_003Ed__40))]
	private IEnumerator AreaMessages()
	{
		return null;
	}

	public void ResetPlayer()
	{
	}
}
