using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Potential
{
	public string PotentialName;

	public string PotentialSubtext;

	[Header("NEW POTENTIAL")]
	public Sprite PotentialIcon;

	public int PotentialLevel;

	public List<int> PotentialProgression;

	public bool MaxedOut;
}
