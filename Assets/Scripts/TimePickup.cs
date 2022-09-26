using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimePickup : MonoBehaviour
{
    public int timeIncrement = 3;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Timer.timeValue += timeIncrement;
            Destroy(gameObject);
        }
    }
}