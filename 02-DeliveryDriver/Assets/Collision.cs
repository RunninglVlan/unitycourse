using UnityEngine;

public class Collision : MonoBehaviour {
    void OnCollisionEnter2D(Collision2D _) {
        Debug.Log("Ouch!");
    }
}
