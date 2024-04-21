using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class MainMenu : MonoBehaviour
{
    // Screens
    public GameObject mainMenuHomeScreen;
    public GameObject mainMenuStoryScreen;
    public GameObject mainMenuRecordsScreen;
    public GameObject mainMenuOptionsScreen;
    public GameObject mainMenuOptionsVolumeScreen;
    public GameObject mainMenuCreditsScreen;
    public GameObject mainMenuCreditsDevelopersScreen;
    public GameObject mainMenuCreditsCommitteeScreen;
    public GameObject mainMenuCreditsMusicScreen;
    public GameObject mainMenuCreditsDisclaimersScreen;
    public GameObject startStoryButton;
    public GameObject story;



    // Game Audio Variables
    // Game Audio Variables - Background Music
    // Game Audio Variables - Background Music - Main Menu
    public AudioSource mainMenuBackgroundAudioSource;
    // Game Audio Variables - Background Music - Main Menu - Story
    public AudioSource storyBackgroundAudioSource;
    // Game Audio Variables - Background Music - Game
    // Game Audio Variables - Background Music - Game - Introduction
    public AudioSource introductionBackgroundAudioSource;
    // Game Audio Variables - Background Music - Game - Simulation
    public AudioSource week01BackgroundAudioSource;
    public AudioSource week02BackgroundAudioSource;
    public AudioSource week03BackgroundAudioSource;
    public AudioSource week04BackgroundAudioSource;
    // Game Audio Variables - Background Music - Game - Summary
    public AudioSource summaryBackgroundAudioSource;
    // Game Audio Variables - Sound Effects
    // Game Audio Variables - Sound Effects - Button Clicks
    public AudioSource forwardButtonClickAudioSource;
    public AudioSource backwardsButtonClickAudioSource;
    public AudioSource playButtonClickAudioSource;
    public AudioSource randomButtonClickAudioSource;
    // Game Audio Variables - Sound Effects - Events
    public AudioSource moneyGainedAudioSource;
    public AudioSource moneyLossAudioSource;
    public AudioSource positiveEventAudioSource;
    public AudioSource negativeEventAudioSource;
    // Game Audio Variables - Sound Effects - Status
    public AudioSource successStatusAudioSource;
    public AudioSource failureStatusAudioSource;



    
    void Awake()
    {
        //mainMenuBackgroundAudioSource.Play();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKey("escape"))
        // {
        //     Application.Quit();
        // }
    }
    // Play Game
    public void PlayGame()
    {
        playButtonClickAudioSource.Play();
        mainMenuBackgroundAudioSource.Stop();
        SceneManager.LoadScene("Game");
    }

    // Story
    public void Story()
    {
        forwardButtonClickAudioSource.Play();
        mainMenuBackgroundAudioSource.Pause();
        mainMenuHomeScreen.SetActive(false);
        mainMenuStoryScreen.SetActive(true);
    }
    public void StartStory()
    {
        storyBackgroundAudioSource.Play();
        startStoryButton.SetActive(false);
        story.SetActive(true);
    }

    // Records
    public void Records()
    {
        forwardButtonClickAudioSource.Play();
        mainMenuHomeScreen.SetActive(false);
        mainMenuRecordsScreen.SetActive(false);
    }

    // Options
    public void Options()
    {
        forwardButtonClickAudioSource.Play();
        mainMenuHomeScreen.SetActive(false);
        mainMenuOptionsScreen.SetActive(true);
    }
    public void OptionsVolume()
    {
        forwardButtonClickAudioSource.Play();
        mainMenuOptionsScreen.SetActive(false);
        mainMenuOptionsVolumeScreen.SetActive(true);
    }

    // Credits
    public void Credits()
    {
        forwardButtonClickAudioSource.Play();
        mainMenuHomeScreen.SetActive(false);
        mainMenuCreditsScreen.SetActive(true);
    }
    public void CreditsDevelopers()
    {
        forwardButtonClickAudioSource.Play();
        mainMenuCreditsScreen.SetActive(false);
        mainMenuCreditsDevelopersScreen.SetActive(true);
    }
    public void CreditsCommittee()
    {
        forwardButtonClickAudioSource.Play();
        mainMenuCreditsScreen.SetActive(false);
        mainMenuCreditsCommitteeScreen.SetActive(true);
    }
    public void CreditsMusic()
    {
        forwardButtonClickAudioSource.Play();
        mainMenuCreditsScreen.SetActive(false);
        mainMenuCreditsMusicScreen.SetActive(true);
    }
    public void CreditsDisclaimer()
    {
        forwardButtonClickAudioSource.Play();
        mainMenuCreditsScreen.SetActive(false);
        mainMenuCreditsDisclaimersScreen.SetActive(true);
    }

    // Back
    public void BackToMainMenu()
    {
        backwardsButtonClickAudioSource.Play();
        mainMenuRecordsScreen.SetActive(false);
        mainMenuOptionsScreen.SetActive(false);
        mainMenuCreditsScreen.SetActive(false);
        mainMenuHomeScreen.SetActive(true);
    }
    public void BackToMainMenuFromStory()
    {
        storyBackgroundAudioSource.Stop();
        backwardsButtonClickAudioSource.Play();
        // mainMenuBackgroundAudioSource.UnPause();
        // mainMenuStoryScreen.SetActive(false);
        // mainMenuHomeScreen.SetActive(true);

        SceneManager.LoadScene("MainMenu");
    }
    public void BackToOptions()
    {
        backwardsButtonClickAudioSource.Play();
        mainMenuOptionsVolumeScreen.SetActive(false);
        mainMenuOptionsScreen.SetActive(true);
    }
    public void BackToCredits()
    {
        backwardsButtonClickAudioSource.Play();
        mainMenuCreditsDevelopersScreen.SetActive(false);
        mainMenuCreditsCommitteeScreen.SetActive(false);
        mainMenuCreditsMusicScreen.SetActive(false);
        mainMenuCreditsDisclaimersScreen.SetActive(false);
        mainMenuCreditsScreen.SetActive(true);
    }

    // Quit Game
    public void QuitGame()
    {
        Application.Quit();
    }
}
