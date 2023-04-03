using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CicloIFELSE : MonoBehaviour
{
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (score <= 0)
        {
            print("Game Over");
        } 
        else if (score >= 0 && score <=9)
        {
            print("Level 1");
        }
        else if (score >= 10)
        {
            print("Level 2");
        }
        else
        {
            print("Game Running");
        }



    }
}
