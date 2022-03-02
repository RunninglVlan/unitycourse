using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour {
    [SerializeField] CrashDetection crashDetection = null!;
    [SerializeField] Finish finish = null!;

    void Awake() {
        crashDetection.PlayerCrashed += Lose;
        finish.PlayerReached += Win;
    }

    static void Lose() {
        Debug.Log("Severe injury. Went to the hospital");
        Reload();
    }

    static void Win() {
        Debug.Log("Hooray! We won");
        Reload();
    }

    static void Reload() {
        var activeScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(activeScene.buildIndex);
    }
}
