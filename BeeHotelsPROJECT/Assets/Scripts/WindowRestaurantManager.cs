using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindowRestaurantManager : MonoBehaviour
{
    public GameObject windowCanvas;
    public Button button;

    // Start is called before the first frame update
    void Awake()
    {
        CloseWindow();
        Button button = GetComponent<Button>();
        if (button != null)
        {
            button.interactable = false;
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
