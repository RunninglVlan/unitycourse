using System;
using UnityEngine;

public class CrashDetection : MonoBehaviour {
    public event Action PlayerCrashed = delegate { };

    ParticleSystem particles = null!;

    void Awake() => particles = GetComponentInChildren<ParticleSystem>();

    void OnTriggerEnter2D(Collider2D trigger) {
        if (!trigger.CompareTag("Level")) {
            return;
        }

        particles.Play();
        PlayerCrashed();
    }
}
