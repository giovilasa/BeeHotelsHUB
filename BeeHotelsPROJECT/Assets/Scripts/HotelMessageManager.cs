using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HotelMessageManager : MonoBehaviour
{
    public Button[] buttons; // Array di bottoni
    public GameObject spawnPoint; // Punto di spawn

    private bool isSpawnPointActivated; // Flag per verificare se il punto di spawn è stato attivato

    private void Start()
    {
        isSpawnPointActivated = false;

        // Aggiungi un listener per ogni pulsante
        for (int i = 0; i < buttons.Length; i++)
        {
            int buttonIndex = i; // Evita la chiusura imprevista
            buttons[i].onClick.AddListener(() => OnButtonClick(buttonIndex));
        }
    }

    private void OnButtonClick(int buttonIndex)
    {
        // Verifica se il punto di spawn è già stato attivato
        if (!isSpawnPointActivated)
        {
            // Attiva il punto di spawn
            spawnPoint.SetActive(true);
            isSpawnPointActivated = true;

            Debug.Log("SpawnPoint attivato!");
        }
        else
        {
            Debug.Log("SpawnPoint già attivato. Non può essere attivato nuovamente.");
        }
    }
}
