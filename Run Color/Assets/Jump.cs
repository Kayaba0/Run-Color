using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private float jumpForce = 5.0f; //Quanto in alto la pallina sale
    public GameObject player; //La pallina

    private Vector2 vector0 = new Vector2(0, 0); //Usato per vedere se il player è fermo e quindi può saltare

    void Start()
    {

    }

    void Update()
    {
        if (GetComponent<Rigidbody2D>().velocity == vector0) //Controllo se è fermo
        {
            if (Input.GetKeyDown(KeyCode.Space)) //Controllo se sto premendo il tasto
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, jumpForce); //Salto
            }
        }
    }

}