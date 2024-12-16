using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GTTOD_ModMenu : MonoBehaviour
{
	public List<CanvasGroup> Menus;

	public RectTransform ModMenuContent;

	public Slider ModMenuSlider;

	public AudioSource ModMenuAudio;

	public GTTOD_ModMenuUI ModUI;

	private GameManager GM;

	private GTTOD_ModManager ModManager;

	private Animator Anim;

	private bool Active;

	private bool KeyProtection;

	private int ModCount;

	private float CurrentArea;

	private float AreaLerp;

	private float ContentSize;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void SetUpModMenu()
	{
	}

	public void KeyAdjustment(bool Right)
	{
	}

	public void SliderAdjustment(float Value)
	{
	}

	public void SetContentPosition()
	{
	}

	public void ToggleMenu(int MenuID)
	{
	}

	public void ActivateSelections()
	{
	}

	public void SelectMod(int Index)
	{
	}

	public void ParseID(string ID)
	{
	}

	public void DisableSelections()
	{
	}
}
