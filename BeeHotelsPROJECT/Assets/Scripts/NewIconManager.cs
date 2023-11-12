using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewIconManager : MonoBehaviour
{
    public Button day2Button;
    public Button day3Button;
    public Button closeButton;
    public GameObject objectToActivate;

    private void Start()
    {
        // Deactivate the object at the start of the game
        objectToActivate.SetActive(false);

        // Connect methods to buttons
        day2Button.onClick.AddListener(ActivateObject);
        day3Button.onClick.AddListener(ActivateObject);
        closeButton.onClick.AddListener(DeactivateObject);
    }

    private void ActivateObject()
    {
        // Activate the object when Day 2 or Day 3 button is pressed
        objectToActivate.SetActive(true);
    }

    private void DeactivateObject()
    {
        // Deactivate the object when Close button is pressed
        objectToActivate.SetActive(false);
    }
}
