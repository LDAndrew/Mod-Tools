using System;
using UnityEngine;

[Serializable]
public class LootSpawn
{
	public string LootName;

	public GameObject LootObject;

	[Range(0f, 100f)]
	public float LootChance;

	public Vector2 LootCountRange;
}
