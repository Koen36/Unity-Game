﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score41 : MonoBehaviour
{
    public Rigidbody2D rb;

    private int Lives;

    public int Levens;
    public Text BlueScore;
    public Text GreenScore;
    public Text YellowScore;
    public Text RedScore;

    public GameObject Blue;
    public Vector3 StartPointBlue;
    public GameObject Green;
    public Vector3 StartPointGreen;
    public GameObject Yellow;
    public Vector3 StartPointYellow;
    public GameObject Red;
    public Vector3 StartPointRed;
    public GameObject Ball;
    public Vector3 StartPointBall;

    void Start()
    {
        Lives = Lives + Levens;
        BlueScore.text = Lives.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Ball") //zorgt ervoor dat alleen de bal er door heen kan
        {
            Hit();
            Blue.transform.position = StartPointBlue;
            Green.transform.position = StartPointGreen;
            Yellow.transform.position = StartPointYellow;
            Red.transform.position = StartPointRed;
            rb.velocity = new Vector3(0, 0, 0);
            Ball.transform.position = StartPointBall;
        }
    }
    void Hit()
    {
        if (Lives > 0)
        {
            Lives--;
            BlueScore.text = Lives.ToString();
        }

        if (Lives == 0)
        {
            Blue.gameObject.SetActive(false);
            BlueScore.text = "Lost".ToString();
        }

        if (Lives > 0 && GreenScore.text == "Lost" && YellowScore.text == "Lost" && RedScore.text == "Lost")
        {
            WinningScene();
        }
    }

    void WinningScene()
    {
        BlueScore.text = "Champion".ToString();
        //leuke animatie of iets
        PauseMenu();
    }

    void PauseMenu()
    {

    }
}