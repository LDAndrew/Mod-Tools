using UnityEngine;

public class CameraRainDrops3D : MonoBehaviour
{
	private GameObject SmallDrops;

	private GameObject MediumDrops;

	private GameObject BigDrops;

	private GameObject RainTrails;

	public bool EnableRainTrails;

	[Range(1f, 3f)]
	public int RainDropsIntensity;

	private int _intensity;

	private bool _trails;

	public bool EnableTrails
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int RainIntensity
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}
}
