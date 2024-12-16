using UnityEngine;
using UnityEngine.EventSystems;

public class MassiveCloudsCameraPad : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
{
	public Transform target;

	[Range(0.01f, 1f)]
	public float sensitivity;

	[SerializeField]
	private float pitch;

	[SerializeField]
	private float yaw;

	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	public void Start()
	{
	}

	public void OnDrag(PointerEventData eventData)
	{
	}

	public void OnEndDrag(PointerEventData eventData)
	{
	}
}
