using UnityEngine;

public class GTTOD_Razor : MonoBehaviour
{
	public LayerMask PotentialLayers;

	public Vector2 EnemyRefreshRate;

	public Vector2 TargetRange;

	public Vector2 ScaleRange;

	public Transform AttackPoint;

	public float AttackDistance;

	public float AttackLength;

	public float AttackDamage;

	public bool Elite;

	private GTTOD_UpgradesManager Upgrades;

	private GTTOD_AIManager AIManager;

	private GTTOD_Enemy EnemyBase;

	private GTTOD_HealthScript PlayerHealth;

	private Transform Target;

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
}
