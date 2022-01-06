using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score 
{
    private int point;
    private int lives;

    public int Lives { get; set; }

    public int Point
    {
        get
        {
            return point; // palauttaa point – muuttujan arvon
        }

        set
        {
            if (value > 5 && value < 10)
            {
                point = value; // antaa point – muuttujalle arvon
            }
            PrintPoint();

        }

    }

    void PrintPoint()
    {
        Debug.Log(point);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
