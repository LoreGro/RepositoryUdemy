using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstScript : MonoBehaviour
{

    public string MyName;
    

    // Start is called before the first frame update
    void Start()
    {
        int returnedNumber = GiveDouble(5);
        print(returnedNumber);
        PrintName(MyName);
        //transform.Translate(speed, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        
        //code for checking mouse click
        
    }

    int GiveDouble(int val)
    {
        return (val * 2);
    }

    void PrintName(string name)
    {
        print("Mi chiamo " + name);
    }

    void TestFunction()
    {
       
    }

    void OnEnable()
    {
        //print("Enable ON");
    }

    void OnDisable()
    {
        //print("Disable ON");
    }



}
