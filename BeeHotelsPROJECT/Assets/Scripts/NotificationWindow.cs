using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;

public class NotificationWindow : MonoBehaviour
{
    public TextMeshProUGUI notificationText;
    public RawImage icon1RawImage;
    public RawImage icon2RawImage;

    public NotificationManager notificationManager;
    public NotificationStrings notificationStrings;
    public GameObject notificationPrefab;


    public ButtonType currentButton; // Aggiunta: Memorizza il pulsante corrente

    //public GameObject[] managerObjects; // Aggiunta: Array di oggetti manager
    //public Button hotelButton; // Aggiunta: Riferimento al pulsante dell'hotel
    //public Button hazardButton; // Aggiunta: Riferimento al pulsante del pericolo
    //public GameObject[] reinforcementObjects; // Aggiunta: Array di oggetti reinforcement
    //public GameObject[] activityObjects; // Aggiunta: Array di oggetti activity


    private void Start()
    {
        Debug.Log("Window: ottenuto il riferimento all'oggetto NotificationManager");
        notificationManager = GetComponent<NotificationManager>();

        Debug.Log("Chiamato il metodo SetNotificationWindow di NotificationManager per passare il riferimento all'oggetto NotificationWindow.");
        notificationManager.SetNotificationWindow(this);

        Debug.Log("Ordina le notifiche in ordine progressivo");
        // Ordina le notifiche in ordine progressivo
        notificationManager.notifications = notificationManager.notifications.OrderBy(n => n.progressive).ToList();

        Debug.Log("Mostra la prima notifica relativa al pulsante corrente nella finestra");
        // Mostra la prima notifica relativa al pulsante corrente nella finestra
        ShowNotification(0);

        Debug.Log("Genera l'oggetto prefab delle notifiche");
        GameObject notificationObject = Instantiate(notificationPrefab, transform);
        notificationText = notificationObject.GetComponentInChildren<TextMeshProUGUI>();
        icon1RawImage = notificationObject.transform.Find("Icon1").GetComponent<RawImage>();
        icon2RawImage = notificationObject.transform.Find("Icon2").GetComponent<RawImage>();
    }

    private void UpdateNotificationUI(Notification notification)
    {
        notificationText.text = notification.message;
        icon1RawImage.texture = notification.icon1;
        icon2RawImage.texture = notification.icon2;
    }


    // Mostra la notifica corrispondente all'indice specificato e al pulsante corrente
    public void ShowNotification(int index)
    {
        Debug.Log("Show Notification");
        if (index >= 0 && index < notificationManager.notifications.Count)
        {
            Notification notification = notificationManager.notifications[index];

            Debug.Log("Controlla se la notifica corrente è relativa al pulsante corrente");
            // Controlla se la notifica corrente è relativa al pulsante corrente
            if (notification.button == currentButton)
            {
                Debug.Log("Aggiorna il testo e le immagini con i dati della notifica corrente");
                // Aggiorna il testo e le immagini con i dati della notifica corrente
                //notificationText.text = ProcessMessage(notification.message);
                //icon1RawImage.texture = notification.icon1;
                //icon2RawImage.texture = notification.icon2;
                UpdateNotificationUI(notification);
            }
        }
    }

}
