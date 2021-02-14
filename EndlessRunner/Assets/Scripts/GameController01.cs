using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController01 : MonoBehaviour
{
    //############## SCROLLING THROUGH DIFFRENT CAMERAS ################
    public GameObject[] gameCameras;
    private int gameCamerasIndex = 0;

    private void Start()
    {
        FocusOnCamera(gameCamerasIndex);
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ChangeCamera(1);
        }
    }


    //##########################################################################
    void FocusOnCamera(int index)
    {
        for(int i = 0; i < gameCameras.Length; i++)
        {
            gameCameras[i].SetActive(i == index);
        }
    }
    void ChangeCamera(int CamIndexScroll)// this parameter is to increase or decrese camera index by1 or -1
    {
        gameCamerasIndex += CamIndexScroll;
        if (gameCamerasIndex>=4)
        {
            gameCamerasIndex = 0;
        }
        else if (gameCamerasIndex<=0)
        {
            gameCamerasIndex = gameCameras.Length-1;
        }
        
        FocusOnCamera(gameCamerasIndex);

    }
}
