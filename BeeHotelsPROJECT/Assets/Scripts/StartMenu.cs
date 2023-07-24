using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour
{
    public bool isStart;
    public bool isQuit;

    public Camera MainCamera;
    public Light MainLight;
    public Camera StartCamera;
    public Light StartLight;

    public GameObject StartBackground;

    public AudioSource buttonClickAudioSource;


    // Start is called before the first frame update
    void Start()
    {
        MainCamera.gameObject.SetActive(false);
        MainLight.gameObject.SetActive(false);
        StartCamera.gameObject.SetActive(true);
        StartCamera.gameObject.SetActive(true);
    }

    public void OnMouseUp()
    {
        if (isStart)
        {
            // Riproduci l'effetto sonoro
            buttonClickAudioSource.Play();
            StartCamera.gameObject.SetActive(!StartCamera.gameObject.activeSelf);
            MainCamera.gameObject.SetActive(!MainCamera.gameObject.activeSelf);
            StartLight.gameObject.SetActive(!StartLight.gameObject.activeSelf);
            MainLight.gameObject.SetActive(!MainLight.gameObject.activeSelf);
            StartBackground.gameObject.SetActive(!StartBackground.gameObject.activeSelf);
        }
        if (isQuit)
        {
            Application.Quit();
        }
    }

    
}
