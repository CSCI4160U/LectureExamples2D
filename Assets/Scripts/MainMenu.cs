using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    public void PlayGame() {
        Debug.Log("Play Game");

        SceneManager.LoadScene("PlayGame");
    }

    public void Settings() {
        Debug.Log("Settings");
    }

    public void ExitGame() {
        Debug.Log("Exit Game");
    }
}
