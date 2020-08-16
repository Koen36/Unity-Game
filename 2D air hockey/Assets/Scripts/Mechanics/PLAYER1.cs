﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAYER1 : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rb;
    private Vector2 moveVelocity;

    private float vx1;
    private float vx2;
    private float vx;

    private float vy1;
    private float vy2;
    private float vy;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //PLAYER 1
        //KeyDown
        if (Input.GetKeyDown(KeyCode.S))
        {
            vy1 = vy1 - 1.0f;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            vy2 = vy2 + 1.0f;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            vx1 = vx1 - 1.0f;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            vx2 = vx2 + 1.0f;
        }
        //KeyUp
        if (Input.GetKeyUp(KeyCode.S))
        {
            vy1 = 0.0f;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            vy2 = 0.0f;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            vx1 = 0.0f;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            vx2 = 0.0f;
        }

        vy = vy1 + vy2;
        vx = vx1 + vx2;

        moveVelocity = new Vector2(vx, vy).normalized * speed;

        //Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        //moveVelocity = moveInput.normalized * speed;
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }
}