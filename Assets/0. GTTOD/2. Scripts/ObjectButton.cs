using UnityEngine;
using UnityEngine.UI;

public class ObjectButton : MonoBehaviour
{
	public GameObject MyObject;

	public string MyObjectName;

	public Text MyObjectText;

	[Header("CANVAS PROPERTIES")]
	public GameObject CanvasObject;

	public string Subject;

	public float MaxValue;

	private LevelEditor Editor;

	private PopUpCanvas MyCanvas;

	private void OnEnable()
	{
	}

	public void SpawnMyObject()
	{
	}
}
