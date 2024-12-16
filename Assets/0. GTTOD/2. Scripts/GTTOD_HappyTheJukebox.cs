using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GTTOD_HappyTheJukebox : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CPowerUpSequence_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_HappyTheJukebox _003C_003E4__this;

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
		public _003CPowerUpSequence_003Ed__26(int _003C_003E1__state)
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
	private sealed class _003CAttackSequence_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_HappyTheJukebox _003C_003E4__this;

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
		public _003CAttackSequence_003Ed__27(int _003C_003E1__state)
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

	public bool GameCompleted;

	[Header("HAPPY OBJECTS")]
	public GameObject PoweredOffJukebox;

	public GameObject PoweredOnJukebox;

	public AudioSource JukeBoxAudio;

	public Transform JukeBoxPoint;

	public GameObject Battery;

	public GameObject Confetti;

	[Header("HAPPY LISTS")]
	public List<int> DialogueSequences;

	public List<Transform> BatteryPoints;

	private GTTOD_HUD HUD;

	private GTTOD_Story Story;

	private GTTOD_Interactable Interactable;

	private Vector3 BatteryStartingPosition;

	private Quaternion BatteryStartingRotation;

	private int Sequence;

	private int TrackIndex;

	private bool HasBattery;

	private bool PoweredOn;

	private bool DialogueComplete;

	private bool HasAttacked;

	private bool MusicPlaying;

	private bool HasFinishedEngagement;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void TryInteract()
	{
	}

	public void AcquireBattery()
	{
	}

	[IteratorStateMachine(typeof(_003CPowerUpSequence_003Ed__26))]
	private IEnumerator PowerUpSequence()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CAttackSequence_003Ed__27))]
	private IEnumerator AttackSequence()
	{
		return null;
	}

	public void EndDialogue()
	{
	}

	public void DeleteSaves()
	{
	}
}
