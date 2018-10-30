using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageReceiver : MonoBehaviour
{

    [SerializeField] GameObject explosionPrefab;
    [SerializeField] float explosionDuration = 1;

    [SerializeField] int health = 100;

    private SoundFxPlayer soundFxPlayer;

    void Start()
    {
        soundFxPlayer = FindObjectOfType<SoundFxPlayer>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        var damageDealer = other.GetComponent<DamageDealer>();
        if (damageDealer)
        {
            getHitBy(damageDealer);
        }
    }

    private void getHitBy(DamageDealer damageDealer)
    {
        health -= damageDealer.damageDealt();
        if (health <= 0)
        {
            playVfxAndDestroy();
        }
        else
        {
            soundFxPlayer.damage();
        }
        damageDealer.hit();
    }

    private void playVfxAndDestroy()
    {
        var explosion = Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        Destroy(explosion, explosionDuration);
        soundFxPlayer.explosion();
        Destroy(gameObject);
    }
}
