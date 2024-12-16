using UnityEngine;

public class GTTOD_Trap : MonoBehaviour
{
	public Transform TriggerPoint;

	public float TriggerDistance;

	public float DamageRange;

	public float Damage;

	private GTTOD_HealthScript PlayerHealth;

	private GTTOD_AIManager AIManager;

	private Transform Player;

	private Animator Anim;

	private bool Triggered;

	private float Distance;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void ResetTrap()
	{
	}

	public void TriggerDamageArea()
	{
	}
}
