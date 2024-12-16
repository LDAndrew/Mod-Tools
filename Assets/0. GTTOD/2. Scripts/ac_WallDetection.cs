using System.Collections.Generic;
using UnityEngine;

public class ac_WallDetection : MonoBehaviour
{
	[Range(0f, 10f)]
	public float Magnetism;

	public float MaxDiference;

	[Header("WALL DETECTION")]
	public Transform WallParent;

	public Transform WallPoint;

	public List<WallCast> WallCasts;

	[HideInInspector]
	public RaycastHit ToWall;

	[HideInInspector]
	public ac_CharacterController CharacterController;

	[HideInInspector]
	public float DirectionNormal;

	[HideInInspector]
	public float LeanProgress;

	[HideInInspector]
	public bool BelowEdge;

	[HideInInspector]
	public bool WallIsGood;

	[HideInInspector]
	public bool WallInRange;

	private GameManager GM;

	private Transform Player;

	private LayerMask AvailableLayers;

	private Vector3 LastPos;

	private float Distance;

	private float dir;

	private float FinalDirection;

	private float Angle;

	private float LeanSpeed;

	private float MovingTowardsWallTimer;

	private bool IsMovingTowardsWall;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public bool WallIsStable()
	{
		return false;
	}

	private float AngleDir(Vector3 fwd, Vector3 targetDir, Vector3 up)
	{
		return 0f;
	}

	private void FixedUpdate()
	{
	}
}
