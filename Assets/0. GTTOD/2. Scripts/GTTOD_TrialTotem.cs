using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GTTOD_TrialTotem : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_TrialTotem _003C_003E4__this;

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
		public _003CStart_003Ed__17(int _003C_003E1__state)
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

	[Header("GENERAL VARIABLES")]
	public bool ShowGeneralVariables;

	[ConditionalField("ShowGeneralVariables", null)]
	public Transform Eyelid;

	[ConditionalField("ShowGeneralVariables", null)]
	public Transform Eye;

	[Header("AWARENESS VARIABLES")]
	public bool ShowAwarenessVariables;

	[ConditionalField("ShowAwarenessVariables", null)]
	public int Difficulty;

	[Header("LISTS")]
	public List<DifficultySelection> Difficulties;

	[Header("PRIVATE VARIABLES")]
	[HideInInspector]
	public int ChallengeIndex;

	[HideInInspector]
	public bool TrialActive;

	private PlayerEffects PlayerEffects;

	private GTTOD_AIManager AIManager;

	private GTTOD_HUD HUDManager;

	private GTTOD_Interactable Interaction;

	private AudioSource Audio;

	private Vector3 AdjustedRotation;

	private Vector3 TickRotation;

	private float RotateTick;

	private float EyelidRotation;

	[IteratorStateMachine(typeof(_003CStart_003Ed__17))]
	private IEnumerator Start()
	{
		return null;
	}

	private void Update()
	{
	}

	public void UseTotem()
	{
	}

	public void PlaySFX(AudioClip SFX)
	{
	}

	public void SetDifficulty(int NewDifficulty, bool ShouldDisplay)
	{
	}

	public void Damage(float Damage)
	{
	}
}
