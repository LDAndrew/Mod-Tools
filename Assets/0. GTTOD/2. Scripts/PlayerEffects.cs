using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PlayerEffects : MonoBehaviour
{
	[Header("PARTICLES")]
	public PlayerVFX SlideVFX;

	public ParticleSystem UnderwaterEffects;

	public ParticleSystem HealEffects;

	public ParticleSystem WindEffects;

	public ParticleSystem LandEffect;

	public ParticleSystem HeavyLandEffect;

	public ParticleSystem SuddenStop;

	public ParticleSystem LightSnow;

	public ParticleSystem Blizard;

	public ParticleSystem UltimateCharge;

	[Header("STATUS EFFECT PARTICLES")]
	public ParticleSystem BurnVFX;

	public ParticleSystem StaticVFX;

	public CanvasGroup WeaknessVFX;

	public FrostEffect FrostVFX;

	[Header("CAMERA EFFECTS")]
	public PostProcessVolume PostProcessor;

	public WaterCamera WaterCam;

	public List<Color> EdgeColors;

	[Header("AUDIO EFFECTS")]
	public AudioSource SpeedWindSFX;

	public AudioLowPassFilter LowPassFilter;

	public List<AudioClip> SFX;

	[Header("MISC EFFECTS")]
	public Transform ScanEffect;

	[HideInInspector]
	public float CurrentFrostAmount;

	[HideInInspector]
	public bool Weak;

	[HideInInspector]
	public int CurrentEdgeColor;

	private ac_CharacterController CharacterController;

	private ac_DevConsole DeveloperConsole;

	private GTTOD_AIManager AIManager;

	private GTTOD_Manager Manager;

	private GTTOD_HUD HUDManager;

	private SustainedShake CameraShake;

	private AudioSource Audio;

	private LensDistortion LensDistortionEffect;

	private Transform PlayerCamera;

	private Rigidbody PlayerPhysics;

	private Vector3 Velocity;

	private Vector3 Direction;

	private Vector3 LastPosition;

	private Color EdgeColor;

	private float Strength;

	private float Dash;

	private float DashLength;

	private float DistortionSpeed;

	private float ScanSize;

	private bool Underwater;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void BumpEffects(float BumpAmount)
	{
	}

	public void BumpDash(float BumpAmount, float BumpSpeed)
	{
	}

	public void BumpDistortion(float BumpAmount, float BumpSpeed)
	{
	}

	public void PlayScanEffect()
	{
	}

	public void EndScan()
	{
	}

	public void PlayLandEffect()
	{
	}

	public void SetEdgeColor(int Index)
	{
	}

	public void PlayHeavyLandEffect()
	{
	}

	public void PlaySuddenStop()
	{
	}

	public void SetEffects(float SetAmount)
	{
	}

	public void ToggleWater(bool Toggle)
	{
	}
}
