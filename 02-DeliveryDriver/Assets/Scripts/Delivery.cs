using System;
using UnityEngine;

public class Delivery : MonoBehaviour {
    public event Action<Vector3> PackagePickedUp = delegate { };
    public event Action<Vector3> PackageDelivered = delegate { };

    bool hasPackage;

    void OnTriggerEnter2D(Collider2D trigger) {
        switch (hasPackage) {
            case false when trigger.CompareTag("Package"):
                Destroy(trigger.gameObject);
                PackagePickedUp(trigger.transform.position);
                hasPackage = true;
                break;
            case true when trigger.CompareTag("Customer"):
                Destroy(trigger.gameObject);
                PackageDelivered(trigger.transform.position);
                hasPackage = false;
                break;
        }
    }
}
