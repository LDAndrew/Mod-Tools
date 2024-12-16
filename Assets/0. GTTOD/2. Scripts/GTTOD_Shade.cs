using UnityEngine;

public class GTTOD_Shade : MonoBehaviour
{
	public bool Elite;

	[ConditionalField("Elite", null)]
	public Transform EliteZone;

	[ConditionalField("Elite", null)]
	public float EliteEffectRange;

	public bool Friendly;

	public Vector2 EnemyRefreshRate;

	public Vector2 TargetRange;

	public Vector2 ScaleRange;

	public GameObject BuffObject;

	public Transform AttackPoint;

	public float AttackDistance;

	public float AttackLength;

	public float AttackDamage;

	private GTTOD_AIManager AIManager;

	private GTTOD_Enemy EnemyBase;

	private GTTOD_HealthScript PlayerHealth;

	private Transform Target;

	private Transform Player;

	private float CrumbTime;

	private float EliteInvincibleTime;

	private float EliteAdjustedZone;

	private float AttackTime;

	private float CheckTime;

	private int TargetLocks;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void FindNewTarget()
	{
	}

	public void TriggerAttack()
	{
	}

	public void TriggerBuff()
	{
	}
}
