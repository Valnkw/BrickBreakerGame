//Valentine Nkowa
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PaddleScript : MonoBehaviour
{
    // Vars
    protected Vector3 aMoveDirection = Vector3.zero;

    //Methods
    public void MovePaddle(InputAction.CallbackContext aContext)
    {
        aMoveDirection = Vector3.zero;
    }

    //Accessors
}
