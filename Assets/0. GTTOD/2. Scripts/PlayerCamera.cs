using EZCameraShake;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
	public GameObject CameraSetUp;

	public Camera MainCamera;

	public Camera WeaponCamera;

	public CameraShaker Shaker;

	private GameObject Player;

	private ac_CharacterController CharacterController;

	private Transform Target;

	private Transform WeaponTarget;

	private Vector3 LastPos;

	[HideInInspector]
	public float DefaultFOV;

	[HideInInspector]
	public float TargetFOV;

	[HideInInspector]
	public float DefaultWeaponFOV;

	private float TargetWeaponFOV;

	private float ZoomSpeed;

	private bool Active;

	private void Start()
	{
	}

	public void ActivateCameras(Transform NewTarget)
	{
	}

	public void DeactivateCameras()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	public void SetTargetFOV(float FOV)
	{
	}

	public void SetDefaultFOV()
	{
	}

	public void SnapToDefault()
	{
	}

	public void SetTargetWeaponFOV(float FOV)
	{
	}

	public void SetDefaultWeaponFOV()
	{
	}

	public void SetWeaponCameraTarget(Transform Target, float Speed)
	{
	}

	public void ResetWeaponCameraTarget(float Speed)
	{
	}
}
