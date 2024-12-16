using UnityEngine;

public class GTTOD_K8 : MonoBehaviour
{
	public Animator ShopDoors;

	public GameObject Interaction;

	public Vector2 QuipRange;

	public float ActiveDistance;

	public float CloseDistance;

	private Animator Anim;

	private Transform Player;

	private GTTOD_Story Story;

	private GTTOD_Manager Manager;

	private bool IsActive;

	private bool PoweredOn;

	private bool DoorOpen;

	private float QuipTime;

	private float ActiveCheckTime;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void TriggerIdleAnimation()
	{
	}

	public void PowerOn()
	{
	}

	public void PowerOff()
	{
	}

	public void Quip()
	{
	}
}
