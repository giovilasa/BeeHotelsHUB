using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindowManager2 : MonoBehaviour
{
    public GameObject windowCanvas;
    public GameObject windowB;

    public AudioSource buttonClickAudioSource;

    void Start()
    {
        windowCanvas.SetActive(false);
        windowB.SetActive(false);
    }

    public void OnButtonClickA()
    {
        windowCanvas.SetActive(true);
        buttonClickAudioSource.Play();
    }

    public void OnButtonClickB()
    {
        windowB.SetActive(true);
        buttonClickAudioSource.Play();
    }

    public void CloseWindow()
    {
        windowCanvas.SetActive(false);
        windowB.SetActive(false);
        buttonClickAudioSource.Play();
    }
}
