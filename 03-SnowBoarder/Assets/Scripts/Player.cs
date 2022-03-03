using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour {
    [SerializeField] float torqueAmount = 1;
    [SerializeField] float speed = 15;
    [SerializeField] float boostSpeed = 30;
    [SerializeField] SurfaceEffector2D surfaceEffector = null!;

    Controls controls = null!;
    Rigidbody2D body = null!;

    void Awake() {
        controls = new Controls();
        body = GetComponent<Rigidbody2D>();
        surfaceEffector.speed = speed;
    }

    void OnEnable() => controls.Enable();
    void OnDisable() => controls.Disable();

    void Update() {
        Rotate();
        Boost();
    }

    void Rotate() {
        var torque = controls.Movement.Torque.ReadValue<float>();
        if (!Mathf.Approximately(torque, 0)) {
            body.AddTorque(torque * torqueAmount);
        }
    }

    void Boost() {
        if (controls.Movement.Boost.WasPressedThisFrame()) {
            surfaceEffector.speed = boostSpeed;
        } else if (controls.Movement.Boost.WasReleasedThisFrame()) {
            surfaceEffector.speed = speed;
        }
    }
}
