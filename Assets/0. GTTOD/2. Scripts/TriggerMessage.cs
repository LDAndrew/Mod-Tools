using UnityEngine;

public class TriggerMessage : MonoBehaviour
{
	public GameObject MessageReciever;

	public string MessageToSend;

	public bool RepeatMessage;

	private bool HasSentMessage;

	private void OnTriggerEnter(Collider Col)
	{
	}

	private void OnTriggerExit(Collider Col)
	{
	}
}
