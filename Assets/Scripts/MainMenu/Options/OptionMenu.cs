using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class OptionMenu : MonoBehaviour
{ 
    public AudioMixer audioMixer;
    [SerializeField] private Slider slider;
    [SerializeField] private Toggle toggle;
    [SerializeField] private Dropdown dropdown;

    public void Awake()
    {
        ReturnOptions();
    }

    public void ReturnOptions()
    {
        slider.value = StaticOptions._volume;
        audioMixer.SetFloat("volume", Mathf.Log10(StaticOptions._volume) * 20);
        dropdown.value = StaticOptions._quality;
        QualitySettings.SetQualityLevel(StaticOptions._quality);
        if (AudioListener.pause==true) toggle.isOn = false;
    }

    public void SetVolume(float volume)
    {
        StaticOptions._volume = volume;
        audioMixer.SetFloat("volume", Mathf.Log10(volume) * 20);
    }

    public void SetQuality(int qualityIndex)
    {

        StaticOptions._quality = qualityIndex;
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void Sound()
    {
        AudioListener.pause = !AudioListener.pause;

    }

    


}
