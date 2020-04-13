using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject sun;
    public List<GameObject> planets = new List<GameObject>();
    public GameObject spaceship;
    public Vector3 offset;
    public float camVelocity = 60;
    Vector3 newPos;
    int objectNumber;

    void CameraMovement(GameObject objectToLookAt)
    {
        offset.z = -objectToLookAt.transform.localScale.z * 2;
        newPos = objectToLookAt.transform.position + offset;
    }
    void LateUpdate()
    {

        if (Input.GetKey(KeyCode.Alpha0))
        {
            objectNumber = 0;
        }
        if (Input.GetKey(KeyCode.Alpha1))
        {
            objectNumber = 1;
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            objectNumber = 2;
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            objectNumber = 3;
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            objectNumber = 4;
        }
        if (Input.GetKey(KeyCode.Alpha5))
        {
            objectNumber = 5;
        }
        if (Input.GetKey(KeyCode.Alpha6))
        {
            objectNumber = 6;
        }
        if (Input.GetKey(KeyCode.Alpha7))
        {
            objectNumber = 7;
        }
        if (Input.GetKey(KeyCode.Alpha8))
        {
            objectNumber = 8;
        }

        switch (objectNumber)
        {
            case 0:
                CameraMovement(sun);
                break;
            case 8:
                CameraMovement(spaceship);
                break;
            default:
                CameraMovement(planets[objectNumber]);
                break;
        }

        transform.position = Vector3.Lerp(transform.position, newPos, camVelocity * Time.deltaTime);
    }
}