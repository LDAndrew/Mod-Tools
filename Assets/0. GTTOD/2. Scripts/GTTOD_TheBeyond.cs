using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GTTOD_TheBeyond : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_TheBeyond _003C_003E4__this;

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
		public _003CStart_003Ed__29(int _003C_003E1__state)
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
	private sealed class _003CAreaMessages_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_TheBeyond _003C_003E4__this;

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
		public _003CAreaMessages_003Ed__32(int _003C_003E1__state)
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

	public Material Skybox;

	public Transform SunPoint;

	public GameObject TeleportObject;

	public string AreaName;

	public string AreaMessage;

	public int Zone;

	public int EdgeColor;

	public Color SunColor;

	private Material SavedSkybox;

	private GTTOD_HUD HUD;

	private GTTOD_OSTManager OST;

	private GTTOD_Manager Manager;

	private GTTOD_AIManager AIManager;

	private ac_CharacterController CharacterController;

	private Transform Player;

	private Transform PreviousSunPoint;

	private float PreviousHeat;

	private float PreviousRotation;

	private int PreviousEdgeColor;

	private int PreviousZone;

	private Vector3 PreviousPosition;

	private Color PreviousSunColor;

	private bool HasSetUp;

	private bool WasSpawning;

	private bool WasQuickSpawning;

	private bool WasDungeonSpawn;

	private bool DoorEventWasActive;

	private bool WaystationWasOn;

	private bool TrackWasPlaying;

	[IteratorStateMachine(typeof(_003CStart_003Ed__29))]
	private IEnumerator Start()
	{
		return null;
	}

	public void Update()
	{
	}

	public void ToggleTheBeyond(bool On)
	{
	}

	[IteratorStateMachine(typeof(_003CAreaMessages_003Ed__32))]
	private IEnumerator AreaMessages()
	{
		return null;
	}
}
