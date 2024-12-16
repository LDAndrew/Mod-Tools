using UnityEngine;

public class GTTOD_Golem : MonoBehaviour
{
	public LayerMask PotentialLayers;

	public bool Friendly;

	public bool Elite;

	[ConditionalField("Elite", null)]
	public GameObject EliteExplosion;

	[Header("GENERAL SETTINGS")]
	public Vector2 EnemyRefreshRate;

	public Vector2 ScaleRange;

	public Vector2 TargetRange;

	public Vector2 EnemyBurstCount;

	public Transform EnemyHead;

	public Transform EnemyRightMuzzle;

	public Transform EnemyLeftMuzzle;

	[Space(15f)]
	[Header("PROJECTILE SETTINGS")]
	public EnemyProjectile Projectile;

	public float EnemyProjectileDamage;

	public float EnemyAccuracyModifier;

	public float EnemyRateOfFire;

	[Space(15f)]
	[Header("MELEE SETTINGS")]
	public GameObject EnemyMeleeObject;

	public Transform EnemyMeleePoint;

	public float EnemyMeleeRange;

	[Space(15f)]
	private GameManager GM;

	private GTTOD_Enemy EnemyBase;

	private GTTOD_AIManager AIManager;

	private GTTOD_UpgradesManager Upgrades;

	private GameObject Target;

	private float CrumbTime;

	private float RateOfFire;

	private float AttackTime;

	private float AttackDelay;

	private float TargetTime;

	private int ShotsFired;

	private bool RightMuzzle;

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

	public void TriggerAttack()
	{
	}

	public void Interrupt()
	{
	}

	private void OnDestroy()
	{
	}
}
