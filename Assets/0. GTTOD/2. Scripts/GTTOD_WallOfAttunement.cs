using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GTTOD_WallOfAttunement : MonoBehaviour
{
	public CanvasGroup RuneGroup;

	public Transform RuneContent;

	public GTTOD_RuneUI RuneUI;

	public Sprite DefaultUI;

	public Text SelectedRuneTitleText;

	public Image SelectedRuneIconImage;

	public Text SelectedRunInfoText;

	private GTTOD_Manager Manager;

	private GTTOD_UpgradesManager Upgrades;

	[HideInInspector]
	public List<GTTOD_RuneUI> RuneSelections;

	private bool Active;

	private void Start()
	{
	}

	public void HoverToggle(int Index, bool On)
	{
	}

	public void ApplyRune(int RuneIndex)
	{
	}

	public void ActivateSelections()
	{
	}

	public void Leave()
	{
	}
}
