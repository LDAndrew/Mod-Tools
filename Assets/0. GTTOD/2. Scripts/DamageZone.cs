using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
	public LayerMask AvailableLayers;

	public List<string> AvailableTags;

	public Projectile.BulletEffect Effect;

	public float Damage;

	[Range(0f, 200f)]
	public float ShieldPercentage;

	public float Radius;

	public float Power;

	public bool Melee;

	public bool Stagger;

	public bool PlayerDamage;

	[ConditionalField("Stagger", null)]
	public float StaggerDistance;

	public bool Continuous;

	[ConditionalField("Continuous", null)]
	public float TickRate;

	public bool Reflect;

	public GameObject HitEffect;

	public GameObject MissEffect;

	private float Tick;

	private GTTOD_HealthScript Health;

	private void OnDrawGizmosSelected()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void DamageArea()
	{
	}
}
