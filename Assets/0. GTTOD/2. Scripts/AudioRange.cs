using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioRange : MonoBehaviour
{
    public bool PlayOnStart = true;
    public float lowestPitch;
    public float highestPitch;
    public AudioClip[] Sounds;

    AudioSource Audio;

    float AdjustedPitch;

    void Start()
    {
        Audio = gameObject.GetComponent<AudioSource>();
        if (PlayOnStart)
        {
            PlayAudio();
        }
    }
    public void SetPlay(AudioClip Clip, float Pitch, float Volume)
    {
        Audio = Audio != null ? Audio : gameObject.GetComponent<AudioSource>();
        Audio.clip = Clip;
        Audio.pitch = Pitch;
        Audio.volume = Volume;
        AdjustedPitch = Pitch;

        Audio.Play();
    }
    public void PlayAudio()
    {
        AdjustedPitch = Random.Range(lowestPitch, highestPitch);
        Audio = gameObject.GetComponent<AudioSource>();
        int index = Random.Range(0, Sounds.Length);
        Audio.clip = Sounds[index];

        Audio.Play();
    }
    private void Update()
    {
        if (Audio.isPlaying)
        {
            Audio.pitch = AdjustedPitch * Time.timeScale;
        }
    }
}