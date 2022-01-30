/*
 * Josh McGrew
 * Assignment 2: Challenge 1
 * script to add score when player hits triggers
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAddScore : MonoBehaviour
{
    //method adds score if player hits trigger, only once per trigger
    private bool triggered = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            ScoreManager.score++;
        }
    }
}
