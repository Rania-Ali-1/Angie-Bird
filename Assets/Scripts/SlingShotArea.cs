using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;  // Ensure you have this using directive for the new input system

public class SlingShotArea : MonoBehaviour
{
    [SerializeField] private LayerMask _slingshotAreaMask;

    public bool IsWithinSlingshotArea()
    {
        Vector2 worldPosition = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        if (Physics2D.OverlapPoint(worldPosition, _slingshotAreaMask))
        {
            return true;
        }
        else
        {
            return false;
        }
       
    }
}
