using System;
using UnityEngine;

public class Finish : MonoBehaviour {
    public event Action PlayerReached = delegate { };

    ParticleSystem particles = null!;

    void Awake() => particles = GetComponentInChildren<ParticleSystem>();

    void OnTriggerEnter2D(Collider2D trigger) {
        if (!trigger.CompareTag("Player")) {
            return;
        }

        particles.Play();
        PlayerReached();
    }
}
