using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchingAndFinding : MonoBehaviour
{
    GameObject searchObj;

    GameObject[] enemies;

    // Start is called before the first frame update
    void Start()
    {
        //searchObj = GameObject.Find("Cube/Cube2/Enemy");

        //Destroy(searchObj, 3f);

        //enemies = GameObject.FindGameObjectsWithTag("Enemy");
        
        //foreach (GameObject o in enemies) { 
            
           // Destroy(o, 3f); 
       // }

        GameObject.Find("Cube").SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
