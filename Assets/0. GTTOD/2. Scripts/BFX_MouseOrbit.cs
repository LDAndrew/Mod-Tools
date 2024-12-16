using UnityEngine;

public class BFX_MouseOrbit : MonoBehaviour
{
	public GameObject target;

	public float distance;

	public float xSpeed;

	public float ySpeed;

	public float yMinLimit;

	public float yMaxLimit;

	private float x;

	private float y;

	private float prevDistance;

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}

	private static float ClampAngle(float angle, float min, float max)
	{
		return 0f;
	}
}
