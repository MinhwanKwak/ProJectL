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

    bool IsVRotAim = true;

    float Sensitivity = 1.0f;

    void Update()
    {
        if (Mathf.Abs(MoveHInput) > 0.1f)
        {
            //Player.transform.localPosition += new Vector3(MoveHInput,0,0);
            Player.transform.localPosition += Player.transform.right * MoveHInput;
        }

        if (Mathf.Abs(MoveVInput) > 0.1f)
        {
            //Player.transform.localPosition += new Vector3(0, 0, MoveVInput);
            Player.transform.localPosition += Player.transform.forward * MoveVInput;
        }

        //if (Mathf.Abs(RotHInput) > 0.1f)
        //{
        //    Player.transform.Rotate(0, RotHInput, 0);
        //}

        if (Player.transform.eulerAngles.x >= 30.0f && Player.transform.eulerAngles.x <= 340.0f) // 시야범위 바깥
        {
            IsVRotAim = false;
            if (Player.transform.eulerAngles.x >= 330.0f)
            {
                // value (0,1) 못하게?
                Player.transform.eulerAngles = new Vector3(340.001f, Player.transform.eulerAngles.y, Player.transform.eulerAngles.z);
            }
            else
            {
                // value (0,-1) 못하게?
                Player.transform.eulerAngles = new Vector3(29.999f, Player.transform.eulerAngles.y, Player.transform.eulerAngles.z);
            }
        }
        else
            IsVRotAim = true;

        if (Mathf.Abs(RotVInput) > 0.1f)
        {
            if (RotVInput < 0)
            {
                Sensitivity = -1.0f;
            }
            else
                Sensitivity = 1.0f;

            if(IsVRotAim)
            {
                Player.transform.Rotate(new Vector3(-Sensitivity, 0, 0));
            }
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
