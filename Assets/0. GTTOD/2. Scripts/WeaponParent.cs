using UnityEngine;

public class WeaponParent : MonoBehaviour
{
	public LayerMask PotentialLayers;

	public GroundMaterials Footsteps;

	public bool ShouldStep;

	private GameManager GM;

	private ac_CharacterController CharacterController;

	private GTTOD_Inventory InventoryManager;

	private GameObject Player;

	private Animator Anim;

	private bool Active;

	private void Start()
	{
	}

	public void ShakeWeapon(float BlendAmount)
	{
	}

	public void Step()
	{
	}

	private void PlayStepSFX()
	{
	}
}
