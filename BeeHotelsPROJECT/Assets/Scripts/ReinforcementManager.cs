using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReinforcementManager : MonoBehaviour
{
    public GameObject hotelA;
    public GameObject hotelB;
    public GameObject hotelC;
    public GameObject hotelD;

    public GameObject objectToActivateA1;
    public GameObject objectToActivateA2;
    public GameObject objectToActivateA3;
    public GameObject objectToActivateA4;
    public GameObject objectToActivateA5;
    public GameObject objectToActivateA6;
    public GameObject objectToActivateA7;

    public GameObject objectToActivateB1;
    public GameObject objectToActivateB2;
    public GameObject objectToActivateB3;
    public GameObject objectToActivateB4;
    public GameObject objectToActivateB5;
    public GameObject objectToActivateB6;
    public GameObject objectToActivateB7;

    public GameObject objectToActivateC1;
    public GameObject objectToActivateC2;
    public GameObject objectToActivateC3;
    public GameObject objectToActivateC4;
    public GameObject objectToActivateC5;
    public GameObject objectToActivateC6;
    public GameObject objectToActivateC7;

    public GameObject objectToActivateD1;
    public GameObject objectToActivateD2;
    public GameObject objectToActivateD3;
    public GameObject objectToActivateD4;
    public GameObject objectToActivateD5;
    public GameObject objectToActivateD6;
    public GameObject objectToActivateD7;

    public GameObject buttonToDeactivateA;
    public GameObject buttonToDeactivateB;
    public GameObject buttonToDeactivateC;
    public GameObject buttonToDeactivateD;

    public GameObject cardToDeactivate1;
    public GameObject cardToDeactivate2;
    public GameObject cardToDeactivate3;
    public GameObject cardToDeactivate4;
    public GameObject cardToDeactivate5;
    public GameObject cardToDeactivate6;
    public GameObject cardToDeactivate7;


    public GameObject windowCanvas;
    public AudioSource buttonClickAudioSource;


    public void OnButton1Click()
    {
        if (hotelA.activeSelf)
        {
            objectToActivateA1.SetActive(true);
            buttonToDeactivateA.SetActive(false);
            cardToDeactivate1.SetActive(false);
        }
        else if (hotelB.activeSelf)
        {
            objectToActivateB1.SetActive(true);
            buttonToDeactivateB.SetActive(false);
            cardToDeactivate1.SetActive(false);
        }
        else if (hotelC.activeSelf)
        {
            objectToActivateC1.SetActive(true);
            buttonToDeactivateC.SetActive(false);
            cardToDeactivate1.SetActive(false);
        }
        else if (hotelD.activeSelf)
        {
            objectToActivateD1.SetActive(true);
            buttonToDeactivateD.SetActive(false);
            cardToDeactivate1.SetActive(false);
        }

        windowCanvas.SetActive(false);
        buttonClickAudioSource.Play();
    }

    public void OnButton2Click()
    {
        if (hotelA.activeSelf)
        {
            objectToActivateA2.SetActive(true);
            buttonToDeactivateA.SetActive(false);
            cardToDeactivate2.SetActive(false);
        }
        else if (hotelB.activeSelf)
        {
            objectToActivateB2.SetActive(true);
            buttonToDeactivateB.SetActive(false);
            cardToDeactivate2.SetActive(false);
        }
        else if (hotelC.activeSelf)
        {
            objectToActivateC2.SetActive(true);
            buttonToDeactivateC.SetActive(false);
            cardToDeactivate2.SetActive(false);
        }
        else if (hotelD.activeSelf)
        {
            objectToActivateD2.SetActive(true);
            buttonToDeactivateD.SetActive(false);
            cardToDeactivate2.SetActive(false);
        }

        windowCanvas.SetActive(false);
        buttonClickAudioSource.Play();
    }

    public void OnButton3Click()
    {
        if (hotelA.activeSelf)
        {
            objectToActivateA3.SetActive(true);
            buttonToDeactivateA.SetActive(false);
            cardToDeactivate3.SetActive(false);
        }
        else if (hotelB.activeSelf)
        {
            objectToActivateB3.SetActive(true);
            buttonToDeactivateB.SetActive(false);
            cardToDeactivate3.SetActive(false);
        }
        else if (hotelC.activeSelf)
        {
            objectToActivateC3.SetActive(true);
            buttonToDeactivateC.SetActive(false);
            cardToDeactivate3.SetActive(false);
        }
        else if (hotelD.activeSelf)
        {
            objectToActivateD3.SetActive(true);
            buttonToDeactivateD.SetActive(false);
            cardToDeactivate3.SetActive(false);
        }

        windowCanvas.SetActive(false);
        buttonClickAudioSource.Play();
    }

    public void OnButton4Click()
    {
        if (hotelA.activeSelf)
        {
            objectToActivateA4.SetActive(true);
            buttonToDeactivateA.SetActive(false);
            cardToDeactivate4.SetActive(false);
        }
        else if (hotelB.activeSelf)
        {
            objectToActivateB4.SetActive(true);
            buttonToDeactivateB.SetActive(false);
            cardToDeactivate4.SetActive(false);
        }
        else if (hotelC.activeSelf)
        {
            objectToActivateC4.SetActive(true);
            buttonToDeactivateC.SetActive(false);
            cardToDeactivate4.SetActive(false);
        }
        else if (hotelD.activeSelf)
        {
            objectToActivateD4.SetActive(true);
            buttonToDeactivateD.SetActive(false);
            cardToDeactivate4.SetActive(false);
        }

        windowCanvas.SetActive(false);
        buttonClickAudioSource.Play();
    }

    public void OnButton5Click()
    {
        if (hotelA.activeSelf)
        {
            objectToActivateA5.SetActive(true);
            buttonToDeactivateA.SetActive(false);
            cardToDeactivate5.SetActive(false);
        }
        else if (hotelB.activeSelf)
        {
            objectToActivateB5.SetActive(true);
            buttonToDeactivateB.SetActive(false);
            cardToDeactivate5.SetActive(false);
        }
        else if (hotelC.activeSelf)
        {
            objectToActivateC5.SetActive(true);
            buttonToDeactivateC.SetActive(false);
            cardToDeactivate5.SetActive(false);
        }
        else if (hotelD.activeSelf)
        {
            objectToActivateD5.SetActive(true);
            buttonToDeactivateD.SetActive(false);
            cardToDeactivate5.SetActive(false);
        }

        windowCanvas.SetActive(false);
        buttonClickAudioSource.Play();
    }

    public void OnButton6Click()
    {
        if (hotelA.activeSelf)
        {
            objectToActivateA6.SetActive(true);
            buttonToDeactivateA.SetActive(false);
            cardToDeactivate6.SetActive(false);
        }
        else if (hotelB.activeSelf)
        {
            objectToActivateB6.SetActive(true);
            buttonToDeactivateB.SetActive(false);
            cardToDeactivate6.SetActive(false);
        }
        else if (hotelC.activeSelf)
        {
            objectToActivateC6.SetActive(true);
            buttonToDeactivateC.SetActive(false);
            cardToDeactivate6.SetActive(false);
        }
        else if (hotelD.activeSelf)
        {
            objectToActivateD6.SetActive(true);
            buttonToDeactivateD.SetActive(false);
            cardToDeactivate6.SetActive(false);
        }

        windowCanvas.SetActive(false);
        buttonClickAudioSource.Play();
    }

    public void OnButton7Click()
    {
        if (hotelA.activeSelf)
        {
            objectToActivateA7.SetActive(true);
            buttonToDeactivateA.SetActive(false);
            cardToDeactivate7.SetActive(false);
        }
        else if (hotelB.activeSelf)
        {
            objectToActivateB7.SetActive(true);
            buttonToDeactivateB.SetActive(false);
            cardToDeactivate7.SetActive(false);
        }
        else if (hotelC.activeSelf)
        {
            objectToActivateC7.SetActive(true);
            buttonToDeactivateC.SetActive(false);
            cardToDeactivate7.SetActive(false);
        }
        else if (hotelD.activeSelf)
        {
            objectToActivateD7.SetActive(true);
            buttonToDeactivateD.SetActive(false);
            cardToDeactivate7.SetActive(false);
        }

        windowCanvas.SetActive(false);
        buttonClickAudioSource.Play();
    }
}
