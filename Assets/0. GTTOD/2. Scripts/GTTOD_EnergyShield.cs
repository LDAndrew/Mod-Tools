using System.Collections.Generic;
using UnityEngine;

public class GTTOD_EnergyShield : MonoBehaviour
{
	public GTTOD_Enemy Enemy;

	[Header("SHIELD SETTINGS")]
	public float ShieldHealth;

	public float ShieldRegenTime;

	public GameObject ShieldBreakObject;

	[Header("SHIELD PROPERTIES")]
	public SkinnedMeshRenderer EnergyShieldMesh;

	public Transform EnergyShieldHealthPosition;

	public Vector2 ShieldSizeRange;

	public float OffsetSpeed;

	public bool StaggerBreaksShield;

	[Header("SHIELD OBJECTS")]
	public List<GameObject> EnableObjects;

	public List<GameObject> DisabledObjects;

	private GameManager GM;

	private GTTOD_HUD HUD;

	private GTTOD_AIManager AIManager;

	private GTTOD_UpgradesManager Upgrades;

	private Material EnergyShieldMaterial;

	private float MaximumHealth;

	private float TimeToRegen;

	private float Opacity;

	private float Offset;

	private bool ShieldDead;

	private bool ShieldActive;

	private bool Buffed;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Stagger(float StaggerDamage)
	{
	}

	public void ShieldDamage(float DamageAmount)
	{
	}

	public void KillShield(float StaggerDistance, float BonusDamage)
	{
	}

	public void BuffEnemy()
	{
	}

	public void ReviveShield(float MaxHealth)
	{
	}
}
