using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager GM;
    void Awake()
    {
        if (GameManager.GM != null && GameManager.GM != this)
        {
            Destroy(GameManager.GM.gameObject);
        }
        GM = this;
    }
}
