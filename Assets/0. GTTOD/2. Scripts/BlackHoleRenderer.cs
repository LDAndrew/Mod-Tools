using UnityEngine;

[ExecuteInEditMode]
public class BlackHoleRenderer : AutoBehaviour
{
	[HideInInspector]
	public float ratio;

	[HideInInspector]
	public float radius;

	[HideInInspector]
	public bool EinsteinRadiusCompliance;

	[HideInInspector]
	public Transform BH;

	private Shader shader;

	private int outOfScreen;

	private Material _material;

	protected Material material => null;

	protected virtual void OnDisable()
	{
	}

	private void Start()
	{
	}

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	private float Remap(float value, float from1, float to1, float from2, float to2)
	{
		return 0f;
	}
}
