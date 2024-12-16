using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GTTOD_GearCardManager : MonoBehaviour
{
	public GameObject GearCardParent;

	public RectTransform GearCardContent;

	public Slider GearCardSlider;

	public Material OmegaCardMaterial;

	[Space(15f)]
	public List<CanvasGroup> CardGroups;

	public List<GearCard> GearCards;

	public List<Transform> CardUnlockRoots;

	[HideInInspector]
	public bool GearCardActive;

	public List<int> NormalCards;

	public List<int> KarmaCards;

	public List<int> SpecialCards;

	private AudioSource GearAudio;

	private CanvasGroup GearGroup;

	private Animator GearAnimator;

	private GameManager GM;

	private ac_CharacterController CharacterController;

	private ac_CutsceneManager Cutscenes;

	private GTTOD_Inventory Inventory;

	private ac_OptionsMenu Options;

	private GTTOD_Manager Manager;

	private Transform Player;

	private int GroupIndex;

	private int CardCount;

	private int LastHeldID;

	private float CurrentArea;

	private float AreaLerp;

	private float ContentSize;

	private float HueShift;

	private bool KeyProtection;

	private void Start()
	{
	}

	private void Update()
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

	public void ToggleGearCards(bool Active, int Index)
	{
	}

	public void OpenGearCards()
	{
	}

	public void CloseGearCards()
	{
	}

	public void OpenPack(int HeldID)
	{
	}

	public void SetUpDeck()
	{
	}

	public void UnlockCards()
	{
	}

	public void AddCardsToDeck()
	{
	}

	public void ShuffleCards()
	{
	}
}
