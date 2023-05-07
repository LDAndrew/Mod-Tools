using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GTTOD_OSTMod : MonoBehaviour
{
    public enum TrackZone
    {
        MainMenu = 0, Prologue = 1, HarborDeep = 2, Reflection = 3, Dungeons = 4, AltitudeOne = 5, AltitudeOneDoorEvent = 6, AltitudeOneSafeLevel = 7, TheBladeSentinel = 8, AltitudeTwo = 9, AltitudeTwoDoorEvent = 10, AltitudeTwoSafeLevel = 11, TheLichSentinel = 12, TheSummit = 13, TheWorldSentinel = 14, Credits = 15, TheHeart = 16
    }
    public TrackZone ModTrackZone;
    public string ModTrackName;
    public string ModTrackArtist;
    public AudioClip ModTrackStartClip;
    public AudioClip ModTrackLoopClip;
    public AudioClip ModAmbienceStart;
    public AudioClip ModAmbienceLoop;
}