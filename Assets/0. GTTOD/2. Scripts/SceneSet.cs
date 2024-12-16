using System;
using UnityEngine;

[Serializable]
public class SceneSet
{
	public string LevelName;

	[Range(0f, 100f)]
	public float GenerateChance;

	public int LevelLayer;

	[HideInInspector]
	public GTTOD_Level CustomLevel;

	[HideInInspector]
	public string CustomSceneName;
}
