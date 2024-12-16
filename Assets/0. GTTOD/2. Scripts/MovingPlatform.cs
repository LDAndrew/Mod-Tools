using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
	public Transform Destination;

	public float MoveSpeed;

	public float WaitTime;

	public bool NearWait;

	[ConditionalField("NearWait", null)]
	public float ActiveDistance;

	private Vector3 Origin;

	private Vector3 CurrentDestination;

	private Transform Player;

	private bool Returning;

	private float CurrentWaitTime;

	private void OnDrawGizmosSelected()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}
}
