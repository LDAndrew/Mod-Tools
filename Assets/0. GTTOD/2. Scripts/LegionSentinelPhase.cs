using System;
using UnityEngine;

[Serializable]
public class LegionSentinelPhase
{
	public string PhaseName;

	[Header("PHASE STATS")]
	public int PhaseSpeed;

	public int PhaseHounds;

	public float PhaseDamage;

	public float DodgeChance;
}
