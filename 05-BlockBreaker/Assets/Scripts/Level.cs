using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    private SceneLoader sceneLoader;
    private int breakableBlocks;

    void Start()
    {
        sceneLoader = FindObjectOfType<SceneLoader>();
    }

    public void addBreakableBlock()
    {
        breakableBlocks++;
    }

    public void removeBreakableBlock()
    {
        breakableBlocks--;
        if (breakableBlocks <= 0)
        {
            sceneLoader.nextScene();
        }
    }
}
