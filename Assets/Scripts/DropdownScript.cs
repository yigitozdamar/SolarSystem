using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.UI;

public class DropdownScript : MonoBehaviour
{
    
    public CinemachineVirtualCamera mainCam,mercuryCam,venusCam,earthCam,
        marsCam,saturnCam,jupiterCam,uranusCam,neptunCam,plutonCam;
    public Dropdown dDownList;
    private List<CinemachineVirtualCamera> camList = new List<CinemachineVirtualCamera>();

    
   
    public void ButtonClickAction()
    {
        camList.Add(mainCam);
        camList.Add(mercuryCam);
        camList.Add(venusCam);
        camList.Add(earthCam);
        camList.Add(marsCam);
        camList.Add(saturnCam);
        camList.Add(jupiterCam);
        camList.Add(uranusCam);
        camList.Add(neptunCam);
        camList.Add(plutonCam);


        if (dDownList.value == 0)
        {
            foreach (CinemachineVirtualCamera cam in camList)
            {
                cam.m_Priority = 10;
                mainCam.m_Priority = 100;
            }
            
        }
        else if (dDownList.value == 1)
        {
            foreach (CinemachineVirtualCamera cam in camList)
            {
                cam.m_Priority = 10;
                mercuryCam.m_Priority = 100;
            }
        }
        else if (dDownList.value == 2)
        {
            foreach (CinemachineVirtualCamera cam in camList)
            {
                cam.m_Priority = 10;
                venusCam.m_Priority = 100;
            }
            
        }
        else if (dDownList.value == 3)
        {
            foreach (CinemachineVirtualCamera cam in camList)
            {
                cam.m_Priority = 10;
                earthCam.m_Priority = 100;
            }
        }
        else if (dDownList.value == 4)
        {
            foreach (CinemachineVirtualCamera cam in camList)
            {
                cam.m_Priority = 10;
                marsCam.m_Priority = 100;
            }
        }
        else if (dDownList.value == 5)
        {
            foreach (CinemachineVirtualCamera cam in camList)
            {
                cam.m_Priority = 10;
                saturnCam.m_Priority = 100;
            }
        }
        else if (dDownList.value == 6)
        {
            foreach (CinemachineVirtualCamera cam in camList)
            {
                cam.m_Priority = 10;
                jupiterCam.m_Priority = 100;
            }
        }
        else if (dDownList.value == 7)
        {
            foreach (CinemachineVirtualCamera cam in camList)
            {
                cam.m_Priority = 10;
                uranusCam.m_Priority = 100;
            }
        }
        else if (dDownList.value == 8)
        {
            foreach (CinemachineVirtualCamera cam in camList)
            {
                cam.m_Priority = 10;
                neptunCam.m_Priority = 100;
            }
        }
        else if (dDownList.value == 9)
        {
            foreach (CinemachineVirtualCamera cam in camList)
            {
                cam.m_Priority = 10;
                plutonCam.m_Priority = 100;
            }
        }
        
    }


}
