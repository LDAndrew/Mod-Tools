using UnityEngine;

public class AutoPilot : MonoBehaviour
{
	private class Chaos
	{
		private float t;

		public float Next => 0f;
	}

	[SerializeField]
	private float velocity;

	[SerializeField]
	private float height;

	private float t;

	private Vector3 target;

	private float targetVelocity;

	private Chaos velocityChaos;

	private Chaos pitchChaos;

	private Chaos VelocityChaos => null;

	private Chaos PitchChaos => null;

	private float Pitch => 0f;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnStep()
	{
	}
}
