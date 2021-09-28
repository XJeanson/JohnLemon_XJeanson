using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSController : MonoBehaviour
{
    // horizontal rotation speed
    public float horizontalSpeed = 1f;
    // vertical rotation speed
    public float verticalSpeed = 1f;
    private float xRotation = 0.0f;
    private float yRotation = 0.0f;
    private Camera cam;

    public float speed = 0.002F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        cam = Camera.main;
    }

    void Update()
    {
        Debug.Log(Input.GetAxis("Mouse X")+";"+ Input.GetAxis("Mouse Y"));
        float mouseX = Input.GetAxis("Mouse X") * horizontalSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * verticalSpeed;

        yRotation += mouseX;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90, 90);

        //cam.transform.eulerAngles = new Vector3(xRotation, yRotation, 0.0f);
        //this.transform.eulerAngles = new Vector3(0.0f, yRotation, 0.0f);
        this.transform.rotation = Quaternion.Euler(new Vector3(0, yRotation, 0));

        //player mouvment
        float xValue = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float yValue = Input.GetAxis("Jump") * speed * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.Translate(xValue, yValue, zValue);
    }
}
