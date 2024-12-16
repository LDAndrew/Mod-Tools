using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GTTOD_Vehicle : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CShiftCycle_003Ed__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GTTOD_Vehicle _003C_003E4__this;

		public bool ShiftUp;

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
		public _003CShiftCycle_003Ed__80(int _003C_003E1__state)
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
	private sealed class _003CFlashHeadlights_003Ed__84 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool On;

		public bool HasRandomized;

		public GTTOD_Vehicle _003C_003E4__this;

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
		public _003CFlashHeadlights_003Ed__84(int _003C_003E1__state)
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

	public LayerMask AvailableLayers;

	public LayerMask TurretLayer;

	[Header("VEHICLE VARIABLES")]
	public string VehicleName;

	public float CameraFollowSpeed;

	public float DrivingSensitivity;

	public float AirAdjustAmount;

	public float FlipForce;

	public float ResetDistance;

	public List<Transform> VehiclePoints;

	[Header("VEHICLE OBJECTS")]
	public Animator DoorguyAnim;

	public GameObject CollisionObject;

	public GameObject DamageObject;

	public GameObject BoostEffects;

	public GTTOD_Interactable Interactable;

	public GTTOD_Interactable CrateInteractable;

	public Transform DirectionalObject;

	public Transform PlayerHook;

	public Transform ReleasePoint;

	public GameObject VehicleHeadlights;

	[Header("VEHICLE AUDIO")]
	public Vector2 SFXRange;

	public AudioSource EngineAudio;

	public AudioSource TurboAudio;

	public AudioSource SFXAudio;

	public AudioSource IdleAudio;

	public List<AudioClip> EngineLoops;

	public List<AnimationSFX> SoundEffects;

	[Range(0f, 1f)]
	public float EngineVolume;

	[Range(0f, 100f)]
	public float AudioProgression;

	[Header("VEHICLE COMBAT")]
	public Transform Turret;

	public Transform Muzzle;

	public GameObject Projectile;

	public ParticleSystem MuzzleFlash;

	public Vector2 BurstCount;

	public float TurretRateOfFire;

	public float TurretRange;

	private GameManager GM;

	private GTTOD_HUD HUDManager;

	private ac_OptionsMenu Options;

	private InventoryScript Inventory;

	private GTTOD_UpgradesManager Upgrades;

	private GTTOD_AIManager AIManager;

	private ac_CharacterController CharacterController;

	private Rigidbody PlayerPhysics;

	private Rigidbody VehiclePhysics;

	private SustainedShake Shaker;

	private Coroutine HeadlightRoutine;

	private Quaternion StartingRotation;

	private Transform CurrentTarget;

	private AudioRange TurretAudio;

	private List<GTTOD_VehicleWheel> Wheels;

	private float CenterOfMassOffset;

	private float AudioAcceleration;

	private float AudioPitch;

	private float AudioVolume;

	private float RevTime;

	private float GroundCheckTime;

	private float AirAdjustTime;

	private float ShiftModifier;

	private float InteractionTimer;

	private float TargetTimer;

	private float RateOfFire;

	private float BreakTime;

	private float TurretActiveTime;

	private int EngineCycles;

	private int CurrentCycle;

	private int Bursts;

	private bool EngineOn;

	private bool Accelerating;

	private bool Grounded;

	private bool Shifting;

	private bool Boosting;

	private bool BoostProtection;

	private bool RevvedEngine;

	private bool HasReleasedInteract;

	private bool HasReleasedPlayer;

	private bool Attacking;

	private bool CanFire;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void UpdateAudio()
	{
	}

	[IteratorStateMachine(typeof(_003CShiftCycle_003Ed__80))]
	private IEnumerator ShiftCycle(bool ShiftUp)
	{
		return null;
	}

	public void ToggleBoost(bool BoostOn)
	{
	}

	public void TryInteract()
	{
	}

	public void ToggleEngine(bool TurnOn)
	{
	}

	[IteratorStateMachine(typeof(_003CFlashHeadlights_003Ed__84))]
	private IEnumerator FlashHeadlights(bool On, bool HasRandomized)
	{
		return null;
	}

	private void AddForce(float ForceAmount, int ForceIndex, ForceMode Mode)
	{
	}

	private void PlaySFX(int SFXIndex)
	{
	}

	private float GetSteeringDirection(Transform CameraHookPoint)
	{
		return 0f;
	}

	public void OnCollisionEnter(Collision collision)
	{
	}
}
