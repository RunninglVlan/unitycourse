using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour {
    [SerializeField] float torqueAmount = 1;

    Controls controls = null!;
    Rigidbody2D body = null!;

    void Awake() {
        controls = new Controls();
        body = GetComponent<Rigidbody2D>();
    }

    void OnEnable() => controls.Enable();
    void OnDisable() => controls.Disable();

    void Update() {
        var torque = controls.Movement.Torque.ReadValue<float>();
        if (!Mathf.Approximately(torque, 0)) {
            body.AddTorque(torque * torqueAmount);
        }
    }
}
