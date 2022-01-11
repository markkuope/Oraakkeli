using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticTest : MonoBehaviour
{

    public static int PlayerCount; //Pelaajien lukum‰‰r‰

    void Start()
    {
        PlayerCount++;

        //Bullets bullet1 = new Bullets();
        ////Bullets.noOfBullets = 10;

        //Bullets bullet2 = new Bullets();
        ////Bullets.noOfBullets = 20;

        //Bullets bullet3 = new Bullets();

        ////print(Bullets.noOfBullets);
        ////print(bullet2.noOfBullets);

        //Bullets.ShowBullets();

        print("Pelaajien lukum‰‰r‰ on: " + PlayerCount);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
} // t‰h‰n p‰‰ttyy StaticTest

public class Bullets
{
    public static int noOfBullets = 0;

    public Bullets()  // constructor -funktio
    {
        noOfBullets++; // arvo kasvaa yhdell‰ aina kun muodostetaan uusi Bullets -muuttuja.
    }

    public static void ShowBullets()
    {
        Debug.Log("NO of Bullets :" + noOfBullets);
    }
}

