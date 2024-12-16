using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GTTOD_TheSummit : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_TheSummit _003C_003E4__this;

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

	[Header("GENERAL SUMMIT")]
	public string LevelName;

	public Material SkyboxMaterial;

	public Material FogMaterial;

	public GameObject FogObject;

	public Vector2 SideToggles;

	public int Zone;

	public float RotationSpeed;

	public float SummitOffset;

	public GameObject RightSide;

	public GameObject LeftSide;

	[Header("THE CHASM")]
	public AudioSource ChasmNote;

	public Transform ChasmEndPoint;

	public ParticleSystem ChasmBlizzard;

	[Header("THE SANCTUM")]
	public GameObject Bridge;

	public Animator SanctumAnimator;

	public Transform SanctumRoot;

	[HideInInspector]
	public bool BlizzardOn;

	[HideInInspector]
	public bool ChasmCleared;

	private GTTOD_HUD HUDManager;

	private GTTOD_AIManager AIManager;

	private GTTOD_UpgradesManager Upgrades;

	private PlayerEffects Effects;

	private Transform Player;

	private float Rotation;

	private float FogStrength;

	private float Pitch;

	private float MaxNoteDistance;

	private bool Active;

	private bool SanctumOpen;

	[IteratorStateMachine(typeof(_003CStart_003Ed__29))]
	private IEnumerator Start()
	{
		return null;
	}

	private void Update()
	{
	}

	public void ToggleBlizzard(bool BlizzardRaging)
	{
	}
}
