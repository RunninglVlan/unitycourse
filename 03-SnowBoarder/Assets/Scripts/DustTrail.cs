using UnityEngine;

public class DustTrail : MonoBehaviour {
    ParticleSystem particles = null!;

    void Awake() => particles = GetComponentInChildren<ParticleSystem>();

    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Ground")) {
            particles.Play();
        }
    }

    void OnCollisionExit2D(Collision2D other) {
        if (other.gameObject.CompareTag("Ground")) {
            particles.Stop();
        }
    }
}
