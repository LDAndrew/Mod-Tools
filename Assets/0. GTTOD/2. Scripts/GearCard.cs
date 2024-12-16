using System;

[Serializable]
public class GearCard
{
	public enum CardClass
	{
		BasicCard,
		KarmaCard,
		SpecialCard
	}

	public string CardName;

	public CardClass CardType;

	public int CardCount;

	public GTTOD_GearCard CardPrefab;
}
