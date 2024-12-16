using System.Collections.Generic;
using UnityEngine;

public class GTTOD_OSTManager : MonoBehaviour
{
	public enum TrackFilter
	{
		AllTracks,
		ModTracks,
		VanillaTracks
	}

	public string CurrentOSTInfo;

	public TrackFilter Filter;

	public AudioSource MainSource;

	public List<GTTOD_OSTZone> OSTZones;

	[HideInInspector]
	public Vector2 CurrentZone;

	[HideInInspector]
	public bool TrackPlaying;

	private ac_OptionsMenu OptionsMenu;

	private GTTOD_Manager Manager;

	private Transform Player;

	private Transform DistanceHook;

	private float FadeMultiplier;

	private float DistanceFade;

	private float IdealDistance;

	private float IdealMinimum;

	private bool TrackHasLoop;

	private bool FadingOut;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void ChooseTrackFromZone(int ZoneIndex)
	{
	}

	private void PlayZone(Vector2 Zone)
	{
	}

	public void ResetZone(int ZoneIndex)
	{
	}

	public void StopMusic(bool FadeOut)
	{
	}

	public void AddNewTrack(int Zone, string Name, string Artist, AudioClip StartClip, AudioClip LoopClip)
	{
	}

	public void SetFilter(int FilterID)
	{
	}

	public void SetDistanceObject(Transform DistanceObject, float Range, float MinimumRange)
	{
	}

	public void ResetDistanceObject(Transform OriginalObject)
	{
	}
}
