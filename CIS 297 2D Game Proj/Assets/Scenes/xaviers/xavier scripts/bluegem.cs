using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bluegem : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "player")
        {
            GameManager.bluegem++;
            Destroy(this.gameObject);
        }
    }
}
