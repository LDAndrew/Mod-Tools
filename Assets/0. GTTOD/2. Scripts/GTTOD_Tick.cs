using UnityEngine;
using UnityEngine.AI;

public class GTTOD_Tick : MonoBehaviour
{
	public LayerMask PotentialLayers;

	public Vector2 EnemyRefreshRate;

	public Vector2 ScaleRange;

	public Vector2 TargetRange;

	public float DigTime;

	private GameManager GM;

	private Respawner EnemyRespawner;

	private GTTOD_Enemy EnemyBase;

	private NavMeshAgent Agent;

	private Transform Target;

	private float CrumbTime;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Interrupt()
	{
	}

	public void RemoveTick()
	{
	}
}
