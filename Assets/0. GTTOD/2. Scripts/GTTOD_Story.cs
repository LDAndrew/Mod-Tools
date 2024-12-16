using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GTTOD_Story : MonoBehaviour
{
	public enum Languages
	{
		English,
		Japanese,
		German,
		Spanish
	}

	[CompilerGenerated]
	private sealed class _003CStart_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_Story _003C_003E4__this;

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
		public _003CStart_003Ed__20(int _003C_003E1__state)
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

	public Languages Language;

	public AudioSource DialogueAudio;

	public AudioSource PlacementAudio;

	public bool HasSubtitles;

	public bool TestLineOnStart;

	[ConditionalField("TestLineOnStart", null)]
	public Vector2 LineToTest;

	[Header("CHARACTERS AND DIALOGUE")]
	public List<Character> Characters;

	[Header("EDITING")]
	public bool CanEditLine;

	[ConditionalField("CanEditLine", null)]
	public Vector3 LineToEdit;

	[HideInInspector]
	public bool isSpeaking;

	[HideInInspector]
	public float VoiceVolumeModifier;

	private int PreviousCharacter;

	private int PreviousLine;

	private GameManager GM;

	private GTTOD_HUD HUDManager;

	private GameObject ReturnObject;

	private Vector3 LastPosition;

	private float DialogueTime;

	private bool HasCheckedConversation;

	[IteratorStateMachine(typeof(_003CStart_003Ed__20))]
	private IEnumerator Start()
	{
		return null;
	}

	private void Update()
	{
	}

	public void PlayLine(int CharacterIndex, int LineType, Vector3 Position, GameObject ObjectToReturn)
	{
	}

	public void AddLineToCharacter()
	{
	}
}
