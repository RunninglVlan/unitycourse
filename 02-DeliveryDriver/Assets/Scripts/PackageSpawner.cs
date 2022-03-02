using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PackageSpawner : MonoBehaviour {
    [SerializeField] Transform[] points = null!;
    [SerializeField] DeliveryObject packageTemplate = null!;
    [SerializeField] DeliveryObject customerTemplate = null!;
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
        var package = PlaceInstance(packageTemplate, packagePosition);
        var customer = PlaceInstance(customerTemplate, customerPosition);
        package.Customer = customer;

        DeliveryObject PlaceInstance(DeliveryObject template, Vector3 position) {
            var instance = Instantiate(template, position, Quaternion.identity);
            instance.Color = color;
            instance.gameObject.SetActive(true);
            return instance;
        }
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
