using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MiddleMenu : MonoBehaviour
{
    public static int currentLevel;

    public void PlayLevel1()
    {
        SceneManager.LoadScene("Game");
    }

    public void PlayLevel2()
    {
        SceneManager.LoadScene("Game1");
    }

    public void PlayLevel3()
    {
        SceneManager.LoadScene("Game2");
    }

    public void PlayLevel4()
    {
        SceneManager.LoadScene("Game3");
    }

    public void PlayLevel5()
    {
        SceneManager.LoadScene("Game4");
    }

    void Start()
    {
        currentLevel = 1;
    }

    void Update()
    {
        if(Input.GetKeyDown("1")) { SceneManager.LoadScene("Game"); }
        else if (Input.GetKeyDown("2")) { SceneManager.LoadScene("Game1"); }
        else if (Input.GetKeyDown("3")) { SceneManager.LoadScene("Game2"); }
        else if (Input.GetKeyDown("4")) { SceneManager.LoadScene("Game3"); }
        else if (Input.GetKeyDown("5")) { SceneManager.LoadScene("Game4"); }
    }

    
}
