using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Aspect
{
	public string AspectName;

	public string AspectSubtext;

	public bool ShowAspectAttributes;

	[ConditionalField("ShowAspectAttributes", null)]
	public int UnlockLevel;

	[ConditionalField("ShowAspectAttributes", null)]
	public Sprite AspectTitle;

	[ConditionalField("ShowAspectAttributes", null)]
	public Sprite AspectIcon;

	public List<Potential> AspectPotential;
}
