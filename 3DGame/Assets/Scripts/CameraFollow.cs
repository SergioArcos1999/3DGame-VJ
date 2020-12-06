using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f; //From 0 to 1
    public Vector3 offset;

    private Vector3 desiredPosition;
    private Vector3 Objective;

    void Start()
    {
        desiredPosition.x = -33;
        desiredPosition.y = 117;
        desiredPosition.z = 0;
    }

    void FixedUpdate ()
    {
        if (target.position.y >= 101 && target.position.x <= -1.49) 
        {
            desiredPosition.x = -33;
            desiredPosition.y = 118;
            desiredPosition.z = 0;
        }
        else if (target.position.y < 101 && target.position.y >= 68 && target.position.x <= -1.49)
        {
            desiredPosition.x = -33;
            desiredPosition.y = 85;
            desiredPosition.z = 0;
        }
        else if (target.position.y < 68 && target.position.y >= 33 && target.position.x <= -1.49)
        {
            desiredPosition.x = -33;
            desiredPosition.y = 51;
            desiredPosition.z = 0;
        }
        else if (target.position.y < 33 && target.position.x <= -1.49)
        {
            desiredPosition.x = -33;
            desiredPosition.y = 22;
            desiredPosition.z = 0;
        }
        else if (target.position.y < 68 && target.position.y >= 33 && target.position.x > -1.49)
        {
            desiredPosition.x = 30;
            desiredPosition.y = 51;
            desiredPosition.z = 0;
        }

        Objective = desiredPosition;
        desiredPosition = desiredPosition + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); //Lineal interpolation
        transform.position = smoothedPosition;

        transform.LookAt(smoothedPosition);
    }
}
