using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f; //From 0 to 1
    public Vector3 offset;

    private Vector3 desiredPosition;
    private Vector3 Objective;

    Scene currentScene; 
    string sceneName;

    void Start()
    {
        currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;

        desiredPosition.x = -33;
        desiredPosition.y = 117;
        desiredPosition.z = 0;
    }

    void FixedUpdate ()
    {
        if(sceneName == "Game") //Level 1
        {
            //Izquierda-arriba
            if (target.position.y >= 101 && target.position.x <= -1.49)
            {
                desiredPosition.x = -33;
                desiredPosition.y = 118;
                desiredPosition.z = 0;
            }
            //Izquierda-centro-superior
            else if (target.position.y < 101 && target.position.y >= 69 && target.position.x <= -1.49)
            {
                desiredPosition.x = -33;
                desiredPosition.y = 85;
                desiredPosition.z = 0;
            }
            //Izquierda-centro-inferior
            else if (target.position.y < 69 && target.position.y >= 36 && target.position.x <= -1.49)
            {
                desiredPosition.x = -33;
                desiredPosition.y = 52;
                desiredPosition.z = 0;
            }
            //Izquierda-abajo
            else if (target.position.y < 36 && target.position.x <= -1.49)
            {
                desiredPosition.x = -33;
                desiredPosition.y = 18;
                desiredPosition.z = 0;
            }
            //Derecha-centro-inferior
            else if (target.position.y < 69 && target.position.y >= 36 && target.position.x > -1.49)
            {
                desiredPosition.x = 30;
                desiredPosition.y = 52;
                desiredPosition.z = 0;
            }
            //Derecha-centro-superior
            else if (target.position.y < 101 && target.position.y >= 69 && target.position.x > -1.49)
            {
                desiredPosition.x = 30;
                desiredPosition.y = 85;
                desiredPosition.z = 0;
            }
            //Derecha-arriba
            else if (target.position.y > 101 && target.position.x > -1.49)
            {
                desiredPosition.x = 30;
                desiredPosition.y = 118;
                desiredPosition.z = 0;
            }
        }
        
        else if(sceneName == "Game1" || sceneName == "Game2") //Level 2
        {
            //Inicio
            if (target.position.y <= 69 && target.position.y >= 36 && target.position.x >= -34 && target.position.x <= 30)
            {
                desiredPosition.x = -2;
                desiredPosition.y = 52;
                desiredPosition.z = 0;
            }
            //Pre-key-2
            else if (target.position.y <= 69 && target.position.y >= 36 && target.position.x >= 30 && target.position.x <= 65)
            {
                desiredPosition.x = 31;
                desiredPosition.y = 52;
                desiredPosition.z = 0;
            }
            //Pre-key-3
            else if (target.position.y < 36 && target.position.y >= 1 && target.position.x >= -2 && target.position.x <= 65)
            {
                desiredPosition.x = 31;
                desiredPosition.y = 18;
                desiredPosition.z = 0;
            }
            //Pre-key-4
            else if (target.position.y < 36 && target.position.y >= 1 && target.position.x >= -66 && target.position.x < -2)
            {
                desiredPosition.x = -33;
                desiredPosition.y = 18;
                desiredPosition.z = 0;
            }
            //Pre-key-5
            else if (target.position.y < 69 && target.position.y >= 36 && target.position.x >= -66 && target.position.x < -2)
            {
                desiredPosition.x = -33;
                desiredPosition.y = 52;
                desiredPosition.z = 0;
            }
            //Pre-key-6
            else if (target.position.y < 102 && target.position.y >= 69 && target.position.x >= -66 && target.position.x < 0)
            {
                desiredPosition.x = -33;
                desiredPosition.y = 85;
                desiredPosition.z = 0;
            }
            //Pre-key-7
            else if (target.position.y < 102 && target.position.y >= 69 && target.position.x >= 0 && target.position.x < 37)
            {
                desiredPosition.x = 4;
                desiredPosition.y = 85;
                desiredPosition.z = 0;
            }
            //Pre-key-8
            else if (target.position.y < 135 && target.position.y >= 102 && target.position.x >= -29 && target.position.x < 37)
            {
                desiredPosition.x = 4;
                desiredPosition.y = 118;
                desiredPosition.z = 0;
            }
            //Sala-key
            else if (target.position.y < 135 && target.position.y >= 102 && target.position.x >= -65 && target.position.x < -29)
            {
                desiredPosition.x = -33;
                desiredPosition.y = 118;
                desiredPosition.z = 0;
            }
            //Post-key-1
            else if (target.position.y <= 102 && target.position.y > 69 && target.position.x >= 36 && target.position.x <= 65)
            {
                desiredPosition.x = 31;
                desiredPosition.y = 85;
                desiredPosition.z = 0;
            }
            //Post-key-2
            else if (target.position.y <= 135 && target.position.y > 102 && target.position.x >= 36 && target.position.x <= 65)
            {
                desiredPosition.x = 31;
                desiredPosition.y = 118;
                desiredPosition.z = 0;
            }
        }

        Objective = desiredPosition;
        desiredPosition = desiredPosition + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); //Lineal interpolation
        transform.position = smoothedPosition;

        transform.LookAt(smoothedPosition);
    }
}
