using UnityEngine;

public class ObjectFreezer : MonoBehaviour
{
    public Transform parentObject;
    private Vector3 relativePosition;
    private Quaternion relativeRotation;

    void Start()
    {
        if (parentObject != null)
        {
            relativePosition = transform.position - parentObject.position;
            relativeRotation = Quaternion.Inverse(parentObject.rotation) * transform.rotation;
        }
    }

    void LateUpdate()
    {
        if (parentObject != null)
        {
            transform.position = parentObject.position + relativePosition;
            transform.rotation = parentObject.rotation * relativeRotation;
        }
    }
}
