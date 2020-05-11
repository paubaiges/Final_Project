using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balapaja : MonoBehaviour
{

	public float movementSpeed;
	public float limite;
	public GameObject hayPrefab;
	public float shootInterval; 
	public Transform haySpawnpoint; 
	private float shootTimer;


    // Start is called before the first frame update
    void Start()
    {
        movementSpeed = 20;
        limite = 21;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateMovement();
        UpdateShooting();

    }

    private void UpdateMovement()
	{
	    float horizontalInput = Input.GetAxisRaw("Horizontal"); // 1

	    if (horizontalInput < 0 && transform.position.x > -limite) // 2
	    {
	        transform.Translate(transform.right * -movementSpeed * Time.deltaTime);
	    }
	    else if (horizontalInput > 0 && transform.position.x < limite) // 3
	    {
	        transform.Translate(transform.right * movementSpeed * Time.deltaTime);
	    }


	}



	private void ShootHay(){

		SoundManager.Instance.PlayShootClip();
	    Instantiate(hayPrefab, haySpawnpoint.position, Quaternion.identity );
	   
	}


	private void UpdateShooting() {
	 shootTimer -= Time.deltaTime;

	 if (shootTimer <= 0 && Input.GetKey(KeyCode.Space)) {
		 shootTimer = shootInterval;
		 ShootHay();
 		}

 	}


}
