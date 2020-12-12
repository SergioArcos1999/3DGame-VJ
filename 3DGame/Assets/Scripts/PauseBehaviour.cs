using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseBehaviour : MonoBehaviour
{
    bool paused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            paused = togglePause();
        if (paused && Input.GetKeyDown(KeyCode.Return))
        {
            paused = togglePause();
            SceneManager.LoadScene("MiddleMenu");
        }
        if (paused && Input.GetKeyDown("space"))
        {
            paused = togglePause();
            SceneManager.LoadScene("MainMenu");
        }
    }

    void OnGUI()
    {
        if (paused)
        {
            GUILayout.Label("GAME IS PAUSED!");
            GUILayout.Label("Press ESCAPE to unpause");
            GUILayout.Label("Press ENTER to return to SELECT LEVEL MENU");
            GUILayout.Label("Press SPACE to return to MAIN MENU");

            if (GUILayout.Button("UNPAUSE"))
                paused = togglePause();
            if (GUILayout.Button("SELECT LEVEL MENU"))
            {
                paused = togglePause();
                SceneManager.LoadScene("MiddleMenu");
            }
                
            if (GUILayout.Button("MAIN MENU"))
            {
                paused = togglePause();
                SceneManager.LoadScene("MainMenu");
            }

        }
    }

    bool togglePause()
    {
        if (Time.timeScale == 0f)
        {
            Time.timeScale = 1f;
            return (false);
        }
        else
        {
            Time.timeScale = 0f;
            return (true);
        }
    }
}
