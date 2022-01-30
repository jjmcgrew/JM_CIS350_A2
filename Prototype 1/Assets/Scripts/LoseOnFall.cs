﻿/*
 * Josh McGrew
 * Assignment 2: Prototype 1
 * script to make player lose upon falling off the road
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//attach to player
public class LoseOnFall : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -1)
        {
            ScoreManager.gameOver = true;
        }
    }
}
