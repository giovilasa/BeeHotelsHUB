using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSound : MonoBehaviour
{
    public AudioSource buttonClickAudioSource;

    private void Start()
    {
        if (buttonClickAudioSource == null)
        {
            Debug.LogError("AudioSource non assegnato al componente ButtonClickSound.");
        }
    }

    public void OnMouseDown()
    {
        // Riproduci l'effetto sonoro
        buttonClickAudioSource.Play();
    }
}
