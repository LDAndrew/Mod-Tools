using System;
using UnityEngine;

[Serializable]
public class ApparelItem
{
	public string ApparelName;

	public string ApparelDescription;

	public Vector2 ApparelModifier;

	public Vector2 PriceRange;

	public GameObject ApparelObject;

	public Sprite ApparelIcon;

	public bool Accessible;
}
