using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{

    public Slider masterVolumeSlider;
    public Slider musicVolumeSlider;
    public Slider soundEffectsVolumeSlider;

    public List<AudioSource> musicSources;
    public List<AudioSource> soundEffectSources;

    private void Start()
    {
        masterVolumeSlider.onValueChanged.AddListener(OnMasterVolumeChanged);
        musicVolumeSlider.onValueChanged.AddListener(OnMusicVolumeChanged);
        soundEffectsVolumeSlider.onValueChanged.AddListener(OnSoundEffectsVolumeChanged);
    }

    public void OnMasterVolumeChanged(float volume)
    {
        // Imposta il volume generale del gioco
        if (volume == 0)
        {
            AudioListener.volume = 0f; // Disattiva l'audio
        }
        else
        {
            AudioListener.volume = volume;
        }
    }

    public void OnMusicVolumeChanged(float volume)
    {
        // Imposta il volume della musica
        foreach (AudioSource musicSource in musicSources)
        {
            if (volume == 0)
            {
                musicSource.volume = 0f; // Disattiva l'audio della musica
            }
            else
            {
                musicSource.volume = volume;
            }
        }
    }

    public void OnSoundEffectsVolumeChanged(float volume)
    {
        // Imposta il volume degli effetti sonori
        foreach (AudioSource soundEffectSource in soundEffectSources)
        {
            if (volume == 0)
            {
                soundEffectSource.volume = 0f; // Disattiva l'audio degli effetti sonori
            }
            else
            {
                soundEffectSource.volume = volume;
            }
        }
    }
}
