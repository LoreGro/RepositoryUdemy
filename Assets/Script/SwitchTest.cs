using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTest : MonoBehaviour
{
    public int power = 0;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        switch (power)
        {
            case 1:
                print("Noob");
                break;
            case 2:
                print("Medio");
                break;
            case 3:
                print("Meglio");
                break;
            case 4:
                print("Bravo");
                break;
            case 5:
                print("Esperto");
                break;
            default:
                print("???");
                break;
        }
    }
}
