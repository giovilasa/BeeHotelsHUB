using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeeHotelManager : MonoBehaviour
{
    public GameObject windowCanvas;
    public GameObject beeMessage;
    private bool beeMessageActivated = false;

    public GameObject Card1;
    public GameObject Card2;
    public GameObject Card3;
    public GameObject Card4;

    public GameObject NewCard1;
    public GameObject NewCard2;
    public GameObject NewCard3;
    public GameObject NewCard4;

    public AudioSource buttonClickAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        CloseWindow();
    }

    public void OnMouseDown()
    {
        if (!beeMessageActivated)
        {
            beeMessageActivated = true;
            beeMessage.SetActive(true);
            windowCanvas.SetActive(false);

        }
        else
        {
            windowCanvas.SetActive(true);
            // Riproduci l'effetto sonoro
            buttonClickAudioSource.Play();
        }

    }


    public void CloseWindow()
    {
        windowCanvas.SetActive(false);
        // Riproduci l'effetto sonoro
        buttonClickAudioSource.Play();
    }
}
