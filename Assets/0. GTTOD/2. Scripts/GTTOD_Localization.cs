using UnityEngine;

public class GTTOD_Localization : MonoBehaviour
{
	public enum Languages
	{
		English,
		German,
		Spanish,
		Russian,
		TraditionalChinese,
		SimplifiedChinese,
		French,
		Portuguese,
		Japanese
	}

	public Languages CurrentLanguage;

	public static GTTOD_Localization Localization;

	public GTTODTexts Texts;

	[Space(15f)]
	public int EntryToEdit;

	private void Awake()
	{
	}

	public string GetText(int Index)
	{
		return null;
	}

	public void SaveLocalizationFile()
	{
	}

	public void LoadLocalizationFile()
	{
	}

	public void AddEntry()
	{
	}

	public void RemoveEntry()
	{
	}
}
