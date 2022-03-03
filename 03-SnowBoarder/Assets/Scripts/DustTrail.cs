using UnityEngine;

public class DustTrail : MonoBehaviour {
    ParticleSystem particles = null!;
    [SerializeField] CrashDetection crashDetection = null!;

    void Awake() {
        particles = GetComponentInChildren<ParticleSystem>();
        crashDetection.PlayerCrashed += DisableParticles;
    }

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

    void DisableParticles() => particles.gameObject.SetActive(false);
}
