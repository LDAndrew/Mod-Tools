using UnityEngine;

public class GTTOD_GolemGun : MonoBehaviour
{
	public Transform Root;

	public GTTOD_Enemy EnemyRoot;

	public GameObject DeathObject;

	public float StaggerID;

	public float Health;

	private Animator Anim;

	private bool Dead;

	private void Start()
	{
	}

	public void Damage(float damage)
	{
	}
}
