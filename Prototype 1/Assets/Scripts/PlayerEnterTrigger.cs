﻿/*
 * Josh McGrew
 * Assignment 2: Prototype 1
 * player trigger
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//attach this to the player
public class PlayerEnterTrigger : MonoBehaviour
{
    //set this reference in the inspector
    public Text textbox;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TriggerZone"))
        {
            textbox.text = "You Win";
        }

    }
}
