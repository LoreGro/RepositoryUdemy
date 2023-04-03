using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LEZ30Shooting : MonoBehaviour
{

    public GameObject bullet;
    public float bullSpeed;
    bool sparando = false;
    public Transform BulletPos;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            sparando = true;
        }



    }

    void FixedUpdate()
    {
        if (sparando)
        {
            Shoot();

            sparando = false;
        }

    }


    void Shoot()
    {
        GameObject bulletSpawn = Instantiate(bullet, BulletPos.position, bullet.transform.rotation);

        bulletSpawn.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, bullSpeed);

        Destroy(bulletSpawn, 3f);

        //bulletSpawn.GetComponent<Rigidbody>().AddForce(0, 0, bullSpeed);

    }
}
