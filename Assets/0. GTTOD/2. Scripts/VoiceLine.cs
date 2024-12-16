using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class VoiceLine
{
	public string LineType;

	[Range(0f, 100f)]
	public float ChanceToPlay;

	[Range(0f, 100f)]
	public float Volume;

	public List<AudioClip> LineSFX;

	public List<Subtitle> LineSubtitles;

	public bool ProgressLine;

	[ConditionalField("ProgressLine", null)]
	public Vector2 ProgressedDialogue;
}
