using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame ()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //Loads the next scene
        SceneManager.LoadScene("Game");
    }

    public void QuitGame ()
    {
        Debug.Log("QUIT!"); //We use this so we can see if we close the app. Because in Unity we can't see it.
        Application.Quit();
    }
}
