using UnityEngine;
using UnityEngine.UI;

public class GTTOD_GridItemUI : MonoBehaviour
{
	public Image ItemIcon;

	public Text ItemCountText;

	private GTTOD_Inventory Inventory;

	private GTTOD_HUD HUD;

	private int HeldItemIndex;

	private string ItemName;

	private string ItemDescription;

	private void Start()
	{
	}

	public void SetUpIcon(string Name, string Description, Sprite Icon, int Count, int HeldIndex)
	{
	}

	public void HoverIcon()
	{
	}

	public void UnhoverIcon()
	{
	}

	public void UseItem()
	{
	}
}
