using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AssignmentManager : MonoBehaviour
{
    public GameObject hotelA;
    public GameObject hotelB;
    public GameObject hotelC;
    public GameObject hotelD;

    public GameObject objectToActivate1A;
    public GameObject objectToActivate2A;
    public GameObject objectToActivate3A;
    public GameObject objectToActivate4A;

    public GameObject objectToActivate1B;
    public GameObject objectToActivate2B;
    public GameObject objectToActivate3B;
    public GameObject objectToActivate4B;

    public GameObject objectToActivate1C;
    public GameObject objectToActivate2C;
    public GameObject objectToActivate3C;
    public GameObject objectToActivate4C;

    public GameObject objectToActivate1D;
    public GameObject objectToActivate2D;
    public GameObject objectToActivate3D;
    public GameObject objectToActivate4D;

    public GameObject managerToDeactivateA;
    public GameObject managerToDeactivateB;
    public GameObject managerToDeactivateC;
    public GameObject managerToDeactivateD;

    public GameObject activityToDeactivateA;
    public GameObject activityToDeactivateB;
    public GameObject activityToDeactivateC;
    public GameObject activityToDeactivateD;

    public GameObject activityToActivateA;
    public GameObject activityToActivateB;
    public GameObject activityToActivateC;
    public GameObject activityToActivateD;

    public GameObject windowCanvas;

    public AudioSource buttonClickAudioSource;


    public void OnButton1Click()
    {
        buttonClickAudioSource.Play();
        
        if (hotelA.activeSelf)
        {
            objectToActivate1A.SetActive(true);

            managerToDeactivateA.SetActive(false);
            activityToDeactivateA.SetActive(false);
            activityToActivateA.SetActive(true);
        }
        else if (hotelB.activeSelf)
        {
            objectToActivate1B.SetActive(true);

            managerToDeactivateB.SetActive(false);
            activityToDeactivateB.SetActive(false);
            activityToActivateB.SetActive(true);
        }
        else if (hotelC.activeSelf)
        {
            objectToActivate1C.SetActive(true);

            managerToDeactivateC.SetActive(false);
            activityToDeactivateC.SetActive(false);
            activityToActivateC.SetActive(true);
        }
        else if (hotelD.activeSelf)
        {
            objectToActivate1D.SetActive(true);

            managerToDeactivateD.SetActive(false);
            activityToDeactivateD.SetActive(false);
            activityToActivateD.SetActive(true);
        }
       
        windowCanvas.SetActive(false); //Close the second window

    }


    public void OnButton2Click()
    {
        if (hotelA.activeSelf)
        {
            objectToActivate2A.SetActive(true);

            managerToDeactivateA.SetActive(false);
            activityToDeactivateA.SetActive(false);
            activityToActivateA.SetActive(true);
        }
        else if (hotelB.activeSelf)
        {
            objectToActivate2B.SetActive(true);

            managerToDeactivateB.SetActive(false);
            activityToDeactivateB.SetActive(false);
            activityToActivateB.SetActive(true);
        }
        else if (hotelC.activeSelf)
        {
            objectToActivate2C.SetActive(true);

            managerToDeactivateC.SetActive(false);
            activityToDeactivateC.SetActive(false);
            activityToActivateC.SetActive(true);
        }
        else if (hotelD.activeSelf)
        {
            objectToActivate2D.SetActive(true);

            managerToDeactivateD.SetActive(false);
            activityToDeactivateD.SetActive(false);
            activityToActivateD.SetActive(true);
        }
       
        windowCanvas.SetActive(false); //Close the second window
        buttonClickAudioSource.Play();
    }


    public void OnButton3Click()
    {
        if (hotelA.activeSelf)
        {
            objectToActivate3A.SetActive(true);

            managerToDeactivateA.SetActive(false);
            activityToDeactivateA.SetActive(false);
            activityToActivateA.SetActive(true);
        }
        else if (hotelB.activeSelf)
        {
            objectToActivate3B.SetActive(true);

            managerToDeactivateB.SetActive(false);
            activityToDeactivateB.SetActive(false);
            activityToActivateB.SetActive(true);
        }
        else if (hotelC.activeSelf)
        {
            objectToActivate3C.SetActive(true);

            managerToDeactivateC.SetActive(false);
            activityToDeactivateC.SetActive(false);
            activityToActivateC.SetActive(true);
        }
        else if (hotelD.activeSelf)
        {
            objectToActivate3D.SetActive(true);

            managerToDeactivateD.SetActive(false);
            activityToDeactivateD.SetActive(false);
            activityToActivateD.SetActive(true);
        }
                
        windowCanvas.SetActive(false); //Close the second window
        buttonClickAudioSource.Play();
    }

    public void OnButton4Click()
    {
        if (hotelA.activeSelf)
        {
            objectToActivate4A.SetActive(true);

            managerToDeactivateA.SetActive(false);
            activityToDeactivateA.SetActive(false);
            activityToActivateA.SetActive(true);
        }
        else if (hotelB.activeSelf)
        {
            objectToActivate4B.SetActive(true);

            managerToDeactivateB.SetActive(false);
            activityToDeactivateB.SetActive(false);
            activityToActivateB.SetActive(true);
        }
        else if (hotelC.activeSelf)
        {
            objectToActivate4C.SetActive(true);

            managerToDeactivateC.SetActive(false);
            activityToDeactivateC.SetActive(false);
            activityToActivateC.SetActive(true);
        }
        else if (hotelD.activeSelf)
        {
            objectToActivate4D.SetActive(true);

            managerToDeactivateD.SetActive(false);
            activityToDeactivateD.SetActive(false);
            activityToActivateD.SetActive(true);
        }
                
        windowCanvas.SetActive(false); //Close the second window
        buttonClickAudioSource.Play();
    }
}
