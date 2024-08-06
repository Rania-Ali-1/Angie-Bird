using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ResumeBtnLevel4Controller : MonoBehaviour
{
    public void Resume()
    {
        SceneManager.LoadScene("Level5");
    }
}

