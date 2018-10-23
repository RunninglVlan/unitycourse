using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] int health = 100;

    void OnTriggerEnter2D(Collider2D other)
    {
        var damageDealer = other.GetComponent<DamageDealer>();
        damageDealer.hit();
        health -= damageDealer.damageDealt();
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
