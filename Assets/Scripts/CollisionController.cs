using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public CanvasController canvasController; // Reference to the CanvasController

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Cat")
        {
            canvasController.ShowCanvas(); // Show the Canvas when the object named "Cat" triggers the collider
            LevelComplete();
        }
    }

    public void LevelComplete()
    {
        // Your level complete logic here
    }
}
