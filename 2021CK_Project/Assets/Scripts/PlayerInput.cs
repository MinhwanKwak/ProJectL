using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    public PlayerMove playerMove;

    public void OnMove(InputAction.CallbackContext context)
    {
        //if(context.started)
        //{
            Vector2 value = context.ReadValue<Vector2>();
            playerMove.SetMoveInput(value);
        //}
        if(context.canceled)
        {
            playerMove.SetMoveInput(Vector2.zero);
        }
        

       
    }
}
