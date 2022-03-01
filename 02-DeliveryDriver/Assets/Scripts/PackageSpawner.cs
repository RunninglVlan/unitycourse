using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PackageSpawner : MonoBehaviour {
    [SerializeField] Transform[] points = null!;
    [SerializeField] SpriteRenderer packageTemplate = null!;
    [SerializeField] SpriteRenderer customerTemplate = null!;
    [SerializeField] Delivery delivery = null!;

    readonly List<Vector3> availablePositions = new();

    void Awake() {
        if (points.Length < 2) {
            Debug.LogError("Add more points, there should be at least 2");
            return;
        }

        foreach (var point in points) {
            availablePositions.Add(point.position);
        }

        delivery.PackagePickedUp += OnPackagePickedUp;
        delivery.PackageDelivered += OnPackageDelivered;
        for (var _ = 0; _ < points.Length / 2; _++) {
            SpawnPackageAndCustomer();
        }
    }

    void SpawnPackageAndCustomer() {
        var packagePosition = RandomPosition();
        var customerPosition = RandomPosition();
        var color = Random.ColorHSV();
        PlaceInstance(packageTemplate, packagePosition, color);
        PlaceInstance(customerTemplate, customerPosition, color);
    }

    static void PlaceInstance(SpriteRenderer template, Vector3 position, Color color) {
        var instance = Instantiate(template, position, Quaternion.identity);
        instance.color = color;
        instance.gameObject.SetActive(true);
    }

    void OnPackagePickedUp(Vector3 packagePosition) {
        availablePositions.Add(packagePosition);
    }

    void OnPackageDelivered(Vector3 customerPosition) {
        availablePositions.Add(customerPosition);
        SpawnPackageAndCustomer();
    }

    Vector3 RandomPosition() {
        var position = Position();
        availablePositions.Remove(position);
        return position;

        Vector3 Position() {
            var random = Random.Range(0, availablePositions.Count);
            return availablePositions[random];
        }
    }
}
