using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class GTTOD_Disclaimer : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_Disclaimer _003C_003E4__this;

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
		public _003CStart_003Ed__18(int _003C_003E1__state)
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

	public GTTOD_SaveFileUI SaveFileUI;

	public RectTransform SaveFileContent;

	public GameObject NewSaveFileButton;

	public Text RandomText;

	public Text TipText;

	public AudioSource LoadingSong;

	public List<string> RandomMessages;

	public List<string> RandomTips;

	public List<AudioClip> DisclaimerAudio;

	public List<string> SaveFiles;

	public List<string> FilePaths;

	private string SaveFileName;

	private string SavedFileType;

	private AudioSource Audio;

	private Animator Anim;

	private bool Closing;

	private bool Deleted;

	private int DeleteCount;

	[IteratorStateMachine(typeof(_003CStart_003Ed__18))]
	private IEnumerator Start()
	{
		return null;
	}

	public void FetchSaveFiles()
	{
	}

	public void NewSaveFile()
	{
	}

	private void CreateSaveFiles()
	{
	}

	public void SelectFile(int FileIndex)
	{
	}

	public void DeleteFile(int FileIndex)
	{
	}

	public void Click()
	{
	}

	public void LoadScene()
	{
	}

	public void DeleteSaves()
	{
	}

	public void PlayAudioClip(int Index)
	{
	}
}
