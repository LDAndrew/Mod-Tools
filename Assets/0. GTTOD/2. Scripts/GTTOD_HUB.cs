using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class GTTOD_HUB : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CIglooLoadRoutine_003Ed__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_HUB _003C_003E4__this;

		private IEnumerator _003C_003E7__wrap1;

		private Transform _003CLight_003E5__3;

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
		public _003CIglooLoadRoutine_003Ed__56(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CMusicTransitionRoutine_003Ed__57 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003CMusicTransitionRoutine_003Ed__57(int _003C_003E1__state)
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
	private sealed class _003CSleepRoutine_003Ed__60 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_HUB _003C_003E4__this;

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
		public _003CSleepRoutine_003Ed__60(int _003C_003E1__state)
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

	public Animator Teleporter;

	public Animator RockBridge;

	public Animator Igloo;

	public Material SkyboxMaterial;

	public Transform SunShaftPoint;

	public Transform TeleportPoint;

	public Transform ScrollPortal;

	public Transform IglooPoint;

	public Transform TutorialLoadPoint;

	public Transform IglooLightParent;

	public GameObject MenuDoorguy;

	public Transform SlowPoint;

	public AudioClip LightSFX;

	public Transform MenuPoint;

	public Text RightText;

	public Text LeftText;

	public Material TempleMaterial;

	public Light TempleLight;

	public CanvasGroup FadeCanvas;

	[ColorUsage(true, true)]
	public List<Color> TempleColors;

	public Color SunShaftColor;

	public float RotationSpeed;

	public float MusicTransitionDistance;

	private float Rotation;

	private float StatsTimer;

	private float LoadTime;

	private int CurrentColor;

	[HideInInspector]
	public bool SendToSummit;

	[HideInInspector]
	public int PreviousZone;

	private ac_CharacterController CharacterController;

	private GTTOD_UpgradesManager Upgrades;

	private ac_CutsceneManager Cutscenes;

	private GTTOD_MemoryManager Memory;

	private GTTOD_AIManager AIManager;

	private InventoryScript Inventory;

	private ac_ObjectPool ObjectPool;

	private GTTOD_Manager Manager;

	private GTTOD_OSTManager OST;

	private GTTOD_HUD HUDManager;

	private Transform Player;

	private Color TempleColor;

	private bool TeleporterOpen;

	private bool BridgeAligned;

	private bool Teleporting;

	private bool CanLoadIgloo;

	private bool IglooOpen;

	private bool IglooLoading;

	private bool ShouldPlay;

	private bool HasEquipped;

	private bool Active;

	private bool FadingOut;

	private bool Sleeping;

	private void Start()
	{
	}

	private void SetStats()
	{
	}

	public void SetTempleColor(int Index)
	{
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CIglooLoadRoutine_003Ed__56))]
	private IEnumerator IglooLoadRoutine()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CMusicTransitionRoutine_003Ed__57))]
	private IEnumerator MusicTransitionRoutine(bool MamaMusic)
	{
		return null;
	}

	public void ResetPlayer()
	{
	}

	public void Sleep()
	{
	}

	[IteratorStateMachine(typeof(_003CSleepRoutine_003Ed__60))]
	private IEnumerator SleepRoutine()
	{
		return null;
	}
}
