using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.Rendering;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{
    private CharacterController characterController;
    public float speed = 5f;
    public float rotationSpeed = 10f;


    void Start()
    {
        characterController = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked; 
        Cursor.visible = false;
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal2");
        float moveZ = Input.GetAxis("Vertical2");
        Vector3 move = new Vector3(moveX, 0, moveZ);

        if (move.magnitude > 1f)
        {
            move.Normalize();
        }

        characterController.Move(move * Time.deltaTime * speed);

        if (move.magnitude > 0)
        {
            Quaternion targetRotation = Quaternion.LookRotation(move);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }
}
