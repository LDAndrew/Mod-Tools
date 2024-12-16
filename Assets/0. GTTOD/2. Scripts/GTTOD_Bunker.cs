using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GTTOD_Bunker : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CUnlockTimer_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_Bunker _003C_003E4__this;

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
		public _003CUnlockTimer_003Ed__22(int _003C_003E1__state)
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

	public GameObject Bunker;

	public GameObject KeyCrab;

	public GameObject KeyCrabDeath;

	public GameObject BunkerLight;

	public float DoorDistance;

	public float BunkerDistance;

	public List<BunkerObject> BunkerObjects;

	public List<AudioClip> BunkerSFX;

	private GameManager GM;

	private Transform PlayerTransform;

	private GTTOD_Manager Manager;

	private GTTOD_HUD HUD;

	private GTTOD_UpgradesManager Upgrades;

	private GTTOD_Inventory Inventory;

	private AudioSource Audio;

	private Animator Anim;

	private bool Unlocked;

	private bool Unlocking;

	private float BunkerTimer;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void UnlockBunker()
	{
	}

	[IteratorStateMachine(typeof(_003CUnlockTimer_003Ed__22))]
	private IEnumerator UnlockTimer()
	{
		return null;
	}

	public void PlaySoundEffect(int SFXIndex)
	{
	}

	public void IdentifyBunker()
	{
	}
}
