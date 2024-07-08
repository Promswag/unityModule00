using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Runtime.InteropServices;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController cc;

    public float speed = 2;
    public float gravity = -9.81f;
    public float velocity = 0;
    public float jumpForce = 0.3f;
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    void Update()
    {
        velocity += gravity * Time.deltaTime;
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), velocity, Input.GetAxis("Vertical"));

        cc.Move(move * (Time.deltaTime * speed));
        if (cc.isGrounded) {
            velocity = 0;
            if (Input.GetKeyDown(KeyCode.Space)) {
                velocity = Mathf.Sqrt(jumpForce * -2f * gravity);
            }
        }
    }

    void OnTriggerEnter(Collider other) {
        if (other.isTrigger) {
            Debug.Log("Game Over");
            Destroy(gameObject);
        }
    }
}
