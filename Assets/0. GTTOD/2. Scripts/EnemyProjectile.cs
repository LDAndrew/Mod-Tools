using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
	public enum ProjectileTypes
	{
		Flat,
		Tracking,
		Physics
	}

	public LayerMask AvailableLayer;

	public ProjectileTypes ProjectileType;

	public Projectile.BulletEffect ProjectileEffect;

	public string TargetTag;

	public float ProjectileSpeed;

	public float ProjectileSize;

	public float UntrackDistance;

	public float ProjectileRange;

	public float DetonateTime;

	public float ScalingMultiplier;

	public GameObject ProjectileHitEffect;

	public GameObject ProjectileMissEffect;

	public GameObject ProjectileReflectEffect;

	public bool EnemyDamage;

	[HideInInspector]
	public float ProjectileDamage;

	private GameManager GM;

	private GTTOD_AIManager AIManager;

	private GTTOD_UpgradesManager Upgrades;

	private Transform Player;

	private Transform PlayerCamera;

	private GameObject SpawnedObject;

	private Vector3 TargetPosition;

	private Vector3 StartingPosition;

	private bool Active;

	private bool HasHit;

	private bool HasPassed;

	public void ActivateProjectile(float Damage, GameObject Spawner)
	{
	}

	private void Update()
	{
	}

	public void ProjectileCollide(GameObject HitObject, float Distance)
	{
	}

	public void Reflect()
	{
	}
}
