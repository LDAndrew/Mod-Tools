using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Video;

public class GTTOD_GrabAGun : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CProcessWeapon_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_GrabAGun _003C_003E4__this;

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
		public _003CProcessWeapon_003Ed__31(int _003C_003E1__state)
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

	public bool InfiniteGrabAGun;

	[Header("Grab A Gun Set-Up")]
	public bool ChoiceWeapon;

	[ConditionalField("ChoiceWeapon", null)]
	public int WeaponID;

	public Transform SpawnPoint;

	public GameObject ScreenParent;

	public VideoPlayer MainScreen;

	public GameObject SpawnObject;

	[Header("Grab A Gun Video / Audio")]
	public VideoClip IdleClip;

	public AudioClip IdleSFX;

	public VideoClip ProcessingClip;

	public AudioClip ProcessingSFX;

	public VideoClip FinishedClip;

	public AudioClip FinishedSFX;

	[HideInInspector]
	public List<int> PotentialWeapons;

	[HideInInspector]
	public bool Empty;

	private GameManager GM;

	private GTTOD_Manager Manager;

	private InventoryScript Inventory;

	private GTTOD_Inventory Wheel;

	private GTTOD_HUD HUD;

	private AudioSource Audio;

	private Transform Player;

	private bool GrabWeapon;

	private bool CanInteract;

	private bool Processing;

	private bool HasSequenced;

	private int SelectedWeapon;

	private void Start()
	{
	}

	public void SequenceWeapons()
	{
	}

	private void Update()
	{
	}

	public void UseObject()
	{
	}

	[IteratorStateMachine(typeof(_003CProcessWeapon_003Ed__31))]
	private IEnumerator ProcessWeapon()
	{
		return null;
	}

	public void GiveWeapon()
	{
	}

	public void ResetGrabAGun()
	{
	}
}
