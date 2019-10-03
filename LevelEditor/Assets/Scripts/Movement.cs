using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speedH = 2.0f;
    public float speedV = 2.0f;

    public float moveSpeed;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    public Camera camera;

    public void Start()
    {
        
    }
    

    // Update is called once per frame
    void Update()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = true;

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * moveSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
        }

        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        camera.transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        //transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        //transform.Rotate(new Vector3(0.0f, yaw, 0.0f));
    }
}
