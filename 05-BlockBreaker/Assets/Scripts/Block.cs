using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{

    [SerializeField] AudioClip breakSound;

    Level level;

    void Start()
    {
        level = FindObjectOfType<Level>();
        level.addBreakableBlock();
    }

    void OnCollisionEnter2D(Collision2D _)
    {
        destroyBlock();
    }

    private void destroyBlock()
    {
        AudioSource.PlayClipAtPoint(breakSound, Camera.main.transform.position);
        level.removeBreakableBlock();
        FindObjectOfType<GameSession>().increaseScore();
        Destroy(gameObject);
    }
}
