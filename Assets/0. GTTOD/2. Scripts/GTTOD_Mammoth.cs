using UnityEngine;

public class GTTOD_Mammoth : MonoBehaviour
{
	public bool Friendly;

	public Vector2 EnemyRefreshRate;

	public Vector2 ScaleRange;

	public GameObject Nest;

	public Transform AttackPoint;

	public float AttackDistance;

	public float AttackLength;

	public float AttackDamage;

	public bool ShouldDig;

	private GameManager GM;

	private GTTOD_AIManager AIManager;

	private GTTOD_Enemy EnemyBase;

	private GTTOD_HealthScript PlayerHealth;

	private Transform Target;

	private Transform SpawnTarget;

	private GameObject[] SpawnPoints;

	private float CrumbTime;

	private float AttackTime;

	private float SpawnTime;

	private float TargetTime;

	private bool Spawning;

	private bool HasSpawned;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private Transform FindEnemyTarget()
	{
		return null;
	}

	private Transform FindDigPoint()
	{
		return null;
	}

	public Transform GetClosestPoint(GameObject[] Points)
	{
		return null;
	}

	public void TriggerAttack()
	{
	}

	public void TriggerSpawn()
	{
	}
}
