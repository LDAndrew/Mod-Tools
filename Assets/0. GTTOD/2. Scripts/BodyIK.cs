using UnityEngine;

public class BodyIK : MonoBehaviour
{
	public Transform spineBone;

	public Transform bulletSpawnTransform;

	[HideInInspector]
	public Transform targetTransform;

	public bool shouldDebug;

	public Vector3 maximumRotationAngles;

	public float rotationSpeed;

	private Quaternion spineRotationLastFrame;

	private Vector3 tempSpineLocalEulerAngles;

	public bool isEnabled;

	public float minDistToAim;

	private Quaternion targetRot;

	public int maxIterations;

	public float minAngle;

	public bool useHighQualityAiming;

	public bool stopForCover;

	private GTTOD_Enemy EnemyBase;

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}

	public void Activate()
	{
	}

	public void Deactivate()
	{
	}

	public void SetTargetTransform(Transform x)
	{
	}

	private float ClampEulerAngles(float r, float lim)
	{
		return 0f;
	}

	private float ResetIfTooHigh(float r, float lim)
	{
		return 0f;
	}
}
