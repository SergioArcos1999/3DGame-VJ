using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MiddleMenu : MonoBehaviour
{
    public static int nextLevel;

    void NextLevel(int n)
    {
        nextLevel = n;
    }
}
