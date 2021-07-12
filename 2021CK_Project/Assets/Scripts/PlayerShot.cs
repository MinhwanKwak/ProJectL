using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerShot : MonoBehaviour
{
    Vector3 Aim;

    int AmmoCount;
    int AmmoMaxCount;

    GameObject CamPivot;

    public void Start()
    {
        CamPivot = PlayerManager.Instance.playerMove.CamPivot;
    }

    public void Shot()
    {
        CamPivot.transform.DOLocalRotate(CamPivot.transform.localEulerAngles - new Vector3(1, 0, 0), 0.2f).OnComplete(() => CamPivot.transform.DOLocalRotate(CamPivot.transform.localEulerAngles + new Vector3(1, 0, 0), 0.2f));
        


        Aim = new Vector3(Camera.main.pixelWidth / 2, Camera.main.pixelHeight / 2);
        Ray ray = Camera.main.ScreenPointToRay(Aim);
        if(Physics.Raycast(ray, out RaycastHit hit))
        {
            Debug.Log(hit.collider.name);
        }
        
    }
}
