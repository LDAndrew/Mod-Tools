using System.Collections.Generic;
using UnityEngine;

public class AimScript : MonoBehaviour
{
	public bool Active;

	public LayerMask AvailableLayers;

	public Transform Raycaster;

	public List<Transform> Targets;

	public Transform CurrentTarget;

	private GTTOD_AIManager Manager;

	private Camera MainCamera;

	private RaycastHit HitCheck;

	private float CurrentLowestDistance;

	private float SearchTime;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void SearchForTargets()
	{
	}

	public void RemoveTarget(Transform Target)
	{
	}
}
