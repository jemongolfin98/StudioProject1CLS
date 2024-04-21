using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;

public class AudioSettings : MonoBehaviour
{
    private static readonly string BackgroundMusicPref = "BackgroundMusicPref";
    private static readonly string SoundEffectsPref = "SoundEffectsPref";
    private float backgroundMusicFloat, soundEffectsFloat;
    public AudioSource[] backgroundMusicAudio;
    public AudioSource[] soundEffectsAudio;

    private void Awake()
    {
        ContinueSettings();
    }

    private void ContinueSettings()
    {
        backgroundMusicFloat = PlayerPrefs.GetFloat(BackgroundMusicPref);
        soundEffectsFloat = PlayerPrefs.GetFloat(SoundEffectsPref);

        for (int i = 0; i < backgroundMusicAudio.Length; i++)
        {
            backgroundMusicAudio[i].volume = backgroundMusicFloat;
        }

        for (int j = 0; j < soundEffectsAudio.Length; j++)
        {
            soundEffectsAudio[j].volume = soundEffectsFloat;
        }
    }
}
