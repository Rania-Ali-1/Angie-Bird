using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IconHandler : MonoBehaviour
{
    [SerializeField] private Image[] _icons;
    [SerializeField] private Color _usedColor;

    public void UseShot(int shotNumber)
    {
        // Loop through the icons array
        for (int i = 0; i < _icons.Length; i++)
        {
            if (shotNumber == i + 1) // Adjust for one-based shotNumber
            {
                _icons[i].color = _usedColor;
                return;
            }
        }
    }
}
