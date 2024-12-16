using UnityEngine;

public class GTTOD_Infantry : MonoBehaviour
{
	public LayerMask PotentialLayers;

	[Header("GENERAL SETTINGS")]
	public Vector2 EnemyRefreshRate;

	public Vector2 ScaleRange;

	public Vector2 TargetRange;

	public Vector2 EnemyBurstCount;

	public Transform EnemyMuzzle;

	[Space(15f)]
	[Header("PROJECTILE SETTINGS")]
	public EnemyProjectile Projectile;

	public float EnemyProjectileDamage;

	public float EnemyAccuracyModifier;

	public float EnemyRateOfFire;

	private GameManager GM;

	private GTTOD_Enemy EnemyBase;

	private GTTOD_AIManager AIManager;

	private Transform Target;

	private float CrumbTime;

	private float RateOfFire;

	private float AttackDelay;

	private int ShotsFired;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void UpdateAttacks()
	{
	}

	public void Interrupt()
	{
	}
}
