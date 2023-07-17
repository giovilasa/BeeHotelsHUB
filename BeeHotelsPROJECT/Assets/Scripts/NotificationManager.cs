using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Notification
{
    public int progressive;
    public NotificationType type;
    public string message;
    public Texture2D icon1;
    public Texture2D icon2;

    public ButtonType button;
}

public enum NotificationType
{
    DR_Birth,
    DR_CorrectReinforcement,
    DR_CompletedActivity,
    DR_NoHazard,
    DR_HazardNoReinforcement,
    DR_HazardWrongReinforcement,
    DR_WeaknessNoReinforcement,
    DR_WeaknessWrongReinforcement,
    DR_OutOfBorder
}

public enum ButtonType
{
    Bombo,
    Cardatrice,
    Muratrice,
    Tagliafoglie
}

public class NotificationManager : MonoBehaviour
{
    public List<Notification> notifications = new List<Notification>();
    private NotificationWindow notificationWindow;

    public void AddNotification(Notification notification)
    {
        Debug.Log("Add Notification (notification manager)");

        notifications.Add(notification);
        notificationWindow.ShowNotification(notifications.Count - 1);
    }


    // Aggiungi una notifica
    public void AddNotification(int progressive, NotificationType type, ButtonType button, string message, Texture2D icon1, Texture2D icon2, ButtonType buttonType, TextMeshProUGUI notificationText, RawImage icon1RawImage, RawImage icon2RawImage)
    {
        Debug.Log("Add Notification (notification manager)");

        Notification notification = new Notification();
        notification.progressive = progressive;
        notification.type = type;
        notification.button = button;
        notification.message = message;
        notification.icon1 = icon1;
        notification.icon2 = icon2;

        notifications.Add(notification);
    }

    public void SetNotificationWindow(NotificationWindow window)
    {
        notificationWindow = window;
    }

}