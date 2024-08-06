using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int MaxNumberOfShots = 3;
    [SerializeField] private float _secondsToWaitBeforeDeathCheck = 3f;
   
    private int _usedNumberOfShots = 0;
    private IconHandler _iconHandler;
    private ScoreHandler _scoreHandler;

    public CanvasController canvasController;
    public GameOverCanvas gameOverCanvas;

    private bool _gameOver = false;
    public Canvas GameOverRevised;

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

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        ResetGameState();
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
            if (!_gameOver)
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

   public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void GameOver()
    {
        if (_gameOver) return;
        _gameOver = true;
        Debug.Log("Game Over!");
        if (gameOverCanvas != null)
        {
            gameOverCanvas.ShowGoCanvas();
        }
        if (GameOverRevised != null)
        {
            GameOverRevised.gameObject.SetActive(true);
        }
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
        if (!_gameOver)
        {
            GameOver();
        }
    }

    public void ResetGameState()
    {
        _usedNumberOfShots = 0;
        _gameOver = false;

        if (_iconHandler != null)
        {
            _iconHandler.ResetIcon(); // Ensure this method safely handles null checks
        }
        else
        {
            Debug.LogWarning("IconHandler reference is missing.");
        }

        if (gameOverCanvas != null)
        {
            gameOverCanvas.gameObject.SetActive(false);
        }
        else
        {
            Debug.LogWarning("GameOverCanvas reference is missing.");
        }

        if (GameOverRevised != null)
        {
            GameOverRevised.gameObject.SetActive(false);
        }
        else
        {
            Debug.LogWarning("GameOverRevised reference is missing.");
        }
    }

}

