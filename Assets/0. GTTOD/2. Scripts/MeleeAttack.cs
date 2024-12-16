using System;
using UnityEngine;

[Serializable]
public class MeleeAttack
{
	public string AttackName;

	[Header("ATTACK STATS")]
	public float Speed;

	public float Damage;

	[Range(100f, 500f)]
	public float ShieldPercentage;

	public float Range;

	public float Power;

	[Header("ATTACK EFFECTS")]
	public bool Stagger;

	[ConditionalField("Stagger", null)]
	public float StaggerDistance;

	public GameObject HitEffect;

	[Header("ATTACK SHAKE")]
	public float Magnitude;

	public float Roughness;

	public float Fade;
}
