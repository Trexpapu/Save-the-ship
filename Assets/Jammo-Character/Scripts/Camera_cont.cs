using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Camera_cont : MonoBehaviour
{
    public float zoomSensitivity = 10f;
    public CinemachineFreeLook freeLookCamera;
    private CinemachineFreeLook.Orbit topRig;
    private CinemachineFreeLook.Orbit bottomRig;
    private CinemachineFreeLook.Orbit middleRig;

    void Start()
    {
        CinemachineFreeLook.Orbit[] orbits = freeLookCamera.m_Orbits;
        bottomRig = orbits[0];
        middleRig = orbits[1];
        topRig = orbits[2];
    }

    void Update()
    {
        float zoomInput = Input.GetAxis("Mouse ScrollWheel") * zoomSensitivity;

        if (zoomInput > 0)
        {
            freeLookCamera.m_Orbits[2] = topRig;
        }
        else if (zoomInput < 0)
        {
            freeLookCamera.m_Orbits[0] = bottomRig;
        }
    }
}
