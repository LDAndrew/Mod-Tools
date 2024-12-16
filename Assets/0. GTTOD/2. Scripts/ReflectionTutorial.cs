using System;
using UnityEngine;

[Serializable]
public class ReflectionTutorial
{
	public string TutorialName;

	public string TutorialDescription;

	[ConditionalField("Unlocked", null)]
	public Transform TutorialEndPoint;

	[ConditionalField("Unlocked", null)]
	public GameObject TutorialObject;

	[ConditionalField("Unlocked", null)]
	public Sprite TutorialIcon;

	[ConditionalField("Unlocked", null)]
	public float TutorialStartDistance;

	[ConditionalField("Unlocked", null)]
	public int ZoneToPlay;

	[ConditionalField("Unlocked", null)]
	public bool ArmPlayer;

	[ConditionalField("Unlocked", null)]
	public bool ShouldSpawn;

	[ConditionalField("Unlocked", null)]
	public bool HasTimer;
}
