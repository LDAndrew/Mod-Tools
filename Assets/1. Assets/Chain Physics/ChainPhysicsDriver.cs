using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainPhysicsDriver : MonoBehaviour
{
    public GameObject chainRoot;
    private List<Rigidbody> rigidbodies = new List<Rigidbody>();
    private Dictionary<Rigidbody, Vector3> initialLocalPositions = new Dictionary<Rigidbody, Vector3>();
    private Dictionary<Rigidbody, Quaternion> initialLocalRotations = new Dictionary<Rigidbody, Quaternion>();

    void Awake()
    {
        if (chainRoot != null)
        {
            rigidbodies.AddRange(chainRoot.GetComponentsInChildren<Rigidbody>(true));
            foreach (var rb in rigidbodies)
            {
                initialLocalPositions[rb] = rb.transform.localPosition;
                initialLocalRotations[rb] = rb.transform.localRotation;
            }
        }
    }

    void OnDisable()
    {
        chainRoot.SetActive(false);
    }

    void OnEnable()
    {
        StartCoroutine(EnableChain());
    }

    IEnumerator EnableChain()
    {
        ResetRigidbodies();
        yield return new WaitForSeconds(0.1f);
        chainRoot.SetActive(true);
    }

    private void ResetRigidbodies()
    {
        foreach (var rb in rigidbodies)
        {
            if (initialLocalPositions.TryGetValue(rb, out var position))
            {
                rb.transform.localPosition = position;
            }
            if (initialLocalRotations.TryGetValue(rb, out var rotation))
            {
                rb.transform.localRotation = rotation;
            }
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
}
