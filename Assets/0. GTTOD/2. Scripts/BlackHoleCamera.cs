using UnityEngine;

public class BlackHoleCamera : AutoBehaviour
{
	public Transform BlackHoleTransform;

	public bool EinsteinRadiusCompliance;

	public float Radius;

	private Camera blackHoleCamera;

	private Camera newCamera;

	private BlackHoleRenderer blackHoleRenderer;

	private float farClip;

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
