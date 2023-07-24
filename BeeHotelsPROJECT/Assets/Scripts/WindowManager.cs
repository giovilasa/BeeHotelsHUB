using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindowManager : MonoBehaviour
{
    public GameObject windowCanvas;

    public AudioSource buttonClickAudioSource;

    void Start()
    {
        windowCanvas.SetActive(false);
    }

    public void OnMouseDown()
    {
        windowCanvas.SetActive(true);
        buttonClickAudioSource.Play();
    }

    public void CloseWindow()
    {
        windowCanvas.SetActive(false);
        buttonClickAudioSource.Play();
    }
}

