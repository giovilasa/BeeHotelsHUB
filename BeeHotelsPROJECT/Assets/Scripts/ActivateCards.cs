using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateCards : MonoBehaviour
{
    public GameObject card1;
    public GameObject card2;
    public GameObject card3;
    public GameObject card4;
    public GameObject card5;
    public GameObject card6;
    public GameObject card7;

    public AudioSource buttonClickAudioSource;


    private void Start()
    {
        card1.SetActive(false);
        card2.SetActive(false);
        card3.SetActive(false);
        card4.SetActive(false);
        card5.SetActive(false);
        card6.SetActive(false);
        card7.SetActive(false);
    }

    public void OnMouseDown()
    {
        card1.SetActive(true);
        buttonClickAudioSource.Play();
    }
}
