using System.Collections.Generic;
using UnityEngine;

public class DissolveScript : MonoBehaviour
{
	public List<Material> DissolveMaterials;

	[Range(0f, 1f)]
	public float DissolveRange;

	private void Update()
	{
	}
}
