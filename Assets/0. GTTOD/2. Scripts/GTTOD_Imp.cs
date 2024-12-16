using UnityEngine;
using UnityEngine.AI;

public class GTTOD_Imp : MonoBehaviour
{
	public LayerMask PotentialLayers;

	[Header("GENERAL SETTINGS")]
	public Vector2 EnemyRefreshRate;

	public Vector2 ScaleRange;

	public Vector2 TargetRange;

	public Transform AttackPoint;

	[Header("PROJECTILE SETTINGS")]
	public EnemyProjectile Projectile;

	public float EnemyProjectileDamage;

	public float EnemyAccuracyModifier;

	public float AttackDelay;

	[Space(15f)]
	[Header("MELEE SETTINGS")]
	public float MeleeDistance;

	public float MeleeDuration;

	public float MeleeDamage;

	private GameManager GM;

	private GTTOD_AIManager AIManager;

	private GTTOD_Enemy EnemyBase;

	private GTTOD_HealthScript PlayerHealth;

	private NavMeshAgent Agent;

	private Transform Target;

	private bool HasAttacked;

	private bool Attacking;

	private float CrumbTime;

	private float AttackTime;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void TriggerAttack()
	{
	}

	public void TriggerMelee()
	{
	}

	public void EndAttack()
	{
	}

	public void Interrupt()
	{
	}
}
