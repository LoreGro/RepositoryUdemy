using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LEZ25RIchiamoFunzione : MonoBehaviour
{
    public GameObject[] ball;


    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Renderer>().enabled = false;
        //Invoke("RandomGenerate", 3f);

        InvokeRepeating("RandomGenerate", 3f, 2f);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            CancelInvoke("RandomGenerate");

        }



    }


    void RandomGenerate()
    {
        int randomNumber = Random.Range(0, ball.Length);


        Instantiate(ball[randomNumber], transform.position, Quaternion.identity);

    }
}
