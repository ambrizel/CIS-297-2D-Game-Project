using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tester : MonoBehaviour
{

    public void Awake()
    {
        Debug.Log("asdfasfd");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("asdfasfd");
    }
}
