using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class PersistentGameSave
{
	[Header("Progression")]
	public GTTOD_MainMenu.StartTypes StartType;

	public string LastLevelLoaded;

	public string LastSeedLoaded;

	[Header("Player Stats")]
	public int EnemiesDefeated;

	public int SuccessfulRuns;

	public int FailedRuns;

	public int StagesCompleted;

	public int DungeonsCleared;

	public int BunkersOpened;

	[Header("Game Stats")]
	public float GauntletTime;

	public int Difficulty;

	public int JadeVines;

	public int CardPacks;

	public int Scrolls;

	public int TellerShards;

	public List<int> GearCards;

	public List<AspectSave> Aspects;

	public List<StashItem> StashItems;

	public List<bool> AttunementRunes;
}
