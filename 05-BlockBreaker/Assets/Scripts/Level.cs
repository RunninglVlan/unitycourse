using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{

    [SerializeField] int breakableBlocks;

    public void addBreakableBlock()
    {
        breakableBlocks++;
    }

    public void removeBreakableBlock()
    {
        breakableBlocks--;
        if (breakableBlocks <= 0)
        {
            FindObjectOfType<SceneLoader>().nextScene();
        }
    }
}
