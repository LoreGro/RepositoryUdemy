using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LEZ22_GetComponent : MonoBehaviour
{
    Rigidbody rb;

    PlayerHealth health;
    
    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();

        //rb.useGravity = false;
        //rb.mass = 10;

        GetComponent<Renderer>().material.color = Color.red;
        //health = GetComponent<PlayerHealth>();
        //health.lives = 9;

        GetComponentInChildren<Rigidbody>().useGravity = true;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
