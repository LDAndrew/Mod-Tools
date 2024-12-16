using UnityEngine;

public class CameraControl : MonoBehaviour
{
	public LayerMask SpawnLayers;

	public Transform PosObject;

	private float Sensitivity;

	private float rotationX;

	private float rotationY;

	private float distanceToCamera;

	private float ClickTime;

	private bool CanSetPosition;

	private Vector3 pivot;

	private Vector3 prev_mousePosition;

	private Camera cam;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private float ScreenToWorldDistance(float screenDistance, float distanceFromCamera)
	{
		return 0f;
	}

	private float CopySign(float x, float y)
	{
		return 0f;
	}
}
