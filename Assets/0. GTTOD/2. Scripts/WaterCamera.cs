using UnityEngine;

public class WaterCamera : MonoBehaviour
{
	public bool Active;

	public Material Wobble;

	public Color underwaterColor;

	public BlendMode Blend;

	[Header("Shaders")]
	[Space]
	public Shader multiply;

	public Shader overlay;

	public Shader screen;

	private void Update()
	{
	}

	public void SetBlend(int mode)
	{
	}

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
