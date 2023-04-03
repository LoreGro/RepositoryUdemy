using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booleane : MonoBehaviour
{

    public bool KillPlayer;

    // Start is called before the first frame update
    void Start()
    {
        /*if (!GameOver) { print("Game is running"); }
        else { print("Game Over"); }*/
    }

    // Update is called once per frame
    void Update()
    {
        if (KillPlayer)
        {
            Destroy(gameObject,2f);
        }
    }
}
