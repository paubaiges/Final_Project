using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{

	public Vector3 movementSpeed; //1
	public Space space; //2
	private enemy_spawner enemyspawner;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetSpawner(enemy_spawner spawner)
	{
	    enemyspawner = spawner;
	}

}
