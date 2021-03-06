using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimHandMove : MonoBehaviour
{
    public Transform location;
    public Vector3 position;
    public float moveSpeed;
    public float turnSpeed;
    public float sprintMultiplier;


    // Start is called before the first frame update
    void Start()
    {
        //Sets position to location.position
        transform.position = location.position;

        // This basically always centers mouse cursor so it doesnt leave game window 
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
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
        #region Rotation using Keyboard
        //if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.A))
        //{
        //    transform.Rotate(Vector3.down * Time.deltaTime * turnSpeed, Space.World);
        //}
        //else if (Input.GetKey(KeyCode.A))
        //{
        //    transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
        //}
        //if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.E))
        //{
        //    transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed, Space.World);
        //}
        //if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.Z))
        //{
        //    transform.Rotate(Vector3.left * Time.deltaTime * turnSpeed, Space.Self);
        //}
        //if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.C))
        //{
        //    transform.Rotate(Vector3.right * Time.deltaTime * turnSpeed, Space.Self);
        //}
        #endregion

        #region Rotation using Mouse
        transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * turnSpeed, Space.Self);
        //transform.Rotate(Vector2.left * Input.GetAxis("Mouse Y") * turnSpeed, Space.Self);

        #endregion
        // sprint?
        DoSprint();

        //Lerp Example
        //transform.position = Vector3.Lerp(transform.position, position, Time.deltaTime);
    }

    private void DoSprint()
    {
        //var acceleration = moveSpeed * sprintMultiplier;
        //moveSpeed = Mathf.Lerp(moveSpeed, acceleration, Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            moveSpeed *= sprintMultiplier;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            moveSpeed /= sprintMultiplier;
        }
        //Debug.Log($"{transform.position}");
    }

    
}
