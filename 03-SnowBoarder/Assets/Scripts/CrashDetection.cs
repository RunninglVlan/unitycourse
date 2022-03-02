using System;
using UnityEngine;

public class CrashDetection : MonoBehaviour {
    public event Action PlayerCrashed = delegate { };

    void OnTriggerEnter2D(Collider2D trigger) {
        if (trigger.CompareTag("Level")) {
            PlayerCrashed();
        }
    }
}
