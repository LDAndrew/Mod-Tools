using System;
using UnityEngine;

[Serializable]
public class WallCast
{
	public Transform MyPoint;

	public Transform MyHitPoint;

	public float CastLength;

	public bool ShouldHit;

	public bool HasTolerance;

	[ConditionalField("HasTolerance", null)]
	public float AngleTolerance;
}
