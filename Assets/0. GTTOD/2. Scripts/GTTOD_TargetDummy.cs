using UnityEngine;

public class GTTOD_TargetDummy : MonoBehaviour
{
	public string DummyName;

	public float Health;

	public bool Shield;

	private GameManager GM;

	private GTTOD_UpgradesManager UpgradesManager;

	private GTTOD_AIManager AIManager;

	private GTTOD_HUD HUDManager;

	private float MaxHealth;

	private void Start()
	{
	}

	public void Damage(float Damage)
	{
	}
}
