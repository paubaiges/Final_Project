using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atomitoo : MonoBehaviour
{

	public GameObject yo;
    private Collider myCollider;
    private Rigidbody myRigidbody;
    public int contador;

    void Start()
    {
        myCollider = GetComponent<Collider>();
        myRigidbody = GetComponent<Rigidbody>();
        contador = 0;
    }

    // Update is called once per frame
    void Update()
    {
    	transform.Rotate(0, 0 , 0);

        if(contador == 1){
            yo.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("palo"))
        {
  			contador = contador +1;
        }

    }



}