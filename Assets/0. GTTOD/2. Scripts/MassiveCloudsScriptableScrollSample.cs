using System.Collections.Generic;
using UnityEngine;

public class MassiveCloudsScriptableScrollSample : MonoBehaviour
{
	[SerializeField]
	private float velocity;

	[SerializeField]
	private Vector3 direction;

	[Range(0f, 1f)]
	[SerializeField]
	private List<float> densities;

	private Vector3 currentOffset;

	private bool initialized;

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	private void OnValidate()
	{
	}
}
