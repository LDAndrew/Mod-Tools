using UnityEngine;

public class GTTOD_Lock : MonoBehaviour
{
	public string LockName;

	public GameObject ObjectToUnlock;

	public GameObject DeadLock;

	public string UnlockMessage;

	public int KeysRequired;

	private GTTOD_Interactable Interactable;

	private GTTOD_Inventory Inventory;

	private GTTOD_Manager Manager;

	private GTTOD_HUD HUDManager;

	private AudioSource Audio;

	private Animator Anim;

	private bool Unlocked;

	private void Start()
	{
	}

	public void TryUnlock()
	{
	}

	public void UnlockObject()
	{
	}
}
