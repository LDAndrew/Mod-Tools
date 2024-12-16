using System;
using UnityEngine;

[Serializable]
public class BladeSentinelPhase
{
	public string PhaseName;

	[Header("PHASE STATS")]
	public int PhaseSpeed;

	public int PhaseBlades;

	public float PhaseAttackSpeed;

	public float PhaseDamage;

	public float DodgeChance;

	public bool CanShield;
}
