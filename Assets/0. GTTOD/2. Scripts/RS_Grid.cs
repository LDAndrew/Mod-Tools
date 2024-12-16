using UnityEngine;

public class RS_Grid : MonoBehaviour
{
	public enum WallType
	{
		Wall,
		Fence,
		Barricade
	}

	public WallType Wall;

	public float WallChance;

	private RS_GridManager Manager;

	private int WallIndex;

	public void SetUpGrid(RS_GridManager NewManager)
	{
	}

	public void Damage(float Damage)
	{
	}
}
