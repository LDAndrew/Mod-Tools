using UnityEngine;

public class RecallObject : MonoBehaviour
{
	public string MessageToSendOnRecall;

	public bool DestroyAfterRecall;

	[ConditionalField("DestroyAfterRecall", null)]
	public new GameObject DestroyObject;

	private GameObject Sender;

	private bool HasRecalled;

	public void RegisterSender(GameObject NewSender)
	{
	}

	public void Recall()
	{
	}
}
