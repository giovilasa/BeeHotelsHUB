using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ActivityNotifications : MonoBehaviour
{
    public GameObject NotifManager1;
    public GameObject NotifManager2;
    public GameObject NotifManager3;
    public GameObject NotifManager4;

    public GameObject ActivityNotif1;
    public GameObject ActivityNotif2;
    public GameObject ActivityNotif3;
    public GameObject ActivityNotif4;

    public GameObject Activity1;
    public GameObject Activity2;
    public GameObject Activity3;

    public TextMeshProUGUI NotifText5;
    public TextMeshProUGUI NotifText6;
    public TextMeshProUGUI NotifText7;
    public TextMeshProUGUI NotifText8;

    private string hotelNameReplacement = "Storia naturale";
    private string hazardNameReplacement = "Pesticidi e Insetticidi";
    private string equippedReinforcementReplacement = "Alla Scoperta!";
    //private string activity1Replacement = "Cercare il nido";
    //private string activity2Replacement = "Raccogliere polline";
    //private string activity3Replacement = "Raccolta del materiale";

    public void OnDay3ButtonPressed()
    {
        if (NotifManager1.activeSelf && Activity1.activeSelf)
        {
            Debug.Log(" Bottone Day3 premuto");
            ActivateNotificationAndActivityNotif(ActivityNotif1, "Cercare il nido");
        }
        else if (NotifManager2.activeSelf && Activity1.activeSelf)
        {
            Debug.Log(" Bottone Day3 premuto");
            ActivateNotificationAndActivityNotif(ActivityNotif2, "Cercare il nido");
        }
        else if (NotifManager3.activeSelf && Activity1.activeSelf)
        {
            Debug.Log(" Bottone Day3 premuto");
            ActivateNotificationAndActivityNotif(ActivityNotif3, "Cercare il nido");
        }
        else if (NotifManager4.activeSelf && Activity1.activeSelf)
        {
            Debug.Log(" Bottone Day3 premuto");
            ActivateNotificationAndActivityNotif(ActivityNotif4, "Cercare il nido");
        }
        else if (NotifManager1.activeSelf && Activity2.activeSelf)
        {
            Debug.Log(" Bottone Day3 premuto");
            ActivateNotificationAndActivityNotif(ActivityNotif1, "Raccogliere polline");
        }
        else if (NotifManager2.activeSelf && Activity2.activeSelf)
        {
            Debug.Log(" Bottone Day3 premuto");
            ActivateNotificationAndActivityNotif(ActivityNotif2, "Raccogliere polline");
        }
        else if (NotifManager3.activeSelf && Activity2.activeSelf)
        {
            Debug.Log(" Bottone Day3 premuto");
            ActivateNotificationAndActivityNotif(ActivityNotif3, "Raccogliere polline");
        }
        else if (NotifManager4.activeSelf && Activity2.activeSelf)
        {
            Debug.Log(" Bottone Day3 premuto");
            ActivateNotificationAndActivityNotif(ActivityNotif4, "Raccogliere polline");
        }
        else if (NotifManager1.activeSelf && Activity3.activeSelf)
        {
            Debug.Log(" Bottone Day3 premuto");
            ActivateNotificationAndActivityNotif(ActivityNotif1, "Raccolta del materiale");
        }
        else if (NotifManager2.activeSelf && Activity3.activeSelf)
        {
            Debug.Log(" Bottone Day3 premuto");
            ActivateNotificationAndActivityNotif(ActivityNotif2, "Raccolta del materiale");
        }
        else if (NotifManager3.activeSelf && Activity3.activeSelf)
        {
            Debug.Log(" Bottone Day3 premuto");
            ActivateNotificationAndActivityNotif(ActivityNotif3, "Raccolta del materiale");
        }
        else if (NotifManager4.activeSelf && Activity3.activeSelf)
        {
            Debug.Log(" Bottone Day3 premuto");
            ActivateNotificationAndActivityNotif(ActivityNotif4, "Raccolta del materiale");
        }
        
    }


    private void ActivateNotificationAndActivityNotif(GameObject activityNotif, string equippedActivity)
    {
        GameObject activeNotifManager = GetActiveNotifManager();

        if (activeNotifManager != null && activityNotif != null)
        {
            Debug.Log("If che sta sotto ActivateNotification And ActivityNotif");
            DeactivateAllActivityNotifs();
            activityNotif.SetActive(true);
            ActivateNotificationObject(activityNotif);
        }

        Debug.Log("Replace Activity Notification Text");
        ReplaceActivityNotificationText(equippedActivity);
    }

    private void ActivateNotificationObject(GameObject notification)
    {
        Debug.Log("Notifica attivata");
        notification.SetActive(true);
    }

    private void ReplaceActivityNotificationText(string equippedActivity)
    {
        Debug.Log("Chiamato il metodo GetReplacedText");
        // Chiamiamo il metodo GetReplacedText utilizzando il parametro ricevuto e impostiamo i testi delle notifiche di attività
        NotifText5.text = GetReplacedText(NotifText5.text, equippedActivity);
        NotifText6.text = GetReplacedText(NotifText6.text, equippedActivity);
        NotifText7.text = GetReplacedText(NotifText7.text, equippedActivity);
        NotifText8.text = GetReplacedText(NotifText8.text, equippedActivity);
    }

    private string GetReplacedText(string originalText, string activityReplacement)
    {
        return originalText
            .Replace("{HotelName}", hotelNameReplacement)
            .Replace("{HazardName}", hazardNameReplacement)
            .Replace("{EquippedReinforcement}", equippedReinforcementReplacement)
            .Replace("{EquippedActivity}", activityReplacement);
    }

    private void DeactivateAllActivityNotifs()
    {
        ActivityNotif1.SetActive(false);
        ActivityNotif2.SetActive(false);
        ActivityNotif3.SetActive(false);
        ActivityNotif4.SetActive(false);
    }

    private GameObject GetActiveNotifManager()
    {
        if (NotifManager1.activeSelf) return NotifManager1;
        if (NotifManager2.activeSelf) return NotifManager2;
        if (NotifManager3.activeSelf) return NotifManager3;
        if (NotifManager4.activeSelf) return NotifManager4;
        return null;
    }
}

