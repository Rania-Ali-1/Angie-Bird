using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
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
        // Reset GameManager state
        if (GameManager.instance != null)
        {
            GameManager.instance.ResetGameState();
        }

        // Reset SlingshotHandler
        SlingshotHandler slingshotHandler = FindObjectOfType<SlingshotHandler>();
        if (slingshotHandler != null)
        {
            slingshotHandler.ResetSlingshot();
        }
    }
}

