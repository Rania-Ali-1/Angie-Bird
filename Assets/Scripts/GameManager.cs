using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int MaxNumberOfShots = 3;
    private int _usedNumberOfShots;
    private IconHandler _iconHandler;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        _iconHandler = FindObjectOfType<IconHandler>();
    }
    public void UseShot()
    {
        _usedNumberOfShots++;
        _usedNumberOfShots = _usedNumberOfShots + 1;
        _iconHandler.UseShot(_usedNumberOfShots);
    }

    public bool HasEnoughShots()
    {
        if (_usedNumberOfShots < MaxNumberOfShots)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
