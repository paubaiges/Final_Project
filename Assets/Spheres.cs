using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spheres : MonoBehaviour
{
    // Start is called before the first frame update
    private spherespawner spheresspawner;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetSpawner(spherespawner spawner)
    {
        spheresspawner = spawner;
    }

}
