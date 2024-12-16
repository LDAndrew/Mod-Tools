using System;
using UnityEngine;

[Serializable]
public class GTTOD_OST
{
	public string TrackName;

	public string TrackArtist;

	public AudioClip TrackStart;

	public AudioClip TrackLoop;

	[HideInInspector]
	public bool HasPlayed;

	[HideInInspector]
	public bool ModTrack;
}
