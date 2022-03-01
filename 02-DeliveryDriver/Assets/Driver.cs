using UnityEngine;

public class Driver : MonoBehaviour {
    void Update() {
        transform.Rotate(Vector3.forward, 20 * Time.deltaTime);
        transform.Translate(0, 2 * Time.deltaTime, 0);
    }
}
