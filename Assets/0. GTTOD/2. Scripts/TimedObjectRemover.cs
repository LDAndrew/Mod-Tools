using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedObjectRemover : MonoBehaviour
{
    public float DestroyTime = 1;
    void Start()
    {
        Destroy(gameObject, DestroyTime);
    }
}