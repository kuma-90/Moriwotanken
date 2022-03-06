using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.Events;

public class GameCameraView : MonoBehaviour
{
    public CinemachineVirtualCamera vcamera;



    public void CameraChange()
    {

        if (vcamera.Priority == 2)
        {

            vcamera.Priority = 20;

        }
        else
        {
            vcamera.Priority = 2;
        }


    }
}
