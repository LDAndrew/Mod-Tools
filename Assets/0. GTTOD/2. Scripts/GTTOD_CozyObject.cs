using UnityEngine;

public class GTTOD_CozyObject : MonoBehaviour
{
	public bool IsObject;

	[ConditionalField("IsObject", null)]
	public GameObject CozyObject;

	private GTTOD_Manager Manager;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
