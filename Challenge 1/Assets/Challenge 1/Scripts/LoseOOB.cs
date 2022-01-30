/*
 * Josh McGrew
 * Assignment 2: Challenge 1
 * game over when player goes out of bounds
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseOOB : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 80 || transform.position.y < -51)
        {
            ScoreManager.gameOver = true;
        }
    }
}
