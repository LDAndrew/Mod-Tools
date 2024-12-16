using UnityEngine;

public class GTTOD_MapMod : MonoBehaviour
{
	public enum Placement
	{
		Act1Stage1,
		Act1Stage2,
		Act1Stage3,
		Act1BossFight,
		Act1SafeLevel,
		Act2Stage1,
		Act2Stage2,
		Act2Stage3,
		Act2BossFight,
		Act2SafeLevel,
		Act3Stage1,
		Act3Stage2,
		Act3Stage3,
		Act3BossFight,
		Act3SafeLevel
	}

	public enum Type
	{
		Act0,
		Act1,
		Act2,
		Act3
	}

	public Placement LevelPlacement;

	public Type WorldType;

	public string LevelName;

	public GTTOD_Level Level;
}
