using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AssignmentManager : MonoBehaviour
{
    public GameObject objectToActivate1;
    public GameObject objectToActivate2;
    public GameObject objectToActivate3;
    public GameObject objectToActivate4;

    public GameObject buttonToDeactivate1;
    public GameObject buttonToDeactivate2;
    
    public GameObject activityToActivate;

    public GameObject windowCanvas;

    public void OnButton1Click()
    {
        objectToActivate1.SetActive(true);
        //objectToActivate2.SetActive(false);
        //objectToActivate3.SetActive(false);
        //objectToActivate4.SetActive(false);

        buttonToDeactivate1.SetActive(false);
        buttonToDeactivate2.SetActive(false);
        activityToActivate.SetActive(true);
        // Chiudi la seconda finestra
        windowCanvas.SetActive(false);
    }

    public void OnButton2Click()
    {
        //objectToActivate1.SetActive(false);
        objectToActivate2.SetActive(true);
        //objectToActivate3.SetActive(false);
        //objectToActivate4.SetActive(false);

        buttonToDeactivate1.SetActive(false);
        buttonToDeactivate2.SetActive(false);
        activityToActivate.SetActive(true);
        // Chiudi la seconda finestra
        windowCanvas.SetActive(false);
    }

    public void OnButton3Click()
    {
        //objectToActivate1.SetActive(false);
        //objectToActivate2.SetActive(false);
        objectToActivate3.SetActive(true);
        //objectToActivate4.SetActive(false);

        buttonToDeactivate1.SetActive(false);
        buttonToDeactivate2.SetActive(false);
        activityToActivate.SetActive(true);
        // Chiudi la seconda finestra
        windowCanvas.SetActive(false);
    }

    public void OnButton4Click()
    {
        //objectToActivate1.SetActive(false);
        //objectToActivate2.SetActive(false);
        //objectToActivate3.SetActive(false);
        objectToActivate4.SetActive(true);

        buttonToDeactivate1.SetActive(false);
        buttonToDeactivate2.SetActive(false);
        activityToActivate.SetActive(true);
        // Chiudi la seconda finestra
        windowCanvas.SetActive(false);
    }
}