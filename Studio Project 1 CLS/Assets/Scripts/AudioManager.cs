using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    private static readonly string FirstPlay = "FirstPlay";
    private static readonly string BackgroundMusicPref = "BackgroundMusicPref";
    private static readonly string SoundEffectsPref = "SoundEffectsPref";
    private int firstPlayInt;
    public Slider backgroundMusicSlider, soundEffectsSlider;
    private float backgroundMusicFloat, soundEffectsFloat;
    public AudioSource[] backgroundMusicAudio;
    public AudioSource[] soundEffectsAudio;

    void Start()
    {
        firstPlayInt = PlayerPrefs.GetInt(FirstPlay);

        if (firstPlayInt == 0)
        {
            backgroundMusicFloat = 0.50f;
            soundEffectsFloat = 0.50f;
            backgroundMusicSlider.value = backgroundMusicFloat;
            soundEffectsSlider.value = soundEffectsFloat;
            PlayerPrefs.SetFloat(BackgroundMusicPref, backgroundMusicFloat);
            PlayerPrefs.SetFloat(SoundEffectsPref, soundEffectsFloat);
            PlayerPrefs.SetFloat(FirstPlay, -1);
        }
        else
        {
            backgroundMusicFloat = PlayerPrefs.GetFloat(BackgroundMusicPref);
            backgroundMusicSlider.value = backgroundMusicFloat;
            soundEffectsFloat = PlayerPrefs.GetFloat(SoundEffectsPref);
            soundEffectsSlider.value = soundEffectsFloat;
        }
    }

    public void SaveSoundSettings()
    {
        PlayerPrefs.SetFloat(BackgroundMusicPref, backgroundMusicSlider.value);
        PlayerPrefs.SetFloat(SoundEffectsPref, soundEffectsSlider.value);
    }

    private void OnApplicationFocus(bool inFocus)
    {
        if (!inFocus)
        {
            SaveSoundSettings();
        }
    }

    public void UpdateSound()
    {
        for (int i = 0; i < backgroundMusicAudio.Length; i++)
        {
            backgroundMusicAudio[i].volume = backgroundMusicSlider.value;
        }
        for (int j = 0; j < soundEffectsAudio.Length; j++)
        {
            soundEffectsAudio[j].volume = soundEffectsSlider.value;
        }
    }
}
