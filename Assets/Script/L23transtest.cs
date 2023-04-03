using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L23transtest : MonoBehaviour
{

    //Vector3 pos;
    public float speed = 0.1f;
    public float zoom = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        //pos = new Vector3(1f, 2f, 3f);
        //print(pos.x);
        //
        //print (transform.position);

        //transform.position = new Vector3(0f, 0f, 0f);

        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += new Vector3(0f, 0.1f, 0);

        //transform.position -= transform.right * speed;

        //transform.Translate(-0.1f, speed, 0);

        transform.Rotate(0, speed, 0);

        transform.localScale += new Vector3(zoom,zoom,zoom);

        

    }
}
