using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewNotif2Manager : MonoBehaviour
{
    public GameObject activatedCard;

    public GameObject newNotifA;
    public GameObject newNotifB;
    public GameObject newNotifC;
    public GameObject newNotifD;

    public GameObject ManagerA;
    public GameObject ManagerB;
    public GameObject ManagerC;
    public GameObject ManagerD;

    public TextMeshProUGUI NotifTextA;
    public TextMeshProUGUI NotifTextB;
    public TextMeshProUGUI NotifTextC;
    public TextMeshProUGUI NotifTextD;

    public GameObject Hotel1;
    public GameObject Hotel2;
    public GameObject Hotel3;
    public GameObject Hotel4;
    public GameObject Reinforce1;
    public GameObject Reinforce3;
    public GameObject Reinforce4;
    public GameObject Reinforce6;


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
        string equippedReinforcementReplacement = GetEquippedReinforcementReplacement();

        // Applica la sostituzione nei testi delle notifiche
        NotifTextA.text = GetReplacedText(NotifTextA.text, hotelNameReplacement, hazardNameReplacement, equippedReinforcementReplacement);
        NotifTextB.text = GetReplacedText(NotifTextB.text, hotelNameReplacement, hazardNameReplacement, equippedReinforcementReplacement);
        NotifTextC.text = GetReplacedText(NotifTextC.text, hotelNameReplacement, hazardNameReplacement, equippedReinforcementReplacement);
        NotifTextD.text = GetReplacedText(NotifTextD.text, hotelNameReplacement, hazardNameReplacement, equippedReinforcementReplacement);
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

    private string GetEquippedReinforcementReplacement()
    {
        if (Reinforce1.activeSelf) return "Alla scoperta";
        if (Reinforce3.activeSelf) return "Nidificazione perfetta";
        if (Reinforce4.activeSelf) return "Orto botanico";
        if (Reinforce6.activeSelf) return "Prole numerosa";
        return "";
    }

    private string GetReplacedText(string originalText, string hotelReplacement, string hazardReplacement, string reinforcementReplacement)
    {
        return originalText
            .Replace("{HotelName}", hotelReplacement)
            .Replace("{HazardName}", hazardReplacement)
            .Replace("{EquippedReinforcement}", reinforcementReplacement);
    }
}