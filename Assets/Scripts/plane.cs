using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plane : MonoBehaviour
{
    public GameObject palo;
    public int contador;
    private Collider myCollider;
    private Rigidbody myRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        myCollider = GetComponent<Collider>();
        myRigidbody = GetComponent<Rigidbody>();
        contador = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(contador == 2){
        	palo.SetActive(true);
        }

        if(contador == 4){
        	palo.active = false;
        	contador = 0;
        }
    }

    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Espada"))
        {
  			contador = contador + 1;
        }

    }
    
}
