using UnityEngine;

public class Collision : MonoBehaviour {
    void OnCollisionEnter2D(Collision2D _) {
        Debug.Log("Ouch!");
    }

    void OnTriggerEnter2D(Collider2D _) {
        Debug.Log("Reached the zone");
    }
}
