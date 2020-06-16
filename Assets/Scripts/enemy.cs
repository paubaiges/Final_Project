using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{

	public Vector3 movementSpeed; //1
	public Space space; //2
    private bool hitByEspada;
    public float runSpeed;
    public float gotEspadaDestroyDelay;
    public float dropDestroyDelay;
    private enemy_spawner enemyspawner;
    private Collider myCollider;
    private Rigidbody myRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        myCollider = GetComponent<Collider>();
        myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    private void HitByEspada()
    {
        enemyspawner.RemoveenemyFromList(gameObject);
        hitByEspada = true;
        runSpeed = 0;

        Destroy(gameObject, gotEspadaDestroyDelay);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Espada") && !hitByEspada)
        {
            //Destroy(other.gameObject);
            HitByEspada();
        }
        if (other.CompareTag("Player") && !hitByEspada)
        {
            HitByEspada();
        }

    }
    private void Drop()
    {
        enemyspawner.RemoveenemyFromList(gameObject);
        myRigidbody.isKinematic = false;
        myCollider.isTrigger = false;
        Destroy(gameObject, dropDestroyDelay);
    }
    public void SetSpawner(enemy_spawner spawner)
    {
        enemyspawner = spawner;
    }
}
