using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ac_CharacterController : MonoBehaviour
{
	public enum GroundState
	{
		InAir,
		Grounded,
		SteadyGround,
		Sliding,
		Onwall,
		Swimming
	}

	public enum SwimState
	{
		TreadingWater,
		SwimmingForward,
		SwimmingBackwards,
		SwimmingRight,
		SwimmingLeft,
		SwimmingUp,
		SwimmingDown
	}

	[CompilerGenerated]
	private sealed class _003CVault_003Ed__151 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ac_CharacterController _003C_003E4__this;

		public Vector3 endPosition;

		public float speed;

		private Vector3 _003CStart_003E5__2;

		private Vector3 _003CMid_003E5__3;

		private Vector3 _003CEnd_003E5__4;

		private float _003Ct_003E5__5;

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
		public _003CVault_003Ed__151(int _003C_003E1__state)
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

	public bool Active;

	[Space(5f)]
	public LayerMask AvailableLayers;

	public LayerMask DefaultLayer;

	[Header("BODY")]
	public ac_BodyController Body;

	public float ColliderHeight;

	public float ColliderRadius;

	public float Speed;

	public float AirSpeed;

	public float SizeModifier;

	public float SprintModifier;

	public float CrouchModifier;

	public float UncrouchHeight;

	public float SwimmingModifier;

	public float Sensitivity;

	[Header("OBJECTS")]
	public PlayerCamera CameraManager;

	public PlayerEffects Effects;

	public Camera MainCam;

	public Transform WeaponCamera;

	public Transform WeaponParent;

	public Animator CameraAnimation;

	public Animator WeaponAnimation;

	public ac_WallController WallController;

	public ac_WallDetection Wall;

	[Header("PHYSICS")]
	public float Gravity;

	public float JumpHeight;

	public float DoubleJumpHeight;

	public float WallKickForce;

	public float DashDistance;

	public int DashCount;

	public float DashSpeed;

	public float MotorAcceleration;

	public float AirAcceleration;

	public float SwimmingAcceleration;

	[Header("ABILITIES")]
	public bool CanJump;

	public bool CanCrouch;

	public bool CanSprint;

	public bool CanVault;

	public bool CanDoubleJump;

	public bool CanDash;

	public bool CanWallrun;

	public bool CanWallKick;

	public bool CanSwim;

	[Space(5f)]
	public List<AnimationSFX> SFX;

	[Header("MULTIPLAYER")]
	public bool NetworkedCharacter;

	public GroundState CharacterGroundState;

	[HideInInspector]
	public SwimState CharacterSwimState;

	[HideInInspector]
	public bool Inverted;

	[HideInInspector]
	public bool ToggleCrouch;

	[HideInInspector]
	public bool Walking;

	[HideInInspector]
	public bool Crouching;

	[HideInInspector]
	public bool Sprinting;

	[HideInInspector]
	public bool Sliding;

	[HideInInspector]
	public bool Occupied;

	[HideInInspector]
	public bool RightWall;

	[HideInInspector]
	public bool CanNudgeCamera;

	[HideInInspector]
	public bool ForceCameraActive;

	[HideInInspector]
	public bool HoldJumpClamber;

	[HideInInspector]
	public float CameraTiltProgress;

	[HideInInspector]
	public float HorizontalVelocity;

	[HideInInspector]
	public float ForwardVelocity;

	[HideInInspector]
	public float GravityModifier;

	[HideInInspector]
	public float SensitivityModifier;

	[HideInInspector]
	public float DashCool;

	[HideInInspector]
	public float SpeedModifier;

	[HideInInspector]
	public float UltimateSpeedModifier;

	[HideInInspector]
	public int CurrentDashCount;

	[HideInInspector]
	public GTTOD_DashPoint DashPoint;

	private ac_OptionsMenu Options;

	private ac_ObjectPool ObjectPool;

	private InventoryScript Inventory;

	private ac_CutsceneManager Cutscenes;

	private GTTOD_UpgradesManager Upgrades;

	private GTTOD_Inventory InventoryManager;

	private GTTOD_HealthScript Health;

	private RaycastHit DashCheck;

	private RaycastHit GroundCheck;

	private PhysicMaterial PlayerMaterial;

	private AudioSource Audio;

	private Rigidbody PlayerPhysics;

	private CapsuleCollider PlayerCollider;

	private Transform CameraParent;

	private Transform DashTransform;

	private Transform DashDestination;

	private Transform FinalDashPosition;

	private Transform FinalDirection;

	private Transform Ruler;

	private Transform Child;

	private Transform PlayerParent;

	private Transform LastParent;

	private Vector3 CameraNudgeDirection;

	private Vector3 AdjustedNudgeDirection;

	private Vector3 SavePosition;

	private Vector3 SwimmingRelativeDirection;

	private Vector3 LastChildPosition;

	private Vector3 MovementOffset;

	private float ForwardMovementDirection;

	private float SidewaysMovementDirection;

	private float DashForwardBack;

	private float DashLeftRight;

	private float DashForce;

	private float GroundTime;

	private float AirTime;

	private float WallTime;

	private float JumpTime;

	private float CameraTilt;

	private float CameraTiltRotation;

	private float XCameraRotation;

	private float ZCameraRotation;

	private float YCameraRotation;

	private float ZWeaponRotation;

	private float PersistentCameraClamp;

	private float CameraNudgeDuration;

	private float ControllerAccelerationY;

	private float ControllerAccelerationX;

	private float DashPointUp;

	private float DashPointForward;

	private float SmoothWeaponMovement;

	private bool HasWallKick;

	private bool DoubleJumpProtection;

	private bool CrouchProtection;

	private bool SprintProtection;

	private bool JumpProtection;

	private bool DashProtection;

	private bool TiltProtection;

	private bool BodyProtection;

	private bool HasDashDirection;

	private bool ToggleSprint;

	private bool Vaulting;

	private bool Dashing;

	private bool TouchedGround;

	private bool CoyoteTimeProtection;

	private bool DashPointVelocity;

	private void Start()
	{
	}

	private void ActivateCharacter()
	{
	}

	private void DeactivateCharacter()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void LateUpdate()
	{
	}

	private void UpdateMovingPlatform()
	{
	}

	public void CameraUpdate()
	{
	}

	private void ColliderUpdate()
	{
	}

	private void UpdateBasicMovement()
	{
	}

	private void Accelerate(Vector3 wishdir)
	{
	}

	private void UpdateAdvancedMovement()
	{
	}

	private void Jump(float SetJumpHeight)
	{
	}

	private void SetCrouch(bool ShouldCrouch)
	{
	}

	private void Land()
	{
	}

	private void Slide()
	{
	}

	public void Swim(bool SwimmingState)
	{
	}

	[IteratorStateMachine(typeof(_003CVault_003Ed__151))]
	public IEnumerator Vault(float speed, Vector3 endPosition, bool Clamber)
	{
		return null;
	}

	public void WallRun(bool IsRightWall)
	{
	}

	public void WallJump(bool Right, float Modifier)
	{
	}

	public void WallKick(bool RightWallKick)
	{
	}

	public void Reorient(bool IsRightWall)
	{
	}

	public void NudgeCamera(Vector3 Nudge, float Duration)
	{
	}

	public void EndNudge()
	{
	}

	public void AnimatePlayerBody(string Animation)
	{
	}

	private float CalculateCameraTilt()
	{
		return 0f;
	}

	public void ResetAbilities()
	{
	}

	public void DrainJumps()
	{
	}

	public void PreventDashing()
	{
	}

	public void UnGround()
	{
	}

	public void MovementShake()
	{
	}

	public void ToggleFreezePlayer(bool IsActive)
	{
	}

	public void SetYRotation(float NewRotation)
	{
	}

	public void SetXRotation(float NewRotation)
	{
	}

	public void PlaySoundEffect(int SoundID)
	{
	}

	public void PlayGlobalSoundEffect(int SoundID)
	{
	}
}
