using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag == "fish")
        {
            LevelComplete();
        }
    }

    public void LevelComplete()
    {

    }

}
