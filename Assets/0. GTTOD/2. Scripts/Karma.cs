using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Karma
{
	public string KarmaName;

	public int KarmaLevel;

	public List<KarmaLevel> KarmaModifiers;

	[Header("Karma UI")]
	public AudioClip KarmaSound;

	public Sprite KarmaIcon;

	public bool KarmaMaxed;

	public bool RequiresLevel;

	public bool Accessible;

	[HideInInspector]
	public GTTOD_KarmaInventoryIcon KarmaUI;
}
