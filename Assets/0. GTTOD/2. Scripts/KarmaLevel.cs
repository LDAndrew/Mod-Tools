using System;
using UnityEngine;

[Serializable]
public class KarmaLevel
{
	public float KarmaModifier;

	public GameObject KarmaObject;

	[TextArea(1, 10)]
	public string KarmaDescription;
}
