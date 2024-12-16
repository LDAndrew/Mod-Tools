using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GTTOD_AspectUI : MonoBehaviour
{
	[HideInInspector]
	public int AspectIndex;

	public Image AspectIcon;

	public Image AspectTitle;

	public Material HoverMaterial;

	public Sprite JadeVineCostPlate;

	public AudioSource ClickAudio;

	public List<PotentialIcon> PotentialIcons;

	private GTTOD_UpgradesManager Upgrades;

	private GTTOD_Manager GTTODManager;

	private GTTOD_HUD HUDManager;

	private AnimationFunctions Functions;

	private CanvasGroup Group;

	private Animator Anim;

	private Material StartingMaterial;

	private string AspectPlateText;

	private string AspectPlateSubtext;

	private Image FillImage;

	private float SelectionTime;

	private float ClickTime;

	private bool Active;

	private bool Hovering;

	private bool Selected;

	private bool Clicking;

	private bool MaxedOut;

	private int ClickedIndex;

	private void Update()
	{
	}

	public void SetUpAspectUI(int Index, string PlateText, string PlateSubtext, Sprite Icon, Sprite Title)
	{
	}

	public void ToggleAspectHover(bool IsHovering)
	{
	}

	public void ToggleAspectSelection()
	{
	}

	public void HoverPotential(int PotentialIndex)
	{
	}

	public void UnHoverPotential()
	{
	}

	public void ClickPotential(int PotentialIndex)
	{
	}

	public void UnclickPotential()
	{
	}

	public void SelectPotential(int PotentialIndex)
	{
	}
}
