using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Auto
{
    public float speed;
    public string color;
    public int highestSpeed;

    void Move()
    {
        Debug.Log("Moving");
    }

    void ApplyBrake()
    {
        Debug.Log("Applying Brake");
    }
    public void CarSpeed()
    {
        Debug.Log(speed);
    }



}
