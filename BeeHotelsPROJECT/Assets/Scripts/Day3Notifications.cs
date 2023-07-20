using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Day3Notifications : MonoBehaviour
{
    public NotificationSystem notificationSystem;
    public GameObject NewCard1;
    public GameObject NewCard2;
    public GameObject NewCard3;
    public GameObject NewCard4;


    private void Start()
    {
        Button day3Button = GetComponent<Button>();
        day3Button.onClick.AddListener(OnDay3ButtonClick);
    }

    private void OnDay3ButtonClick()
    {
        Debug.Log("3rd Day: notification reinforcement");

        if (NewCard1.activeSelf)
        {
            notificationSystem.ModifyContainerElements(4);  // Passa l'indice 4 per NewCard1
        }
        else if (NewCard2.activeSelf)
        {
            notificationSystem.ModifyContainerElements(5);  // Passa l'indice 5 per NewCard2
        }
        else if (NewCard3.activeSelf)
        {
            notificationSystem.ModifyContainerElements(6);  // Passa l'indice 6 per NewCard3
        }
        else if (NewCard4.activeSelf)
        {
            notificationSystem.ModifyContainerElements(7);  // Passa l'indice 7 per NewCard4
        }
    }

}
