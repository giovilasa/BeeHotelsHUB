using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivityManager : MonoBehaviour
{
    public GameObject objectToActivate1;
    public GameObject objectToActivate2;
    public GameObject objectToActivate3;
    public GameObject objectToActivate4;
    public GameObject objectToActivate5;
    public GameObject objectToActivate6;

    public GameObject buttonToDeactivate;
    
    public GameObject windowCanvas;

    public void OnButton1Click()
    {
        objectToActivate1.SetActive(true);

        buttonToDeactivate.SetActive(false);
        
        windowCanvas.SetActive(false);
    }

    public void OnButton2Click()
    {
        objectToActivate2.SetActive(true);
        
        buttonToDeactivate.SetActive(false);
        
        windowCanvas.SetActive(false);
    }

    public void OnButton3Click()
    {
        objectToActivate3.SetActive(true);
        
        buttonToDeactivate.SetActive(false);
        
        windowCanvas.SetActive(false);
    }

    public void OnButton4Click()
    {
        objectToActivate4.SetActive(true);

        buttonToDeactivate.SetActive(false);
        
        windowCanvas.SetActive(false);
    }

    public void OnButton5Click()
    {
        objectToActivate5.SetActive(true);

        buttonToDeactivate.SetActive(false);
        
        windowCanvas.SetActive(false);
    }

    public void OnButton6Click()
    {
        objectToActivate6.SetActive(true);

        buttonToDeactivate.SetActive(false);
        
        windowCanvas.SetActive(false);
    }
}
