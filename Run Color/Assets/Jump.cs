using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private float jumpForce = 5.0f; //Quanto in alto la pallina sale
    public GameObject player; //La pallina
    //public Transform player;

    private Vector2 vector0 = new Vector2(0, 0); //Usato per vedere se il player è fermo e quindi può saltare

    private bool grounded = false;
    private float speed = 0.002f;

  


    void Start()
    {

    }

    void Update()
    {
        //GetComponent<Rigidbody2D>().velocity = new Vector2(2, 0); //Avanzamento automatico 
        //transform.position = new Vector2(player.position.x + 0.09f, 0); //Avanzamento automatico alternativa<
        //if (GameObject.Find("Green Line").GetComponent<BoxCollider2D>().bounds.Contains(GetComponent<BoxCollider2D>().bounds.min)) //vedere se i bound si intersecano
        
        //if (GetComponent<Rigidbody2D>().velocity == vector0) //Controllo se è fermo
        {
            if (grounded)
            {
                if (Input.GetKeyDown(KeyCode.Space)) //Controllo se sto premendo il tasto
                {
                    GetComponent<Rigidbody2D>().velocity = new Vector2(4, jumpForce); //Salto //Problema che salta solo quando l'oggetto è fermo, devo fare il collider con la  linea
                }
            }
        }
    }

    private void OnTriggerEnter2D()
    {
        grounded = true;
    }

    private void OnTriggerExit2D()
    {
        grounded = false;
    }
}