using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GTTOD_WorldlyPotentialSelection : MonoBehaviour
{
	public RectMask2D ProgressBarMask;

	public Transform RightMarksParent;

	public Transform LeftMarksParent;

	public RectMask2D UpgradeEffectMask;

	public CanvasGroup UpgradeEffectGroup;

	public List<AudioClip> SFX;

	[HideInInspector]
	public List<GameObject> RightMarks;

	[HideInInspector]
	public List<GameObject> LeftMarks;

	private GTTOD_Manager Manager;

	private GTTOD_UpgradesManager Upgrades;

	private GTTOD_WorldlyPotential WorldlyPotential;

	private RectMask2D SelectionMask;

	private RectTransform UITransform;

	private CanvasGroup SelectionGroup;

	private AudioSource Audio;

	private string Description;

	private float AdjustedHeight;

	private float AdjustedMask;

	private float SmoothedUpgrade;

	private int Level;

	private int Index;

	private int Cost;

	private int Dividend;

	private bool MaxedOut;

	private bool MouseOver;

	private void Start()
	{
	}

	public void SetUpSelection(GTTOD_WorldlyPotential MyPotential, string NewDescription, int CurrentLevel, bool IsMaxed, int CurrentCost, int CurrentDividend, int CurrentIndex)
	{
	}

	private void Update()
	{
	}

	public void AdjustRunes()
	{
	}

	public void TryUpgrade()
	{
	}

	public void MouseEnter()
	{
	}

	public void MouseExit()
	{
	}

	public void MouseClick()
	{
	}

	public void PlaySFX(int Index)
	{
	}
}
