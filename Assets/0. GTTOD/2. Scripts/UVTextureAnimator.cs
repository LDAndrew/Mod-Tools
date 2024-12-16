using UnityEngine;

internal class UVTextureAnimator : MonoBehaviour
{
	public int Rows;

	public int Columns;

	public float Fps;

	public int OffsetMat;

	public float StartDelay;

	public bool IsInterpolateFrames;

	public BFX_TextureShaderProperties[] TextureNames;

	public AnimationCurve FrameOverTime;

	private Renderer currentRenderer;

	private Projector projector;

	private Material instanceMaterial;

	private float animationStartTime;

	private bool canUpdate;

	private int previousIndex;

	private int totalFrames;

	private float currentInterpolatedTime;

	private int currentIndex;

	private Vector2 size;

	private bool isInitialized;

	private bool startDelayIsBroken;

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void ManualUpdate()
	{
	}

	private void StartDelayFunc()
	{
	}

	private void InitDefaultVariables()
	{
	}

	private void InitializeMaterial()
	{
	}

	private void UpdateMaterial()
	{
	}

	private void SetSpriteAnimation()
	{
	}

	private void SetSpriteAnimationIterpolated()
	{
	}
}
