using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour {
    [SerializeField] CrashDetection crashDetection = null!;
    [SerializeField] Finish finish = null!;
    [SerializeField] float reloadDelay = 1;

    void Awake() {
        crashDetection.PlayerCrashed += Lose;
        finish.PlayerReached += Win;
    }

    void Lose() {
        Debug.Log("Severe injury. Went to the hospital");
        Invoke(nameof(Reload), reloadDelay);
    }

    void Win() {
        Debug.Log("Hooray! We won");
        Invoke(nameof(Reload), reloadDelay);
    }

    void Reload() {
        var activeScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(activeScene.buildIndex);
    }
}
