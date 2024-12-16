using UnityEngine;
using UnityEngine.UI;

public class GTTOD_GearsGuide : MonoBehaviour
{
	public CanvasGroup CanvasGroup;

	public GTTOD_ReflectionIcon TutorialIcon;

	public RectTransform TutorialContent;

	public Text TutorialNameText;

	public Text TutorialDescriptionText;

	public Slider TutorialSlider;

	private GTTOD_Reflection Reflection;

	private Animator Anim;

	private int RemainingTutorials;

	private float AreaLerp;

	private float CurrentArea;

	private float ContentSize;

	private bool KeyProtection;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void KeyAdjustment(bool Right)
	{
	}

	public void SliderAdjustment(float Value)
	{
	}

	public void SetContentPosition()
	{
	}

	public void SetInfo(string Name, string Description)
	{
	}

	public void ActivateSelections()
	{
	}

	public void SelectTutorial(int Index)
	{
	}
}
