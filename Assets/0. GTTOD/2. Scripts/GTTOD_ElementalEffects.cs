using UnityEngine;

public class GTTOD_ElementalEffects : MonoBehaviour
{
	public Transform EffectPlacement;

	[Header("EFFECTS")]
	public bool CanBurn;

	[ConditionalField("CanBurn", null)]
	public GameObject FireEffect;

	[ConditionalField("CanBurn", null)]
	public Vector2 FireEffectRange;

	[ConditionalField("CanBurn", null)]
	public float FireDamage;

	public bool CanShock;

	[ConditionalField("CanShock", null)]
	public GameObject StackEffect;

	[ConditionalField("CanShock", null)]
	public GameObject ShockEffect;

	[ConditionalField("CanShock", null)]
	public GameObject DischargeEffect;

	[ConditionalField("CanShock", null)]
	public float ChargeTime;

	[ConditionalField("CanShock", null)]
	public float StackDamage;

	[ConditionalField("CanShock", null)]
	public float StackCap;

	public bool CanFrost;

	[ConditionalField("CanFrost", null)]
	public GameObject FrostEffect;

	[ConditionalField("CanFrost", null)]
	public float FrostTick;

	[ConditionalField("CanFrost", null)]
	public float FrostTime;

	[Space(10f)]
	public bool HeavyEnemy;

	[ConditionalField("HeavyEnemy", null)]
	public GameObject HeavyGrappleEffect;

	private GameManager GM;

	private GTTOD_UpgradesManager Upgrades;

	private GTTOD_AIManager AI;

	private GTTOD_Enemy Enemy;

	private Transform Player;

	private ParticleSystem CurrentFireEffect;

	private Transform NewShockEffect;

	private ParticleSystem NewFrostEffect;

	private int TickCount;

	private bool OnFire;

	private bool Charging;

	private bool Shocking;

	private bool Frosted;

	private float FireEffectTime;

	private float StaticChargeTime;

	private float StackedDamage;

	private float FrostEffectTime;

	private float FrostAmount;

	private float FrostCooldown;

	private float TemperanceTime;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void FireEffects()
	{
	}

	public void StaticEffects()
	{
	}

	public void FrostEffects()
	{
	}

	public void InstantFrostEffects()
	{
	}

	public void Death()
	{
	}
}
