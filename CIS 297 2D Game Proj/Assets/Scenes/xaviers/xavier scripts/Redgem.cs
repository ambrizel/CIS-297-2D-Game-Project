using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Redgem : MonoBehaviour
{

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "player")
        {
            GameManager.redgem++;
            Destroy(this.gameObject);
        }
    }


}
