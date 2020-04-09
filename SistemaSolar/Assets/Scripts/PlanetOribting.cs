using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlanetOribting : MonoBehaviour
{
    public GameObject planetToOrbit;
    public float orbitingSpeed;
    public bool rotatesOnOwnAxis = true;
    public float ownRotationSpeed;

    float actualPosX;
    float actualPosZ;

    void Orbit(GameObject planet, float speed)
    {
        transform.RotateAround(planet.transform.position, Vector3.down, speed * Time.deltaTime);
    }

    void Update()
    {
        Orbit(planetToOrbit, orbitingSpeed);

        if(rotatesOnOwnAxis)
        {
            Orbit(gameObject, ownRotationSpeed);
        }
    }
}
