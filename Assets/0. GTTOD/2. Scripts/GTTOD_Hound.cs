using UnityEngine;

public class GTTOD_Hound : MonoBehaviour
{
	public Vector2 EnemyRefreshRate;

	public Vector2 ScaleRange;

	public Transform AttackPoint;

	public float AttackDistance;

	public float AttackLength;

	[HideInInspector]
	public GTTOD_LegionSentinel LegionSentinel;

	private GTTOD_AIManager AIManager;

	private GTTOD_Enemy EnemyBase;

	private GTTOD_HealthScript PlayerHealth;

	private GTTOD_UpgradesManager Upgrades;

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

	private void OnDestroy()
	{
	}
}
