using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindowRestaurantManager : MonoBehaviour
{
    public GameObject window;
    //public GameObject message;
    public GameObject takeButton;

    //private bool isFirstClick = true;

    public AudioSource buttonClickAudioSource;


    public void OnMouseDown()
    {
        window.SetActive(true);
        buttonClickAudioSource.Play();
        takeButton.SetActive(true);
    }
}
