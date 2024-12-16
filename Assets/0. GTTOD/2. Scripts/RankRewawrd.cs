using System;
using UnityEngine;

[Serializable]
public class RankRewawrd
{
	public string RewardName;

	[TextArea(1, 5)]
	public string RewardDescription;

	public Sprite RewardIcon;
}
