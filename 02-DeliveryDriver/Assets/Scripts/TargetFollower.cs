using UnityEngine;

public class TargetFollower : MonoBehaviour {
    [SerializeField] Transform target = null!;
    [SerializeField] Vector3 shift;

    void LateUpdate() {
        transform.position = target.position + shift;
    }
}
