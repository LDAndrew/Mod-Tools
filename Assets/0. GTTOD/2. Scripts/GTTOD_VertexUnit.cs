using UnityEngine;
using UnityEngine.AI;

public class GTTOD_VertexUnit : MonoBehaviour
{
	[Header("UNIT VARIABLES")]
	public bool PlayerUnit;

	public float Health;

	[Header("NAVIGATION VARIABLES")]
	public Vector2 MinimumRange;

	public Vector2 RefreshRate;

	public Vector2 AreaRange;

	[Header("COMBAT VARIABLES")]
	public LayerMask CombatLayers;

	public GTTOD_VertexProjectile Projectile;

	public Transform ProjectileRoot;

	public float ProjectileDamage;

	public float ProjectileRange;

	public float Inaccuracy;

	public float RateOfFire;

	public Vector2 Bursts;

	[Header("HIDDEN VARIABLES")]
	public bool ShowHiddenVariables;

	[ConditionalField("ShowHiddenVariables", null)]
	public Transform AreaTarget;

	[ConditionalField("ShowHiddenVariables", null)]
	public Transform EnemyTarget;

	private GameManager GM;

	private GTTOD_VertexManager VertexManager;

	private Animator Anim;

	private NavMeshAgent Agent;

	private bool Engaged;

	private float NavTime;

	private float EnemyScan;

	private float AdjustedFireRate;

	private int ShotsFired;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void SetUpUnit(GTTOD_VertexManager NewManager, Transform NewAreaTarget, bool IsPlayerUnit)
	{
	}

	public bool TryDestination(Vector3 Position)
	{
		return false;
	}

	public void Damage(float Damage)
	{
	}
}
