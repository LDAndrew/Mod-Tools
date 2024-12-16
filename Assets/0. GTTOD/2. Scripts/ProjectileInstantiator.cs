using UnityEngine;

public class ProjectileInstantiator : MonoBehaviour
{
	public string PoolObjectName;

	public Projectile.BulletType Projectile;

	public Projectile.BulletEffect Effect;

	public Projectile.BulletEffect BonusEffect;

	[Header("PROJECTILE SETTINGS")]
	public float Damage;

	[Range(0f, 200f)]
	public float ShieldPercentage;

	public float Range;

	public float Speed;

	public int Pierce;

	public GameObject HitEffect;

	public GameObject MissEffect;

	public GameObject BulletObject;

	public bool FireOnStart;

	public bool FireForPlayer;

	private ac_ObjectPool MyObjectPool;

	private void Start()
	{
	}

	public void Fire()
	{
	}

	public void SetBulletObject(Transform Bullet)
	{
	}
}
