using UnityEngine;

public class ac_WallController : MonoBehaviour
{
	public enum WallDirection
	{
		Forward,
		Right,
		Left
	}

	public WallDirection CurrentWallDirection;

	public LayerMask AvailableLayers;

	public GameObject WallEffect;

	public float MaxOutwardBendAngle;

	public float MaxWallRunTime;

	public float Acceleration;

	public float MaxSpeed;

	private GameManager GM;

	private AudioSource Audio;

	[HideInInspector]
	public Rigidbody WallPhysics;

	private bool WallRunning;

	private bool hasJumped;

	private bool hasReleased;

	private bool Dipping;

	private bool HasTopped;

	private float StartingYRotation;

	private float ForwardSpeed;

	private float VerticalSpeed;

	private float TimeToDismount;

	private float PlayerAngle;

	private float AdjustedMaxSpeed;

	private float BumpTime;

	private float MaxBumpTime;

	private float WallRunTime;

	private float AngleSpeedModifier;

	private float OrientationAngle;

	private float AnchorTime;

	private ac_WallDetection WallDetection;

	private ac_CharacterController CharacterController;

	private Rigidbody PlayerPhysics;

	private Transform PlayerPosition;

	private Vector3 LookRotation;

	private Quaternion WallRotation;

	private Quaternion StartingRotation;

	private void Start()
	{
	}

	public void StartWallRun(ac_WallDetection Detector, WallDirection Direction)
	{
	}

	private void Update()
	{
	}

	private void ChangeOrientation(bool Right)
	{
	}

	private void UpdateOrientation()
	{
	}

	public void VerticalDip()
	{
	}

	public void EndWallrun()
	{
	}
}
