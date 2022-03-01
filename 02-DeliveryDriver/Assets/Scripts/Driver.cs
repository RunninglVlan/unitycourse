using System.Collections;
using UnityEngine;

public class Driver : MonoBehaviour {
    [SerializeField] int steerSpeed = 20;
    [SerializeField] int normalMoveSpeed = 20;
    [SerializeField] int slowMoveSpeed = 10;
    [SerializeField] int fastMoveSpeed = 30;
    [SerializeField] float moveSpeedEffectDuration = 2;

    Controls controls = null!;
    int moveSpeed;
    Coroutine? moveSpeedEffect;

    void Awake() {
        controls = new Controls();
        moveSpeed = normalMoveSpeed;
    }

    void OnEnable() => controls.Enable();
    void OnDisable() => controls.Disable();

    void Update() {
        var steer = controls.Movement.Steer.ReadValue<float>();
        var move = controls.Movement.Move.ReadValue<float>();
        if (move >= 0) {
            steer *= -1;
        } else {
            move /= 2;
        }

        transform.Rotate(Vector3.forward, steer * steerSpeed * Time.deltaTime);
        transform.Translate(0, move * moveSpeed * Time.deltaTime, 0);
    }

    void OnCollisionEnter2D(Collision2D _) {
        ChangeMoveSpeed(slowMoveSpeed);
    }

    void OnTriggerEnter2D(Collider2D trigger) {
        if (trigger.CompareTag("Boost")) {
            ChangeMoveSpeed(fastMoveSpeed);
        }
    }

    void ChangeMoveSpeed(int newSpeed) {
        if (moveSpeedEffect != null) {
            StopCoroutine(moveSpeedEffect);
        }

        moveSpeed = newSpeed;
        moveSpeedEffect = StartCoroutine(ChangeMoveSpeedBackToNormal());
    }

    IEnumerator ChangeMoveSpeedBackToNormal() {
        yield return new WaitForSeconds(moveSpeedEffectDuration);
        moveSpeed = normalMoveSpeed;
        moveSpeedEffect = null;
    }
}
