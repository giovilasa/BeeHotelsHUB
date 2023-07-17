using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class NewBeeManager : MonoBehaviour
{
    public GameObject Card1;
    public GameObject Card2;
    public GameObject Card3;
    public GameObject Card4;

    public GameObject NewCard1;
    public GameObject NewCard2;
    public GameObject NewCard3;
    public GameObject NewCard4;

    public NotificationSystem notificationSystem;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void OnButtonClick()
    {
        Debug.Log("New Bee Manager, notifica");

        if (Card1.activeSelf)
        {
            Card1.gameObject.SetActive(false);
            NewCard1.gameObject.SetActive(true);
            notificationSystem.ModifyContainerElements(0);  // Passa l'indice 0 per NewCard1
        }

        else if (Card2.activeSelf)
        {
            Card2.gameObject.SetActive(false);
            NewCard2.gameObject.SetActive(true);
            notificationSystem.ModifyContainerElements(1);  // Passa l'indice 1 per NewCard2
        }

        else if (Card3.activeSelf)
        {
            Card3.gameObject.SetActive(false);
            NewCard3.gameObject.SetActive(true);
            notificationSystem.ModifyContainerElements(2);  // Passa l'indice 2 per NewCard3
        }

        else if (Card4.activeSelf)
        {
            Card4.gameObject.SetActive(false);
            NewCard4.gameObject.SetActive(true);
            notificationSystem.ModifyContainerElements(3);  // Passa l'indice 3 per NewCard4
        }

        Debug.Log("New Bee Manager, chiamato metodo ModifyContainerElements");
    }
}

