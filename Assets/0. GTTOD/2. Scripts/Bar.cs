using UnityEngine;
using UnityEngine.UI;

public class Bar : MonoBehaviour
{
	public float MyDelay;

	public CanvasGroup TitleGroup;

	public Text BarTitle;

	public Text BarValue;

	private CanvasGroup ContentGroup;

	private Image BarImage;

	private float Delay;

	private float StartingDelay;

	private float Value;

	private float MaxValue;

	private float Adjustment;

	public void AssignBar(float AssignedDelay, float AssignedValue, float AssignedMaxValue, string AssignedTitle)
	{
	}

	private void Update()
	{
	}
}
