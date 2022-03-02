using System;
using UnityEngine;

public class Delivery : MonoBehaviour {
    [SerializeField] Vector3 packagePosition;
    [SerializeField] Vector3 packageScale;

    public event Action<Vector3> PackagePickedUp = delegate { };
    public event Action<Vector3> PackageDelivered = delegate { };

    SpriteRenderer? package;

    void Awake() => package = null;

    void OnTriggerEnter2D(Collider2D trigger) {
        switch (package) {
            case null when trigger.CompareTag("Package"):
                PackagePickedUp(trigger.transform.position);
                PlacePackage(trigger);
                break;
            case not null when trigger.CompareTag("Customer"):
                Destroy(package!.gameObject);
                package = null;
                Destroy(trigger.gameObject);
                PackageDelivered(trigger.transform.position);
                break;
        }

        void PlacePackage(Collider2D newPackage) {
            package = newPackage.GetComponent<SpriteRenderer>();
            var packageTransform = package.transform;
            packageTransform.parent = transform;
            packageTransform.localPosition = packagePosition;
            packageTransform.localRotation = Quaternion.identity;
            packageTransform.localScale = packageScale;
            package.sortingOrder = 3;
        }
    }
}
