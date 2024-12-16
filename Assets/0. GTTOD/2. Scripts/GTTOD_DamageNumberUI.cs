using UnityEngine;
using UnityEngine.UI;

public class GTTOD_DamageNumberUI : MonoBehaviour
{
	public Text DamageText;

	public Gradient DamageGradient;

	public Gradient OutlineGradient;

	private Animator Anim;

	private UnityEngine.UI.Outline Outline;

	private float Scale;

	private void Start()
	{
	}

	public void PlayDamage(float DamagePercentage, float AdjustedDamage)
	{
	}
}
