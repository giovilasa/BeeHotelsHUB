using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightController : MonoBehaviour
{
    public float intensityChangeRate = 1.0f;
    public GameObject menu;
    public Button[] stopButtons;

    private Light spotLight;
    private bool increasingIntensity = true;

    void Start()
    {
        spotLight = GetComponent<Light>();

        // Verifica se ci sono pulsanti nell'array
        if (stopButtons != null && stopButtons.Length > 0)
        {
            // Aggiungi il listener a ciascun pulsante nell'array
            foreach (Button button in stopButtons)
            {
                button.onClick.AddListener(StopButtonClicked);
            }
        }
        else
        {
            Debug.LogError("L'array di pulsanti Stop è vuoto. Aggiungi almeno un pulsante nell'Inspector.");
        }

        InvokeRepeating("ChangeIntensity", 0f, intensityChangeRate);
    }

    void ChangeIntensity()
    {
        if (!menu.activeSelf)
        {
            if (increasingIntensity)
            {
                if (spotLight.intensity < 2.0f)
                {
                    spotLight.intensity += 1.0f;
                }
                else
                {
                    increasingIntensity = false;
                }
            }
            else
            {
                if (spotLight.intensity > 0.0f)
                {
                    spotLight.intensity -= 1.0f;
                }
                else
                {
                    increasingIntensity = true;
                }
            }
        }
        else
        {
            // Se il menu è attivo, imposto l'intensità a 0
            spotLight.intensity = 0.0f;
        }
    }

    void StopButtonClicked()
    {
        // Se uno qualsiasi dei pulsanti "Stop" viene premuto, disattiva lo Spot Light
        spotLight.enabled = false;
    }
}
