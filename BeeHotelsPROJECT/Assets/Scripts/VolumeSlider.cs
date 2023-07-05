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
        AudioListener.volume = volume;
    }

    public void OnMusicVolumeChanged(float volume)
    {
        // Imposta il volume della musica
        foreach (AudioSource musicSource in musicSources)
        {
            musicSource.volume = volume;
        }
    }

    public void OnSoundEffectsVolumeChanged(float volume)
    {
        // Imposta il volume degli effetti sonori
        foreach (AudioSource soundEffectSource in soundEffectSources)
        {
            soundEffectSource.volume = volume;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
