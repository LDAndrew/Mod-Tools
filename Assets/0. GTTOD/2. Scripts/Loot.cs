using System;
using UnityEngine;

[Serializable]
public class Loot
{
	public string LootID;

	public int LootChance;

	public Vector2 LootRange;

	public GameObject LootObject;
}
