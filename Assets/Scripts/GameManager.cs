using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int MaxNumberOfShots = 3;
    private int _usedNumberOfShots = 0; // Initialize to 0
    private IconHandler _iconHandler;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        _iconHandler = FindObjectOfType<IconHandler>();
    }

    public void UseShot()
    {
        if (HasEnoughShots())
        {
            _usedNumberOfShots++;
            _iconHandler.UseShot(_usedNumberOfShots);
        }
        else
        {
            Debug.LogWarning("No more shots available!");
            GameOver();
        }
    }

    public bool HasEnoughShots()
    {
        return _usedNumberOfShots < MaxNumberOfShots;
    }

    // Optional: Return the remaining shots
    public int GetRemainingShots()
    {
        return MaxNumberOfShots - _usedNumberOfShots;
    }

    // Game Over method
    private void GameOver()
    {
        Debug.Log("Game Over!");
        // Implement game over logic here
        // For example, show a game over screen or restart the level
    }
}
