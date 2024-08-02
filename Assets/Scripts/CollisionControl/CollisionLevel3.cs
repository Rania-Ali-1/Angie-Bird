using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CollisionLevel3 : MonoBehaviour
{
    public CanvasController canvasController; // Reference to the CanvasController

    private bool hasHitCat = false;
    private bool hasHitCat2 = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Cat")
        {
            hasHitCat = true;
            Debug.Log("Cat Triggered");
            CheckAndShowCanvas();
        }
        else if (other.gameObject.name == "Cat2")
        {
            hasHitCat2 = true;
            Debug.Log("Cat2 Triggered");
            CheckAndShowCanvas();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Cat")
        {
            hasHitCat = true;
            Debug.Log("Cat Collided");
            CheckAndShowCanvas();
        }
        else if (collision.gameObject.name == "Cat2")
        {
            hasHitCat2 = true;
            Debug.Log("Cat2 Collided");
            CheckAndShowCanvas();
        }
    }

    private void CheckAndShowCanvas()
    {
        // Show the canvas only if both conditions are met
        if (hasHitCat && hasHitCat2)
        {
            canvasController.ShowCanvas();
            LevelComplete();
        }
    }

    public void LevelComplete()
    {
        // Your level complete logic here
    }
}
