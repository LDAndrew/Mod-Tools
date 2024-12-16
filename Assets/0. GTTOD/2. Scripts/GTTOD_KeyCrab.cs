using UnityEngine;
using UnityEngine.AI;

public class GTTOD_KeyCrab : MonoBehaviour
{
	public LayerMask PotentialLayers;

	public Vector2 EnemyRefreshRate;

	public Vector2 TargetRange;

	public Vector2 ScaleRange;

	public Transform AttackPoint;

	public float AttackDistance;

	public float AttackDamage;

	public float AttackRadius;

	public float AttackCooldown;

	public bool Elite;

	private GTTOD_UpgradesManager Upgrades;

	private GTTOD_AIManager AIManager;

	private GTTOD_HealthScript PlayerHealth;

	private NavMeshAgent EnemyAgent;

	private Rigidbody EnemyPhysics;

	private GTTOD_Enemy EnemyBase;

	private Transform Target;

	private bool Falling;

	private bool HasDamaged;

	private float CrumbTime;

	public float AttackTime;

	private float FallTime;

	private int CyclesBeforeDeath;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void JumpAttack()
	{
	}

	public void TogglePhysics(bool PhysicsOn)
	{
	}
}
