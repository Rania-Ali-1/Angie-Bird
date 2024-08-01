using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int MaxNumberOfShots = 3;
    [SerializeField] private float _secondsToWaitBeforeDeathCheck = 3f;

    private int _usedNumberOfShots = 0; // Initialize to 0
    private IconHandler _iconHandler;
    private ScoreHandler _scoreHandler;

    public CanvasController canvasController;
    public GameOverCanvas gameOverCanvas;

    private bool _gameOver = false; // Track game over state
    public Canvas GameOverRevised; // Reference to the Canvas

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
        if (_iconHandler == null)
        {
            Debug.LogError("IconHandler is not found in the scene.");
        }
    }

    public void UseShot()
    {
        if (HasEnoughShots())
        {
            _usedNumberOfShots++;
            _iconHandler.UseShot(_usedNumberOfShots);
            CheckForLastShot();
        }
        else
        {
            Debug.LogWarning("No more shots available!");
            if (!_gameOver) // Only call GameOver if not already called
            {
                _usedNumberOfShots = 0;
                GameOver();
            }
        }
    }

    public bool HasEnoughShots()
    {
        return _usedNumberOfShots < MaxNumberOfShots;
    }

    public int GetRemainingShots()
    {
        return MaxNumberOfShots - _usedNumberOfShots;
    }

    public void CalScore()
    {
        // _scoreHandler.ScoreCalc(_usedNumberOfShots);
    }

    private void GameOver()
    {
        if (_gameOver) return; // Avoid multiple calls to GameOver
        _gameOver = true;
        Debug.Log("Game Over!");
        gameOverCanvas.ShowGoCanvas();
        GameOverRevised.gameObject.SetActive(true);
    }

    public void CheckForLastShot()
    {
        if (_usedNumberOfShots >= MaxNumberOfShots)
        {
            StartCoroutine(CheckAfterWaitTime());
        }
    }

    private IEnumerator CheckAfterWaitTime()
    {
        yield return new WaitForSeconds(_secondsToWaitBeforeDeathCheck);
        if (!_gameOver) // Ensure GameOver is only called if not already set
        {
            GameOver();
        }
    }

    public void ResetGameState()
    {
        _usedNumberOfShots = 0;
        _gameOver = false;
        _iconHandler.ResetIcon(); // Ensure this method is defined in IconHandler
        // Optionally, reset other game state components here
    }
}
