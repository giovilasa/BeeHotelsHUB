using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaterialActivity : MonoBehaviour
{
    public List<GameObject> objectsToActivate;
    public GameObject windowCanvas1;
    public GameObject windowCanvas2;

    private bool buttonsActivated = false;

    void Start()
    {
        foreach (GameObject obj in objectsToActivate)
        {
            Button button = obj.GetComponent<Button>();
            if (button != null)
            {
                button.interactable = false;
            }
        }
    }

    public void ToggleButtons()
    {
        buttonsActivated = !buttonsActivated;

        foreach (GameObject obj in objectsToActivate)
        {
            Button button = obj.GetComponent<Button>();
            if (button != null)
            {
                button.interactable = buttonsActivated;
            }
        }
    }

    public void CloseWindows()
    {
        windowCanvas1.SetActive(false);
        windowCanvas2.SetActive(false);
    }
}
