using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.Rendering;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 5f;
    public float rotationSpeed = 10f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true; 
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal2");
        float moveZ = Input.GetAxis("Vertical2");

        Vector3 move = new Vector3(moveX, 0, moveZ).normalized * speed;

        if (move.magnitude > 0)
        {
            rb.velocity = new Vector3(move.x, rb.velocity.y, move.z); 

            Quaternion targetRotation = Quaternion.LookRotation(move);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.fixedDeltaTime);
        }
        else
        {
            rb.velocity = new Vector3(0, rb.velocity.y, 0);
        }
    }
}
