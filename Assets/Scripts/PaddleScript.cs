//Valentine Nkowa
// 1/31/25
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PaddleScript : MonoBehaviour
{
    // Vars
    protected Vector3 MoveDirection = Vector3.zero;
    [SerializeField, Range(1,20)] protected float MoveSpeed = 1f;
    //[SerializeField, Range(10,29)] protected float MaxSpeed = 20f;

    //Methods

    private void Update()
    {
        MovePaddle();
    }
    //Get inputs from action
    public void MoveInput(InputAction.CallbackContext aContext)
    {
        Vector2 aV2 = aContext.ReadValue<Vector2>();
        MoveDirection.x = aV2.x;
        MoveDirection.z = aV2.y;
    }

    //Move the paddle
    public void MovePaddle()
    {
       transform.Translate(MoveDirection * MoveSpeed * Time.deltaTime); //transforms game obj based on the direction x speed  
    }

    //Accessors
}
