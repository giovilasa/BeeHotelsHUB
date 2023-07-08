using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManagerMain : MonoBehaviour
{

    public Button[] buttons;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Verifica se la telecamera principale è attiva
        bool isMainCameraActive = Camera.main != null;

        // Abilita o disabilita i pulsanti in base allo stato della telecamera principale
        foreach (Button button in buttons)
        {
            button.interactable = isMainCameraActive;
        }
    }
}
