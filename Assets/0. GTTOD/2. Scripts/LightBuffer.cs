using UnityEngine;

[DisallowMultipleComponent]
public class LightBuffer : MonoBehaviour
{
	public float Distance;

	public bool CanOptimize;

	private Light MyLight;

	private Transform Player;

	private LensFlare Flare;

	private float TimeToCheckDistance;

	private float MyTime;

	private float LightIntensity;

	private int OptimizationCheck;

	private bool InRange;

	private bool FullLight;

	private bool HasLensFlare;

	private bool HasShadows;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void LightsUpdate()
	{
	}
}
