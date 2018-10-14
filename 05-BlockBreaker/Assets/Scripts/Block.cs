using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{

    [SerializeField] AudioClip breakSound;

    void Start()
    {
        FindObjectOfType<Level>().addBreakableBlock();
    }

    void OnCollisionEnter2D(Collision2D _)
    {
        AudioSource.PlayClipAtPoint(breakSound, Camera.main.transform.position);
        Destroy(gameObject);
    }
}
