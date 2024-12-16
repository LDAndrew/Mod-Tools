using UnityEngine;

public class SustainedShake : MonoBehaviour
{
	public bool Active;

	[Range(0f, 1f)]
	public float IntensityModifer;

	public Vector2 IntensityRange;

	public Vector2 ShakeRange;

	private float TimeToShake;

	private void Update()
	{
	}

	private void Shake()
	{
	}
}
