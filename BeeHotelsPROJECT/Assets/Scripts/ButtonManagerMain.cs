using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManagerMain : MonoBehaviour
{
    public GameObject window;

    public AudioSource buttonClickAudioSource;

    void Start()
    {
        window.SetActive(false);
    }

    public void OnButtonClick()
    {
        window.SetActive(true);
        buttonClickAudioSource.Play();
    }

    public void CloseWindow()
    {
        window.SetActive(false);
        buttonClickAudioSource.Play();
    }
}
