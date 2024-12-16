using UnityEngine;

public class GTTOD_VertexProjectile : MonoBehaviour
{
	public enum ProjectileTypes
	{
		Flat,
		Tracking,
		Physics
	}

	public LayerMask AvailableLayer;

	public ProjectileTypes ProjectileType;

	public float ProjectileSpeed;

	public float ProjectileSize;

	public float UntrackDistance;

	public float ProjectileRange;

	public float DetonateTime;

	public GameObject ProjectileHitEffect;

	private Transform Target;

	private Vector3 RangedPosition;

	private Vector3 StartingPosition;

	private bool Active;

	private bool HasHit;

	private bool HasPassed;

	private float ProjectileDamage;

	public void ActivateProjectile(float Damage, Transform ProjectileTarget)
	{
	}

	private void Update()
	{
	}

	public void ProjectileCollide(GameObject HitObject, float Distance)
	{
	}
}
