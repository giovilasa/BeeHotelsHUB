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
        // Set the overall volume of the game
        if (volume == 0)
        {
            AudioListener.volume = 0f; // Mute the audio
        }
        else
        {
            AudioListener.volume = volume;
        }
    }

    public void OnMusicVolumeChanged(float volume)
    {
        // Set the music volume
        foreach (AudioSource musicSource in musicSources)
        {
            if (volume == 0)
            {
                musicSource.volume = 0f; // Mute the music
            }
            else
            {
                musicSource.volume = volume;
            }
        }
    }

    public void OnSoundEffectsVolumeChanged(float volume)
    {
        // Set the volume of the sound effects
        foreach (AudioSource soundEffectSource in soundEffectSources)
        {
            if (volume == 0)
            {
                soundEffectSource.volume = 0f; // Mute sound effects
            }
            else
            {
                soundEffectSource.volume = volume;
            }
        }
    }
}
