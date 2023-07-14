using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindowRestaurantManager : MonoBehaviour
{
    public GameObject windowCanvas;
    public GameObject falseRestaurant;
    public GameObject trueRestaurant;
    
    public Button[] buttonsToMonitor;

    public Button additionalButton;
    public Button day3Button;
    public GameObject waitingObject;

    public GameObject newWindow;

    // Start is called before the first frame update
    private void Start()
    {
        trueRestaurant.gameObject.SetActive(false);
        falseRestaurant.gameObject.SetActive(true);
        waitingObject.SetActive(false);
        newWindow.SetActive(false);

        foreach (Button button in buttonsToMonitor)
        {
            button.onClick.AddListener(OnButtonPressed);
        }

        additionalButton.onClick.AddListener(OnAdditionalButtonPressed);
        day3Button.onClick.AddListener(OnDay3ButtonPressed);
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


    private void OnAdditionalButtonPressed()
    {
        additionalButton.gameObject.SetActive(false);
        waitingObject.SetActive(true);
        newWindow.SetActive(true);

    }

    private void OnDay3ButtonPressed()
    {
        additionalButton.gameObject.SetActive(true);
        waitingObject.SetActive(false);
    }

    public void CloseWindow()
    {
        windowCanvas.SetActive(false);
    }
}
