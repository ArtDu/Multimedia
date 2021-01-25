using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 4.0f;
    public float JumpSpeed = 1.95f;
    public float Gravity = 20.0f;
    private Vector3 MoveDirection = Vector3.zero;
    private CharacterController Controller;
    void Start()
    {
        Controller = GetComponent<CharacterController>();
    }

    void FixedUpdate()
    {
        if (Controller.isGrounded)
        {
            MoveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            MoveDirection = transform.TransformDirection(MoveDirection);
            MoveDirection *= Speed;
        }
        MoveDirection.y -= Gravity * Time.deltaTime;
        Controller.Move(MoveDirection * Time.deltaTime);
    }
}