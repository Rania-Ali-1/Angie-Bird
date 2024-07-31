using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    public Canvas CanvasLevelComplete; // Reference to the Canvas

    private void Start()
    {
        HideCanvas(); // Hide the Canvas at the start
    }

    // Method to hide the Canvas
    public void HideCanvas()
    {
        if (CanvasLevelComplete != null)
        {
            CanvasLevelComplete.gameObject.SetActive(false);
        }
        else
        {
            Debug.LogError("CanvasLevelComplete is not assigned in the inspector.");
        }
    }
    // Method to show the Canvas
    public void ShowCanvas()
    {
        CanvasLevelComplete.gameObject.SetActive(true);
    }
}
