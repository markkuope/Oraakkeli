using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public void Attack()
    {
        print("Vihollinen hyökkää");
        GetComponent<Renderer>().material.color = Color.red;
    }

    Tankki tankki = new Tankki();
    Tankki tankki2 = new HarmaaTankki();
    Tankki tankki3 = new MustaTankki();

    private void Start()
    {
        Attack();
        tankki.Attack();
        tankki2.Attack();
        tankki3.Attack();
    }
}

