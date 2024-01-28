using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class NewBeeManager : MonoBehaviour
{
    public GameObject Hotel1Card1;
    public GameObject Hotel1Card2;
    public GameObject Hotel1Card3;
    public GameObject Hotel1Card4;
    public GameObject Hotel1NewCard1;
    public GameObject Hotel1NewCard2;
    public GameObject Hotel1NewCard3;
    public GameObject Hotel1NewCard4;

    public GameObject Hotel2Card1;
    public GameObject Hotel2Card2;
    public GameObject Hotel2Card3;
    public GameObject Hotel2Card4;
    public GameObject Hotel2NewCard1;
    public GameObject Hotel2NewCard2;
    public GameObject Hotel2NewCard3;
    public GameObject Hotel2NewCard4;

    public GameObject Hotel3Card1;
    public GameObject Hotel3Card2;
    public GameObject Hotel3Card3;
    public GameObject Hotel3Card4;
    public GameObject Hotel3NewCard1;
    public GameObject Hotel3NewCard2;
    public GameObject Hotel3NewCard3;
    public GameObject Hotel3NewCard4;

    public GameObject Hotel4Card1;
    public GameObject Hotel4Card2;
    public GameObject Hotel4Card3;
    public GameObject Hotel4Card4;
    public GameObject Hotel4NewCard1;
    public GameObject Hotel4NewCard2;
    public GameObject Hotel4NewCard3;
    public GameObject Hotel4NewCard4;

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

    public void OnButtonClick1()
    {
        Debug.Log("New Bee Manager, notifica 1");

        if (Hotel1Card1.activeSelf)
        {
            Hotel1Card1.gameObject.SetActive(false);
            Hotel1NewCard1.gameObject.SetActive(true);
            Ticket1.gameObject.SetActive(false);
            Ticket_Manager1.gameObject.SetActive(true);
            //Manager1.gameObject.SetActive(true);
            //NotifManager1.gameObject.SetActive(true);
        }

        else if (Hotel1Card2.activeSelf)
        {
            Hotel1Card2.gameObject.SetActive(false);
            Hotel1NewCard2.gameObject.SetActive(true);
            Ticket2.gameObject.SetActive(false);
            Ticket_Manager2.gameObject.SetActive(true);
            //Manager2.gameObject.SetActive(true);
            //NotifManager2.gameObject.SetActive(true);
        }

        else if (Hotel1Card3.activeSelf)
        {
            Hotel1Card3.gameObject.SetActive(false);
            Hotel1NewCard3.gameObject.SetActive(true);
            Ticket3.gameObject.SetActive(false);
            Ticket_Manager3.gameObject.SetActive(true);
            //Manager3.gameObject.SetActive(true);
            //NotifManager3.gameObject.SetActive(true);
        }

        else if (Hotel1Card4.activeSelf)
        {
            Hotel1Card4.gameObject.SetActive(false);
            Hotel1NewCard4.gameObject.SetActive(true);
            Ticket4.gameObject.SetActive(false);
            Ticket_Manager4.gameObject.SetActive(true);
            //Manager4.gameObject.SetActive(true);
            //NotifManager4.gameObject.SetActive(true);
        }
    }

    public void OnButtonClick2()
    {
        Debug.Log("New Bee Manager, notifica 2");

        if (Hotel2Card1.activeSelf)
        {
            Hotel2Card1.gameObject.SetActive(false);
            Hotel2NewCard1.gameObject.SetActive(true);
            Ticket1.gameObject.SetActive(false);
            Ticket_Manager1.gameObject.SetActive(true);
            //Manager1.gameObject.SetActive(true);
            //NotifManager1.gameObject.SetActive(true);
        }

        else if (Hotel2Card2.activeSelf)
        {
            Hotel2Card2.gameObject.SetActive(false);
            Hotel2NewCard2.gameObject.SetActive(true);
            Ticket2.gameObject.SetActive(false);
            Ticket_Manager2.gameObject.SetActive(true);
            //Manager2.gameObject.SetActive(true);
            //NotifManager2.gameObject.SetActive(true);
        }

        else if (Hotel2Card3.activeSelf)
        {
            Hotel2Card3.gameObject.SetActive(false);
            Hotel2NewCard3.gameObject.SetActive(true);
            Ticket3.gameObject.SetActive(false);
            Ticket_Manager3.gameObject.SetActive(true);
            //Manager3.gameObject.SetActive(true);
            //NotifManager3.gameObject.SetActive(true);
        }

        else if (Hotel2Card4.activeSelf)
        {
            Hotel2Card4.gameObject.SetActive(false);
            Hotel2NewCard4.gameObject.SetActive(true);
            Ticket4.gameObject.SetActive(false);
            Ticket_Manager4.gameObject.SetActive(true);
            //Manager4.gameObject.SetActive(true);
            //NotifManager4.gameObject.SetActive(true);
        }
    }

    public void OnButtonClick3()
    {
        Debug.Log("New Bee Manager, notifica 3");

        if (Hotel3Card1.activeSelf)
        {
            Hotel3Card1.gameObject.SetActive(false);
            Hotel3NewCard1.gameObject.SetActive(true);
            Ticket1.gameObject.SetActive(false);
            Ticket_Manager1.gameObject.SetActive(true);
            //Manager1.gameObject.SetActive(true);
            //NotifManager1.gameObject.SetActive(true);
        }

        else if (Hotel3Card2.activeSelf)
        {
            Hotel3Card2.gameObject.SetActive(false);
            Hotel3NewCard2.gameObject.SetActive(true);
            Ticket2.gameObject.SetActive(false);
            Ticket_Manager2.gameObject.SetActive(true);
            //Manager2.gameObject.SetActive(true);
            //NotifManager2.gameObject.SetActive(true);
        }

        else if (Hotel3Card3.activeSelf)
        {
            Hotel3Card3.gameObject.SetActive(false);
            Hotel3NewCard3.gameObject.SetActive(true);
            Ticket3.gameObject.SetActive(false);
            Ticket_Manager3.gameObject.SetActive(true);
            //Manager3.gameObject.SetActive(true);
            //NotifManager3.gameObject.SetActive(true);
        }

        else if (Hotel3Card4.activeSelf)
        {
            Hotel3Card4.gameObject.SetActive(false);
            Hotel3NewCard4.gameObject.SetActive(true);
            Ticket4.gameObject.SetActive(false);
            Ticket_Manager4.gameObject.SetActive(true);
            //Manager4.gameObject.SetActive(true);
            //NotifManager4.gameObject.SetActive(true);
        }
    }

    public void OnButtonClick4()
    {
        Debug.Log("New Bee Manager, notifica 4");

        if (Hotel4Card1.activeSelf)
        {
            Hotel4Card1.gameObject.SetActive(false);
            Hotel4NewCard1.gameObject.SetActive(true);
            Ticket1.gameObject.SetActive(false);
            Ticket_Manager1.gameObject.SetActive(true);
            //Manager1.gameObject.SetActive(true);
            //NotifManager1.gameObject.SetActive(true);
        }

        else if (Hotel4Card2.activeSelf)
        {
            Hotel4Card2.gameObject.SetActive(false);
            Hotel4NewCard2.gameObject.SetActive(true);
            Ticket2.gameObject.SetActive(false);
            Ticket_Manager2.gameObject.SetActive(true);
            //Manager2.gameObject.SetActive(true);
            //NotifManager2.gameObject.SetActive(true);
        }

        else if (Hotel4Card3.activeSelf)
        {
            Hotel4Card3.gameObject.SetActive(false);
            Hotel4NewCard3.gameObject.SetActive(true);
            Ticket3.gameObject.SetActive(false);
            Ticket_Manager3.gameObject.SetActive(true);
            //Manager3.gameObject.SetActive(true);
            //NotifManager3.gameObject.SetActive(true);
        }

        else if (Hotel4Card4.activeSelf)
        {
            Hotel4Card4.gameObject.SetActive(false);
            Hotel4NewCard4.gameObject.SetActive(true);
            Ticket4.gameObject.SetActive(false);
            Ticket_Manager4.gameObject.SetActive(true);
            //Manager4.gameObject.SetActive(true);
            //NotifManager4.gameObject.SetActive(true);
        }
    }

}

