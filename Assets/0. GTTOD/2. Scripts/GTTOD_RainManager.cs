using System.Collections.Generic;
using UnityEngine;

public class GTTOD_RainManager : MonoBehaviour
{
	public bool HeavyRain;

	[ConditionalField("HeavyRain", null)]
	public ParticleSystem LightningParticle;

	[ConditionalField("HeavyRain", null)]
	public Transform LightningPointsParent;

	[ConditionalField("HeavyRain", null)]
	public Vector2 LightningIntensityRange;

	[ConditionalField("HeavyRain", null)]
	public Vector2 LightningTimeRange;

	[ConditionalField("HeavyRain", null)]
	public float ThunderChance;

	public ParticleSystem RainParticles;

	public float RainHeight;

	public List<GameObject> Audio;

	[HideInInspector]
	public List<Transform> LightningPoints;

	private float LightningTime;

	private GameManager GM;

	private Transform Player;

	private ParticleSystem.MainModule RainModule;

	private Light WorldLight;

	private AudioSource RainAudio;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void PlayThunder()
	{
	}
}
