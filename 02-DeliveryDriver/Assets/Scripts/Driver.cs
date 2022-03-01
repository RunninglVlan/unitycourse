using UnityEngine;

public class Driver : MonoBehaviour {
    [SerializeField] int steerSpeed = 20;
    [SerializeField] int moveSpeed = 2;

    Controls controls;

    void Awake() => controls = new Controls();
    void OnEnable() => controls.Enable();
    void OnDisable() => controls.Disable();

    void Update() {
        var steer = controls.Movement.Steer.ReadValue<float>();
        var move = controls.Movement.Move.ReadValue<float>();
        if (move >= 0) {
            steer *= -1;
        }
        transform.Rotate(Vector3.forward, steer * steerSpeed * Time.deltaTime);
        transform.Translate(0, move * moveSpeed * Time.deltaTime, 0);
    }
}
