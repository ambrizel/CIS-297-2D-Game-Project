using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greengem : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "player")
        {
            GameManager.greengem++;
            Destroy(this.gameObject);
        }
    }
}
