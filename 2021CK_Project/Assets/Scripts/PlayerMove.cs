using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [HideInInspector]
    public float RotHInput;
    [HideInInspector]
    public float RotVInput;


    void Start()
    {
        
    }

    void Update()
    {
        if(Mathf.Abs(RotHInput) > 0.1f)
        {

        }

        if (Mathf.Abs(RotVInput) > 0.1f)
        {

        }
    }

    public void SetRotInput(Vector2 value)
    {
        RotHInput = value.x;
        RotVInput = value.y;
    }
}
