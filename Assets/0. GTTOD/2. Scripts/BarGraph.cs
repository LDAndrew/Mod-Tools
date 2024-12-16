using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarGraph : MonoBehaviour
{
	public List<StatItem> Stats;

	public Bar BarObject;

	public Transform Content;

	public Text MaxValueText;

	private float MaxValue;

	private int CycleID;

	private void Start()
	{
	}

	public void AssignBars()
	{
	}
}
