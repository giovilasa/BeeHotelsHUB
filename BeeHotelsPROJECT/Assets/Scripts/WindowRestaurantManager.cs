using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindowRestaurantManager : MonoBehaviour
{
    public GameObject windowCanvas;
    public GameObject falseRestaurant;
    public GameObject trueRestaurant;
    //public bool interactable;
    public Button[] buttonsToMonitor;

    // Start is called before the first frame update
    private void Start()
    {
        trueRestaurant.gameObject.SetActive(false);
        falseRestaurant.gameObject.SetActive(true);

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
            trueRestaurant.gameObject.SetActive(true);
            falseRestaurant.gameObject.SetActive(false);
        }
    }

    public void OnMouseDown()
    {
        windowCanvas.SetActive(true);
    }

    public void CloseWindow()
    {
        windowCanvas.SetActive(false);
    }
}
