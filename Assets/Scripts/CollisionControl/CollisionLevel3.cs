using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionLevel3 : MonoBehaviour
{
    public CanvasController canvasController; // Reference to the CanvasController

    private bool hasHitCat = false;
    private bool hasHitCat2 = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the collider belongs to one of the tagged objects
        if (other.CompareTag("cat"))
        {
            hasHitCat = true;
            Debug.Log("Cat Triggered");
            CheckAndShowCanvas();
        }
        else if (other.CompareTag("cat2"))
        {
            hasHitCat2 = true;
            Debug.Log("Cat2 Triggered");
            CheckAndShowCanvas();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("heyy");
        // Check if the collided object belongs to one of the tagged objects
        if (collision.gameObject.name == "Angie Bird" || collision.gameObject.CompareTag("fish"))
        {
            hasHitCat = true;
            Debug.Log("Cat Collided");
            CheckAndShowCanvas();
        }
        else if (collision.gameObject.name == "Angie Bird" || collision.gameObject.CompareTag("fish"))
        {
            hasHitCat2 = true;
            Debug.Log("Cat2 Collided");
            CheckAndShowCanvas();
        }
    }

    private void CheckAndShowCanvas()
    {
        Debug.Log($"CheckAndShowCanvas: hasHitCat = {hasHitCat}, hasHitCat2 = {hasHitCat2}");

        // Show the canvas only if both conditions are met
        if (hasHitCat && hasHitCat2)
        {
            if (canvasController != null)
            {
                Debug.Log("Showing Canvas");
                canvasController.ShowCanvas();
                LevelComplete();
            }
            else
            {
                Debug.LogError("CanvasController is not assigned!");
            }
        }
    }

    public void LevelComplete()
    {
        Debug.Log("Level Complete");
        // Your level complete logic here
    }
}
