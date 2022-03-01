using UnityEngine;

public class Game : MonoBehaviour {
    [SerializeField] int packagesToDeliver = 3;
    [SerializeField] Delivery delivery = null!;

    void Awake() => delivery.PackageDelivered += CheckGameOver;

    void CheckGameOver(Vector3 _) {
        if (--packagesToDeliver <= 0) {
            Debug.Log("Work's done for today. You've delivered all the packages!");
        }
    }
}
