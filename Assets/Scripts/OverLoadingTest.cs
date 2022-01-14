using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverLoadingTest : MonoBehaviour
{   
    void Start()
    {
        Fun fun = new Fun();

        //fun.printFloat(2.5f);

        //fun.printInt(2);

        //fun.printString("Markku");

        //fun.Print(2);
        //fun.Print(2.5f);
        //fun.Print("Markku taas");

        fun.Print(1);

        fun.Print(1, 2);

       

    }

} // OverLoadingTest p‰‰ttyy t‰h‰n

public class Fun
{
    //public void printInt(int i)
    //{
    //    Debug.Log(i);
    //}
    //public void printFloat(float i)
    //{
    //    Debug.Log(i);
    //}
    //public void printString(string i)
    //{
    //    Debug.Log(i);
    //}

    public void Print(int i)
    {
        Debug.Log("Print(int i) Getting Called");
    }
    public void Print(float i)
    {
        Debug.Log("Print(float i) Getting Called");
    }

    public void Print(string i)
    {
        Debug.Log("Print(string i) Getting Called");
    }

    public void Print(int i, int j)
    {
        Debug.Log("Print(int i, int j) Getting Called");

    }




}

