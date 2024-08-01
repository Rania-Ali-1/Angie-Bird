using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResumeBtnController : MonoBehaviour
{
    public void Resume()
    {
        SceneManager.LoadScene("Level2");
    }
}
