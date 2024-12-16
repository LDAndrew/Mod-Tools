using UnityEngine;
using UnityEngine.UI;

public class LudeoLoadingCanvasUI : MonoBehaviour
{
	public GameObject content;

	public Canvas _blockCanvas;

	public Text _loadingText;

	public Slider _loadingBar;

	public static LudeoLoadingCanvasUI Instance { get; private set; }

	private void Awake()
	{
	}
}
