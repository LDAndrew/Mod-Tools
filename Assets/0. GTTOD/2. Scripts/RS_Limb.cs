using UnityEngine;

public class RS_Limb : MonoBehaviour
{
	public enum LimbType
	{
		Arm,
		Leg,
		Head
	}

	public LimbType Type;

	public float Health;

	public RS_Enemy EnemyRoot;

	public Transform LimbRoot;

	public GameObject DeathEffect;

	public GameObject LimbReplacement;

	private bool Dead;

	public void LimbDamage(float damage)
	{
	}

	private void Die()
	{
	}
}
