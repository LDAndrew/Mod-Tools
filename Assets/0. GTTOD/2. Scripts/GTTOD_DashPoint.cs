using UnityEngine;

public class GTTOD_DashPoint : MonoBehaviour
{
	public LayerMask AvailableLayers;

	public bool WorldStepPoint;

	public float ForwardForce;

	public float UpForce;

	public float Range;

	private ac_CharacterController Player;

	private GTTOD_UpgradesManager Upgrades;

	private Transform PlayerCamera;

	private Camera MainCamera;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
