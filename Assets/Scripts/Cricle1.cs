using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cricle1 : MonoBehaviour
{
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
    }


void OnTriggerEnter2D (Collider2D col)
{
    if(col.gameObject.CompareTag("Player"))
    {    
        Debug.Log("Ball's X Scale: ");
        rb.isKinematic = false;
    }
}
    void Update()
    {
        
    }
}
