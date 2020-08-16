﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DualPlayer : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed;
    private Vector2 targetPosition;
    private int Break = 0;

    void Start()
    {

        targetPosition = new Vector2(0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Break == 0)
        {
            targetPosition = Input.mousePosition;
            targetPosition = Camera.main.ScreenToWorldPoint(new Vector3(targetPosition.x, targetPosition.y, 0.0f));
        }
        this.transform.position = Vector2.MoveTowards(this.transform.position, targetPosition, speed * Time.deltaTime);


    }
}