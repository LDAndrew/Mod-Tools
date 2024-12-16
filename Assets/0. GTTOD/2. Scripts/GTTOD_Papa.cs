using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GTTOD_Papa : MonoBehaviour
{
	public LayerMask PotentialLayers;

	[Header("GENERAL SETTINGS")]
	public bool Friendly;

	public bool CanMelee;

	public Vector2 EnemyRefreshRate;

	public Vector2 EnemyRageRefreshRate;

	public Vector2 PapaRateOfFireRange;

	public Vector2 ScaleRange;

	public Vector2 TargetRange;

	public Transform Eye;

	[Header("PAPA SETTINGS")]
	public float PapaRageHealth;

	public float GunRange;

	public float CheeseProjectileDamage;

	public Transform GunPivot;

	public Transform GunFollow;

	public List<PapaGun> PapaGuns;

	[Header("LASER SETTINGS")]
	public float LaserTrackingSpeed;

	public float EnemyLaserDamage;

	public float EnemyLaserTickTime;

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

	private float RateOfFire;

	private int GunIndex;

	private bool WithinSight;

	private bool Raging;

	private bool Lasering;

	private bool HasRaged;

	private bool GunsActive;

	private bool HasTriggeredSecondPhase;

	private bool TriggeredCutscene;

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

	public void Interrupt()
	{
	}

	public void ActivateGuns()
	{
	}
}
