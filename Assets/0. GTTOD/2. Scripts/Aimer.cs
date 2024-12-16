using UnityEngine;

public class Aimer : MonoBehaviour
{
	public LayerMask AvailableLayers;

	[Header("Aim Objects")]
	public Transform AimPoint;

	public Transform BulletPoint;

	private Vector3 HitPosition;

	private float AimDistance;

	private float ResetTime;

	private float RandomX;

	private float RandomY;

	private float DistanceAdjustment;

	private void Update()
	{
	}

	public void Fire(float X, float Y)
	{
	}
}
