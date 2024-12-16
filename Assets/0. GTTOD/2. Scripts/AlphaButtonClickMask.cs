using UnityEngine;
using UnityEngine.UI;

public class AlphaButtonClickMask : MonoBehaviour, ICanvasRaycastFilter
{
	protected Image _image;

	public void Start()
	{
	}

	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
	{
		return false;
	}
}
