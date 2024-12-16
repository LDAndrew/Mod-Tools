using System;
using UnityEngine;

[Serializable]
public class GTTODMod
{
	public string GTTODModName;

	public string GTTODModDescription;

	public string GTTODModPath;

	public string GTTODModSteamID;

	public AssetBundle GTTODModBundle;

	public Texture2D GTTODModThumbnail;

	public GTTOD_Mod.ModType GTTODModType;

	[HideInInspector]
	public GTTOD_Mod GTTODModObject;
}
