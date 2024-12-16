using UnityEngine;

public class GTTOD_BillboardAnimator : MonoBehaviour
{
	public Material BackgroundMaterial;

	[ColorUsage(true, true)]
	public Color DefaultColor;

	public float ScrollSpeed;

	public Vector2 ActiveDistance;

	private Color MaterialColor;

	private Vector2 UVScroll;

	private Transform Player;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
