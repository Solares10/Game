using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play() {
        SceneManager.LoadScene("ScissorsLevel");
    }

    public void Quit() {
        Application.Quit();
        Debug.Log("Player has quit");
    }

    public void Options() {
        SceneManager.LoadScene("OptionsMenu");
    }
}
