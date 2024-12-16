using System;
using UnityEngine;

[Serializable]
public class Rune
{
	public string RuneName;

	[TextArea(1, 5)]
	public string RuneInfo;

	public Sprite RuneIcon;

	public int UnlockLevel;

	public bool RuneActive;

	public bool RuneAccessible;
}
