using UnityEngine;
using UnityEngine.UI;

public class GTTOD_StashItemUI : MonoBehaviour
{
	public Image ItemIcon;

	public Text ItemText;

	public Text ItemCount;

	private GTTOD_Locker ItemLocker;

	private GTTOD_MemoryManager Memory;

	private AudioSource Audio;

	private CanvasGroup Group;

	private float Scale;

	private int Index;

	private int SFXIndex;

	private bool Active;

	public bool InStash;

	private void Update()
	{
	}

	public void SetUpUI(GTTOD_Locker Locker, int LockerIndex, int AudioIndex, Sprite Icon, string Name, bool Stored)
	{
	}

	public void ToggleHover(bool IsHovering)
	{
	}

	public void Click()
	{
	}
}
