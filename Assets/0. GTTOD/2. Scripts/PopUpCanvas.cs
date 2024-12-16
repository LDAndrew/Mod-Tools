using UnityEngine;
using UnityEngine.UI;

public class PopUpCanvas : MonoBehaviour
{
	public bool IsFloat;

	[Header("UI COMPONENTS")]
	public Text SubjectText;

	public Text ValueText;

	public Slider ValueSlider;

	private Transform Editor;

	private GameObject AssignedObject;

	private float MyFloatValue;

	private int MyIntValue;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void InitializePopUp(GameObject Object, string Subject, float Value)
	{
	}

	public void AdjustFloatValue(float NewValue)
	{
	}

	public void AdjustIntValue(int NewValue)
	{
	}

	public void AcceptValue()
	{
	}
}
