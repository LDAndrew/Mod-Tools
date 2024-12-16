using System;
using UnityEngine;

[Serializable]
public class LeylineOption
{
	public enum OfferingType
	{
		JadeVines,
		Shards,
		Keys,
		HarborScroll,
		CardPack,
		Health,
		Shield,
		Overshield,
		MaxAmmo,
		FullHeal,
		ExtraLife,
		Blessing,
		Curse,
		UltimateAbility
	}

	public string OfferingName;

	[TextArea(1, 5)]
	public string OfferingDescription;

	public Sprite OfferingIcon;

	public OfferingType Offering;

	[Range(0f, 100f)]
	public float OfferingChance;

	public bool RequiresLevel;

	public string GetOfferingDescription(int BonusIndex)
	{
		return null;
	}

	public void AcceptOffering(int BonusIndex)
	{
	}
}
