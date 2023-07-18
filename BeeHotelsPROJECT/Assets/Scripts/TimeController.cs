using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeController : MonoBehaviour
{
    public TextMeshProUGUI timerText;  // Riferimento al componente TextMeshProUGUI che mostrerà il timer
    private float startTime;  // Tempo di inizio del timer
    private bool timerRunning;  // Indica se il timer è in esecuzione

    private int startingHour = 12;
    private int startingMinute = 10;
    private int startingSecond = 0;

    void Start()
    {
        timerText = GetComponent<TextMeshProUGUI>();

        if (timerText == null)
        {
            Debug.Log("timerText is null");
        }
        else
        {
            Debug.Log("timerText is assigned");
        }

        startTime = Time.time;
        timerRunning = true;

        // Imposta il tempo di partenza
        startTime = Time.time - GetTotalElapsedTime();
    }

    void Update()
    {
        if (timerRunning)
        {
            // Calcola l'elapsedTime totale
            float totalElapsedTime = GetTotalElapsedTime();

            // Converti il tempo totale in ore, minuti e secondi
            int hours = startingHour + (int)(totalElapsedTime / 3600);
            int minutes = startingMinute + (int)((totalElapsedTime % 3600) / 60);
            int seconds = startingSecond + (int)(totalElapsedTime % 60);

            // Formatta i valori per visualizzare l'orario nel formato "hh:mm:ss"
            string formattedTime = hours.ToString("00") + ":" + minutes.ToString("00") + ":" + seconds.ToString("00");

            // Aggiorna il testo del timer
            timerText.text = formattedTime;
        }
    }

    private float GetTotalElapsedTime()
    {
        // Calcola l'elapsedTime totale dalla partenza
        return Time.time - startTime;
    }

    public void RestartTimer()
    {
        startTime = Time.time;
    }
}
