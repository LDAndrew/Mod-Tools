using System;
using UnityEngine;

[Serializable]
public class BodyHook
{
	public string BodyPart;

	public bool IKActive;

	public float SpringMultiplier;

	public float DampeningMultiplier;

	public Rigidbody Bone;

	public Transform Hook;

	[HideInInspector]
	public ConfigurableJoint Joint;

	[HideInInspector]
	public Quaternion targetInitialRotation;
}
