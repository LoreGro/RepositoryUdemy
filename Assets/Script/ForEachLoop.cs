using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForEachLoop : MonoBehaviour
{

    public GameObject[] oggettiforeachloop;

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject o in oggettiforeachloop)
        {
            o.SetActive(true);
            //Destroy(o);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
