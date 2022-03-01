using UnityEngine;

public class Delivery : MonoBehaviour {
    bool hasPackage;

    void OnCollisionEnter2D(Collision2D _) {
        Debug.Log("Ouch!");
    }

    void OnTriggerEnter2D(Collider2D trigger) {
        switch (hasPackage) {
            case false when trigger.CompareTag("Package"):
                Debug.Log("Picked up the package");
                hasPackage = true;
                break;
            case true when trigger.CompareTag("Customer"):
                Debug.Log("Delivered package to the customer");
                hasPackage = false;
                break;
        }
    }
}
