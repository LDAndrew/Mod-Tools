using System.Collections.Generic;
using UnityEngine;

public class ActiveRagdoll : MonoBehaviour
{
	public LayerMask AvailableLayers;

	public bool Active;

	[Range(0f, 150f)]
	public float SpringStrength;

	[Range(0f, 15f)]
	public float DampeningStrength;

	[Range(0f, 1f)]
	public float PositionStrength;

	[Range(0f, 1f)]
	public float RotationStrength;

	public float RecoveryTime;

	[Space(15f)]
	public Transform AnimationRoot;

	public Transform BodyRoot;

	public List<BodyHook> BodyParts;

	[Space(5f)]
	public bool Readjust;

	private float SpringSave;

	private float DampeningSave;

	public Animator Anim;

	private bool KnockedDown;

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}

	private void FixedUpdate()
	{
	}

	public void KnockDown()
	{
	}
}
