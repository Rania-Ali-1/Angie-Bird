using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ResumeBtnLevel2Controller : MonoBehaviour
{
    public void Resume()
    {
        SceneManager.LoadScene("Level3");
    }
}
