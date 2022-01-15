using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoRoutineTest : MonoBehaviour
{   
    void Start()
    {
        //StartCoroutine("Test");

        //Test2();

        //StartCoroutine("Test3");

        StartCoroutine("Test3", 6);

        //StopCoroutine("Test3");

        //for (int i = 0; i < 6; i++)
        //{
        //    print("Start()");
        //}

    }

    IEnumerator Test()
    {
        print(" CoRoutine Starts");

        yield return new WaitForSeconds(2f);

        GetComponent<Renderer>().material.color = Color.red;

        yield return new WaitForSeconds(2f);

        // yield return null; // Odotetaan kehys loppuun ennen seuraavaa käskyä

        GetComponent<Renderer>().material.color = Color.green;

        print(" CoRoutine Ends");
    }

    void Test2()
    {
        for (int i = 0; i < 6; i++)
        {
            print("Test2()");
        }
    }

    IEnumerator Test3(int times)
    {
        for (int i = 0; i < times; i++)
        {
            print("Test3()");

            yield return null;
        }
    }

}
