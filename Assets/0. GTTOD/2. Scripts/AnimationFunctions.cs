using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

[RequireComponent(typeof(AudioSource))]

public class AnimationFunctions : MonoBehaviour
{
    public List<AnimationSFX> SFX;
    public List<ParticleSystem> VFX;
    public List<AnimationObject> Objects;
    public List<AnimationMessage> Messages;

    float LastPitch = 1;

    GameManager GM;
    AudioSource LocalAudio;
    ac_ObjectPool ObjectPool;

    void Start()
    {
        GM = GameManager.GM;
        LocalAudio = GetComponent<AudioSource>();
        ObjectPool = GameManager.GM.GetComponent<ac_ObjectPool>();

        LastPitch = LocalAudio.pitch;
    }
    void Update()
    {
        LocalAudio.pitch = LastPitch * Time.timeScale;
    }

    public void PlaySoundEffect(int SoundID)
    {
        if (Random.Range(0f, 100f) <= SFX[SoundID].ChanceToPlay)
        {
            if (ObjectPool == null)
            {
                ObjectPool = GameManager.GM.GetComponent<ac_ObjectPool>();
            }
            AudioRange Audio = ObjectPool.GetObject("GlobalSoundEffect").GetComponent<AudioRange>();
            Audio.transform.position = transform.position;
            Audio.SetPlay(SFX[SoundID].SFX[Random.Range(0, SFX[SoundID].SFX.Count)], Random.Range(SFX[SoundID].SFXRange.x, SFX[SoundID].SFXRange.y), SFX[SoundID].SFXVolume);
        }
    }
    public void PlayLocalSoundEffect(int SoundID)
    {
        if (Random.Range(0f, 100f) <= SFX[SoundID].ChanceToPlay)
        {
            if (LocalAudio == null)
            {
                LocalAudio = GetComponent<AudioSource>();
            }
            LastPitch = Random.Range(SFX[SoundID].SFXRange.x, SFX[SoundID].SFXRange.y);
            LocalAudio.pitch = LastPitch;
            LocalAudio.clip = SFX[SoundID].SFX[Random.Range(0, SFX[SoundID].SFX.Count)];
            LocalAudio.volume = SFX[SoundID].SFXVolume;

            LocalAudio.Play();
        }
    }
    public void PlayVisualEffect(int EffectID)
    {
        VFX[EffectID].Play();
    }
    public void StopVisualEffect(int EffectID)
    {
        VFX[EffectID].Stop();
    }
    public void SpawnObject(int ObjectID)
    {
        GameObject SpawnedObject = Instantiate(Objects[ObjectID].ObjectPrefabs[Random.Range(0, Objects[ObjectID].ObjectPrefabs.Count)]);
        SpawnedObject.transform.position = Objects[ObjectID].ObjectTransform.position;
    }
    public void SendMessage(int MessageID)
    {
        Messages[MessageID].Receiver.SendMessage(Messages[MessageID].MessageToSend, SendMessageOptions.DontRequireReceiver);
    }
    public void SmallShake()
    {
        CameraShaker.Instance.DefaultRotInfluence = new Vector3(1, 0.5f, 1);
        CameraShaker.Instance.ShakeOnce(4.5f, 5f, 0.1f, 0.25f);
        CameraShaker.Instance.ResetCamera();
    }
    public void MediumShake()
    {
        CameraShaker.Instance.DefaultRotInfluence = new Vector3(1, 0.5f, 1);
        CameraShaker.Instance.ShakeOnce(6.5f, 5, 0.1f, 0.5f);
        CameraShaker.Instance.ResetCamera();
    }
    public void RoughShake()
    {
        CameraShaker.Instance.DefaultRotInfluence = new Vector3(1, 0.5f, 1);
        CameraShaker.Instance.ShakeOnce(9f, 6f, 0.1f, 0.75f);
        CameraShaker.Instance.ResetCamera();
    }
}
[System.Serializable]
public class AnimationSFX
{
    public string SFXHandle;

    [Range(0f, 100f)]
    public float ChanceToPlay = 100f;
    public float SFXVolume = 1;
    public Vector2 SFXRange;
    public List<AudioClip> SFX;
}
[System.Serializable]
public class AnimationObject
{
    public string ObjectHandle;

    public Transform ObjectTransform;
    public List<GameObject> ObjectPrefabs;
}
[System.Serializable]
public class AnimationMessage
{
    public string MessageToSend;
    public GameObject Receiver;
}