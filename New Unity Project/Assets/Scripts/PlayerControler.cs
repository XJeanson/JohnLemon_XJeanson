using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float speed = 0.02f;
    public float turnSpeed = 5;
    public float mouseSensitivity = 5;
    public float cameraOffSet = 5;

    private float userInputXSpeed = 0;
    private float userInputZSpeed = 0;
    private float xMouse = 0;
    private float yMouse = 0;
    private CharacterController characterController;
    private Vector3 movement;
    private bool carrying = false;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        userInputXSpeed = Input.GetAxis("Vertical") * speed;
        userInputZSpeed = Input.GetAxis("Horizontal") * speed;
        xMouse = Input.GetAxis("Mouse X");
        yMouse = Input.GetAxis("Mouse Y") * -1;

        Camera.main.transform.RotateAround(transform.position, new Vector3(yMouse, xMouse), mouseSensitivity);
        Camera.main.transform.LookAt(gameObject.transform);

        //if (characterController.isGrounded == true)
        //{
            movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            movement = transform.TransformDirection(movement);
            movement *= 5.0f;

            if (Input.GetKey(KeyCode.Space) == true)
                movement.y = 10.0f;
        //}

        movement.y -= 20.0f * Time.deltaTime;

        characterController.Move(movement * Time.deltaTime);

        //if (userInputXSpeed != 0 || userInputZSpeed != 0)
        //{
        //    GetComponent<Rigidbody>().MoveRotation(
        //        Quaternion.LookRotation(
        //            Vector3.RotateTowards(transform.forward, Camera.main.transform.forward, turnSpeed * Time.deltaTime, 0f)
        //            ));
        //    //GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + new Vector3(userInputXSpeed, 0.0f, userInputZSpeed).normalized * speed);
        //    GetComponent<CharacterController>().Move(transform.TransformDirection(Vector3.forward)*speed);
        //}
        //else
        //{
        //    GetComponent<Rigidbody>().freezeRotation = true;
        //}
    }
    private void FixedUpdate()
    {
    }

    
}

