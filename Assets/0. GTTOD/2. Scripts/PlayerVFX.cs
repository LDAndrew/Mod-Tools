using System;
using UnityEngine;

[Serializable]
public class PlayerVFX
{
	public ParticleSystem VFXParticles;

	public AudioSource VFXAudio;

	public Transform VFXTarget;

	[HideInInspector]
	public bool ParticlePlaying;
}
