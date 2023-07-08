using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WindowManager : MonoBehaviour
{
    public GameObject windowCanvas;
    //public TextMeshProUGUI textElement;
    //public RawImage Ostacolo1;
    //public RawImage Ostacolo2;

    // Start is called before the first frame update
    void Start()
    {
        windowCanvas.SetActive(false);
    }

    // Update is called once per frame
    public void OnButtonClick()
    {
        // Attiva la finestra
        windowCanvas.SetActive(true);

        // Configura gli elementi all'interno della finestra in base al pulsante premuto
        
        //textElement.text = "Testo personalizzato";
        //Ostacolo1.texture = Resources.Load<Texture>("NomeImmagine");
        //Ostacolo1.texture = Resources.Load<Texture>("NomeImmagine");
    }
}
