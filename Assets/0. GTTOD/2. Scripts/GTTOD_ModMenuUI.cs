using UnityEngine;
using UnityEngine.UI;

public class GTTOD_ModMenuUI : MonoBehaviour
{
	public Text ModTitle;

	public Text ModDescription;

	public Image ModPreviewThumbnail;

	private GTTOD_ModMenu Menu;

	private CanvasGroup Group;

	private int Index;

	private bool Active;

	public void SetUpUI(GTTOD_ModMenu NewMenu, int NewIndex, string NewTitle, string NewDescription, Texture2D NewThumbnail)
	{
	}

	public void OnMouseDown()
	{
	}

	public void OnMouseUp()
	{
	}

	public void OnMouseClick()
	{
	}
}
