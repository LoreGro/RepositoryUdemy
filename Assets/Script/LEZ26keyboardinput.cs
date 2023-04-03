using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LEZ26keyboardinput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            print("SpacePressed");

            this.GetComponent<Renderer>().material.color = Color.green;


        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            print("SpaceReleased");

            this.GetComponent<Renderer>().material.color = Color.red;


        }

        if (Input.GetKey(KeyCode.Space))
        {
            print("HoldSpaceButtonDown");


        }*/


        if (Input.GetButtonDown("Jump"))
        {
            print("SpacePressed");

            this.GetComponent<Renderer>().material.color = Color.green;


        }

        if (Input.GetButtonUp("Jump"))
        {
            print("SpaceReleased");

            this.GetComponent<Renderer>().material.color = Color.red;


        }



    }
}
