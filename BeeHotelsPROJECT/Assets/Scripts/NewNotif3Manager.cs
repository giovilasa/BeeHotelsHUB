using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewNotif3Manager : MonoBehaviour
{
    public GameObject activatedCard;

    public GameObject newNotifA;
    public GameObject newNotifB;
    public GameObject newNotifC;
    public GameObject newNotifD;

    public TextMeshProUGUI NotifTextA;
    public TextMeshProUGUI NotifTextB;
    public TextMeshProUGUI NotifTextC;
    public TextMeshProUGUI NotifTextD;

    public GameObject ManagerA;
    public GameObject ManagerB;
    public GameObject ManagerC;
    public GameObject ManagerD;

    public GameObject Hotel1;
    public GameObject Hotel2;
    public GameObject Hotel3;
    public GameObject Hotel4;
    public GameObject Activity4;
    public GameObject Activity5;


    void Update()
    {
        // Controlla lo stato dell'oggetto "activateCard"
        if (activatedCard.activeSelf)
        {
            // Attiva gli oggetti NewNotif in base agli stati dei Manager
            newNotifA.SetActive(ManagerA.activeSelf);
            newNotifB.SetActive(ManagerB.activeSelf);
            newNotifC.SetActive(ManagerC.activeSelf);
            newNotifD.SetActive(ManagerD.activeSelf);

            // Sostituisci le stringhe nei testi delle notifiche
            ReplaceNotificationText();
        }
    }

    private void ReplaceNotificationText()
    {
        // Sostituisci le stringhe nei testi delle notifiche in base agli oggetti di gioco attivi
        string hotelNameReplacement = GetHotelNameReplacement();
        string hazardNameReplacement = GetHazardNameReplacement();
        string equippedActivityReplacement = GetEquippedActivityReplacement();

        // Applica la sostituzione nei testi delle notifiche
        NotifTextA.text = GetReplacedText(NotifTextA.text, hotelNameReplacement, hazardNameReplacement, equippedActivityReplacement);
        NotifTextB.text = GetReplacedText(NotifTextB.text, hotelNameReplacement, hazardNameReplacement, equippedActivityReplacement);
        NotifTextC.text = GetReplacedText(NotifTextC.text, hotelNameReplacement, hazardNameReplacement, equippedActivityReplacement);
        NotifTextD.text = GetReplacedText(NotifTextD.text, hotelNameReplacement, hazardNameReplacement, equippedActivityReplacement);
    }

    private string GetHotelNameReplacement()
    {
        if (Hotel1.activeSelf) return "Storia naturale";
        if (Hotel2.activeSelf) return "Memoria";
        if (Hotel3.activeSelf) return "Alpi Cozie";
        if (Hotel4.activeSelf) return "Nicoli";
        return "";
    }

    private string GetHazardNameReplacement()
    {
        if (Hotel1.activeSelf) return "Pesticidi";
        if (Hotel2.activeSelf) return "Rimozione prato";
        if (Hotel3.activeSelf) return "Siccità";
        if (Hotel4.activeSelf) return "Potatura esagerata";
        return "";
    }

    private string GetEquippedActivityReplacement()
    {
        if (Activity4.activeSelf) return "Raccolta polline";
        if (Activity5.activeSelf) return "Raccolta materiale";
        return "";
    }

    private string GetReplacedText(string originalText, string hotelReplacement, string hazardReplacement, string activityReplacement)
    {
        return originalText
            .Replace("{HotelName}", hotelReplacement)
            .Replace("{HazardName}", hazardReplacement)
            .Replace("{EquippedActivity}", activityReplacement);
    }
}
