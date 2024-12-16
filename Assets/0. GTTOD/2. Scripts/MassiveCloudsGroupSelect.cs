using System;
using System.Collections.Generic;
using UnityEngine;

public class MassiveCloudsGroupSelect : MonoBehaviour
{
	[Serializable]
	public class Group
	{
		public string Name;
	}

	public GameObject ItemTemplate;

	public Transform OptionsRoot;

	public List<Group> Groups;

	public int initialGroup;

	public bool build;

	private void Start()
	{
	}

	private void OnValidate()
	{
	}

	public void Select(int groupIndex)
	{
	}
}
