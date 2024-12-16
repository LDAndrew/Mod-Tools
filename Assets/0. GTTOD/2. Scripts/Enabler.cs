using System.Collections.Generic;
using UnityEngine;

public class Enabler : MonoBehaviour
{
	public enum EnableTypes
	{
		None,
		Trigger,
		Distance,
		XDepth,
		YDepth,
		ZDepth
	}

	public EnableTypes EnableType;

	public float Range;

	public bool Toggle;

	public bool DisableOnStart;

	public List<GameObject> EnableObjects;

	public List<GameObject> DisableObjects;

	private Transform Player;

	private bool HasTriggered;

	private void OnDrawGizmosSelected()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Trigger(bool On)
	{
	}
}
