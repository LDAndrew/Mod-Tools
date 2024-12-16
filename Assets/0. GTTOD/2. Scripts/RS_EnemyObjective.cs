using System.Collections.Generic;
using UnityEngine;

public class RS_EnemyObjective : MonoBehaviour
{
	public enum Objective
	{
		Player,
		EntryPoint,
		Generator
	}

	public Objective ObjectiveType;

	public Transform ObjectivePoint;

	public float ObjectiveRange;

	public float BarrierAnimation;

	public bool AnimateEntry;

	[ConditionalField("AnimateEntry", null)]
	public Transform EntryPoint;

	[ConditionalField("AnimateEntry", null)]
	public float EntryAnimation;

	[ConditionalField("AnimateEntry", null)]
	public float EntrySpeed;

	[ConditionalField("AnimateEntry", null)]
	public float EntryTime;

	public List<GameObject> EntrySegments;

	private int SegmentIndex;

	private bool EntryOpen;

	public void RipBoard(RS_Enemy EnemySource)
	{
	}
}
