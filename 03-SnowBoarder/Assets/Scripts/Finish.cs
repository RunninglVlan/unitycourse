using System;
using UnityEngine;

public class Finish : MonoBehaviour {
    public event Action PlayerReached = delegate { };

    void OnTriggerEnter2D(Collider2D trigger) {
        if (trigger.CompareTag("Player")) {
            PlayerReached();
        }
    }
}
