using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlanetOribting : MonoBehaviour
{
    public GameObject starToOrbit;
    public float distanceFromSun;
    public float orbitingSpeed;
    public bool rotatesOnOwnAxis = true;
    public float ownRotationSpeed;

    float actualPos;
    float posX;
    float posZ;

    void Orbit(GameObject planet, float speed)
    {
        transform.RotateAround(planet.transform.position, Vector3.down, speed * Time.deltaTime);
    }

    void Start()
    {
        transform.position = new Vector3(transform.position.x, 0.0f, transform.position.z);

        actualPos = Random.Range(-180.0f, 180.0f);
    }

    void Update()
    {
       // Orbit(starToOrbit, orbitingSpeed);

        if(rotatesOnOwnAxis)
        {
            Orbit(gameObject, ownRotationSpeed);
        }

        posX = starToOrbit.transform.position.x + distanceFromSun * Mathf.Cos(actualPos);
        posZ = starToOrbit.transform.position.z + distanceFromSun * Mathf.Sin(actualPos);

        transform.position = new Vector3(posX, starToOrbit.transform.position.y, posZ);

        actualPos += orbitingSpeed * Time.deltaTime;
    }
}
