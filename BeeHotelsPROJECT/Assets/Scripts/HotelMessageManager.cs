using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class HotelMessageManager : MonoBehaviour
{
    public GameObject messageObject; // Riferimento all'oggetto "Message"
    public GameObject[] objectsToActivate; // Array di oggetti da attivare
    private bool activated = false;

    public List<GameObject> managers1;
    public List<GameObject> managers2;
    public List<GameObject> managers3;
    public List<GameObject> managers4;

    public GameObject bee1;
    public GameObject bee2;
    public GameObject bee3;
    public GameObject bee4;


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

            // Attiva i Bee in base all'attivazione dei manager nelle rispettive liste
            ActivateBeeList(managers1, bee1);
            ActivateBeeList(managers2, bee2);
            ActivateBeeList(managers3, bee3);
            ActivateBeeList(managers4, bee4);

            // Disattiva questo script dopo aver attivato l'oggetto "Message"
            enabled = false;
            activated = true;
        }
    }

    private void ActivateBeeList(List<GameObject> managers, GameObject bee)
    {
        // Attiva il Bee se almeno uno dei manager nella lista è attivo
        if (managers != null && managers.Any(manager => manager != null && manager.activeSelf) && bee != null)
        {
            bee.SetActive(true);
        }
    }
}
