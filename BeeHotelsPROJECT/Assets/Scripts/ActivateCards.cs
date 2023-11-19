using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateCards : MonoBehaviour
{
    public GameObject newWindow;

    public GameObject card1;
    public GameObject card2;
    public GameObject card3;
    public GameObject card4;
    public GameObject card5;
    public GameObject card6;
    public GameObject card7;

    public GameObject reinforcement1;
    public GameObject reinforcement2;
    public GameObject reinforcement3;
    public GameObject reinforcement4;
    public GameObject reinforcement5;
    public GameObject reinforcement6;
    public GameObject reinforcement7;

    public GameObject newCard1;
    public GameObject newCard2;
    public GameObject newCard3;
    public GameObject newCard4;
    public GameObject newCard5;
    public GameObject newCard6;
    public GameObject newCard7;

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

    public void OnMouseDown1()
    {
        newWindow.SetActive(true);
        card1.SetActive(true);
        reinforcement1.SetActive(true);
        newCard1.SetActive(true);
        buttonClickAudioSource.Play();
    }

    public void OnMouseDown2()
    {
        newWindow.SetActive(true);
        card2.SetActive(true);
        reinforcement2.SetActive(true);
        newCard2.SetActive(true);
        buttonClickAudioSource.Play();
    }

    public void OnMouseDown3()
    {
        newWindow.SetActive(true);
        card3.SetActive(true);
        reinforcement3.SetActive(true);
        newCard3.SetActive(true);
        buttonClickAudioSource.Play();
    }

    public void OnMouseDown4()
    {
        newWindow.SetActive(true);
        card4.SetActive(true);
        reinforcement4.SetActive(true);
        newCard4.SetActive(true);
        buttonClickAudioSource.Play();
    }

    public void OnMouseDown5()
    {
        newWindow.SetActive(true);
        card5.SetActive(true);
        reinforcement5.SetActive(true);
        newCard5.SetActive(true);
        buttonClickAudioSource.Play();
    }

    public void OnMouseDown6()
    {
        newWindow.SetActive(true);
        card6.SetActive(true);
        reinforcement6.SetActive(true);
        newCard6.SetActive(true);
        buttonClickAudioSource.Play();
    }

    public void OnMouseDown7()
    {
        newWindow.SetActive(true);
        card7.SetActive(true);
        reinforcement7.SetActive(true);
        newCard7.SetActive(true);
        buttonClickAudioSource.Play();
    }
}
