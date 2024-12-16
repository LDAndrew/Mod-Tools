using UnityEngine;

public class MoveController : MonoBehaviour
{
	public float movementSpeed;

	public float jumpSpeed;

	public float runMultiplier;

	public float gravity;

	private Vector3 velocity;

	private CharacterController characterController;

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
