using UnityEngine;

public class GTTOD_ValariProjectile : MonoBehaviour
{
	public float Damage;

	public float Speed;

	public float Range;

	[Range(1f, 10f)]
	public int Bounces;

	public GameObject HitObject;

	private GameObject TargetDamageObject;

	private Transform Target;

	private Transform Player;

	private Transform PlayerCamera;

	private GameManager GM;

	private InventoryScript Inventory;

	private GTTOD_AIManager AIManager;

	private float MinimumDistance;

	private bool HitMidpoint;

	private bool Moving;

	private Vector3 MidPoint;

	private Vector3 AdjustedMidpoint;

	private void Start()
	{
	}

	private void FindTarget()
	{
	}

	private void Update()
	{
	}
}
