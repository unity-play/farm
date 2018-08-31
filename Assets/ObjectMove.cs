using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float velocity = 4.0f;
        if (Input.GetButton("Jump"))
        {
            velocity = 6 * velocity;
        }

        float x = velocity * Input.GetAxis("Horizontal");
        float y = 0;
        float z = velocity * Input.GetAxis("Vertical");
        //transform.Translate(x * Time.deltaTime, y * Time.deltaTime, z * Time.deltaTime);
        transform.Translate(0, 0, z * Time.deltaTime);


    }
}
