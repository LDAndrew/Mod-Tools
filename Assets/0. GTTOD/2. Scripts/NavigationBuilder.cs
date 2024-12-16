using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavigationBuilder : MonoBehaviour
{
	public delegate void NavMeshUpdatedEvent(Bounds Bounds);

	public Vector3 NavMeshScale;

	public Vector3 NavMeshPosition;


	public NavMeshUpdatedEvent OnNavMeshUpdate;

	private NavMeshData[] NavMeshDatas;

	private Dictionary<int, List<NavMeshBuildSource>> SourcesPerSurface;

	private Dictionary<int, List<NavMeshBuildMarkup>> MarkupsPerSurface;


	private bool CacheSources;

	private void Awake()
	{
	}

	public void BuildNavMesh(bool Async)
	{
	}

	private void HandleNavMeshUpdate(AsyncOperation Operation)
	{
	}
}
