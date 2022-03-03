using System;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Finish : MonoBehaviour {
    public event Action PlayerReached = delegate { };

    ParticleSystem particles = null!;
    new AudioSource audio = null!;

    void Awake() {
        particles = GetComponentInChildren<ParticleSystem>();
        audio = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D trigger) {
        if (!trigger.CompareTag("Player")) {
            return;
        }

        particles.Play();
        audio.Play();
        PlayerReached();
    }
}
