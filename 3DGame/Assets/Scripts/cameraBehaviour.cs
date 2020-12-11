using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class cameraBehaviour : MonoBehaviour
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
                desiredPosition.z = -38;
            }
            //Izquierda-centro-superior
            else if (target.position.y < 101 && target.position.y >= 69 && target.position.x <= -1.49)
            {
                desiredPosition.x = -33;
                desiredPosition.y = 85;
                desiredPosition.z = -38;
            }
            //Izquierda-centro-inferior
            else if (target.position.y < 69 && target.position.y >= 36 && target.position.x <= -1.49)
            {
                desiredPosition.x = -33;
                desiredPosition.y = 52;
                desiredPosition.z = -38;
            }
            //Izquierda-abajo
            else if (target.position.y < 36 && target.position.x <= -1.49)
            {
                desiredPosition.x = -33;
                desiredPosition.y = 18;
                desiredPosition.z = -38;
            }
            //Derecha-centro-inferior
            else if (target.position.y < 69 && target.position.y >= 36 && target.position.x > -1.49)
            {
                desiredPosition.x = 30;
                desiredPosition.y = 52;
                desiredPosition.z = -38;
            }
            //Derecha-centro-superior
            else if (target.position.y < 101 && target.position.y >= 69 && target.position.x > -1.49)
            {
                desiredPosition.x = 30;
                desiredPosition.y = 85;
                desiredPosition.z = -38;
            }
            //Derecha-arriba
            else if (target.position.y > 101 && target.position.x > -1.49)
            {
                desiredPosition.x = 30;
                desiredPosition.y = 118;
                desiredPosition.z = -38;
            }
        }
        
        else if(sceneName == "Game1") //Level 2
        {
            //Inicio
            if (target.position.y <= 69 && target.position.y >= 36 && target.position.x >= -34 && target.position.x <= 30)
            {
                desiredPosition.x = -2;
                desiredPosition.y = 52;
                desiredPosition.z = -34;
            }
            //Pre-key-2
            else if (target.position.y <= 69 && target.position.y >= 36 && target.position.x >= 30 && target.position.x <= 65)
            {
                desiredPosition.x = 31;
                desiredPosition.y = 52;
                desiredPosition.z = -34;
            }
            //Pre-key-3
            else if (target.position.y < 36 && target.position.y >= 1 && target.position.x >= -2 && target.position.x <= 65)
            {
                desiredPosition.x = 31;
                desiredPosition.y = 18;
                desiredPosition.z = -34;
            }
            //Pre-key-4
            else if (target.position.y < 36 && target.position.y >= 1 && target.position.x >= -66 && target.position.x < -2)
            {
                desiredPosition.x = -33;
                desiredPosition.y = 18;
                desiredPosition.z = -34;
            }
            //Pre-key-5
            else if (target.position.y < 69 && target.position.y >= 36 && target.position.x >= -66 && target.position.x < -2)
            {
                desiredPosition.x = -33;
                desiredPosition.y = 52;
                desiredPosition.z = -34;
            }
            //Pre-key-6
            else if (target.position.y < 102 && target.position.y >= 69 && target.position.x >= -66 && target.position.x < 0)
            {
                desiredPosition.x = -33;
                desiredPosition.y = 85;
                desiredPosition.z = -34;
            }
            //Pre-key-7
            else if (target.position.y < 102 && target.position.y >= 69 && target.position.x >= 0 && target.position.x < 37)
            {
                desiredPosition.x = 4;
                desiredPosition.y = 85;
                desiredPosition.z = -34;
            }
            //Pre-key-8
            else if (target.position.y < 135 && target.position.y >= 102 && target.position.x >= -29 && target.position.x < 37)
            {
                desiredPosition.x = 4;
                desiredPosition.y = 118;
                desiredPosition.z = -34;
            }
            //Sala-key
            else if (target.position.y < 135 && target.position.y >= 102 && target.position.x >= -65 && target.position.x < -29)
            {
                desiredPosition.x = -33;
                desiredPosition.y = 118;
                desiredPosition.z = -34;
            }
            //Post-key-1
            else if (target.position.y <= 102 && target.position.y > 69 && target.position.x >= 36 && target.position.x <= 65)
            {
                desiredPosition.x = 31;
                desiredPosition.y = 85;
                desiredPosition.z = -34;
            }
            //Post-key-2
            else if (target.position.y <= 135 && target.position.y > 102 && target.position.x >= 36 && target.position.x <= 65)
            {
                desiredPosition.x = 31;
                desiredPosition.y = 118;
                desiredPosition.z = -34;
            }
        }

        else if(sceneName == "Game2")
        {
            //Inicio
            if (target.position.y <= 36 && target.position.y >= 22 && target.position.x >= 30 && target.position.x <= 65)
            {
                desiredPosition.x = 34;
                desiredPosition.y = 20;
                desiredPosition.z = -31;
            }
            //Inicio2
            else if (target.position.y <= 36 && target.position.y >= 22 && target.position.x >= -31 && target.position.x < 30)
            {
                desiredPosition.x = 0;
                desiredPosition.y = 20;
                desiredPosition.z = -31;
            }
            //Post-pinchos
            else if (target.position.y <= 36 && target.position.y >= 22 && target.position.x >= -66 && target.position.x < -31)
            {
                desiredPosition.x = -35;
                desiredPosition.y = 20;
                desiredPosition.z = -31;
            }
            //Balas 1
            else if (target.position.y <= 70 && target.position.y > 36 && target.position.x >= -66 && target.position.x < -31)
            {
                desiredPosition.x = -35;
                desiredPosition.y = 50;
                desiredPosition.z = -31;
            }
            //Balas 2
            else if (target.position.y <= 103 && target.position.y > 70 && target.position.x >= -66 && target.position.x < -31)
            {
                desiredPosition.x = -35;
                desiredPosition.y = 86;
                desiredPosition.z = -31;
            }
            //Final Balas
            else if (target.position.y <= 132 && target.position.y > 103 && target.position.x >= -66 && target.position.x < -31)
            {
                desiredPosition.x = -35;
                desiredPosition.y = 116;
                desiredPosition.z = -31;
            }
            //Checkpoint
            else if (target.position.y <= 132 && target.position.y > 103 && target.position.x >= -31 && target.position.x < 31)
            {
                desiredPosition.x = 0;
                desiredPosition.y = 116;
                desiredPosition.z = -31;
            }
            //Post-checkpoint
            else if (target.position.y <= 132 && target.position.y > 103 && target.position.x >= 31 && target.position.x < 65)
            {
                desiredPosition.x = 35;
                desiredPosition.y = 116;
                desiredPosition.z = -31;
            }
            //Checkpoint 2
            else if (target.position.y <= 103 && target.position.y > 87 && target.position.x >= 28 && target.position.x < 65)
            {
                desiredPosition.x = 35;
                desiredPosition.y = 86;
                desiredPosition.z = -31;
            }
            //Sala pinchos chungos 1
            else if (target.position.y <= 103 && target.position.y > 75 && target.position.x >= -30 && target.position.x < 28)
            {
                desiredPosition.x = 0;
                desiredPosition.y = 86;
                desiredPosition.z = -31;
            }
            //Sala pinchos chungos 2
            else if (target.position.y <= 75 && target.position.y > 52 && target.position.x >= -30 && target.position.x < 28)
            {
                desiredPosition.x = 0;
                desiredPosition.y = 61;
                desiredPosition.z = -31;
            }
            //Sala pinchos chungos 3
            else if (target.position.y <= 52 && target.position.y > 35 && target.position.x >= -30 && target.position.x < 28)
            {
                desiredPosition.x = 0;
                desiredPosition.y = 50;
                desiredPosition.z = -31;
            }
            //Post-pinchos chungos
            else if (target.position.y <= 54 && target.position.y > 35 && target.position.x >= 28 && target.position.x < 65)
            {
                desiredPosition.x = 34;
                desiredPosition.y = 50;
                desiredPosition.z = -31;
            }
            //Sala final
            else if (target.position.y <= 86 && target.position.y > 54 && target.position.x >= 28 && target.position.x < 65)
            {
                desiredPosition.x = 34;
                desiredPosition.y = 69;
                desiredPosition.z = -31;
            }
        }
        
        else if(sceneName == "Game4")
        {
            //Inicio
            if (target.position.y <= 135 && target.position.y >= 101 && target.position.x >= -66 && target.position.x <= -1)
            {
                desiredPosition.x = -33;
                desiredPosition.y = 118;
                desiredPosition.z = -43;
            }
            //Boss
            else if (target.position.y <= 98 && target.position.y >= 35 && target.position.x >= -66 && target.position.x <= 61)
            {
                desiredPosition.x = -2;
                desiredPosition.y = 67;
                desiredPosition.z = -80;
            }
            //Final
            else if (target.position.y < 35 && target.position.y >= 1 && target.position.x >= -1 && target.position.x <= 62)
            {
                desiredPosition.x = 29;
                desiredPosition.y = 19;
                desiredPosition.z = -43;
            }
        }
        desiredPosition = desiredPosition + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); //Lineal interpolation for position
        transform.position = smoothedPosition;

        

        transform.LookAt(smoothedPosition);
    }
}
