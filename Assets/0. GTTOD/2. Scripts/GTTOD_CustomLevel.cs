using System.Collections.Generic;
using UnityEngine;

public class GTTOD_CustomLevel : MonoBehaviour
{
	public GTTOD_Level DefaultCustomLevel;

	[Header("GAME VARIABLES")]
	public bool ShowGameVariables;

	[ConditionalField("ShowGameVariables", null)]
	public GTTOD_OrangeDoor OrangeDoor;

	[ConditionalField("ShowGameVariables", null)]
	public GameObject EmptyBunker;

	[ConditionalField("ShowGameVariables", null)]
	public GameObject GrabAGun;

	[ConditionalField("ShowGameVariables", null)]
	public GameObject KeyJar;

	[ConditionalField("ShowGameVariables", null)]
	public GameObject AlphaCache;

	[ConditionalField("ShowGameVariables", null)]
	public Color SunColor;

	[ConditionalField("ShowGameVariables", null)]
	public Transform SunPoint;

	[ConditionalField("ShowGameVariables", null)]
	public Transform Fog;

	[ConditionalField("ShowGameVariables", null)]
	public GameObject Beacon;

	[ConditionalField("ShowGameVariables", null)]
	public GameObject BABECave;

	[ConditionalField("ShowGameVariables", null)]
	public GameObject DungeonPortal;

	private GTTOD_ModManager ModManager;

	private GTTOD_Manager Manager;

	private string CustomLevelTag;

	[HideInInspector]
	public List<GTTOD_MapMod> PotentialMaps;

	private void Start()
	{
	}
}
