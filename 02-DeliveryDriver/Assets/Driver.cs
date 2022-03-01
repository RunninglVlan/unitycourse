using UnityEngine;

public class Driver : MonoBehaviour {
    void Update() {
        transform.Rotate(Vector3.forward, 10 * Time.deltaTime);
    }
}
