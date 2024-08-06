using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ResumeBtnLevel3Controller : MonoBehaviour
{
    public void Resume()
    {
        SceneManager.LoadScene("Level4");
    }
}
