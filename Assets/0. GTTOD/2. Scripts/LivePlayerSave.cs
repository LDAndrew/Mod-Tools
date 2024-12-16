using System;
using System.Collections.Generic;

[Serializable]
public class LivePlayerSave
{
	public int SeedSequence;

	public int LevelIndex;

	public int LevelsCompleted;

	public int ThreatLevel;

	public int Lives;

	public int MinutesInGame;

	public int DungeonLayer;

	public float MaxHealth;

	public float MaxShield;

	public float MaxOvershield;

	public int Shards;

	public int InventorySlots;

	public int TacticalEquipment;

	public int LethalEquipment;

	public int MeleeWeapon;

	public int Ultimate;

	public string Apparel;

	public List<string> Run;

	public List<GunSave> Guns;

	public List<ItemSave> Items;

	public List<KarmaSave> Karma;

	public List<int> SequencedSeeds;
}
