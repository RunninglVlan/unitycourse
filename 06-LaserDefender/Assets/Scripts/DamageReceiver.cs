using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageReceiver : MonoBehaviour
{

    [SerializeField] GameObject explosionPrefab;
    [SerializeField] float explosionDuration = 1;

    [SerializeField] int health = 100;

    void OnTriggerEnter2D(Collider2D other)
    {
        var damageDealer = other.GetComponent<DamageDealer>();
        getHitBy(damageDealer);
    }

    private void getHitBy(DamageDealer damageDealer)
    {
        health -= damageDealer.damageDealt();
        if (health <= 0)
        {
            playVfxAndDestroy();
        }
        damageDealer.hit();
    }

    private void playVfxAndDestroy()
    {
        var explosion = Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        Destroy(explosion, explosionDuration);
        Destroy(gameObject);
    }
}
