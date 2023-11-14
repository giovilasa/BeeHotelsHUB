using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightController : MonoBehaviour
{
    public float intensityChangeRate = 1.0f;
    public GameObject menu;
    public GameObject[] stopObjects; // Array di oggetti

    private Light spotLight;
    private bool increasingIntensity = true;

    void Start()
    {
        spotLight = GetComponent<Light>();

        // Verifica se ci sono oggetti nell'array
        if (stopObjects != null && stopObjects.Length > 0)
        {
            foreach (GameObject stopObject in stopObjects)
            {
                stopObject.SetActive(false); // Assicurati che gli oggetti siano disattivati all'inizio
            }
        }
        else
        {
            Debug.LogError("L'array di oggetti Stop è vuoto. Aggiungi almeno un oggetto nell'Inspector.");
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

        // Verifica se uno qualsiasi degli oggetti "Stop" è attivo e disattiva lo Spot Light
        foreach (GameObject stopObject in stopObjects)
        {
            if (stopObject.activeSelf)
            {
                spotLight.enabled = false;
                break;
            }
        }
    }
}
