using UnityEngine;
using Random = UnityEngine.Random;

public class PackageSpawner : MonoBehaviour {
    [SerializeField] Transform[] points;
    [SerializeField] SpriteRenderer packageTemplate;
    [SerializeField] SpriteRenderer customerTemplate;
    [SerializeField] Delivery delivery;

    void Awake() {
        delivery.Happened += OnPackageDelivered;
        SpawnPackageAndCustomer();
    }

    void SpawnPackageAndCustomer(Vector3? lastCustomer = null) {
        var packagePosition = RandomPosition(lastCustomer);
        var customerPosition = RandomPosition(packagePosition);
        var color = Random.ColorHSV();
        PlaceInstance(packageTemplate, packagePosition);
        PlaceInstance(customerTemplate, customerPosition);

        void PlaceInstance(SpriteRenderer template, Vector3 position) {
            var instance = Instantiate(template, position, Quaternion.identity);
            instance.color = color;
            instance.gameObject.SetActive(true);
        }
    }

    void OnPackageDelivered(Vector3 customerPosition) {
        SpawnPackageAndCustomer(customerPosition);
    }

    Vector3 RandomPosition(Vector3? except = null) {
        var position = Position();
        while (position == except) {
            position = Position();
        }

        return position;

        Vector3 Position() {
            var random = Random.Range(0, points.Length);
            return points[random].position;
        }
    }
}
