using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public float sensitivity = 4;

    private Vector3 offset;
    private bool firstPerson;

    // Use this for initialization
    void Start()
    {
        offset = transform.position - player.transform.position;
        if (offset == Vector3.zero)
        {
            firstPerson = true;
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;

        if(Input.GetMouseButton(0))
        {
            float mouseX = Input.GetAxis("Mouse X") * sensitivity;
            float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

            Vector3 rotation = transform.rotation.eulerAngles;
            rotation.x += mouseY;
            rotation.y -= mouseX;

            transform.rotation = Quaternion.Euler(rotation);
        }
        else
        {
            if (firstPerson)
            {
                //transform.Rotate(Vector3.up * player.transform.rotation.y);
                transform.rotation = Quaternion.Euler(0, player.transform.eulerAngles.y, 0);
            }
            else
            {
                transform.rotation = Quaternion.Euler(0, player.transform.eulerAngles.y, 0);
            }

        }

        //transform.LookAt(player.transform.position - player.transform.forward * 10f);

        //transform.position = player.transform.position - player.transform.forward * 4f;
        //transform.LookAt(player.transform);

        //transform.rotation = player.transform.rotation;

        //Vector3 rotate = Vector3.zero;
        //rotate.y = player.transform.rotation.y;
        //transform.Rotate(Vector3.up, rotate.y * Time.deltaTime);
    }
}
