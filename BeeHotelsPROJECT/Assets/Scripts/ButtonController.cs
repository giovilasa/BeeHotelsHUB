using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public GameObject[] objectsToActivate;
    public GameObject[] objectsToDeactivate;

    public AudioSource buttonClickAudioSource;


    public void OnMouseDown()
    {
        
        foreach (GameObject obj in objectsToActivate)
        {
            obj.SetActive(true);
            buttonClickAudioSource.Play();
        }

        foreach (GameObject obj in objectsToDeactivate)
        {
            obj.SetActive(false);
            buttonClickAudioSource.Play();
        }
    }
}
