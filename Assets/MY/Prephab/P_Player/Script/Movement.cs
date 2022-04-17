using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private float speed = 10f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Z))
        {
            this.transform.position +=  Vector3.forward * speed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.S))
        {
            this.transform.position +=  Vector3.back * speed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.Q))
        {
            this.transform.position +=  Vector3.left * speed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.D))
        {
            this.transform.position +=  Vector3.right * speed * Time.deltaTime;
        }
    }
}
