using UnityEngine;

public class Resource : MonoBehaviour
{
	public enum ResourceTypes
	{
		Tree,
		Obtainium
	}

	public ResourceTypes ResourceType;

	public int Health;

	public GameObject DeathObject;

	private bool Dead;

	public void Damage(int damage)
	{
	}

	private void Die()
	{
	}
}
