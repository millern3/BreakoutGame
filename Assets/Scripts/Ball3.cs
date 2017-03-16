﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball3 : MonoBehaviour {
    public Vector2 startingVelocity = new Vector2(5, -15);
    private Vector3 startingPosition;
    public GameObject gameOverSign;
    public GameObject youWinSign;
    public Text livesValue;
    public Text pointsValue;

    int lives = 4;
    int points = 0;

	// Use this for initialization
	void Start () {
        startingPosition = transform.position;
        GetComponent<Rigidbody2D>().velocity = startingVelocity;
        livesValue.text = lives.ToString();
		
	}
	
	// Update is called once per frame
	void Update () {
        if(transform.position.y < -4.4f)
        {
            GetOut();
        }
        if(Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody2D>().velocity = startingVelocity;
        }
	}

    internal void BrickBroken3(int points)
    {
        throw new NotImplementedException();
    }

    void GetOut()
    {
        Debug.Log("You are out");
        lives = lives - 1;
        livesValue.text = lives.ToString();

        transform.position = startingPosition;
        GetComponent<Rigidbody2D>().velocity = new Vector2();
  
        if(lives == 0)
        {
            DoGameOver();
        }
    }
    void DoGameOver()
    {
        gameOverSign.SetActive(true);
    }
    public void BrickBroken3()
    {
        points += 1;
        pointsValue.text = points.ToString();

        var bricksLeft = FindObjectsOfType<Brick>().Length;
        if(bricksLeft == 0)
        {
            youWinSign.SetActive(true);
        }
    }
}
