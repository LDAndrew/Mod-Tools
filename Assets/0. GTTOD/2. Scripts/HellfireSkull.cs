using System;
using UnityEngine;

[Serializable]
public class HellfireSkull
{
	public Animator Skull;

	public Transform Muzzle;

	public ParticleSystem ParticleEffect;

	public Vector2 FireWaitRange;

	[Range(0f, 100f)]
	public float ReactionChance;

	[HideInInspector]
	public float TimeToFire;

	[HideInInspector]
	public bool Primed;
}
