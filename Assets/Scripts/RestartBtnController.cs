using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartBtnController : MonoBehaviour
{
    public void Restart()
    {
        StartCoroutine(ReloadScene());
    }

    private IEnumerator ReloadScene()
    {
        yield return new WaitForSeconds(0.1f); // Adjust the delay as needed
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);

        // Reset the GameManager state after loading the scene
        if (GameManager.instance != null)
        {
            GameManager.instance.ResetGameState();
        }
    }
}

