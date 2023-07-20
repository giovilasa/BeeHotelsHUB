using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindowRestaurantManager : MonoBehaviour
{
    public GameObject windowCanvas;
    public GameObject falseRestaurant;
    public GameObject trueRestaurant;

    public Button buttonToMonitor;

    public Button additionalButton;
    public Button day3Button;
    public GameObject waitingObject;

    public GameObject newWindow;

    public GameObject beeMessage;
    private bool beeMessageActivated = false;

    // Start is called before the first frame update
    private void Start()
    {
        //Debug.Log("Il metodo Start del Ristorante è stato chiamato.");
        trueRestaurant.gameObject.SetActive(false);
        falseRestaurant.gameObject.SetActive(true);
        waitingObject.SetActive(false);
        newWindow.SetActive(false);

        buttonToMonitor.onClick.AddListener(OnButtonPressed);

        additionalButton.onClick.AddListener(OnAdditionalButtonPressed);
        day3Button.onClick.AddListener(OnDay3ButtonPressed);
    }

    private void OnButtonPressed()
    {
        //Debug.Log("Il pulsante monitorato è stato premuto");

        trueRestaurant.SetActive(true);
        falseRestaurant.SetActive(false);
    }

    public void OnMouseDown()
    {
        if (!beeMessageActivated)
        {
            beeMessageActivated = true;
            beeMessage.SetActive(true); // Attiva l'oggetto beeMessage
            windowCanvas.SetActive(false);
        }
        else
        {
            windowCanvas.SetActive(true);
        }
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
