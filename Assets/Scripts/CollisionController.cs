using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public CanvasController canvasController; // Reference to the CanvasController

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Angie Bird")
        {
            Debug.Log("Success");
            canvasController.ShowCanvas(); // Show the Canvas when the object named "Cat" triggers the collider
            LevelComplete();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Angie Bird" || collision.gameObject.CompareTag("fish"))
        {
            Debug.Log("Success");
            canvasController.ShowCanvas(); // Show the Canvas when the object named "Angie Bird" or tagged "fish" triggers the collider
            LevelComplete();
        }
    }

    public void LevelComplete()
    {
        // Your level complete logic here
    }
}
