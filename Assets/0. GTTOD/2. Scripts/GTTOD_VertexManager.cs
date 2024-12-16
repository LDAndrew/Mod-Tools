using System.Collections.Generic;
using UnityEngine;

public class GTTOD_VertexManager : MonoBehaviour
{
	[Header("VERTEX VARIABLES")]
	public int UnitLimit;

	public List<GTTOD_VertexObjective> Objectives;

	public List<GTTOD_VertexUnit> Units;

	[Header("PLAYER VARIABLES")]
	public int PlayerVerts;

	public int SelectedPlayerUnit;

	public int SelectedPlayerObjective;

	public List<Transform> PlayerSpawnPoints;

	public List<GTTOD_VertexUnit> ActivePlayerUnits;

	[Header("OPPONENT VARIABLES")]
	public int OpponentVerts;

	public int SelectedOpponentUnit;

	public int SelectedOpponentObjective;

	public List<Transform> OpponentSpawnPoints;

	public List<GTTOD_VertexUnit> ActiveOpponentUnits;

	private Transform Player;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void SpawnUnit(bool PlayerSpawn)
	{
	}

	public Transform GetClosestSpawn(Transform[] Points, Transform FocusPoint)
	{
		return null;
	}

	public Transform GetClosestTarget(GTTOD_VertexUnit SelectedUnit)
	{
		return null;
	}
}
