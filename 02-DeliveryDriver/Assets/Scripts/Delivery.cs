using System;
using UnityEngine;

public class Delivery : MonoBehaviour {
    public event Action<Vector3> PackagePickedUp = delegate { };
    public event Action<Vector3> PackageDelivered = delegate { };

    bool hasPackage;

    void OnCollisionEnter2D(Collision2D _) {
        Debug.Log("Ouch!");
    }

    void OnTriggerEnter2D(Collider2D trigger) {
        switch (hasPackage) {
            case false when trigger.CompareTag("Package"):
                Debug.Log("Picked up the package");
                Destroy(trigger.gameObject);
                PackagePickedUp(trigger.transform.position);
                hasPackage = true;
                break;
            case true when trigger.CompareTag("Customer"):
                Debug.Log("Delivered package to the customer");
                Destroy(trigger.gameObject);
                PackageDelivered(trigger.transform.position);
                hasPackage = false;
                break;
        }
    }
}
