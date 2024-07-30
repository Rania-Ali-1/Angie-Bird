using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public LevelCompleteScreen LevelCompleteScreen;
    
    public void LevelComp()
    {
        LevelCompleteScreen.Setup();
    }
}
