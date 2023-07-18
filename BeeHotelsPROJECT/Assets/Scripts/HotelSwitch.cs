using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HotelSwitch : MonoBehaviour
{
    public GameObject firstHotel;
    public GameObject secondHotel;
    public Button[] buttonsToMonitor;


    private void Start()
    {
        secondHotel.gameObject.SetActive(false);
        firstHotel.gameObject.SetActive(true);

        foreach (Button button in buttonsToMonitor)
        {
            button.onClick.AddListener(OnButtonPressed);
        }

    }

    private void OnButtonPressed()
    {

        bool allButtonsPressed = true;

        foreach (Button button in buttonsToMonitor)
        {
            if (!button.interactable)
            {
                allButtonsPressed = false;
                break;
            }
        }

        if (allButtonsPressed)
        {
            Debug.Log("Switching to the second hotel");

            firstHotel.SetActive(false);
            secondHotel.SetActive(true);
        }
    }

    
}
