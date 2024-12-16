using UnityEngine;

public class CavityBlitter : MonoBehaviour
{
	public bool use;

	public Shader cavityShader;

	private Material cavityMaterial;

	public float highlights;

	public float shadows;

	public float size;

	public float depthBias;

	private void OnRenderImage(RenderTexture from, RenderTexture to)
	{
	}

	private void Start()
	{
	}
}
