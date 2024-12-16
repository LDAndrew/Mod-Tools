using UnityEngine;
using UnityEngine.UI;

public class FolderScript : MonoBehaviour
{
	[Header("BASIC OBJECTS")]
	public Text FolderNameText;

	public Slider FolderSlider;

	[Header("FOLDER OBJECTS")]
	public string MyFolderName;

	public RectTransform MyFolderGroup;

	public float MyFolderDepth;

	private void OnEnable()
	{
	}

	private void Update()
	{
	}
}
