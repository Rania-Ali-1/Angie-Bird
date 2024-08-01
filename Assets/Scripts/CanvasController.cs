using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    public Canvas LevelCompleteRevised; // Reference to the Canvas

    private void Start()
    {
        HideCanvas(); // Hide the Canvas at the start
    }

    // Method to hide the Canvas
    public void HideCanvas()
    {
        if (LevelCompleteRevised != null)
        {
            LevelCompleteRevised.gameObject.SetActive(false);
        }
        else
        {
            Debug.LogError("CanvasLevelComplete is not assigned in the inspector.");
        }
    }
    public void ShowCanvas()
    {
        LevelCompleteRevised.gameObject.SetActive(true);
    }
}
