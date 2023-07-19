using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivityNotifications : MonoBehaviour
{
    public GameObject day3Button; // Assicurati di assegnare il pulsante "day3" nell'Inspector
    public NotificationSystem notificationSystem; // Assicurati di assegnare il componente NotificationSystem nell'Inspector

    public GameObject NewCard1;
    public GameObject NewCard2;
    public GameObject NewCard3;
    public GameObject NewCard4;

    private void Update()
    {
        // Verifica se l'oggetto "activity" è stato attivato e il pulsante "day3" è stato premuto
        if (gameObject.activeSelf && day3Button.activeSelf && Input.GetKeyDown(KeyCode.Mouse0))
        {
            // Verifica quale delle NewCard è attiva e chiama il metodo ModifyContainerElements corrispondente
            if (NewCard1.activeSelf)
            {
                notificationSystem.ModifyContainerElements(8); // Passa l'indice 8 per NewCard1
            }
            else if (NewCard2.activeSelf)
            {
                notificationSystem.ModifyContainerElements(9); // Passa l'indice 9 per NewCard2
            }
            else if (NewCard3.activeSelf)
            {
                notificationSystem.ModifyContainerElements(10); // Passa l'indice 10 per NewCard3
            }
            else if (NewCard4.activeSelf)
            {
                notificationSystem.ModifyContainerElements(11); // Passa l'indice 11 per NewCard4
            }
        }
    }
}
