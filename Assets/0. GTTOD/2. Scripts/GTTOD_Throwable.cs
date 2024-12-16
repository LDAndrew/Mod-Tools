using UnityEngine;

public class GTTOD_Throwable : MonoBehaviour
{
	public Vector2 ThrowSpeed;

	public Vector3 Torque;

	public float CollideTime;

	public float SpawnTime;

	public bool StickOnCollision;

	[ConditionalField("StickOnCollision", null)]
	public bool ParentToCollider;

	public bool SpawnOnTimer;

	[ConditionalField("SpawnOnTimer", null)]
	public GameObject SpawnObject;

	public bool AudioOnCollision;

	[ConditionalField("AudioOnCollision", null)]
	public AudioClip SFX;

	[ConditionalField("AudioOnCollision", null)]
	public bool Loop;

	public bool AlignWithNormal;

	public bool DestroyOnTimer;

	private Rigidbody Physics;

	private AudioSource Audio;

	private bool Frozen;

	private bool HasCollided;

	private bool HasSpawned;

	private float Timer;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}
}
