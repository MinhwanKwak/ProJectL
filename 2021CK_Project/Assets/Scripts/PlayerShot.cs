using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : MonoBehaviour
{
    Vector3 Aim;

    int AmmoCount;
    int AmmoMaxCount;

    public void Shot()
    {
        Aim = new Vector3(Camera.main.pixelWidth / 2, Camera.main.pixelHeight / 2);
        Ray ray = Camera.main.ScreenPointToRay(Aim);
        if(Physics.Raycast(ray, out RaycastHit hit))
        {
            Debug.Log(hit.collider.name);
        }
        
    }
}
