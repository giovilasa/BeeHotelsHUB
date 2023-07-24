using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Day3Notifications : MonoBehaviour
{
    public GameObject NotifManager1;
    public GameObject NotifManager2;
    public GameObject NotifManager3;
    public GameObject NotifManager4;

    public GameObject NewNotif1;
    public GameObject NewNotif2;
    public GameObject NewNotif3;
    public GameObject NewNotif4;

    public TextMeshProUGUI NotifText1;
    public TextMeshProUGUI NotifText2;
    public TextMeshProUGUI NotifText3;
    public TextMeshProUGUI NotifText4;

    private string hotelNameReplacement = "Storia naturale";
    private string hazardNameReplacement = "Pesticidi e Insetticidi";
    private string equippedReinforcementReplacement = "Alla Scoperta!";

    public void OnDay3ButtonPressed()
    {
        if (NotifManager1.activeSelf)
        {
            ActivateNotification(NewNotif1);
        }
        else if (NotifManager2.activeSelf)
        {
            ActivateNotification(NewNotif2);
        }
        else if (NotifManager3.activeSelf)
        {
            ActivateNotification(NewNotif3);
        }
        else if (NotifManager4.activeSelf)
        {
            ActivateNotification(NewNotif4);
        }
    }

    private void ActivateNotification(GameObject notification)
    {
        notification.SetActive(true);
        ReplaceNotificationText(notification);
    }

    private void ReplaceNotificationText(GameObject notification)
    {

        if (NotifText1 != null && notification == NewNotif1)
        {
            NotifText1.text = GetReplacedText(NotifText1.text);
        }
        else if (NotifText2 != null && notification == NewNotif2)
        {
            NotifText2.text = GetReplacedText(NotifText2.text);
        }
        else if (NotifText3 != null && notification == NewNotif3)
        {
            NotifText3.text = GetReplacedText(NotifText3.text);
        }
        else if (NotifText4 != null && notification == NewNotif4)
        {
            NotifText4.text = GetReplacedText(NotifText4.text);
        }
    }

    private string GetReplacedText(string originalText)
    {
        return originalText
            .Replace("{HotelName}", hotelNameReplacement)
            .Replace("{HazardName}", hazardNameReplacement)
            .Replace("{EquippedReinforcement}", equippedReinforcementReplacement);
    }
}
