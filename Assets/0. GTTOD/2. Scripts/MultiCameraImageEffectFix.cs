using UnityEngine;

[RequireComponent(typeof(Camera))]
public class MultiCameraImageEffectFix : MonoBehaviour
{
	private RenderTexture resultAfterImageEffects;

	private void Awake()
	{
	}

	private void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
	}
}
