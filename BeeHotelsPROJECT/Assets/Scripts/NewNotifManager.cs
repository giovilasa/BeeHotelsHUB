using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewNotifManager : MonoBehaviour
{
    public GameObject activatedCard;
    public GameObject newNotif;


    void Update()
    {
        // Controlla lo stato dell'oggetto "Activated Card"
        if (activatedCard.activeSelf)
        {
            // Se l'oggetto "Activated Card" è attivo e "New Notif" non è già attivo, attiva "New Notif"
            if (!newNotif.activeSelf)
            {
                newNotif.SetActive(true);
            }
        }
    }
}
