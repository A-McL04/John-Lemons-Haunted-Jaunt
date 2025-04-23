using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraTransition : MonoBehaviour
{
    public CinemachineVirtualCamera virtualCamera1;
    public CinemachineVirtualCamera virtualCamera2;
    public CinemachineVirtualCamera virtualCamera3;
    public CinemachineVirtualCamera virtualCamera4;
    public CinemachineVirtualCamera virtualCamera5;
    public CinemachineVirtualCamera virtualCamera6;

    void Start()
    {
        virtualCamera1 = GameObject.Find("FirstVirtualCamera").GetComponent<CinemachineVirtualCamera>();
        virtualCamera2 = GameObject.Find("SecondVirtualCamera").GetComponent<CinemachineVirtualCamera>();
        virtualCamera3 = GameObject.Find("ThirdVirtualCamera").GetComponent<CinemachineVirtualCamera>();
        virtualCamera4 = GameObject.Find("ForthVirtualCamera").GetComponent<CinemachineVirtualCamera>();
        virtualCamera5 = GameObject.Find("FifthVirtualCamera").GetComponent<CinemachineVirtualCamera>();
        virtualCamera6 = GameObject.Find("SixthVirtualCamera").GetComponent<CinemachineVirtualCamera>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && this.tag == "Camera1")
        {
            virtualCamera1.Priority = 11;
        }
        else if (other.tag == "Player" && this.tag == "Camera2")
        {
            virtualCamera2.Priority = 11;
        }
        else if (other.tag == "Player" && this.tag == "Camera3")
        {
            virtualCamera3.Priority = 11;
        }
        else if (other.tag == "Player" && this.tag == "Camera4")
        {
            virtualCamera4.Priority = 11;
        }
        else if (other.tag == "Player" && this.tag == "Camera5")
        {
            virtualCamera5.Priority = 11;
        }
        else if (other.tag == "Player" && this.tag == "Camera6")
        {
            virtualCamera6.Priority = 11;
        }
    }
}
