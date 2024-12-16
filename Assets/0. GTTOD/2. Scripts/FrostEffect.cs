using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Image Effects/Frost")]
public class FrostEffect : MonoBehaviour
{
	public float FrostAmount;

	public float EdgeSharpness;

	public float minFrost;

	public float maxFrost;

	public float seethroughness;

	public float distortion;

	public Texture2D Frost;

	public Texture2D FrostNormals;

	public Shader Shader;

	private Material material;

	private void Awake()
	{
	}

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
