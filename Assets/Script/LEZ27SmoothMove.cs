using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LEZ27SmoothMove : MonoBehaviour
{
    public float speed = 0.1f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float DestraSinistra = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float AltoBasso = Input.GetAxis("Vertical") * speed * Time.deltaTime;


        transform.Translate(DestraSinistra, AltoBasso, 0);

        print(DestraSinistra);
        print(AltoBasso);


    }
}
