using UnityEngine;

public class HealZone : MonoBehaviour
{
	public float HealRadius;

	public float HealAmount;

	public float HealDelay;

	public int HealCount;

	public bool DestroyOnEmpty;

	public bool Overcharge;

	public bool SpeedBoost;

	private Transform Player;

	private GTTOD_HealthScript Health;

	private GTTOD_UpgradesManager Upgrades;

	private float HealTime;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
