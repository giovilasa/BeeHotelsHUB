using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class MessageManager : MonoBehaviour
{
    public GameObject messageObject; // Riferimento all'oggetto "Message"
    public GameObject[] objectsToActivate; // Array di oggetti da attivare

    private bool activated = false;

    
    private void Update()
    {
        // Se l'oggetto "Message" non è ancora stato attivato e almeno uno degli oggetti da attivare è attivo
        if (!activated && CheckObjectsToActivate())
        {
            ActivateMessage();
        }
    }

    private bool CheckObjectsToActivate()
    {
        foreach (GameObject obj in objectsToActivate)
        {
            // Se almeno un oggetto da attivare è attivo, restituisci true
            if (obj != null && obj.activeSelf)
            {
                return true;
            }
        }
        return false;
    }

    private void ActivateMessage()
    {
        // Attiva l'oggetto "Message"
        if (messageObject != null)
        {
            messageObject.SetActive(true);
            // Disattiva questo script dopo aver attivato l'oggetto "Message"
            enabled = false;
            activated = true;
        }
    }
}
