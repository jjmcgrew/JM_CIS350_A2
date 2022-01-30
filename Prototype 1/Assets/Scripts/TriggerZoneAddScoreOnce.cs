/*
 * Josh McGrew
 * Assignment 2: Prototype 1
 * add score with triggers
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//attach to TriggerZone
public class TriggerZoneAddScoreOnce : MonoBehaviour
{
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
