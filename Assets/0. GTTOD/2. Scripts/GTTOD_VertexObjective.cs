using UnityEngine;

public class GTTOD_VertexObjective : MonoBehaviour
{
	public enum ObjectiveTypes
	{
		BlankObjective,
		CommandPost,
		CentralOutpost,
		ObjectiveOutpost
	}

	[Range(-1f, 1f)]
	public float CaptureAmount;

	public ObjectiveTypes ObjectiveType;

	public GTTOD_VertexManager VertexManager;

	public Transform FocusPoint;

	public float ObjectiveRadius;

	private float CheckTime;

	private bool Capturing;

	private bool PlayerCapturing;

	private int PlayerUnitsInRange;

	private int OpponentUnitsInRange;

	private void OnDrawGizmosSelected()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}
}
