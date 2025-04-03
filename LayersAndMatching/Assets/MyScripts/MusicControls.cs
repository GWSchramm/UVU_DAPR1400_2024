using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicControls : MonoBehaviour
{
    //drag the audio sources for the music here
    public AudioSource musicSourceA;
    public AudioSource musicSourceB;

    //drag the sliders here
    public Slider volumeSliderA;
    public Slider volumeSliderB;

    
    void Start()
    {
        // takes the value of the slider and sets the volume equal to it
        volumeSliderA.value = musicSourceA.volume;
        volumeSliderB.value = musicSourceB.volume;

        //when the value of the slider is changed the volume is attenuated
        volumeSliderA.onValueChanged.AddListener(AdjustVolumeA);
        volumeSliderB.onValueChanged.AddListener(AdjustVolumeB);
    }

    public void AdjustVolumeA(float newVolume)
    {
        musicSourceA.volume = newVolume;
    }

    public void AdjustVolumeB(float newVolume)
    {
        musicSourceB.volume = newVolume;
    }


    public void ToggleMusic()
    {
        //if either of the sources are playing:
        if (musicSourceA.isPlaying | musicSourceB.isPlaying)
        {
            musicSourceA.Pause();
            musicSourceB.Pause();
        }
        else
        {
            musicSourceA.Play();
            musicSourceB.Play();
        }
    }


}
