using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class AttributesTest : MonoBehaviour
{
    //[HideInInspector]
    //[SerializeField]
    //private int speed;

    [Range(0, 20)]
    public int speed;


    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
