using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class EndgameManager : MonoBehaviour
{
    public Button[] buttonsToMonitor;
    public GameObject spawnPoint;
    public GameObject[] objectsToDisable;

    private int buttonIndex = 0; // Index of the next button to press in the correct order

    private void Start()
    {
        foreach (Button button in buttonsToMonitor)
        {
            button.onClick.AddListener(() => OnButtonPressed(button));
        }
    }

    private void OnButtonPressed(Button pressedButton)
    {
        // Verify if the pressed button is the correct one in the order
        if (pressedButton == buttonsToMonitor[buttonIndex])
        {
            // Deactivates the pressed button so that it cannot be pressed again
            pressedButton.interactable = false;

            buttonIndex++; // Move to the next button in the correct order

            // Check if all buttons have been pressed in the correct order
            if (buttonIndex == buttonsToMonitor.Length)
            {
                // Disable objects in the "objectstodisable" array
                foreach (GameObject obj in objectsToDisable)
                {
                    obj.SetActive(false);
                }

                // Appearance of the object in the scene
                spawnPoint.SetActive(true);
            }
        }
        else
        {
            // Reset button order if wrong button is pressed
            buttonIndex = 0;

            // Reactivate all buttons to try again
            foreach (Button button in buttonsToMonitor)
            {
                button.interactable = true;
            }
        }
    }
}
