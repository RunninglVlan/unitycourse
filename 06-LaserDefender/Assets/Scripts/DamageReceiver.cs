using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DamageReceiver : MonoBehaviour
{

    [SerializeField] GameObject explosionPrefab;
    [SerializeField] float explosionDuration = 1;

    [SerializeField] protected int health = 100;

    private SoundFxPlayer soundFxPlayer;

    protected virtual void Start()
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
        onHit();
        if (health <= 0)
        {
            playVfxAndDestroy();
            onDeath();
        }
        else
        {
            soundFxPlayer.damage();
        }
        damageDealer.hit();
    }

    protected virtual void onHit()
    {

    }

    private void playVfxAndDestroy()
    {
        var explosion = Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        Destroy(explosion, explosionDuration);
        soundFxPlayer.explosion();
        Destroy(gameObject);
    }

    protected virtual void onDeath()
    {

    }
}
