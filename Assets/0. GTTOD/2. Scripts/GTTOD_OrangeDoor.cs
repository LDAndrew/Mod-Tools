using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GTTOD_OrangeDoor : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDoormanReact_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_OrangeDoor _003C_003E4__this;

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
		public _003CDoormanReact_003Ed__37(int _003C_003E1__state)
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
	private sealed class _003CPlayAmbience_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_OrangeDoor _003C_003E4__this;

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
		public _003CPlayAmbience_003Ed__38(int _003C_003E1__state)
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

	public ParticleSystem DoorActivateEffect;

	public GameObject DoorMessage;

	public Material DoorMaterial;

	public Transform DoorPoint;

	public Transform DoorZone;

	public int OSTZone;

	public int AmbienceZone;

	public float ProgressMultiplier;

	[Space(15f)]
	public GTTOD_LeylineOffering Offering;

	public Transform RewardPoint;

	[HideInInspector]
	public float ChargePercentage;

	private Transform Player;

	private GTTOD_UpgradesManager Upgrades;

	private GTTOD_OSTManager OSTManager;

	private GTTOD_AIManager AIManager;

	private GTTOD_Level CurrentLevel;

	private PlayerEffects Effects;

	private GTTOD_Manager Manager;

	private GTTOD_HUD HUDManager;

	private GTTOD_Story Story;

	private AudioSource Audio;

	private bool Activating;

	private bool HasStartedEvent;

	private bool MustClearBeacons;

	private bool HasCompletedEvent;

	private bool HasCollectedReward;

	private bool HasEntered;

	private float Distance;

	private float Fill;

	private float ZoneSize;

	private float ThoroughPurgeTime;

	private float AdjustedZoneSize;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private bool BeaconsCleared()
	{
		return false;
	}

	public void ToggleDoorEvent(bool Active)
	{
	}

	public void Progress(int ChargeAmount, bool forceUpdate = false)
	{
	}

	[IteratorStateMachine(typeof(_003CDoormanReact_003Ed__37))]
	public IEnumerator DoormanReact()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CPlayAmbience_003Ed__38))]
	private IEnumerator PlayAmbience()
	{
		return null;
	}

	public void PreUnlock(bool ShouldReward)
	{
	}

	public void CollectReward()
	{
	}
}
