using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
	public string ObjectName;

	[Header("GENERAL USE")]
	[Space(5f)]
	public bool DisableObject;

	public bool Cutscene;

	[Header("WORLD INTERACTION")]
	[Space(5f)]
	public bool StructurePickup;

	public bool PowerSwitch;

	[Header("INTERACTION VARIABLES")]
	[Space(5f)]
	[ConditionalField("Cutscene", null)]
	public int CutsceneID;

	[HideInInspector]
	public List<RS_PowerObject> PowerObjects;

	private bool PowerOn;

	private void Start()
	{
	}

	public void Interact()
	{
	}

	public void SetObjectName(string Name)
	{
	}
}
