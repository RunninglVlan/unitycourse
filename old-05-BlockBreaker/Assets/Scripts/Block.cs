using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{

    [SerializeField] AudioClip breakSound;
    [SerializeField] GameObject sparklesEffect;
    [SerializeField] Sprite[] hitSprites;

    private Level level;

    private int currentHits = 0;

    void Start()
    {
        level = FindObjectOfType<Level>();
        if (tag == "Breakable")
        {
            level.addBreakableBlock();
        }
    }

    void OnCollisionEnter2D(Collision2D _)
    {
        if (tag == "Breakable")
        {
            hitBlock();
        }
    }

    private void hitBlock()
    {
        currentHits++;
        var maxHits = hitSprites.Length + 1;
        if (currentHits >= maxHits)
        {
            destroyBlock();
        }
        else
        {
            showNextHitSprite();
        }
    }

    private void showNextHitSprite()
    {
        var spriteIndex = currentHits - 1;
        GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
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
