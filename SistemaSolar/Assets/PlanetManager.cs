using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetManager : MonoBehaviour
{
    //public GameObject planetToOrbit;
    //public float orbitingSpeed;
    //public bool rotatesOnOwnAxis = true;
    //public float ownRotationSpeed;

    public List<GameObject> planets = new List<GameObject>();

    
    void Start()
    {
        for (int i = 0; i < planets.Count; i++)
        {
            Instantiate(planets[i], planets[i].transform.position, Quaternion.identity);
        }
    }

    void Update()
    {
        
    }
}
