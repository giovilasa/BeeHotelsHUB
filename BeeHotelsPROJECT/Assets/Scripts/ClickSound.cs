using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSound : MonoBehaviour
{

    public AudioSource buttonClickAudioSource;

    // Start is called before the first frame update
    private void Start()
    {
        // Assicurati di avere aggiunto l'AudioSource al pulsante
        if (buttonClickAudioSource == null)
        {
            Debug.LogError("AudioSource non assegnato al componente ButtonClickSound.");
        }
    }

    public void OnButtonClick()
    {
        // Riproduci l'effetto sonoro
        buttonClickAudioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
