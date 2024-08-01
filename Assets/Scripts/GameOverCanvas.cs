using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverCanvas : MonoBehaviour
{
    public Canvas GameOverRevised; // Reference to the Canvas

    private void Start()
    {
        HideCanvas(); 
    }

    public void HideCanvas()
    {
        if (GameOverRevised != null)
        {
            GameOverRevised.gameObject.SetActive(false);
        }
        else
        {
            Debug.LogError("Game over is not assigned in the inspector.");
        }
    }
    public void ShowGoCanvas()
    {
        GameOverRevised.gameObject.SetActive(true);
    }
}
