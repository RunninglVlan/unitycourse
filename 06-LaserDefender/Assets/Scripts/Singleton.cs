using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Singleton : MonoBehaviour
{

    void Awake()
    {
        ensureSingleton();
    }

    private void ensureSingleton()
    {
        var objectsOfCurrentType = FindObjectsOfType(GetType()).Where(it => it.GetType() == GetType());
        if (objectsOfCurrentType.Count() > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
