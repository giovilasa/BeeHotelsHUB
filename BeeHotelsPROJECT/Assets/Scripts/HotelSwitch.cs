using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HotelSwitch : MonoBehaviour
{
    public GameObject firstHotel;
    public GameObject secondHotel;
    //public bool interactable;
    public Button[] buttonsToMonitor;

    // Start is called before the first frame update
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
            // Apparizione dell'oggetto nella scena
            secondHotel.gameObject.SetActive(true);
            firstHotel.gameObject.SetActive(false);
        }
    }

    
}
