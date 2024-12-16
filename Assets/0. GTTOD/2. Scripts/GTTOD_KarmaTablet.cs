using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GTTOD_KarmaTablet : MonoBehaviour
{
	public enum KarmaMix
	{
		Blessing,
		Curse,
		Mix
	}

	[Header("KARMA OBJECTS")]
	public GTTOD_KarmaIcon KarmaIcon;

	public GameObject BlessingEffect;

	public GameObject CurseEffect;

	[Header("MIX VARIBALES")]
	public List<Text> NameTexts;

	public List<Text> DescriptionTexts;

	public List<GameObject> RerollButtons;

	public List<CanvasGroup> CanvasGroups;

	public List<HorizontalLayoutGroup> Contents;

	public List<KarmaSelection> PotentialKarma;

	private GameManager GM;

	private GTTOD_Manager Manager;

	private GTTOD_UpgradesManager Upgrades;

	private Animator Anim;

	private int SelectedMix;

	private int JadeVinesCost;

	private bool Active;

	private bool HasRerolled;

	private int SequenceCount;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void ReRoll()
	{
	}

	public void SetUpKarma(KarmaMix Mix)
	{
	}

	private void ShuffleGrid<T>(List<T> list)
	{
	}

	public void ActivateSelections()
	{
	}

	public void SetInfo(string Name, string Description)
	{
	}

	public void SelectKarma(int Index, bool Blessing)
	{
	}
}
