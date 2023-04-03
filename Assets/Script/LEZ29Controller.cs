using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LEZ29Controller : MonoBehaviour
{
    Animator AnimBoy;
    Rigidbody rb;
    public float speed;
    public float salto;
    bool saltando = false;
  

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        AnimBoy = GetComponent<Animator>();
    }
    
    
    
    void Start()
    {
        //rb.velocity = new Vector3(0, 0, 20f);
      
    }

    // Update is called once per frame
    void Update()
    {

     

         
    }


    IEnumerator TimerSalto()
    {
        yield return new WaitForSeconds(1.0f);
        AnimBoy.ResetTrigger("Salta");
    }

  

    void FixedUpdate()
    {
       
        
        //FLOAT DI MOVIMENTO
        float destrasinistra = Input.GetAxis("Horizontal");
        float altobasso = Input.GetAxis("Vertical");
        rb.velocity = new Vector3(destrasinistra * speed, rb.velocity.y, altobasso * speed);

        //SALTA
        if (Input.GetButtonDown("Jump"))
        {
            saltando  = true;
            AnimBoy.ResetTrigger("Isidle");
            AnimBoy.SetTrigger("Salta");
            StartCoroutine("TimerSalto");
        }

        if (saltando)
        {
            Jump();
            saltando = false;
        }

        //ANIMAZIONE WALKING
        if(destrasinistra != 0.0f || altobasso != 0.0f)
        {
            AnimBoy.SetTrigger("Cammina");
            AnimBoy.ResetTrigger("Isidle");
        }
        else {
            AnimBoy.SetTrigger("Isidle");
            AnimBoy.ResetTrigger("Cammina");
        }

        

    }


    void Jump()
    {
        rb.AddForce(0, salto, 0);
       
    }


}
