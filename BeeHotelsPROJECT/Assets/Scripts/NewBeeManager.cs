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

    //public NotificationSystem notificationSystem;

    public GameObject Ticket1;
    public GameObject Ticket2;
    public GameObject Ticket3;
    public GameObject Ticket4;

    public GameObject Ticket_Manager1;
    public GameObject Ticket_Manager2;
    public GameObject Ticket_Manager3;
    public GameObject Ticket_Manager4;

    public GameObject Manager1;
    public GameObject Manager2;
    public GameObject Manager3;
    public GameObject Manager4;

    public GameObject NotifManager1;
    public GameObject NotifManager2;
    public GameObject NotifManager3;
    public GameObject NotifManager4;


    void Start()
    {

    }

    public void OnButtonClick()
    {
        Debug.Log("New Bee Manager, notifica");

        if (Card1.activeSelf)
        {
            Card1.gameObject.SetActive(false);
            NewCard1.gameObject.SetActive(true);
            //notificationSystem.ModifyContainerElements(0);  // Pass index 0 for NewCard1
            Ticket1.gameObject.SetActive(false);
            Ticket_Manager1.gameObject.SetActive(true);
            Manager1.gameObject.SetActive(true);
            NotifManager1.gameObject.SetActive(true);

        }

        else if (Card2.activeSelf)
        {
            Card2.gameObject.SetActive(false);
            NewCard2.gameObject.SetActive(true);
            //notificationSystem.ModifyContainerElements(1);  // Pass index 1 for NewCard2
            Ticket2.gameObject.SetActive(false);
            Ticket_Manager2.gameObject.SetActive(true);
            Manager2.gameObject.SetActive(true);
            NotifManager2.gameObject.SetActive(true);
        }

        else if (Card3.activeSelf)
        {
            Card3.gameObject.SetActive(false);
            NewCard3.gameObject.SetActive(true);
            //notificationSystem.ModifyContainerElements(2);  // Pass index 2 for NewCard3
            Ticket3.gameObject.SetActive(false);
            Ticket_Manager3.gameObject.SetActive(true);
            Manager3.gameObject.SetActive(true);
            NotifManager3.gameObject.SetActive(true);
        }

        else if (Card4.activeSelf)
        {
            Card4.gameObject.SetActive(false);
            NewCard4.gameObject.SetActive(true);
            //notificationSystem.ModifyContainerElements(3);  // Pass index 3 for NewCard4
            Ticket4.gameObject.SetActive(false);
            Ticket_Manager4.gameObject.SetActive(true);
            Manager4.gameObject.SetActive(true);
            NotifManager4.gameObject.SetActive(true);
        }

        Debug.Log("New Bee Manager, chiamato metodo ModifyContainerElements");
    }
}

