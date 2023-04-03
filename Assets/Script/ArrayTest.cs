using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayTest : MonoBehaviour
{
    public int[] rollNumber;
    string[] names = new string [4];
    public GameObject[] objects;
    public Color[] colors;


    // Start is called before the first frame update
    void Start()
    {
        names[0] = "No Name";
        names[1] = "Lorenzo";
        names[2] = "Grossi";
        names[3] = "Ross";

        //Destroy(objects[2],2f);
        //Destroy(objects[1], 4f);

        objects[0].GetComponent<Renderer>().material.color = colors[0];

        objects[1].GetComponent<Renderer>().material.color = colors[1];

        objects[2].GetComponent<Renderer>().material.color = colors[2];

        objects[3].GetComponent<Renderer>().material.color = colors[3];

      
        //print(names[0]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
