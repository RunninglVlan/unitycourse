using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{

    [SerializeField] float speed = .5f;

    private Material material;
    private Vector2 offset;

    void Start()
    {
        material = GetComponent<Renderer>().material;
        offset = new Vector2(0, speed);
    }

    void Update()
    {
        material.mainTextureOffset += offset * Time.deltaTime;
    }
}
