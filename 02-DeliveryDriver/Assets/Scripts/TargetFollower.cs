using UnityEngine;

public class TargetFollower : MonoBehaviour {
    [SerializeField] Transform target;
    [SerializeField] Vector3 shift;

    void LateUpdate() {
        transform.position = target.position + shift;
    }
}
