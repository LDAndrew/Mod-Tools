using UnityEngine;

public class GTTOD_VehicleWheel : MonoBehaviour
{
	[Header("WHEEL OBJECTS")]
	public Transform WheelModel;

	public WheelCollider WheelCollision;

	private bool Drifting;

	[Header("Properties")]
	public float MaxAngle;

	public float peakTorque;

	public float brakeTorque;

	public float timeToMaxTorque;

	public float timeToZeroTorque;

	[Header("Effects")]
	public ParticleSystem dustTrail;

	public ParticleSystem dirtDots;

	private float torque;

	private AudioSource Audio;

	private float steerInput;

	private float throttle;

	[HideInInspector]
	public float SteerInput
	{
		set
		{
		}
	}

	[HideInInspector]
	public float Throttle
	{
		set
		{
		}
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void ApplyBrake(bool Braking)
	{
	}

	private float FindCurrentFriction()
	{
		return 0f;
	}
}
