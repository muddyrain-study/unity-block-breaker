using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject BulletPrefab;
    // Start is called before the first frame update
    void Start()
    {   
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject bullet = GameObject.Instantiate(BulletPrefab, transform.position, transform.rotation);
            Rigidbody rd = bullet.GetComponent<Rigidbody>();
            //rd.AddForce(Vector3.forward * 100);
            rd.velocity = Vector3.forward * 30;
        }
    }
}
