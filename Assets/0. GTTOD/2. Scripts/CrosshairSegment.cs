using System;
using UnityEngine;

[Serializable]
public class CrosshairSegment
{
	public enum RecoilDirection
	{
		AxisX = 1,
		AxisY
	}

	public RecoilDirection Direction;

	public RectTransform Segment;

	public float DefaultPosition;
}
