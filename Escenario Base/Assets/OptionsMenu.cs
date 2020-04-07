using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public UnityEngine.UI.Slider slider;

    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("SoundVolume", 0.75f);
    }

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("SoundVolume", Mathf.Log10(volume) * 20);
        print(Mathf.Log10(volume) * 20);
    }
}
