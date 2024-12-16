using UnityEngine;
using UnityEngine.AI;

public class GTTOD_PageOfPentacles : MonoBehaviour
{
	public Transform Midpoint;

	public Animator Anim;

	public NavMeshAgent Agent;

	public AudioSource Audio;

	public Vector2 ScaleRange;

	public Vector2 PitchRange;

	public Vector2 SpeedRange;

	public Vector2 StealRange;

	public float EdgeRange;

	public float ActiveRange;

	private GTTOD_Enemy Enemy;

	private GTTOD_Manager Manager;

	private Transform Target;

	private Transform PlayerCamera;

	private bool Visible;

	private bool Active;

	private float HiddenSpeed;

	private float AnimationSpeed;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
