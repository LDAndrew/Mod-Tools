using System.Collections.Generic;
using UnityEngine;

public class GTTOD_SentinelBlade : MonoBehaviour
{
	public enum BladeAIType
	{
		SeekerBlade,
		SinkerBlade,
		ShieldBlade
	}

	public LayerMask WorldLayer;

	public LayerMask PlayerLayer;

	public string Name;

	public string SillyName;

	[Header("BLADE SETTINGS")]
	public BladeAIType BladeType;

	public float BladeDamage;

	[Header("BLADE OBJECTS")]
	public GameObject BladeSentinel;

	public Transform ShieldPoint;

	public GameObject HitEffect;

	public GameObject MissEffect;

	public GameObject DrawEffect;

	public GameObject AOEEffect;

	public GameObject DeflectEffect;

	public GameObject HitBox;

	public ParticleSystem AttackParticles;

	public ParticleSystem ZoneParticles;

	public List<AudioClip> SoundEffects;

	[HideInInspector]
	public bool Active;

	[HideInInspector]
	public List<Transform> Points;

	private GameManager GM;

	private GTTOD_UpgradesManager Upgrades;

	private GTTOD_AIManager AIManager;

	private GTTOD_HUD PlayerHUD;

	private AudioSource Audio;

	private LensFlare Flare;

	private Transform Parent;

	private Transform Blade;

	private Transform Player;

	private Vector3 Target;

	private Vector3 AttackPoint;

	private Quaternion Down;

	private RaycastHit Hit;

	private float Speed;

	private float Distance;

	private float AttackTime;

	private float Health;

	private bool Attacking;

	private bool Resetting;

	private bool HasHit;

	private bool Embedded;

	private bool HasPoint;

	private string AdjustedName;

	private GameObject[] TemppPoints;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Damage(float Damage)
	{
	}

	public void Activate(BladeAIType Type)
	{
	}

	public void ResetBlade()
	{
	}

	public void DeactivateBlade()
	{
	}

	public void PlayAudio(int Index)
	{
	}
}
