using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LEZ28Mouse : MonoBehaviour
{
    public GameObject ball;
    public float speed = 0.5f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            //print("Txt Sinistro");

            print(Input.mousePosition.x + " " + Input.mousePosition.y);

            Vector3 pos = Input.mousePosition;

            pos.z = 10f;

            pos = Camera.main.ScreenToWorldPoint(pos);

            Instantiate(ball, pos, Quaternion.identity);



        }

        if (Input.GetMouseButtonDown(1))
        {

            print("Txt Destro");
        }

        if (Input.GetMouseButtonDown(2))
        {

            print("Rotella");
        }

    }




    void OnMouseDown()
    {

        Destroy(gameObject);


    }
}
