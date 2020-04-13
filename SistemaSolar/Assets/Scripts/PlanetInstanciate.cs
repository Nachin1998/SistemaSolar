using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetInstanciate : MonoBehaviour
{
    public List<PlanetOribting> planetPrefab = new List<PlanetOribting>();
    public new CameraManager camera;

    void Start()
    {
        int maxPlanets = planetPrefab.Count;

        for (int i = 0; i < maxPlanets; i++)
        {
            GameObject planet = Instantiate(planetPrefab[i], planetPrefab[i].transform.position, Quaternion.identity).gameObject;
            camera.planets.Add(planet);
        }
    }
}
