using UnityEngine;

public class EquipmentRecaller : MonoBehaviour
{
	public bool SpawnOnRecall;

	[ConditionalField("SpawnOnRecall", null)]
	public GameObject RecallObject;

	[ConditionalField("SpawnOnRecall", null)]
	public Transform RecallObjectSpawnPoint;

	public bool InheritVelocity;

	[ConditionalField("InheritVelocity", null)]
	public Rigidbody RecallPhysics;

	public bool DestroyOnRecall;

	public void Recall()
	{
	}

	public void Damage(float damage)
	{
	}
}
