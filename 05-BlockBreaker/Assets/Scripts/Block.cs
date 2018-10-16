using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{

    [SerializeField] AudioClip breakSound;
    [SerializeField] GameObject sparklesEffect;

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
        playEffects();
        level.removeBreakableBlock();
        FindObjectOfType<GameSession>().increaseScore();
        Destroy(gameObject);
    }

    private void playEffects()
    {
        AudioSource.PlayClipAtPoint(breakSound, Camera.main.transform.position);
        GameObject sparkles = Instantiate(sparklesEffect, transform.position, transform.rotation);
        Destroy(sparkles, 1);
    }
}
