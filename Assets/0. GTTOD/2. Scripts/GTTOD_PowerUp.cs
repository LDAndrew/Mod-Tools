using UnityEngine;

public class GTTOD_PowerUp : MonoBehaviour
{
	public enum PowerUpType
	{
		DoublePoints,
		QuadDamage,
		RapidFire,
		Overcharge,
		AmmoBag,
		MoneyBag,
		Obliterate,
		AmmoCrate,
		ExtraLife
	}

	public PowerUpType PowerUp;

	public bool ShouldDestroy;

	[ConditionalField("ShouldDestroy", null)]
	public float DestroyTime;

	public GameObject BigCollectEffect;

	public GameObject SmallCollectEffect;

	public string CollectMessage;

	public bool BigEffect;

	private GameManager GM;

	private GTTOD_UpgradesManager Upgrades;

	private PlayerEffects Effects;

	private GTTOD_HUD HUD;

	private Transform Player;

	private float ParticleScale;

	private bool HasPickedUp;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void PickUp()
	{
	}
}
