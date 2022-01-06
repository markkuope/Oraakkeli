using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Auto
{
    public float speed;
    public string color;
    public int highestSpeed;

    public Auto()
    {
        Debug.Log("Auto() kutsuttu");
    }
    public Auto(float s)
    {
        this.speed = s;
        Debug.Log("Auto(float) kutsuttu");
        Debug.Log("Speed = " + s);
    }
    public Auto(float s, string c)
    {
        this.speed = s;
        this.color = c;
        Debug.Log("Auto(float, string) kutsuttu");
        Debug.Log("Speed = " + s + "  Color = " + c);

    }



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

    public void PrintCarDetails()
    {
        Debug.Log("Speed = " + speed);
        Debug.Log("Color = " + color);
        Debug.Log("HighestSpeed = " + highestSpeed);
    }




}
