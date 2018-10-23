﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageReceiver : MonoBehaviour
{

    [SerializeField] int health = 100;

    void OnTriggerEnter2D(Collider2D other)
    {
        var damageDealer = other.GetComponent<DamageDealer>();
        if (tag != damageDealer?.tag)
        {
            getHitBy(damageDealer);
        }
    }

    private void getHitBy(DamageDealer damageDealer)
    {
        health -= damageDealer.damageDealt();
        if (health <= 0)
        {
            Destroy(gameObject);
        }
        damageDealer.hit();
    }
}
