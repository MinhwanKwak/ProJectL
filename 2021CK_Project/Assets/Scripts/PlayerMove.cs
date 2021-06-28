using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public GameObject Player;

    [HideInInspector]
    public float RotHInput;
    [HideInInspector]
    public float RotVInput;
    [HideInInspector]
    public float MoveHInput;
    [HideInInspector]
    public float MoveVInput;


    void Update()
    {
        if(Mathf.Abs(MoveHInput) > 0.1f)
        {
            Player.transform.position += new Vector3(MoveHInput,0,0);
        }

        if(Mathf.Abs(MoveVInput) > 0.1f)
        {
            Player.transform.position += new Vector3(0, 0, MoveVInput);
        }
    }

    public void SetMoveInput(Vector2 value)
    {
        MoveHInput = value.x;
        MoveVInput = value.y;
    }

    public void SetRotInput(Vector2 value)
    {
        RotHInput = value.x;
        RotVInput = value.y;
    }
}
