using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LanguageHandler : MonoBehaviour
{
	[SerializeField]
	private Toggle toggleEnglish;

	[SerializeField]
	private Toggle toggleArabic;

	[SerializeField]
	private Toggle toggleSpanish;

	[SerializeField]
	private Toggle togglePersian;

	[SerializeField]
	private TextMeshProUGUI textBack;

	[SerializeField]
	private TextMeshProUGUI textTitle;

	private Toggle[] allToggles;

	private static Dictionary<string, string> backTexts;

	private static Dictionary<string, string> titleTexts;

	private void Init()
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnValidate()
	{
	}

	private void SyncWithToggles()
	{
	}

	public void OnToggleClick(bool b)
	{
	}
}
