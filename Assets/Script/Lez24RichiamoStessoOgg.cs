using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lez24RichiamoStessoOgg : MonoBehaviour
{

    public GameObject[] ball;

   



    // Start is called before the first frame update
    void Start()
    {

        //Instantiate(bigrock, transform.position, Quaternion.identity);

        
        
       this.GetComponent<Renderer>().enabled = false;
          


    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {

            int randomNumber = Random.Range(0, ball.Length);


            Instantiate(ball[randomNumber], transform.position, Quaternion.identity);

            


        }


    }
}
