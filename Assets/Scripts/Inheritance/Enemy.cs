using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public void Attack()
    {
        Debug.Log("Vihollinen hy�kk��");
        GetComponent<Renderer>().material.color = Color.red;
    }

}
