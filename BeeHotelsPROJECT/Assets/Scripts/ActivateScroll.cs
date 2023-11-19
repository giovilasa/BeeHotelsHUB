using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateScroll : MonoBehaviour
{
    public Scrollbar scrollbar;
    public GameObject scrollArea;
    public Button[] activateButtons;

    private void Start()
    {
        foreach (Button button in activateButtons)
        {
            button.onClick.AddListener(OnActivateButtonClick);
        }

        scrollbar.gameObject.SetActive(false);
        scrollArea.SetActive(false);
    }

    private void OnActivateButtonClick()
    {
        scrollbar.gameObject.SetActive(true);
        scrollArea.SetActive(true);

        foreach (Button button in activateButtons)
        {
            button.gameObject.SetActive(false);
        }
    }
}
