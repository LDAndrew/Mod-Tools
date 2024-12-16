using System.Collections.Generic;
using UnityEngine;

public class LevelCreator : MonoBehaviour
{
	public GameObject CurrentCube;

	public List<GameObject> Cubes;

	public Camera LevelCam;

	[SerializeField]
	private int size;

	[SerializeField]
	private int MaxSpaces;

	private int CubeIndex;

	private void Start()
	{
	}

	public Vector3 GetNearestPointOnGrid(Vector3 position)
	{
		return default(Vector3);
	}
}
