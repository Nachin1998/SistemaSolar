using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public List <GameObject> planets = new List<GameObject>();

    int objectNumber;

    void Start()
    {
        objectNumber = 0;

        Camera.main.transform.position = new Vector3(planets[objectNumber].transform.position.x,
            planets[objectNumber].transform.position.y,
            planets[objectNumber].transform.position.z - planets[objectNumber].transform.localScale.z * 2);    
    }

    // Update is called once per frame
    void Update()
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
        if (Input.GetKey(KeyCode.Alpha9))
        {
            objectNumber = 9;
        }

        Camera.main.transform.position = new Vector3(planets[objectNumber].transform.position.x, 
            planets[objectNumber].transform.position.y, 
            planets[objectNumber].transform.position.z - planets[objectNumber].transform.localScale.z * 2);

        Camera.main.transform.LookAt(planets[objectNumber].transform);
    }
}
