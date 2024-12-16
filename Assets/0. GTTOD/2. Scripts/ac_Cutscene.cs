using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ac_Cutscene : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CSegmentCutscene_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ac_Cutscene _003C_003E4__this;

		public float Time;

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
		public _003CSegmentCutscene_003Ed__37(int _003C_003E1__state)
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

	[Header("CUTSCENE VARIABLES")]
	public Transform CameraRoot;

	public SkinnedMeshRenderer Arms;

	public bool ShowOptionalObjects;

	[ConditionalField("ShowOptionalObjects", null)]
	public CanvasGroup ScreenSegment;

	[ConditionalField("ShowOptionalObjects", null)]
	public Transform CutsceneEndingPosition;

	public bool CanSpeak;

	[ConditionalField("CanSpeak", null)]
	public int CharacterID;

	[ConditionalField("CanSpeak", null)]
	public Transform CharacterPosition;

	[Header("CUTSCENE START OPTIONS")]
	public bool SetFOVOnStart;

	[ConditionalField("SetFOVOnStart", null)]
	public int FOVToSet;

	[Header("CUTSCENE END OPTIONS")]
	public bool EndWithZone;

	[ConditionalField("EndWithZone", null)]
	public int ZoneToPlay;

	public bool EndWithWeapon;

	[ConditionalField("EndWithWeapon", null)]
	public int WeaponToGive;

	public bool EndWithScene;

	[ConditionalField("EndWithScene", null)]
	public string SceneToLoad;

	public bool EndWithForce;

	[ConditionalField("EndWithForce", null)]
	public Vector2 Force;

	public bool EndWithCenterPopUp;

	[ConditionalField("EndWithCenterPopUp", null)]
	public string CenterMessage;

	public bool EndWithBigPopUp;

	[ConditionalField("EndWithBigPopUp", null)]
	public string BigMessage;

	public bool EndWithClense;

	public bool EndWithReset;

	public bool EndWithFOVReset;

	[Header("CUTSCENE LISTS")]
	public List<GameObject> CutsceneObjects;

	public List<Animator> Animators;

	public List<AudioClip> SFX;

	private GTTOD_Manager Manager;

	private ac_CharacterController CharacterController;

	private ac_CutsceneManager Cutscenes;

	private AudioSource Audio;

	private bool AllowSkip;

	private void Update()
	{
	}

	public void StartCutscene()
	{
	}

	public void EndCutscene()
	{
	}

	public void SkipCutscene()
	{
	}

	[IteratorStateMachine(typeof(_003CSegmentCutscene_003Ed__37))]
	public IEnumerator SegmentCutscene(float Time)
	{
		return null;
	}

	public void AnimateCutscene(string Trigger)
	{
	}

	public void CenterPopUp()
	{
	}

	public void BigPopUp()
	{
	}

	public void PlayZone()
	{
	}

	private void GiveNewWeapon()
	{
	}

	private void LoadNewScene()
	{
	}

	private void RestartGTTOD()
	{
	}

	public void SetZoom(int Zoom)
	{
	}

	public void ResetZoom()
	{
	}

	public void AuthorizeSkip()
	{
	}

	public void SpeakLine(int LineID)
	{
	}
}
