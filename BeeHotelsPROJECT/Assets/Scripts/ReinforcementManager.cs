using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReinforcementManager : MonoBehaviour
{
    public GameObject objectToActivate1;
    public GameObject objectToActivate2;
    public GameObject objectToActivate3;
    public GameObject objectToActivate4;
    public GameObject objectToActivate5;
    public GameObject objectToActivate6;
    public GameObject objectToActivate7;

    public GameObject buttonToDeactivate;

    public GameObject windowCanvas;

    public AudioSource buttonClickAudioSource;


    public void OnButton1Click()
    {
        objectToActivate1.SetActive(true);
        buttonToDeactivate.SetActive(false);
        windowCanvas.SetActive(false);
        buttonClickAudioSource.Play();
    }

    public void OnButton2Click()
    {
        objectToActivate2.SetActive(true);
        buttonToDeactivate.SetActive(false);
        windowCanvas.SetActive(false);
        buttonClickAudioSource.Play();
    }

    public void OnButton3Click()
    {
        objectToActivate3.SetActive(true);
        buttonToDeactivate.SetActive(false);
        windowCanvas.SetActive(false);
        buttonClickAudioSource.Play();
    }

    public void OnButton4Click()
    {
        objectToActivate4.SetActive(true);
        buttonToDeactivate.SetActive(false);
        windowCanvas.SetActive(false);
        buttonClickAudioSource.Play();
    }

    public void OnButton5Click()
    {
        objectToActivate5.SetActive(true);
        buttonToDeactivate.SetActive(false);
        windowCanvas.SetActive(false);
        buttonClickAudioSource.Play();
    }

    public void OnButton6Click()
    {
        objectToActivate6.SetActive(true);
        buttonToDeactivate.SetActive(false);
        windowCanvas.SetActive(false);
        buttonClickAudioSource.Play();
    }

    public void OnButton7Click()
    {
        objectToActivate7.SetActive(true);
        buttonToDeactivate.SetActive(false);
        windowCanvas.SetActive(false);
        buttonClickAudioSource.Play();
    }
}
