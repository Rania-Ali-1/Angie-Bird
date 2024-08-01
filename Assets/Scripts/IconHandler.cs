using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IconHandler : MonoBehaviour
{
    [SerializeField] private Image[] _icons;
    [SerializeField] private Color _usedColor;
    [SerializeField] private Color _defaultColor; // Add this to store the default color

    private void Start()
    {
        // Set the default color for each icon at the start
        foreach (var icon in _icons)
        {
            icon.color = _defaultColor;
        }
    }

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

    public void ResetIcon()
    {
        // Reset all icons to their default color
        foreach (var icon in _icons)
        {
            icon.color = _defaultColor;
        }
    }
}
