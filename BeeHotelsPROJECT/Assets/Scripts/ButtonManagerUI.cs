using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManagerUI : MonoBehaviour
{
    //public Button MainMenu;//
    public GameObject MainUI;
    public GameObject SecondUI;
    private bool isSecondUIVisible = false;
    private bool isMainUIVisible = true;

    // Start is called before the first frame update
    void Start()
    {
        SecondUI.SetActive(false);
    }

    public void HandleButtonClick()
    {
        Debug.Log("Il pulsante è stato cliccato!");
        // Aggiungi qui la logica che desideri eseguire quando il pulsante viene cliccato
    }

    public void OnButtonClick()
    {
        isSecondUIVisible = !isSecondUIVisible; // Switch visibility state of SecondUI
        SecondUI.SetActive(isSecondUIVisible); // Sets the visibility of SecondUI based on the value of the variable
        isMainUIVisible = !isMainUIVisible; // Switch visibility state of MainUI
        MainUI.SetActive(isMainUIVisible); // Sets the visibility of MainUI based on the value of the variable
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
