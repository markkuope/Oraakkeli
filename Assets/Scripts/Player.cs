using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Score score = new Score();
        //score.Point = 8;
        //print(score.Point);
        //score.Point = 3;
        //print(score.Point);
        score.Lives = 9;
        print(score.Lives);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
