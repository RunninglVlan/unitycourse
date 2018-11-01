using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Singleton : MonoBehaviour
{

    void Awake()
    {
        ensureSingleton();
    }

    private void ensureSingleton()
    {
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
