using UnityEngine;
using UnityEngine.UI;

public class GTTOD_PopUpText : MonoBehaviour
{
	public Text PopUpText;

	public RectTransform UITransform;

	private CanvasGroup Group;

	private Vector2 Scale;

	private float TimeToFade;

	private float AdjustedYScale;

	private bool Active;

	private bool Fading;

	public void ActivatePopup(string Message, float TimeOnScreen)
	{
	}

	private void Update()
	{
	}
}
