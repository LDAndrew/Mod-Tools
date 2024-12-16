using UnityEngine;
using UnityEngine.AI;

public class GTTOD_Cyclops : MonoBehaviour
{
	public LayerMask PotentialLayers;

	public bool Elite;

	[Header("GENERAL SETTINGS")]
	public bool Friendly;

	public bool CanMelee;

	public bool CanRage;

	[ConditionalField("CanRage", null)]
	public GameObject RageExplosion;

	[ConditionalField("CanRage", null)]
	public float ShieldHealth;

	public Vector2 EnemyRefreshRate;

	public Vector2 EnemyRageRefreshRate;

	public Vector2 ScaleRange;

	public Vector2 TargetRange;

	public Transform Eye;

	[Header("LASER SETTINGS")]
	public float LaserTrackingSpeed;

	public float EnemyLaserDamage;

	public float EnemyLaserTickTime;

	public float EnemyLaserRange;

	public Transform LaserObject;

	public Transform LaserPoint;

	public AudioSource LaserAudio;

	[Header("MELEE SETTINGS")]
	public GameObject EnemyMeleeObject;

	public Transform EnemyMeleePoint;

	public float EnemyMeleeRange;

	private GameManager GM;

	private GTTOD_Enemy EnemyBase;

	private GTTOD_AIManager AIManager;

	private GTTOD_UpgradesManager Upgrades;

	private GTTOD_ElementalEffects ElementalEffects;

	private GTTOD_EnergyShield EnergyShield;

	private NavMeshAgent Agent;

	private Animator Anim;

	private GameObject Target;

	private float CrumbTime;

	private float MeleeAttackTime;

	private float LaserTime;

	private float TargetTime;

	private float LaserTickTime;

	private float RageTime;

	private float RageHealth;

	private float DefaultSpeed;

	private float LaserCoolTime;

	private float LookRotation;

	private bool WithinSight;

	private bool Raging;

	private bool Lasering;

	private bool HasRaged;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private GameObject FindEnemyTarget()
	{
		return null;
	}

	public void UpdateAttacks()
	{
	}

	private void ToggleRage(bool IsRaging)
	{
	}

	public void TriggerAttack()
	{
	}

	public void TriggerStep()
	{
	}

	public void Interrupt()
	{
	}

	public void Damage(float damage)
	{
	}
}
