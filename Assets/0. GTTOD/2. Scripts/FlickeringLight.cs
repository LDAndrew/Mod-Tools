using System.Runtime.CompilerServices;
using UnityEngine;

public class FlickeringLight : MonoBehaviour
{
	public delegate void MainLoop();

	[Tooltip("This is how big the light is. Experiment with it.")]
	public float scale;

	[Tooltip("The moves (new targets for properties; intensity, range, position) your light will do per second.")]
	public float speed;

	[HideInInspector]
	public bool MakeSourceStationary;

	[HideInInspector]
	public float positionOffset;

	private Light light;

	private float intensityOrigin;

	private float intensityOffset;

	private float intensityDelta;

	private float rangeOrigin;

	private float rangeOffset;

	private float rangeTarget;

	private float rangeDelta;

	private Vector3 positionOrigin;

	private Vector3 positionDelta;

	private bool setNewTargets;

	private float deltaSum;

	public event MainLoop mainLoop
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Start()
	{
	}

	private void IntensityAndRange()
	{
	}

	private void Position()
	{
	}

	private void Update()
	{
	}
}
