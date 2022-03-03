using System;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class CrashDetection : MonoBehaviour {
    public event Action PlayerCrashed = delegate { };

    ParticleSystem particles = null!;
    new AudioSource audio = null!;

    void Awake() {
        particles = GetComponentInChildren<ParticleSystem>();
        audio = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D trigger) {
        if (!trigger.CompareTag("Ground")) {
            return;
        }

        particles.Play();
        audio.Play();
        PlayerCrashed();
    }
}
