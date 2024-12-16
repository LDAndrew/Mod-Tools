using UnityEngine;

public class ac_BodyController : MonoBehaviour
{
	public ac_CharacterController CharacterController;

	public Animator BodyController;

	public Transform WeaponRoot;

	public SkinnedMeshRenderer Mesh;

	private GameManager GM;

	private ac_CutsceneManager Cutscenes;

	private InventoryScript Inventory;

	private GTTOD_Manager Manager;

	private bool Animating;

	private bool Frozen;

	private string LastAnimation;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Animate(string AnimationName)
	{
	}

	public void EndAnimation()
	{
	}
}
