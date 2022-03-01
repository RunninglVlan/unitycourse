using UnityEngine;

public class Driver : MonoBehaviour {
    [SerializeField] int steerSpeed = 20;
    [SerializeField] int moveSpeed = 2;

    void Update() {
        transform.Rotate(Vector3.forward, steerSpeed * Time.deltaTime);
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
    }
}
