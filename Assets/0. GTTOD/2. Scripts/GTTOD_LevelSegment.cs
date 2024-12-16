using System.Collections.Generic;
using UnityEngine;

public class GTTOD_LevelSegment : MonoBehaviour
{
	public Transform SegmentCenterpoint;

	public float ActiveDistance;

	public List<GameObject> ToggleObjects;

	private Transform Player;

	private bool ObjectsActive;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
