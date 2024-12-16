using UnityEngine;

public class RS_HitBox : MonoBehaviour
{
	public GameObject Base;

	public float DamageMultiplier;

	public bool LimbHealth;

	[ConditionalField("LimbHealth", null)]
	public RS_Limb Limb;

	public void Damage(float Damage)
	{
	}
}
