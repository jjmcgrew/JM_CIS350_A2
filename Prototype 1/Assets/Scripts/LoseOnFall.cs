/*
 * Josh McGrew
 * Assignment 2: Prototype 1
 * script to make player lose upon falling off the road
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//attach to player
public class LoseOnFall : MonoBehaviour
{
    public Text textbox;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -1)
        {
            textbox.text = "You Lose";
        }
    }
}
