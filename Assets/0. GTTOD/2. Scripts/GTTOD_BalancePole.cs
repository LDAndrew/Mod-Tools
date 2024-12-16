using UnityEngine;

public class GTTOD_BalancePole : MonoBehaviour
{
	public float Speed;

	public float StableTime;

	public float Radius;

	private Transform Player;

	private ac_CharacterController CharacterController;

	private InventoryScript Inventory;

	private Rigidbody ControllerPhysics;

	private BoxCollider Collider;

	private float Distance;

	private float StableTimer;

	private bool Pulling;

	private bool Balanced;

	private bool HasLanded;

	private bool Stable;

	private bool Launching;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
