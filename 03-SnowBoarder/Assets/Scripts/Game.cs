using UnityEngine;

public class Game : MonoBehaviour {
    [SerializeField] CrashDetection crashDetection = null!;
    [SerializeField] Finish finish = null!;

    void Awake() {
        crashDetection.PlayerCrashed += Lose;
        finish.PlayerReached += Win;
    }

    static void Lose() {
        Time.timeScale = 0;
        Debug.Log("Severe injury. Went to the hospital");
    }

    static void Win() {
        Time.timeScale = 0;
        Debug.Log("Hooray! We won");
    }
}
