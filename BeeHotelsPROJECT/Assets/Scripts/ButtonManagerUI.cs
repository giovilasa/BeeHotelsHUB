using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManagerUI : MonoBehaviour
{
    //public Button MainMenu;//
    public GameObject MainUI;
    public GameObject SecondUI;
    private bool isSecondUIVisible = true;
    //private bool isMainUIVisible = true;

    // Start is called before the first frame update
    void Start()
    {
        SecondUI.SetActive(true);
    }
    public void OnButtonClick()
    {
        if (isSecondUIVisible)
        {
            // Mostra MainUI e nascondi SecondUI
            MainUI.SetActive(true);
            //isMainUIVisible = true;
            SecondUI.SetActive(false);
            isSecondUIVisible = false;
        }
        else
        {
            // Mostra SecondUI e nascondi MainUI
            MainUI.SetActive(false);
            //isMainUIVisible = false;
            SecondUI.SetActive(true);
            isSecondUIVisible = true;
        }
    }

    
}
