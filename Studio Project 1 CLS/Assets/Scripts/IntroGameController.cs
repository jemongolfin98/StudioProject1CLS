using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using TMPro;
using System.Data.SqlTypes;
using Unity.VisualScripting;
using System.IO;
using Unity.Mathematics;
using System;

public class IntroGameController : MonoBehaviour
{
    //Introduction - Game Buttons
    //Introduction - Game Buttons - Gender
    public GameObject maleButton;
    public GameObject femaleButton;
    public GameObject otherGenderButton;
    //Introduction - Game Buttons - Race/Nationality
    public GameObject europeanDescentButton;
    public GameObject africanDescentButton;
    public GameObject nativeAmericanDescentButton;
    public GameObject hispanicDescentButton;
    public GameObject asianDescentButton;
    public GameObject otherDescentButton;
    //Introduction - Game Buttons - Education
    public GameObject noDegreeButton;
    public GameObject hsDiplomaButton;
    public GameObject associatesDegreeButton;
    public GameObject bachelorsDegreeButton;
    public GameObject mastersDegreeButton;
    public GameObject advancedDegreeButton;
    // Introduction - Game Buttons - Employment
    public GameObject waiterButton;
    public GameObject cashierButton;
    public GameObject fryCookButton;
    public GameObject customerServiceAgentButton;
    public GameObject teacherButton;
    public GameObject licensedSalesAgentButton;
    public GameObject programmerButton;
    public GameObject engineerButton;
    public GameObject lawyerButton;
    public GameObject doctorButton;
    // Introduction - Game Buttons - Housing
    public GameObject livingWithParentsButton;
    public GameObject livingWithRoommatesButton;
    public GameObject basicApartmentButton;
    public GameObject luxuryApartmentButton;
    public GameObject basicHouseButton;
    public GameObject luxuryHouseButton;
    // Introduction - Game Buttons - Utilities - Communications
    public GameObject housePhone1990Button;
    public GameObject housePhone2020Button;
    public GameObject basicCellPhone1990Button;
    public GameObject basicCellPhone2020Button;
    public GameObject unlimitedCellPhone2020Button;
    public GameObject continueFromCommunicationsButton;
    // Introduction - Game Buttons - Utilities - Entertainment
    public GameObject basicCable1990Button;
    public GameObject basicCable2020Button;
    public GameObject premiumCable1990Button;
    public GameObject premiumCable2020Button;
    public GameObject streamingService2020Button;
    public GameObject continueFromEntertainmentButton;
    // Introduction - Game Buttons - Utilities - Internet 
    public GameObject basicDialUpInternet1990Button;
    public GameObject premiumDialUpInternet1990Button;
    public GameObject mb50Internet2020Button;
    public GameObject mb100Internet2020Button;
    public GameObject mb200Internet2020Button;
    public GameObject continueFromInternetButton;
    //Introduction - Game Buttons - Transportation
    public GameObject bicycleButton;
    public GameObject usedCarButton;
    public GameObject newCarButton;
    public GameObject motorcycleButton;
    public GameObject busButton;
    public GameObject trainButton;
    //Introduction - Game Buttons - Gift Money
    public GameObject giftMoneyButton;
    //Introduction - Game Buttons - Summary
    public GameObject summaryButton1990;
    public GameObject summaryButton2020;

    
    //Introduction - Game Screens
    //Introduction - Game Screens - Welcome
    public GameObject welcomeScreen;
    //Introduction - Game Screens - Gender
    public GameObject toGenderScreen;
    public GameObject genderScreen;
    public GameObject maleScreen;
    public GameObject femaleScreen;
    public GameObject otherGenderScreen;
    //Introduction - Game Screens - Race
    public GameObject toRaceScreen;
    public GameObject raceScreen;
    public GameObject europeanDescentScreen;
    public GameObject africanDescentScreen;
    public GameObject nativeAmericanDescentScreen;
    public GameObject hispanicDescentScreen;
    public GameObject asianDescentScreen;
    public GameObject otherDescentScreen;
    //Introduction - Game Screens - Education
    public GameObject toEducationScreen;
    public GameObject educationScreen;
    public GameObject educationScreenNoDegree;
    public GameObject educationScreenHSDiploma;
    public GameObject educationScreenAssociatesDegree;
    public GameObject educationScreenBachelorsDegree;
    public GameObject educationScreenMastersDegree;
    public GameObject educationScreenAdvancedDegree;
    //Introduction - Game Screens - Employment
    public GameObject toJobScreen;
    public GameObject jobScreen;
    public GameObject waiterScreen;
    public GameObject cashierScreen;
    public GameObject fryCookScreen;
    public GameObject customerServiceAgentScreen;
    public GameObject teacherScreen;
    public GameObject licensedSalesAgentScreen;
    public GameObject programmerScreen;
    public GameObject engineerScreen;
    public GameObject lawyerScreen;
    public GameObject doctorScreen;
    //Introduction - Game Screens - Housing
    public GameObject toHousingScreen;
    public GameObject housingScreen;
    public GameObject livingWithParentsScreen;
    public GameObject livingWithRoommatesScreen;
    public GameObject basicApartmentScreen;
    public GameObject luxuryApartmentScreen;
    public GameObject basicHouseScreen;
    public GameObject luxuryHouseScreen;
    //Introduction - Game Screens - Utilities
    public GameObject toUtilitiesScreen;
    public GameObject utilitiesScreen;
    public GameObject utilitiesElectricScreen;
    public GameObject utilitiesWaterScreen;
    public GameObject utilitiesCommunicationsScreen;
    public GameObject housePhone1990Screen;
    public GameObject housePhone2020Screen;
    public GameObject basicCellPhone1990Screen;
    public GameObject basicCellPhone2020Screen;
    public GameObject unlimitedCellPhone2020Screen;
    public GameObject utilitiesEntertainmentScreen;
    public GameObject basicCable1990Screen;
    public GameObject basicCable2020Screen;
    public GameObject premiumCable1990Screen;
    public GameObject premiumCable2020Screen;
    public GameObject streamingService2020Screen;
    public GameObject utilitiesInternetScreen;
    public GameObject basicDialUpInternet1990Screen;
    public GameObject premiumDialUpInternet1990Screen;
    public GameObject mb50Internet2020Screen;
    public GameObject mb100Internet2020Screen;
    public GameObject mb200Internet2020Screen;
    //Introduction - Game Screens - Transportation
    public GameObject toTransportationScreen;
    public GameObject transportationScreen;
    public GameObject bicycleScreen;
    public GameObject usedCarScreen;
    public GameObject newCarScreen;
    public GameObject motorcycleScreen;
    public GameObject busScreen;
    public GameObject trainScreen;
    //Introduction - Game Screens - Gift Money
    public GameObject toGiftMoneyScreen;
    public GameObject giftMoneyScreen1;
    public GameObject giftMoneyScreen2;
    //Introduction - Game Screens - Summary
    public GameObject toIntroSummaryScreen;
    public GameObject introSummaryScreen;
    public GameObject introSummary1990Screen;
    public GameObject introSummary2020Screen;


    //Introduction - Game Setting Variables
    //Introduction - Game Setting Variables - Gender
    public bool maleGender = false;
    public bool femaleGender = false;
    public bool otherGender = false;
    //Introduction - Game Setting Variables - Race
    public bool europeanDescent = false;
    public bool africanDescent = false;
    public bool nativeAmericanDescent = false;
    public bool hispanicDescent =  false;
    public bool asianDescent = false;
    public bool otherDescent = false;
    //Introduction - Game Setting Variables - Education
    public bool noDegree = false;
    public bool hsDiploma = false;
    public bool associatesDegree = false;
    public bool bachelorsDegree = false;
    public bool mastersDegree = false;
    public bool advancedDegree = false;
    //Introduction - Game Setting Variables - Employment
    public bool waiter = false;
    public bool cashier = false;
    public bool fryCook = false;
    public bool customerServiceAgent = false;
    public bool teacher = false;
    public bool licensedSalesAgent = false;
    public bool programmer = false;
    public bool engineer = false;
    public bool lawyer = false;
    public bool doctor = false;
    //Introduction - Game Setting Variables - Housing
    public bool livingWithParents = false;
    public bool livingWithRoommates = false;
    public bool basicApartment = false;
    public bool luxuryApartment = false;
    public bool basicHouse = false;
    public bool luxuryHouse = false;
    //Introduction - Game Setting Variables - Utilities
    public bool utilityElectric = false;
    public bool utilityWater = false;
    public bool utilityCommunications1990 = false;
    public bool utilityCommunications2020 = false;
    public bool housePhone1990 = false;
    public bool housePhone2020 = false;
    public bool basicCellPhone1990 = false;
    public bool basicCellPhone2020 = false;
    public bool unlimitedCellPhone2020 = false;
    public bool utilityEntertainment1990 = false;
    public bool utilityEntertainment2020 = false;
    public bool basicCable1990 = false;
    public bool basicCable2020 = false;
    public bool premiumCable1990 = false;
    public bool premiumCable2020 = false;
    public bool streamingService2020 = false;
    public bool utilityInternet1990 = false;
    public bool utilityInternet2020 = false;
    public bool basicDialUpInternet1990 = false;
    public bool premiumDialUpInternet1990 = false;
    public bool mb50Internet2020 = false;
    public bool mb100Internet2020 = false;
    public bool mb200Internet2020 = false;
    //Introduction - Game Setting Variables - Transportation
    public bool bicycle = false;
    public bool usedCar = false;
    public bool newCar = false;
    public bool motorcycle = false;
    public bool bus = false;
    public bool train = false;


    //Introduction - Text
    public TMPro.TMP_Text jobPayWaiter1990Text;
    public TMPro.TMP_Text jobPayWaiter2020Text;
    public TMPro.TMP_Text jobPayCashier1990Text;
    public TMPro.TMP_Text jobPayCashier2020Text;
    public TMPro.TMP_Text jobPayFryCook1990Text;
    public TMPro.TMP_Text jobPayFryCook2020Text;
    public TMPro.TMP_Text jobPayCSA1990Text;
    public TMPro.TMP_Text jobPayCSA2020Text;
    public TMPro.TMP_Text jobPayTeacher1990Text;
    public TMPro.TMP_Text jobPayTeacher2020Text;
    public TMPro.TMP_Text jobPayLSA1990Text;
    public TMPro.TMP_Text jobPayLSA2020Text;
    public TMPro.TMP_Text jobPayProgrammer1990Text;
    public TMPro.TMP_Text jobPayProgrammer2020Text;
    public TMPro.TMP_Text jobPayEngineer1990Text;
    public TMPro.TMP_Text jobPayEngineer2020Text;
    public TMPro.TMP_Text jobPayLawyer1990Text;
    public TMPro.TMP_Text jobPayLawyer2020Text;
    public TMPro.TMP_Text jobPayDoctor1990Text;
    public TMPro.TMP_Text jobPayDoctor2020Text;
    public TMPro.TMP_Text giftMoneyText;
    //Introduction - Text - Cost Text
    public TMPro.TMP_Text housingCostLWP1990Text;
    public TMPro.TMP_Text housingCostLWP2020Text;
    public TMPro.TMP_Text housingCostLWR1990Text;
    public TMPro.TMP_Text housingCostLWR2020Text;
    public TMPro.TMP_Text housingCostBA1990Text;
    public TMPro.TMP_Text housingCostBA2020Text;
    public TMPro.TMP_Text housingCostLA1990Text;
    public TMPro.TMP_Text housingCostLA2020Text;
    public TMPro.TMP_Text housingCostBH1990Text;
    public TMPro.TMP_Text housingCostBH2020Text;
    public TMPro.TMP_Text housingCostLH1990Text;
    public TMPro.TMP_Text housingCostLH2020Text;
    public TMPro.TMP_Text utilityElectricityCost1990Text;
    public TMPro.TMP_Text utilityElectricityCost2020Text;
    public TMPro.TMP_Text utilityWaterCost1990Text;
    public TMPro.TMP_Text utilityWaterCost2020Text;
    public TMPro.TMP_Text utilityCommunicationsHPCost1990Text;
    public TMPro.TMP_Text utilityCommunicationsHPCost2020Text;
    public TMPro.TMP_Text utilityCommunicationsBCPCost1990Text;
    public TMPro.TMP_Text utilityCommunicationsBCPCost2020Text;
    public TMPro.TMP_Text utilityCommunicationsUCPCost2020Text;
    public TMPro.TMP_Text utilityEntertainmentBCCost1990Text;
    public TMPro.TMP_Text utilityEntertainmentBCCost2020Text;
    public TMPro.TMP_Text utilityEntertainmentPCCost1990Text;
    public TMPro.TMP_Text utilityEntertainmentPCCost2020Text;
    public TMPro.TMP_Text utilityEntertainmentSSCost2020Text;
    public TMPro.TMP_Text utilityInternetBasicDialUpCost1990Text;
    public TMPro.TMP_Text utilityInternetPremiumDialUpCost1990Text;
    public TMPro.TMP_Text utilityInternet50Cost2020Text;
    public TMPro.TMP_Text utilityInternet100Cost2020Text;
    public TMPro.TMP_Text utilityInternet200Cost2020Text;
    public TMPro.TMP_Text transportationBCost1990Text;
    public TMPro.TMP_Text transportationBCost2020Text;
    public TMPro.TMP_Text transportationUCCost1990Text;
    public TMPro.TMP_Text transportationUCCost2020Text;
    public TMPro.TMP_Text transportationNCCost1990Text;
    public TMPro.TMP_Text transportationNCCost2020Text;
    public TMPro.TMP_Text transportationMCost1990Text;
    public TMPro.TMP_Text transportationMCost2020Text;
    public TMPro.TMP_Text transportationBusCost1990Text;
    public TMPro.TMP_Text transportationBusCost2020Text;
    public TMPro.TMP_Text transportationTCost1990Text;
    public TMPro.TMP_Text transportationTCost2020Text;
    //Introduction - Text - Game Intro Summary
    public TMPro.TMP_Text summaryInitialMoney1990Text;
    public TMPro.TMP_Text summaryInitialMoney2020Text;
    public TMPro.TMP_Text summaryGender1990Text;
    public TMPro.TMP_Text summaryGender2020Text;
    public TMPro.TMP_Text summaryRace1990Text;
    public TMPro.TMP_Text summaryRace2020Text;
    public TMPro.TMP_Text summaryEducation1990Text;
    public TMPro.TMP_Text summaryEducation2020Text;
    public TMPro.TMP_Text summaryJob1990Text;
    public TMPro.TMP_Text summaryJob2020Text;
    public TMPro.TMP_Text summaryJobPay1990Text;
    public TMPro.TMP_Text summaryJobPay2020Text;
    public TMPro.TMP_Text summaryHousing1990Text;
    public TMPro.TMP_Text summaryHousing2020Text;
    public TMPro.TMP_Text summaryHousingRent1990Text;
    public TMPro.TMP_Text summaryHousingRent2020Text;
    public TMPro.TMP_Text summaryUtilities1990Text;
    public TMPro.TMP_Text summaryUtilities2020Text;
    public TMPro.TMP_Text summaryUtilitiesCost1990Text;
    public TMPro.TMP_Text summaryUtilitiesCost2020Text;
    public TMPro.TMP_Text summaryTransportation1990Text;
    public TMPro.TMP_Text summaryTransportation2020Text;
    public TMPro.TMP_Text summaryTransportationCost1990Text;
    public TMPro.TMP_Text summaryTransportationCost2020Text;
    public TMPro.TMP_Text summaryGift1990Text;
    public TMPro.TMP_Text summaryGift2020Text;
    public TMPro.TMP_Text summaryCurrentMoney1990Text;
    public TMPro.TMP_Text summaryCurrentMoney2020Text;

    //Game Monetary Variables
    public double initialMoney1990 = 0.00;
    public double initialMoney2020 = 0.00;
    public double currentMoney1990 = 0.00;
    public double currentMoney2020 = 0.00;
    public double giftMoney = 0.00;
    public double biweeklySalary1990 = 0.00;
    public double biweeklySalary2020 = 0.00;
    public double rentCost1990 = 0.00;
    public double rentCost2020 = 0.00;
    public double mortgageCost1990 = 0.00;
    public double mortgageCost2020 = .00;
    public double utilitiesCost1990 = 0.00;
    public double utilitiesCost2020 = 0.00;
    public double foodCost1990 = 0.00;
    public double foodCost2020 = 0.00;
    public double foodGroceryCost1990 = 40.00;
    public double foodGroceryCost2020 = 80.00;
    public double foodFastFoodCost1990 = 80.00;
    public double foodFastFoodCost2020 = 150.00;
    public double foodEatingOutCost1990 = 160.00;
    public double foodEatingOutCost2020 = 300.00;
    // Game Monetary Variables - Transportation
    public double transportationCost1990 = 0.00;
    public double transportationCost2020 = 0.00;
    public double gasCost1990 = 1.15;
    public double gasCost2020 = 2.50;
    // Game Monetary Variables -  Transportation - Bicycle
    public double airPump1990 = 2.00;
    public double airPump2020 = 3.00;
    public double bicycleCost1990 = 0.00;
    public double bicycleCost2020 = 0.00;
    // Game Monetary Variables -  Transportation - Used Car
    public int usedCarTank = 10;
    public double weeklyUsedCarCost1990 = 0.00;
    public double weeklyUsedCarCost2020 = 0.00;
    // Game Monetary Variables -  Transportation - New Car
    public int newCarTank = 15;
    public double weeklyNewCarCost1990 = 0.00;
    public double weeklyNewCarCost2020 = 0.00;
    // Game Monetary Variables -  Transportation - Motorcycle
    public int motorcycleTank = 4;
    public double weeklyMotorcycleCost1990 = 0.00;
    public double weeklyMotorcycleCost2020 = 0.00;
    // Game Monetary Variables -  Transportation - Bus
    public double busPass1990 = 2.00;
    public double busPass2020 = 4.50;
    // Game Monetary Variables -  Transportation - Train
    public double trainPass1990 = 0.00;
    public double trainPass2020 = 0.00;
    // Game Monetary Variables -  Other
    public double otherCost1990 = 0.00;
    public double otherCost2020 = 0.00;
    public double studentLoan1990 = 0.00;
    public double studentLoan2020 = 0.00;
    public double medicalCost1990 = 0.00;
    public double medicalCost2020 = 0.00;
    public double raise1990 = 0.00;
    public double raise2020 = 0.00;
    public double payCut1990 = 0.00;
    public double payCut2020 = 0.00;
    public double taxReturn1990 = 0.00;
    public double taxReturn2020 = 0.00;

    public double winnings = 0.00;

    //Game Monetary Variables - Utilities
    public double utilityElectricCost1990 = 0.00;
    public double utilityElectricCost2020 = 0.00;
    public double utilityWaterCost1990 = 0.00;
    public double utilityWaterCost2020 = 0.00;
    public double utilityCommunicationsCost1990 = 0.00;
    public double utilityCommunicationsCost2020 = 0.00;
    public double utilityEntertainmentCost1990 = 0.00;
    public double utilityEntertainmentCost2020 = 0.00;
    public double utilityInternetCost1990 = 0.00;
    public double utilityInternetCost2020 = 0.00;
    //Game Monetary Variables - Transportation
    public double weekB1990 = 0.00;
    public double weekB2020 = 0.00;
    public double weekUC1990 = 0.00;
    public double weekUC2020 = 0.00;
    public double weekNC1990 = 0.00;
    public double weekNC2020 = 0.00;
    public double weekM1990 = 0.00;
    public double weekM2020 = 0.00;
    public double weekBus1990 = 0.00;
    public double weekBus2020 = 0.00;
    public double weekT1990 = 0.00;
    public double weekT2020 = 0.00;


    //Game - Option Selection
    public string genderSelected;
    public string raceSelected;
    public string educationSelected;
    public string jobSelected;
    public string housingSelected;
    public string transportationSelected;

    //Game - Utility Selection
    public string utilityElectric1990Selected;
    public string utilityElectric2020Selected;
    public string utilityWater1990Selected;
    public string utilityWater2020Selected;
    public string utilityCommunications1990Selected;
    public string utilityCommunications2020Selected;
    public string utilityEntertainment1990Selected;
    public string utilityEntertainment2020Selected;
    public string utilityInternet1990Selected;
    public string utilityInternet2020Selected;

    //Game - Other Variables
    public GameObject introductionSection;
    public GameObject simulationSection;
    public GameObject summarySection;
    public GameObject introGameController1;
    public GameObject backFromCommunicationsButton;
    public GameObject backFromEntertainmentButton;
    public GameObject backFromInternetButton;
    public int genderNow = 0;
    public int raceNow = 0;
    public int educationNow = 0;
    public int jobNow = 0;
    public int houseNow = 0;
    public int utilitiesNow;
    public int travelNow = 0;
    public int utilitiesSelected = 0;
    public int i = 0;
    public int j = 0;




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
    




    //Simulation Variables
    //Simulation - Screens
    public GameObject simulationStartScreen;
    public GameObject mainSimulationScreen;
    public GameObject pauseMenuScreen;
    public GameObject tasksScreen;
    public GameObject playerStats1990Screen;
    public GameObject playerStats2020Screen;
    public GameObject payDayScreen1;
    public GameObject payDayScreen2;
    public GameObject payRentScreen1;
    public GameObject payRentScreen2;
    public GameObject payUtilitiesScreen;
    public GameObject payUtilitiesElectricityScreen;
    public GameObject payUtilitiesWaterScreen;
    public GameObject payUtilitiesCommunicationsScreen;
    public GameObject payUtilitiesEntertainmentScreen;
    public GameObject payUtilitiesInternetScreen;
    public GameObject payFoodScreen;
    public GameObject payFoodFastFoodScreen;
    public GameObject payFoodGroceriesScreen;
    public GameObject payFoodEatingOutScreen;
    public GameObject payTransportationScreen1;
    public GameObject payTransportationScreen2;
    //Simulation - Screens - Random Events
    public GameObject randomEventsScreen1;
    public GameObject randomEventsScreen2;
    public GameObject randomEventsScreenJob;
    public GameObject randomEventsScreenTransportation;

    //Simulation - Buttons
    public GameObject toPayDayButton;
    public GameObject toPayHousingButton;
    public GameObject payHousingButton;
    public GameObject toPayUtilitiesButton;
    public GameObject toPayUtilitiesElectricityButton;
    public GameObject payUtilitiesElectricity1990Button;
    public GameObject payUtilitiesElectricity2020Button;
    public GameObject toPayUtilitiesWaterButton;
    public GameObject payUtilitiesWater1990Button;
    public GameObject payUtilitiesWater2020Button;
    public GameObject toPayUtilitiesCommunicationsButton;
    public GameObject payUtilitiesCommunications1990Button;
    public GameObject payUtilitiesCommunications2020Button;
    public GameObject toPayUtilitiesEntertainmentButton;
    public GameObject payUtilitiesEntertainment1990Button;
    public GameObject payUtilitiesEntertainment2020Button;
    public GameObject toPayUtilitiesInternetButton;
    public GameObject payUtilitiesInternet1990Button;
    public GameObject payUtilitiesInternet2020Button;
    public GameObject toPayGroceriesButton;
    public GameObject payFoodGroceriesButton;
    public GameObject payFoodFastFoodButton;
    public GameObject payFoodEatingOutButton;
    public GameObject toPayTransportationButton;
    public GameObject payTransportationButton;
    //Simulation - Buttons - Random Events
    public GameObject RandomEventsPage1CloseButton;
    //public GameObject RandomEventsPage2Button;
    public GameObject RandomEventsPage2CloseButton;
    //Simulation - Buttons - Random Events - Event
    public GameObject RandomEvent01Page1Button;
    public GameObject RandomEvent02Page1Button;
    public GameObject RandomEvent03Page1Button;
    public GameObject RandomEvent04Page1Button;
    public GameObject RandomEvent05Page1Button;
    public GameObject RandomEvent06Page1Button;
    public GameObject RandomEvent07Page1Button;
    public GameObject RandomEvent08Page1Button;
    public GameObject RandomEvent09Page1Button;
    public GameObject RandomEvent10Page1Button;
    public GameObject RandomEvent11Page1Button;
    public GameObject RandomEvent12Page1Button;
    public GameObject RandomEvent13Page1Button;
    public GameObject RandomEvent14Page1Button;
    public GameObject RandomEvent15Page1Button;
    public GameObject RandomEvent16Page1Button;
    public GameObject RandomEvent17Page1Button;
    public GameObject RandomEvent18Page1Button;
    public GameObject RandomEvent19Page1Button;
    public GameObject RandomEvent20Page1Button;
    public GameObject RandomEvent21Page1Button;
    public GameObject RandomEvent22Page1Button;
    public GameObject RandomEvent23Page1Button;
    public GameObject RandomEvent24Page1Button;
    public GameObject RandomEvent25Page1Button;
    public GameObject RandomEvent26Page1Button;
    public GameObject RandomEvent27Page1Button;
    public GameObject RandomEvent28Page1Button;
    public GameObject RandomEvent29Page1Button;
    public GameObject RandomEvent30Page1Button;
    public GameObject RandomEvent31Page1Button;
    public GameObject RandomEvent32Page1Button;
    public GameObject RandomEvent33Page1Button;
    public GameObject RandomEvent34Page1Button;
    public GameObject RandomEvent35Page1Button;
    public GameObject RandomEvent36Page1Button;
    public GameObject RandomEvent37Page1Button;
    public GameObject RandomEvent38Page1Button;
    public GameObject RandomEvent39Page1Button;
    public GameObject RandomEvent40Page1Button;
    public GameObject RandomEvent41Page1Button;
    public GameObject RandomEvent42Page1Button;
    public GameObject RandomEvent43Page1Button;
    public GameObject RandomEvent44Page1Button;
    public GameObject RandomEvent45Page1Button;
    public GameObject RandomEvent46Page1Button;
    public GameObject RandomEvent47Page1Button;
    public GameObject RandomEvent48Page1Button;
    public GameObject RandomEvent49Page1Button;
    public GameObject RandomEvent50Page1Button;
    //Simulation - Buttons - Random Events - Job
    public GameObject newWaiterButton;
    public GameObject newCashierButton;
    public GameObject newFryCookButton;
    public GameObject newCSAButton;
    public GameObject newTeacherButton;
    public GameObject newLSAButton;
    public GameObject newProgrammerButton;
    public GameObject newEngineerButton;
    public GameObject newDoctorButton;
    public GameObject newLawyerButton;
    // Simulation - Buttons - Random Events - Travel
    public GameObject newBicycleButton;
    public GameObject newUsedCarButton;
    public GameObject newNewCarButton;
    public GameObject newMotorcycleButton;
    public GameObject newBusButton;
    public GameObject newTrainButton;

    //Simulation - Text
    //Simulation - Text - Title
    public TMPro.TMP_Text quarterTitleText;
    public TMPro.TMP_Text monthTitleText;
    public TMPro.TMP_Text weekTitleText;
    //Simulation - Text - Main Sim Status
    public TMPro.TMP_Text simCurrentMoney1990Text;
    public TMPro.TMP_Text simCurrentMoney2020Text;
    public TMPro.TMP_Text simHousing1990PaidText;
    public TMPro.TMP_Text simHousing2020PaidText;
    public TMPro.TMP_Text simUtilities1990PaidText;
    public TMPro.TMP_Text simUtilities2020PaidText;
    public TMPro.TMP_Text simGroceries1990PaidText;
    public TMPro.TMP_Text simGroceries2020PaidText;
    public TMPro.TMP_Text simTransportation1990PaidText;
    public TMPro.TMP_Text simTransportation2020PaidText;
    public TMPro.TMP_Text simOtherCost1990PaidText;
    public TMPro.TMP_Text simOtherCost2020PaidText;
    //Simulation - Text - Player Stats
    public TMPro.TMP_Text playerStats1990GenderText;
    public TMPro.TMP_Text playerStats2020GenderText;
    public TMPro.TMP_Text playerStats1990RaceText;
    public TMPro.TMP_Text playerStats2020RaceText;
    public TMPro.TMP_Text playerStats1990EducationText;
    public TMPro.TMP_Text playerStats2020EducationText;
    public TMPro.TMP_Text playerStats1990EmploymentText;
    public TMPro.TMP_Text playerStats2020EmploymentText;
    public TMPro.TMP_Text playerStats1990PayText;
    public TMPro.TMP_Text playerStats2020PayText;
    public TMPro.TMP_Text playerStats1990HousingText;
    public TMPro.TMP_Text playerStats2020HousingText;
    public TMPro.TMP_Text playerStats1990TransportationText;
    public TMPro.TMP_Text playerStats2020TransportationText;
    //Simulation - Text
    public TMPro.TMP_Text payDay1990Text;
    public TMPro.TMP_Text payDay2020Text;
    public TMPro.TMP_Text rentPaid1990Text;
    public TMPro.TMP_Text rentPaid2020Text;
    public GameObject electricity1990PaidTextObject;
    public TMPro.TMP_Text electricity1990PaidText;
    public GameObject electricity2020PaidTextObject;
    public TMPro.TMP_Text electricity2020PaidText;
    public GameObject water1990PaidTextObject;
    public TMPro.TMP_Text water1990PaidText;
    public GameObject water2020PaidTextObject;
    public TMPro.TMP_Text water2020PaidText;
    public GameObject communications1990PaidTextObject;
    public TMPro.TMP_Text communications1990PaidText;
    public GameObject communications2020PaidTextObject;
    public TMPro.TMP_Text communications2020PaidText;
    public GameObject entertainment1990PaidTextObject;
    public TMPro.TMP_Text entertainment1990PaidText;
    public GameObject entertainment2020PaidTextObject;
    public TMPro.TMP_Text entertainment2020PaidText;
    public GameObject internet1990PaidTextObject;
    public TMPro.TMP_Text internet1990PaidText;
    public GameObject internet2020PaidTextObject;
    public TMPro.TMP_Text internet2020PaidText;
    public TMPro.TMP_Text groceries1990PaidText;
    public TMPro.TMP_Text groceries2020PaidText;
    public TMPro.TMP_Text fastFood1990PaidText;
    public TMPro.TMP_Text fastFood2020PaidText;
    public TMPro.TMP_Text eatingOut1990PaidText;
    public TMPro.TMP_Text eatingOut2020PaidText;
    public TMPro.TMP_Text payTransportationTitleText1;
    public TMPro.TMP_Text payTransportationTitleText2;
    public TMPro.TMP_Text payTransportationDescriptionText;
    public TMPro.TMP_Text transportation1990PaidText;
    public TMPro.TMP_Text transportation2020PaidText;
    //Simulation - Text - Random Events
    //Simulation - Text - Random Events - Buttons
    public TMPro.TMP_Text RandomEvent01Page1ButtonText;
    public TMPro.TMP_Text RandomEvent02Page1ButtonText;
    public TMPro.TMP_Text RandomEvent03Page1ButtonText;
    public TMPro.TMP_Text RandomEvent04Page1ButtonText;
    public TMPro.TMP_Text RandomEvent05Page1ButtonText;
    public TMPro.TMP_Text RandomEvent06Page1ButtonText;
    public TMPro.TMP_Text RandomEvent07Page1ButtonText;
    public TMPro.TMP_Text RandomEvent08Page1ButtonText;
    public TMPro.TMP_Text RandomEvent09Page1ButtonText;
    public TMPro.TMP_Text RandomEvent10Page1ButtonText;
    public TMPro.TMP_Text RandomEvent11Page1ButtonText;
    public TMPro.TMP_Text RandomEvent12Page1ButtonText;
    public TMPro.TMP_Text RandomEvent13Page1ButtonText;
    public TMPro.TMP_Text RandomEvent14Page1ButtonText;
    public TMPro.TMP_Text RandomEvent15Page1ButtonText;
    public TMPro.TMP_Text RandomEvent16Page1ButtonText;
    public TMPro.TMP_Text RandomEvent17Page1ButtonText;
    public TMPro.TMP_Text RandomEvent18Page1ButtonText;
    public TMPro.TMP_Text RandomEvent19Page1ButtonText;
    public TMPro.TMP_Text RandomEvent20Page1ButtonText;
    public TMPro.TMP_Text RandomEvent21Page1ButtonText;
    public TMPro.TMP_Text RandomEvent22Page1ButtonText;
    public TMPro.TMP_Text RandomEvent23Page1ButtonText;
    public TMPro.TMP_Text RandomEvent24Page1ButtonText;
    public TMPro.TMP_Text RandomEvent25Page1ButtonText;
    public TMPro.TMP_Text RandomEvent26Page1ButtonText;
    public TMPro.TMP_Text RandomEvent27Page1ButtonText;
    public TMPro.TMP_Text RandomEvent28Page1ButtonText;
    public TMPro.TMP_Text RandomEvent29Page1ButtonText;
    public TMPro.TMP_Text RandomEvent30Page1ButtonText;
    public TMPro.TMP_Text RandomEvent31Page1ButtonText;
    public TMPro.TMP_Text RandomEvent32Page1ButtonText;
    public TMPro.TMP_Text RandomEvent33Page1ButtonText;
    public TMPro.TMP_Text RandomEvent34Page1ButtonText;
    public TMPro.TMP_Text RandomEvent35Page1ButtonText;
    public TMPro.TMP_Text RandomEvent36Page1ButtonText;
    public TMPro.TMP_Text RandomEvent37Page1ButtonText;
    public TMPro.TMP_Text RandomEvent38Page1ButtonText;
    public TMPro.TMP_Text RandomEvent39Page1ButtonText;
    public TMPro.TMP_Text RandomEvent40Page1ButtonText;
    public TMPro.TMP_Text RandomEvent41Page1ButtonText;
    public TMPro.TMP_Text RandomEvent42Page1ButtonText;
    public TMPro.TMP_Text RandomEvent43Page1ButtonText;
    public TMPro.TMP_Text RandomEvent44Page1ButtonText;
    public TMPro.TMP_Text RandomEvent45Page1ButtonText;
    public TMPro.TMP_Text RandomEvent46Page1ButtonText;
    public TMPro.TMP_Text RandomEvent47Page1ButtonText;
    public TMPro.TMP_Text RandomEvent48Page1ButtonText;
    public TMPro.TMP_Text RandomEvent49Page1ButtonText;
    public TMPro.TMP_Text RandomEvent50Page1ButtonText;
    //Simulation - Text - Random Events - Title
    public TMPro.TMP_Text randomEventsPage1TitleText;
    public TMPro.TMP_Text randomEventsPage2TitleText;
    public TMPro.TMP_Text randomEventsPageJobTitleText;
    public TMPro.TMP_Text randomEventsPageTransportationTitleText;
    //Simulation - Text - Random Events - Description Text
    public TMPro.TMP_Text randomEventsPage1DescriptionText;
    public TMPro.TMP_Text randomEventsPage2DescriptionText1;
    public TMPro.TMP_Text randomEventsPage2DescriptionText2;
    public TMPro.TMP_Text randomEventsPage2DescriptionText3;
    public TMPro.TMP_Text randomEventsPageJobDescriptionText1;
    public TMPro.TMP_Text randomEventsPageTransportationDescriptionText1; 
    //Simulation - Text (Additional)

    //Simulation - Strings
    //Simulation - Strings - Titles
    public string quarterTitle;
    public string monthTitle;
    public string weekTitle;

    //Simulation - Booleans
    //Simulation - Booleans - Pay Process
    public bool payDayNow = false;
    public bool rentDue = false;
    public bool utilitiesDue = false;
    public bool electricityDue = false;
    public bool waterDue = false;
    public bool communicationsDue = false;
    public bool entertainmentDue = false;
    public bool internetDue = false;
    public bool groceriesDue = false;
    public bool transportationDue = false;
    public bool RandomEvent = false;
    //Simulation - Booleans - Utilities
    public bool electricity1990Paid = false;
    public bool electricity2020Paid = false;
    public bool water1990Paid = false;
    public bool water2020Paid = false;
    public bool communications1990Paid = false;
    public bool communications2020Paid = false;
    public bool entertainment1990Paid = false;
    public bool entertainment2020Paid = false;
    public bool internet1990Paid = false;
    public bool internet2020Paid = false;

    //Simulation - Variables
    //Simulation - Variables - Monetary
    public double payRecieved1990;
    public double payRecieved2020;
    public double incomeTax1990 = 0.12;
    public double incomeTax2020 = 0.15;
    //Simulation - Variables - Monetary Paid
    public double rentPaid1990 = 0.00;
    public double rentPaid2020 = 0.00;
    public double mortgagePaid1990 = 0.00;
    public double mortgagePaid2020 = 0.00;
    public double utilitiesPaid1990 = 0.00;
    public double utilitiesPaid2020 = 0.00;
    public double utilityElectricPaid1990 = 0.00;
    public double utilityElectricPaid2020 = 0.00;
    public double utilityWaterPaid1990 = 0.00;
    public double utilityWaterPaid2020 = 0.00;
    public double utilityCommunicationsPaid1990 = 0.00;
    public double utilityCommunicationsPaid2020 = 0.00;
    public double utilityEntertainmentPaid1990 = 0.00;
    public double utilityEntertainmentPaid2020 = 0.00;
    public double utilityInternetPaid1990 = 0.00;
    public double utilityInternetPaid2020 = 0.00;
    public double groceryPaid1990 = 0.00;
    public double groceryPaid2020 = 0.00;
    public double transportationPaid1990 = 0.00;
    public double transportationPaid2020 = 0.00;
    public double otherPaid1990 = 0.00;
    public double otherPaid2020 = 0.00;
    //Simulation - Variables - Other
    public int quarterNumber;
    public int monthNumber;
    public int weekNumber;
    public int RandomEventCounter;
    public int randomEventNumber;
    // Simulation - Variables - Iteration
    // Simulation - Variables - Iteration - Quarter Counter
    public int q = 1;
    // Simulation - Variables - Iteration - Month Counter
    public int m = 1;
    // Simulation - Variables - Iteration - Week Counter
    public int m1w = 0;
    public int m2w = 0;
    public int m3w = 0;



    //Summary - Screens
    public GameObject weekSummaryScreen;
    public GameObject weekSummary1990Screen;
    public GameObject weekSummary2020Screen;
    public GameObject monthSummaryScreen;
    public GameObject monthSummary1990Screen;
    public GameObject monthSummary2020Screen;
    public GameObject quarterSummaryScreen;
    public GameObject quarterSummary1990Screen;
    public GameObject quarterSummary2020Screen;
    public GameObject finalSummaryScreen;
    //Summary - Buttons
    public GameObject toWeekSummaryButton;
    public GameObject toWeekSummary1990Button;
    public GameObject toWeekSummary2020Button;
    public GameObject continueSimulationFromWeekButton;
    public GameObject toMonthSummaryButton;
    public GameObject toMonthSummary1990Button;
    public GameObject toMonthSummary2020Button;
    public GameObject continueSimulationFromMonthButton;
    public GameObject toQuarterSummaryButton;
    public GameObject toQuarterSummary1990Button;
    public GameObject toQuarterSummary2020Button;
    public GameObject continueSimulationFromQuarterButton;
    public GameObject toFinalSummaryButton;
    //Summary - Booleans
    public bool housingComplete = false;
    public bool utilitiesComplete = false;
    public bool groceryComplete = false;
    public bool transportationComplete = false;
    //Summary - Variables
    //Summary - Variables - Week
    public double weekMoneyObtained1990 = 0.00;
    public double weekMoneyObtained2020 = 0.00;
    public double weekMoneyLoss1990 = 0.00;
    public double weekMoneyLoss2020 = 0.00;
    public double weekMoneyRemaining1990 = 0.00;
    public double weekMoneyRemaining2020 = 0.00;
    //Summary - Variables - Month
    public double monthMoneyObtained1990 = 0.00;
    public double monthMoneyObtained2020 = 0.00;
    public double month01MoneyObtained1990 = 0.00;
    public double month01MoneyObtained2020 = 0.00;
    public double month02MoneyObtained1990 = 0.00;
    public double month02MoneyObtained2020 = 0.00;
    public double month03MoneyObtained1990 = 0.00;
    public double month03MoneyObtained2020 = 0.00;
    public double monthMoneyLoss1990 = 0.00;
    public double monthMoneyLoss2020 = 0.00;
    public double month01MoneyLoss1990 = 0.00;
    public double month01MoneyLoss2020 = 0.00;
    public double month02MoneyLoss1990 = 0.00;
    public double month02MoneyLoss2020 = 0.00;
    public double month03MoneyLoss1990 = 0.00;
    public double month03MoneyLoss2020 = 0.00;
    public double monthMoneyRemaining1990 = 0.00;
    public double monthMoneyRemaining2020 = 0.00;
    // Summary - Variables - Quarter
    public double quarterMoneyObtained1990 = 0.00;
    public double quarterMoneyObtained2020 = 0.00;
    public double quarter01MoneyObtained1990 = 0.00;
    public double quarter01MoneyObtained2020 = 0.00;
    public double quarter02MoneyObtained1990 = 0.00;
    public double quarter02MoneyObtained2020 = 0.00;
    public double quarter03MoneyObtained1990 = 0.00;
    public double quarter03MoneyObtained2020 = 0.00;
    public double quarter04MoneyObtained1990 = 0.00;
    public double quarter04MoneyObtained2020 = 0.00;
    public double quarterMoneyLoss1990 = 0.00;
    public double quarterMoneyLoss2020 = 0.00;
    public double quarter01MoneyLoss1990 = 0.00;
    public double quarter01MoneyLoss2020 = 0.00;
    public double quarter02MoneyLoss1990 = 0.00;
    public double quarter02MoneyLoss2020 = 0.00;
    public double quarter03MoneyLoss1990 = 0.00;
    public double quarter03MoneyLoss2020 = 0.00;
    public double quarter04MoneyLoss1990 = 0.00;
    public double quarter04MoneyLoss2020 = 0.00;
    public double quarterMoneyRemaining1990 = 0.00;
    public double quarterMoneyRemaining2020 = 0.00;
    // Summary - Variables - Final
    public double finalMoneyObtained1990 = 0.00;
    public double finalMoneyObtained2020 = 0.00;
    public double finalMoneyLoss1990 = 0.00;
    public double finalMoneyLoss2020 = 0.00;
    public double finalMoneyRemaining1990 = 0.00;
    public double finalMoneyRemaining2020 = 0.00;

    //Summary - Text
    public TMPro.TMP_Text weekSummaryTitleText;
    public TMPro.TMP_Text monthSummaryTitleText;
    public TMPro.TMP_Text quarterSummaryTitleText;
    //Summary - Text - Week
    public TMPro.TMP_Text weekSummaryMoneyObtained1990Text;
    public TMPro.TMP_Text weekSummaryMoneyObtained2020Text;
    public TMPro.TMP_Text weekSummaryMoneyLoss1990Text;
    public TMPro.TMP_Text weekSummaryMoneyLoss2020Text;
    public TMPro.TMP_Text weekSummaryMoneyRemaining1990Text;
    public TMPro.TMP_Text weekSummaryMoneyRemaining2020Text;
    public TMPro.TMP_Text weekSummaryStatus1990Text;
    public TMPro.TMP_Text weekSummaryStatus2020Text;
    //Summary - Text - Month
    public TMPro.TMP_Text monthSummaryMoneyObtained1990Text;
    public TMPro.TMP_Text monthSummaryMoneyObtained2020Text;
    public TMPro.TMP_Text monthSummaryMoneyLoss1990Text;
    public TMPro.TMP_Text monthSummaryMoneyLoss2020Text;
    public TMPro.TMP_Text monthSummaryMoneyRemaining1990Text;
    public TMPro.TMP_Text monthSummaryMoneyRemaining2020Text;
    public TMPro.TMP_Text monthSummaryStatus1990Text;
    public TMPro.TMP_Text monthSummaryStatus2020Text;
    //Summary - Text - Quarter
    public TMPro.TMP_Text quarterSummaryMoneyObtained1990Text;
    public TMPro.TMP_Text quarterSummaryMoneyObtained2020Text;
    public TMPro.TMP_Text quarterSummaryMoneyLoss1990Text;
    public TMPro.TMP_Text quarterSummaryMoneyLoss2020Text;
    public TMPro.TMP_Text quarterSummaryMoneyRemaining1990Text;
    public TMPro.TMP_Text quarterSummaryMoneyRemaining2020Text;
    public TMPro.TMP_Text quarterSummaryStatus1990Text;
    public TMPro.TMP_Text quarterSummaryStatus2020Text;
    //Summary - Text - Final
    public TMPro.TMP_Text finalSummaryMoneyObtained1990Text;
    public TMPro.TMP_Text finalSummaryMoneyObtained2020Text;
    public TMPro.TMP_Text finalSummaryMoneyLoss1990Text;
    public TMPro.TMP_Text finalSummaryMoneyLoss2020Text;
    public TMPro.TMP_Text finalSummaryMoneyRemaining1990Text;
    public TMPro.TMP_Text finalSummaryMoneyRemaining2020Text;
    public TMPro.TMP_Text finalSummaryStatus1990Text;
    public TMPro.TMP_Text finalSummaryStatus2020Text;

    //bools
    public bool electricityComplete = false;
    public bool waterComplete = false;
    public bool communicationsComplete = false;
    public bool entertainmentComplete = false;
    public bool internetComplete = false;

    public double housingPaid1990;
    public double housingPaid2020;

    // Wage Calculations
    public int workDays = 5;
    public int daysMissed = 0;
    public int totalDaysMissed = 0;
    public int daysWorked = 10;
    public int hoursWorked = 8;
    public int hoursMissed = 0;
    public int totalHoursMissed = 0;
    public double hourlyRate1990 = 0.00;
    public double hourlyRate2020 = 0.00;
    public double dailyTips1990 = 0.00;
    public double dailyTips2020 = 0.00;
    public double tipsMade1990 = 0.00;
    public double tipsMade2020 = 0.00;
    public double incomeTaxPaid1990 = 0.00;
    public double incomeTaxPaid2020 = 0.00;
    // Housing Calculations
    public double hotelRate1990 = 0.00;
    public double hotelRate2020 = 0.00;
    public int hotelDays = 0;
    public double hotelStay1990 = 0.00;
    public double hotelStay2020 = 0.00;
    // Transportation Calculations
    public int transportationIncreasePercent = 0;
    public double transportationWoes1990 = 0.00;
    public double transportationWoes2020 = 0.00;
    public double transportationReplacement1990 = 0.00;
    public double transportationReplacement2020= 0.00;
    // General Calculations
    public double generalPercent = 0;
    public double generalPercent1 = 0;
    // Random Event Tracking
    public bool randomEvent01Selected = false;
    public bool randomEvent02Selected = false;
    public bool randomEvent03Selected = false;
    public bool randomEvent04Selected = false;
    public bool randomEvent05Selected = false;
    public bool randomEvent06Selected = false;
    public bool randomEvent07Selected = false;
    public bool randomEvent08Selected = false;
    public bool randomEvent09Selected = false;
    public bool randomEvent10Selected = false;
    public bool randomEvent11Selected = false;
    public bool randomEvent12Selected = false;
    public bool randomEvent13Selected = false;
    public bool randomEvent14Selected = false;
    public bool randomEvent15Selected = false;
    public bool randomEvent16Selected = false;
    public bool randomEvent17Selected = false;
    public bool randomEvent18Selected = false;
    public bool randomEvent19Selected = false;
    public bool randomEvent20Selected = false;
    public bool randomEvent21Selected = false;
    public bool randomEvent22Selected = false;
    public bool randomEvent23Selected = false;
    public bool randomEvent24Selected = false;
    public bool randomEvent25Selected = false;
    public bool randomEvent26Selected = false;
    public bool randomEvent27Selected = false;
    public bool randomEvent28Selected = false;
    public bool randomEvent29Selected = false;
    public bool randomEvent30Selected = false;
    public bool randomEvent31Selected = false;
    public bool randomEvent32Selected = false;
    public bool randomEvent33Selected = false;
    public bool randomEvent34Selected = false;
    public bool randomEvent35Selected = false;
    public bool randomEvent36Selected = false;
    public bool randomEvent37Selected = false;
    public bool randomEvent38Selected = false;
    public bool randomEvent39Selected = false;
    public bool randomEvent40Selected = false;
    public bool randomEvent41Selected = false;
    public bool randomEvent42Selected = false;
    public bool randomEvent43Selected = false;
    public bool randomEvent44Selected = false;
    public bool randomEvent45Selected = false;
    public bool randomEvent46Selected = false;
    public bool randomEvent47Selected = false;
    public bool randomEvent48Selected = false;
    public bool randomEvent49Selected = false;
    public bool randomEvent50Selected = false;
    
    // Current Money Update
    public GameObject currentMoneyUpdateSimulationScreen;
    public TMPro.TMP_Text currentMoneyUpdateSimulation1990Text;
    public TMPro.TMP_Text currentMoneyUpdateSimulation2020Text;
    public GameObject currentMoneyUpdateSummaryScreen;
    public TMPro.TMP_Text currentMoneyUpdateSummary1990Text;
    public TMPro.TMP_Text currentMoneyUpdateSummary2020Text;

    // Utilities Tracker
    public bool electricityPaid = false;
    public bool waterPaid = false;
    public bool communicationsPaid = false;
    public bool entertainmentPaid = false;
    public bool internetPaid = false;
    public TMPro.TMP_Text utilitiesCompleteText;
    public GameObject utilitiesCompleteTextObject;
    public GameObject electricityCloseButton;
    public GameObject waterCloseButton;
    public GameObject communicationsCloseButton;
    public GameObject entertainmentCloseButton;
    public GameObject internetCloseButton;



    // Start is called before the first frame update
    void Start()
    {
        //introductionBackgroundAudioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        //Keeps Main Simulation Page Updated
        MainSimulationStatus();
        currentMoneyUpdateSimulation1990Text.text = "$" + currentMoney1990;
        currentMoneyUpdateSimulation2020Text.text = "$" + currentMoney2020;
        currentMoneyUpdateSummary1990Text.text = "$" + currentMoney1990;
        currentMoneyUpdateSummary2020Text.text = "$" + currentMoney2020;
        
        
        //Allowing to Press Escape Key to Quit Game from Level
        // if (Input.GetKey("escape"))
        // {
        //     Application.Quit();
        // }
    }



    // Random Mode
    public void RandomGenderSelection()
    {
        randomButtonClickAudioSource.Play();

        toGenderScreen.SetActive(false);
        
        genderNow = UnityEngine.Random.Range(1, 3);

        ChooseGender();
    }
    public void RandomRaceSelection()
    {
        randomButtonClickAudioSource.Play();
        
        toRaceScreen.SetActive(false);
        
        raceNow = UnityEngine.Random.Range(1, 6);

        ChooseRace();
    }
    public void RandomEducationSelection()
    {
        randomButtonClickAudioSource.Play();
        
        toEducationScreen.SetActive(false);
        
        educationNow = UnityEngine.Random.Range(1, 6);

        ChooseEducation();
    }
    public void RandomEmploymentSelection()
    {
        randomButtonClickAudioSource.Play();
        
        toJobScreen.SetActive(false);
        
        if (noDegree == true)
        {
            jobNow = UnityEngine.Random.Range(1, 2);
        }
        else if (hsDiploma == true || associatesDegree == true)
        {
            jobNow = UnityEngine.Random.Range(1, 4);
        }
        else if (bachelorsDegree == true)
        {
            jobNow = UnityEngine.Random.Range(1, 6);
        }
        else if (mastersDegree == true)
        {
            jobNow = UnityEngine.Random.Range(1, 8);
        }
        else if (advancedDegree == true)
        {
            jobNow = UnityEngine.Random.Range(1, 10);
        }

        ChooseJob();
    }
    public void RandomHousingSelection()
    {
        randomButtonClickAudioSource.Play();
        
        toHousingScreen.SetActive(false);
        
        houseNow = UnityEngine.Random.Range(1, 6);
        
        ChooseHousing();
    }
    public void RandomUtilitiesSelection()
    {

    }
    public void RandomTransportationSelection()
    {
       randomButtonClickAudioSource.Play(); 
        
        toTransportationScreen.SetActive(false);
        
        travelNow = UnityEngine.Random.Range(1, 6);

        ChooseTransportation();
    }
    
    
    
    //Intriduction Functions
    //Selecting Gender
    public void ChooseGender()
    {
        switch(genderNow)
        {
            case 1:
                genderScreen.SetActive(false);
                maleScreen.SetActive(true);
                femaleScreen.SetActive(false);
                otherGenderScreen.SetActive(false);

                genderSelected = "Male";
                maleGender = true;
                break;
            case 2:
                genderScreen.SetActive(false);
                maleScreen.SetActive(false);
                femaleScreen.SetActive(true);
                otherGenderScreen.SetActive(false);

                genderSelected = "Female";
                femaleGender = true;
                break;
            case 3:
                genderScreen.SetActive(false);
                maleScreen.SetActive(false);
                femaleScreen.SetActive(false);
                otherGenderScreen.SetActive(true);

                genderSelected = "Other Gender";
                otherGender = true;
                break;
        }
    }
    public void ChooseGenderMale()
    {
        forwardButtonClickAudioSource.Play();
        genderNow = 1;
        ChooseGender();
    }
    public void ChooseGenderFemale()
    {
        forwardButtonClickAudioSource.Play();
        genderNow = 2;
        ChooseGender();
    }
    public void ChooseGenderNoGender()
    {
        forwardButtonClickAudioSource.Play();
        genderNow = 3;
        ChooseGender();
    }



    //Selecting Race
    public void ChooseRace()
    {
        switch (raceNow)
        {
            case 1:
                raceScreen.SetActive(false);
                europeanDescentScreen.SetActive(true);
                africanDescentScreen.SetActive(false);
                nativeAmericanDescentScreen.SetActive(false);
                hispanicDescentScreen.SetActive(false);
                asianDescentScreen.SetActive(false);
                otherDescentScreen.SetActive(false);

                raceSelected = "European Descent";
                europeanDescent = true;
                break;
            case 2:
                raceScreen.SetActive(false);
                europeanDescentScreen.SetActive(false);
                africanDescentScreen.SetActive(true);
                nativeAmericanDescentScreen.SetActive(false);
                hispanicDescentScreen.SetActive(false);
                asianDescentScreen.SetActive(false);
                otherDescentScreen.SetActive(false);

                raceSelected = "African Descent";
                africanDescent = true;
                break;
            case 3:
                raceScreen.SetActive(false);
                europeanDescentScreen.SetActive(false);
                africanDescentScreen.SetActive(false);
                nativeAmericanDescentScreen.SetActive(true);
                hispanicDescentScreen.SetActive(false);
                asianDescentScreen.SetActive(false);
                otherDescentScreen.SetActive(false);

                raceSelected = "Native American Descent";
                nativeAmericanDescent = true;
                break;
            case 4:
                raceScreen.SetActive(false);
                europeanDescentScreen.SetActive(false);
                africanDescentScreen.SetActive(false);
                nativeAmericanDescentScreen.SetActive(false);
                hispanicDescentScreen.SetActive(true);
                asianDescentScreen.SetActive(false);
                otherDescentScreen.SetActive(false);

                raceSelected = "Hispanic Descent";
                hispanicDescent = true;
                break;
            case 5:
                raceScreen.SetActive(false);
                europeanDescentScreen.SetActive(false);
                africanDescentScreen.SetActive(false);
                nativeAmericanDescentScreen.SetActive(false);
                hispanicDescentScreen.SetActive(false);
                asianDescentScreen.SetActive(true);
                otherDescentScreen.SetActive(false);

                raceSelected = "Asian Descent";
                asianDescent = true;
                break;
            case 6:
                raceScreen.SetActive(false);
                europeanDescentScreen.SetActive(false);
                africanDescentScreen.SetActive(false);
                nativeAmericanDescentScreen.SetActive(false);
                hispanicDescentScreen.SetActive(false);
                asianDescentScreen.SetActive(false);
                otherDescentScreen.SetActive(true);

                raceSelected = "Other Descent";
                otherDescent = true;
                break;
        }
    }
    public void ChooseRaceEuropeanDescent()
    {
        forwardButtonClickAudioSource.Play();
        raceNow = 1;
        ChooseRace();
    }
    public void ChooseRaceAfricanDescent()
    {
        forwardButtonClickAudioSource.Play();
        raceNow = 2;
        ChooseRace();
    }
    public void ChooseRaceNativeAmericanDescent()
    {
        forwardButtonClickAudioSource.Play();
        raceNow = 3;
        ChooseRace();
    }
    public void ChooseRaceHispanicDescent()
    {
        forwardButtonClickAudioSource.Play();
        raceNow = 4;
        ChooseRace();
    }
    public void ChooseRaceAsianDescent()
    {
        forwardButtonClickAudioSource.Play();
        raceNow = 5;
        ChooseRace();
    }
    public void ChooseRaceOtherDescent()
    {
        forwardButtonClickAudioSource.Play();
        raceNow = 6;
        ChooseRace();
    }



    //Selecting Education
    public void ChooseEducation()
    {
        if (educationNow == 1)
        {
            //Changes Panel View
            educationScreen.SetActive(false);
            educationScreenNoDegree.SetActive(true);
            educationScreenHSDiploma.SetActive(false);
            educationScreenAssociatesDegree.SetActive(false);
            educationScreenBachelorsDegree.SetActive(false);
            educationScreenMastersDegree.SetActive(false);
            educationScreenAdvancedDegree.SetActive(false);

            educationSelected = "No Degree";
            noDegree = true;

            //Sets Available Jobs
            waiterButton.SetActive(true);
            cashierButton.SetActive(true);
            fryCookButton.SetActive(false);
            customerServiceAgentButton.SetActive(false);
            teacherButton.SetActive(false);
            licensedSalesAgentButton.SetActive(false);
            programmerButton.SetActive(false);
            engineerButton.SetActive(false);
            lawyerButton.SetActive(false);
            doctorButton.SetActive(false);
        }
        else if (educationNow == 2)
        {
            //Changes Panel View
            educationScreen.SetActive(false);
            educationScreenNoDegree.SetActive(false);
            educationScreenHSDiploma.SetActive(true);
            educationScreenAssociatesDegree.SetActive(false);
            educationScreenBachelorsDegree.SetActive(false);
            educationScreenMastersDegree.SetActive(false);
            educationScreenAdvancedDegree.SetActive(false);

            educationSelected = "High School Diploma";
            hsDiploma = true;

            //Sets Available Jobs
            waiterButton.SetActive(true);
            cashierButton.SetActive(true);
            fryCookButton.SetActive(true);
            customerServiceAgentButton.SetActive(true);
            teacherButton.SetActive(false);
            licensedSalesAgentButton.SetActive(false);
            programmerButton.SetActive(false);
            engineerButton.SetActive(false);
            doctorButton.SetActive(false);
            lawyerButton.SetActive(false);
        }
        else if (educationNow == 3)
        {
            //Changes Panel View
            educationScreen.SetActive(false);
            educationScreenNoDegree.SetActive(false);
            educationScreenHSDiploma.SetActive(false);
            educationScreenAssociatesDegree.SetActive(true);
            educationScreenBachelorsDegree.SetActive(false);
            educationScreenMastersDegree.SetActive(false);
            educationScreenAdvancedDegree.SetActive(false);

            educationSelected = "Associates Degree";
            associatesDegree = true;

            //Sets Available Jobs
            waiterButton.SetActive(true);
            cashierButton.SetActive(true);
            fryCookButton.SetActive(true);
            customerServiceAgentButton.SetActive(true);
            teacherButton.SetActive(false);
            licensedSalesAgentButton.SetActive(false);
            programmerButton.SetActive(false);
            engineerButton.SetActive(false);
            lawyerButton.SetActive(false);
            doctorButton.SetActive(false);
        }
        else if (educationNow == 4)
        {
            //Changes Panel View
            educationScreen.SetActive(false);
            educationScreenNoDegree.SetActive(false);
            educationScreenHSDiploma.SetActive(false);
            educationScreenAssociatesDegree.SetActive(false);
            educationScreenBachelorsDegree.SetActive(true);
            educationScreenMastersDegree.SetActive(false);
            educationScreenAdvancedDegree.SetActive(false);

            educationSelected = "Bachelor's Degree";
            bachelorsDegree = true;

            //Sets Available Jobs
            waiterButton.SetActive(true);
            cashierButton.SetActive(true);
            fryCookButton.SetActive(true);
            customerServiceAgentButton.SetActive(true);
            teacherButton.SetActive(true);
            licensedSalesAgentButton.SetActive(true);
            programmerButton.SetActive(false);
            engineerButton.SetActive(false);
            lawyerButton.SetActive(false);
            doctorButton.SetActive(false);
        }
        else if (educationNow == 5)
        {
            //Changes Panel View
            educationScreen.SetActive(false);
            educationScreenNoDegree.SetActive(false);
            educationScreenHSDiploma.SetActive(false);
            educationScreenAssociatesDegree.SetActive(false);
            educationScreenBachelorsDegree.SetActive(false);
            educationScreenMastersDegree.SetActive(true);
            educationScreenAdvancedDegree.SetActive(false);

            educationSelected = "Master's Degreee";
            mastersDegree = true;

            //Sets Available Jobs
            waiterButton.SetActive(true);
            cashierButton.SetActive(true);
            fryCookButton.SetActive(true);
            customerServiceAgentButton.SetActive(true);
            teacherButton.SetActive(true);
            licensedSalesAgentButton.SetActive(true);
            programmerButton.SetActive(true);
            engineerButton.SetActive(true);
            lawyerButton.SetActive(false);
            doctorButton.SetActive(false);
        }
        else if (educationNow == 6)
        {
            //Changes Panel View
            educationScreen.SetActive(false);
            educationScreenNoDegree.SetActive(false);
            educationScreenHSDiploma.SetActive(false);
            educationScreenAssociatesDegree.SetActive(false);
            educationScreenBachelorsDegree.SetActive(false);
            educationScreenMastersDegree.SetActive(false);
            educationScreenAdvancedDegree.SetActive(true);

            educationSelected = "Advanced Degree";
            advancedDegree =  true;

            //Sets Available Jobs
            waiterButton.SetActive(true);
            cashierButton.SetActive(true);
            fryCookButton.SetActive(true);
            customerServiceAgentButton.SetActive(true);
            teacherButton.SetActive(true);
            licensedSalesAgentButton.SetActive(true);
            programmerButton.SetActive(true);
            engineerButton.SetActive(true);
            lawyerButton.SetActive(true);
            doctorButton.SetActive(true);
        }
    }
    public void ChooseEducationNoDegree()
    {
        forwardButtonClickAudioSource.Play();
        educationNow = 1;
        ChooseEducation();
    }
    public void ChooseEducationHighSchoolDiploma()
    {
        forwardButtonClickAudioSource.Play();
        educationNow = 2;
        ChooseEducation();
    }
    public void ChooseEducationAssociatesDegree()
    {
        forwardButtonClickAudioSource.Play();
        educationNow = 3;
        ChooseEducation();
    }
    public void ChooseEducationBachelorsDegree()
    {
        forwardButtonClickAudioSource.Play();
        educationNow =  4;
        ChooseEducation();
    }
    public void ChooseEducationMastersDegree()
    {
        forwardButtonClickAudioSource.Play();
        educationNow = 5;
        ChooseEducation();
    }
    public void ChooseEducationAdvancedDegree()
    {
        forwardButtonClickAudioSource.Play();
        educationNow = 6;
        ChooseEducation();
    }



    //Selecting Employment
    public void ChooseJob()
    {
        if (jobNow == 1)
        {
            //Changes Panel View
            jobScreen.SetActive(false);
            waiterScreen.SetActive(true);
            cashierScreen.SetActive(false);
            fryCookScreen.SetActive(false);
            customerServiceAgentScreen.SetActive(false);
            teacherScreen.SetActive(false);
            licensedSalesAgentScreen.SetActive(false);
            programmerScreen.SetActive(false);
            engineerScreen.SetActive(false);
            lawyerScreen.SetActive(false);
            doctorScreen.SetActive(false);

            jobSelected = "Waiter";
            waiter = true;

            //Setting Pay
            switch (educationNow)
            {
                case 1:
                    //biweeklySalary1990 = 240; // 3 (3 x 80 = 240)
                    //biweeklySalary2020 = 480; // 6 (6 x 80 = 480)
                    hourlyRate1990 = 1.50F;
                    hourlyRate2020 = 3.00F;
                    break;
                case 2:
                    //biweeklySalary1990 = 280; // 3.50 (3.50 x 80 = 280)
                    //biweeklySalary2020 = 580; // 7.25 (7.25 x 80 = 580)
                    hourlyRate1990 = 1.75F;
                    hourlyRate2020 = 3.75F;
                    break;
                case 3:
                    //biweeklySalary1990 = 300; // 3.75 (3.75 x 80 = 300)
                    //biweeklySalary2020 = 620; // 7.75 (7.75 x 80 = 620)
                    hourlyRate1990 = 2.00F;
                    hourlyRate2020 = 4.00F;
                    break;
                case 4:
                    //biweeklySalary1990 = 320; // 4 (4 x 80 hr = 320)
                    //biweeklySalary2020 = 684.80; // 8.56 (8.56 x 80 = hr)
                    hourlyRate1990 = 2.00F;
                    hourlyRate2020 = 4.25F;
                    break;
                case 5:
                    //biweeklySalary1990 = 360; // 4.50 (4.50 x 80 = 360)
                    //biweeklySalary2020 = 740; // 9.25 (9.25 x 80 = 740)
                    hourlyRate1990 = 2.25F;
                    hourlyRate2020 = 5.75F;
                    break;
                case 6:
                    //biweeklySalary1990 = 400; // 5 (5 x 80 = 400)
                    //biweeklySalary2020 = 800; // 10 (10 x 80 = 800)
                    hourlyRate1990 = 2.50F;
                    hourlyRate2020 = 5.00F;
                    break;
            }

            hourlyRate1990 = Math.Round(hourlyRate1990, 2);
            hourlyRate2020 = Math.Round(hourlyRate2020, 2);

            jobPayWaiter1990Text.text = "1990: Hourly Pay: $" + hourlyRate1990 + "/hour!";
            jobPayWaiter2020Text.text = "2020: Hourly Pay: $" + hourlyRate2020 + "/hour!";

            //Sets Available Housing
            livingWithParentsButton.SetActive(true);
            livingWithRoommatesButton.SetActive(true);
            basicApartmentButton.SetActive(true);
            luxuryApartmentButton.SetActive(false);
            basicHouseButton.SetActive(false);
            luxuryHouseButton.SetActive(false);
        }
        else if (jobNow == 2)
        {
            //Changes Panel View
            jobScreen.SetActive(false);
            waiterScreen.SetActive(false);
            cashierScreen.SetActive(true);
            fryCookScreen.SetActive(false);
            customerServiceAgentScreen.SetActive(false);
            teacherScreen.SetActive(false);
            licensedSalesAgentScreen.SetActive(false);
            programmerScreen.SetActive(false);
            engineerScreen.SetActive(false);
            lawyerScreen.SetActive(false);
            doctorScreen.SetActive(false);

            jobSelected = "Cashier";
            cashier = true;

            //Setting Pay
            switch (educationNow)
            {
                case 1:
                    //biweeklySalary1990 = 320; //4
                    //biweeklySalary2020 = 684.80; //8.56
                    hourlyRate1990 = 4.00F;
                    hourlyRate2020 = 8.50F;
                    break;
                case 2:
                    //biweeklySalary1990 = 360; //4.50
                    //biweeklySalary2020 = 720; //9
                    hourlyRate1990 = 4.50F;
                    hourlyRate2020 = 9.00F;
                    break;
                case 3:
                    //biweeklySalary1990 = 380; // 4.75
                    //biweeklySalary2020 = 740; // 9.25
                    hourlyRate1990 = 4.75F;
                    hourlyRate2020 = 9.25F;
                    break;
                case 4:
                    //biweeklySalary1990 = 400; //5
                    //biweeklySalary2020 = 760; //9.50
                    hourlyRate1990 = 5.00F;
                    hourlyRate2020 = 9.50F;
                    break;
                case 5:
                    //biweeklySalary1990 = 440; //5.50
                    //biweeklySalary2020 = 800; //10
                    hourlyRate1990 = 5.50F;
                    hourlyRate2020 = 10.00F;
                    break;
                case 6:
                    //biweeklySalary1990 = 480; //6
                    //biweeklySalary2020 = 840; //10.50
                    hourlyRate1990 = 6.00F;
                    hourlyRate2020 = 10.50F;
                    break;
            }

            hourlyRate1990 = Math.Round(hourlyRate1990, 2);
            hourlyRate2020 = Math.Round(hourlyRate2020, 2);

            jobPayCashier1990Text.text = "1990: Hourly Pay: $" + hourlyRate1990 + "/hour!";
            jobPayCashier2020Text.text = "2020: Hourly Pay: $" + hourlyRate2020 + "/hour!";

            //Sets Available Housing
            livingWithParentsButton.SetActive(true);
            livingWithRoommatesButton.SetActive(true);
            basicApartmentButton.SetActive(true);
            luxuryApartmentButton.SetActive(false);
            basicHouseButton.SetActive(false);
            luxuryHouseButton.SetActive(false);
        }
        else if (jobNow == 3)
        {
            //Changes Panel View
            jobScreen.SetActive(false);
            waiterScreen.SetActive(false);
            cashierScreen.SetActive(false);
            fryCookScreen.SetActive(true);
            customerServiceAgentScreen.SetActive(false);
            teacherScreen.SetActive(false);
            licensedSalesAgentScreen.SetActive(false);
            programmerScreen.SetActive(false);
            engineerScreen.SetActive(false);
            lawyerScreen.SetActive(false);
            doctorScreen.SetActive(false);

            jobSelected = "Fry Cook";
            fryCook = true;

            //Setting Pay
            switch (educationNow)
            {
                case 1:
                    //biweeklySalary1990 = 320; // 4
                    //biweeklySalary2020 = 684.80; // 8.56
                    hourlyRate1990 = 4.00F;
                    hourlyRate2020 = 8.50F;
                    break;
                case 2:
                    //biweeklySalary1990 = 400; // 5
                    //biweeklySalary2020 = 760; // 9.50
                    hourlyRate1990 = 5.00F;
                    hourlyRate2020 = 9.50F;
                    break;
                case 3:
                    //biweeklySalary1990 = 440; // 5.50
                    //biweeklySalary2020 = 800; // 10
                    hourlyRate1990 = 5.50F;
                    hourlyRate2020 = 10.00F;
                    break;
                case 4:
                    //biweeklySalary1990 = 480; // 6
                    //biweeklySalary2020 = 840; // 10.50
                    hourlyRate1990 = 6.00F;
                    hourlyRate2020 = 10.50F;
                    break;
                case 5:
                    //biweeklySalary1990 = 560; // 7
                    //biweeklySalary2020 = 920; // 11.50
                    hourlyRate1990 = 7.00F;
                    hourlyRate2020 = 11.50F;
                    break;
                case 6:
                    //biweeklySalary1990 = 640; // 8
                    //biweeklySalary2020 = 1000; // 12.50
                    hourlyRate1990 = 8.00F;
                    hourlyRate2020 = 12.50F;
                    break;
            }

            hourlyRate1990 = Math.Round(hourlyRate1990, 2);
            hourlyRate2020 = Math.Round(hourlyRate2020, 2);

            jobPayFryCook1990Text.text = "1990: Hourly Pay: $" + hourlyRate1990 + "/hour!";
            jobPayFryCook2020Text.text = "2020: Hourly Pay: $" + hourlyRate2020 + "/hour!";

            //Sets Available Housing
            livingWithParentsButton.SetActive(true);
            livingWithRoommatesButton.SetActive(true);
            basicApartmentButton.SetActive(true);
            luxuryApartmentButton.SetActive(false);
            basicHouseButton.SetActive(false);
            luxuryHouseButton.SetActive(false);
        }
        else if (jobNow == 4)
        {
            //Changes Panel View
            jobScreen.SetActive(false);
            waiterScreen.SetActive(false);
            cashierScreen.SetActive(false);
            fryCookScreen.SetActive(false);
            customerServiceAgentScreen.SetActive(true);
            teacherScreen.SetActive(false);
            licensedSalesAgentScreen.SetActive(false);
            programmerScreen.SetActive(false);
            engineerScreen.SetActive(false);
            lawyerScreen.SetActive(false);
            doctorScreen.SetActive(false);

            jobSelected = "Customer Service Agent";
            customerServiceAgent = true;

            //Setting Pay
            switch (educationNow)
            {
                case 1:
                    //biweeklySalary1990 = 320; // 4
                    //biweeklySalary2020 = 684.80; // 8.56
                    hourlyRate1990 = 4.00F;
                    hourlyRate2020 = 8.50F;
                    break;
                case 2:
                    //biweeklySalary1990 = 420; // 5.25
                    //biweeklySalary2020 = 780; // 9.75
                    hourlyRate1990 = 5.25F;
                    hourlyRate2020 = 9.75F;
                    break;
                case 3:
                    //biweeklySalary1990 = 460; // 5.75
                    //biweeklySalary2020 =  820; // 10.25
                    hourlyRate1990 = 5.75F;
                    hourlyRate2020 = 10.25F;
                    break;
                case 4:
                    //biweeklySalary1990 = 520; // 6.50
                    //biweeklySalary2020 = 880; // 11
                    hourlyRate1990 = 6.50F;
                    hourlyRate2020 = 11.00F;
                    break;
                case 5:
                    //biweeklySalary1990 = 620; // 7.75
                    //biweeklySalary2020 = 980; // 12.25
                    hourlyRate1990 = 7.75F;
                    hourlyRate2020 = 12.25F;
                    break;
                case 6:
                    //biweeklySalary1990 = 720; // 9
                    //biweeklySalary2020 = 1080; // 13.50
                    hourlyRate1990 = 9.00F;
                    hourlyRate2020 = 13.50F;
                    break;
            }

            hourlyRate1990 = Math.Round(hourlyRate1990, 2);
            hourlyRate2020 = Math.Round(hourlyRate2020, 2);

            jobPayCSA1990Text.text = "1990: Hourly Pay: $" + hourlyRate1990 + "/hour!";
            jobPayCSA2020Text.text = "2020: Hourly Pay: $" + hourlyRate2020 + "/hour!";

            //Sets Available Housing
            livingWithParentsButton.SetActive(true);
            livingWithRoommatesButton.SetActive(true);
            basicApartmentButton.SetActive(true);
            luxuryApartmentButton.SetActive(false);
            basicHouseButton.SetActive(true);
            luxuryHouseButton.SetActive(false);
        }
        else if (jobNow == 5)
        {
            //Changes Panel View
            jobScreen.SetActive(false);
            waiterScreen.SetActive(false);
            cashierScreen.SetActive(false);
            fryCookScreen.SetActive(false);
            customerServiceAgentScreen.SetActive(false);
            teacherScreen.SetActive(true);
            licensedSalesAgentScreen.SetActive(false);
            programmerScreen.SetActive(false);
            engineerScreen.SetActive(false);
            lawyerScreen.SetActive(false);
            doctorScreen.SetActive(false);

            jobSelected = "Teacher";
            teacher = true;

            //Setting Pay
            switch (educationNow)
            {
                case 1:
                    //biweeklySalary1990 = 0;
                    //biweeklySalary2020 = 0;
                    hourlyRate1990 = 0.00F;
                    hourlyRate2020 = 0.00F;
                    break;
                case 2:
                    //biweeklySalary1990 = 0;
                    //biweeklySalary2020 = 0;
                    hourlyRate1990 = 0.00F;
                    hourlyRate2020 = 0.00F;
                    break;
                case 3: 
                    //biweeklySalary1990 = 0;
                    //biweeklySalary2020 = 0;
                    hourlyRate1990 = 0.00F;
                    hourlyRate2020 = 0.00F;
                    break;
                case 4:
                    //biweeklySalary1990 = 800; // 10
                    //biweeklySalary2020 = 1200; // 15
                    hourlyRate1990 = 10.00F;
                    hourlyRate2020 = 15.00F;
                    break;
                case 5:
                    //biweeklySalary1990 = 960; // 12
                    //biweeklySalary2020 = 1600; // 20
                    hourlyRate1990 = 12.00F;
                    hourlyRate2020 = 20.00F;
                    break;
                case 6:
                    //biweeklySalary1990 = 1200; // 15
                    //biweeklySalary2020 = 2000; // 25
                    hourlyRate1990 = 15.00F;
                    hourlyRate2020 = 25.00F;
                    break;
            }

            hourlyRate1990 = Math.Round(hourlyRate1990, 2);
            hourlyRate2020 = Math.Round(hourlyRate2020, 2);

            jobPayTeacher1990Text.text = "1990: Hourly Pay: $" + hourlyRate1990 + "/hour!";
            jobPayTeacher2020Text.text = "2020: Hourly Pay: $" + hourlyRate2020 + "/hour!";

            //Sets Available Housing
            livingWithParentsButton.SetActive(true);
            livingWithRoommatesButton.SetActive(true);
            basicApartmentButton.SetActive(true);
            luxuryApartmentButton.SetActive(true);
            basicHouseButton.SetActive(true);
            luxuryHouseButton.SetActive(true);
        }
        else if (jobNow == 6)
        {
            //Changes Panel View
            jobScreen.SetActive(false);
            waiterScreen.SetActive(false);
            cashierScreen.SetActive(false);
            fryCookScreen.SetActive(false);
            customerServiceAgentScreen.SetActive(false);
            teacherScreen.SetActive(false);
            licensedSalesAgentScreen.SetActive(true);
            programmerScreen.SetActive(false);
            engineerScreen.SetActive(false);
            lawyerScreen.SetActive(false);
            doctorScreen.SetActive(false);

            jobSelected = "Licensed Sales Agent";
            licensedSalesAgent = true;

            //Setting Pay
            switch (educationNow)
            {
                case 1:
                    //biweeklySalary1990 = 0;
                    //biweeklySalary2020 = 0;
                    hourlyRate1990 = 0.00F;
                    hourlyRate2020 = 0.00F;
                    break;
                case 2:
                    //biweeklySalary1990 = 800; // 10
                    //biweeklySalary2020 = 1200; // 15
                    hourlyRate1990 = 10.00F;
                    hourlyRate2020 = 15.00F;
                    break;
                case 3:
                    //biweeklySalary1990 = 880; // 11
                    //biweeklySalary2020 = 1300; // 16.25
                    hourlyRate1990 = 11.00F;
                    hourlyRate2020 = 16.25F;
                    break;
                case 4:
                    //biweeklySalary1990 = 1000; // 12.50
                    //biweeklySalary2020 = 1440; // 18
                    hourlyRate1990 = 12.50F;
                    hourlyRate2020 = 18.00F;
                    break;
                case 5:
                    //biweeklySalary1990 = 1200; // 15
                    //biweeklySalary2020 = 1680; // 21
                    hourlyRate1990 = 15.00F;
                    hourlyRate2020 = 21.00F;
                    break;
                case 6:
                    //biweeklySalary1990 = 1400; // 17.50
                    //biweeklySalary2020 = 1920; // 24
                    hourlyRate1990 = 17.50F;
                    hourlyRate2020 = 24.00F;
                    break;
            }

            hourlyRate1990 = Math.Round(hourlyRate1990, 2);
            hourlyRate2020 = Math.Round(hourlyRate2020, 2);

            jobPayLSA1990Text.text = "1990: Hourly Pay: $" + hourlyRate1990 + "/hour!";
            jobPayLSA2020Text.text = "2020: Hourly Pay: $" + hourlyRate2020 + "/hour!";

            //Sets Available Housing
            livingWithParentsButton.SetActive(true);
            livingWithRoommatesButton.SetActive(true);
            basicApartmentButton.SetActive(true);
            luxuryApartmentButton.SetActive(true);
            basicHouseButton.SetActive(true);
            luxuryHouseButton.SetActive(true);
        }
        else if (jobNow == 7)
        {
            //Changes Panel View
            jobScreen.SetActive(false);
            waiterScreen.SetActive(false);
            cashierScreen.SetActive(false);
            fryCookScreen.SetActive(false);
            customerServiceAgentScreen.SetActive(false);
            teacherScreen.SetActive(false);
            licensedSalesAgentScreen.SetActive(false);
            programmerScreen.SetActive(true);
            engineerScreen.SetActive(false);
            lawyerScreen.SetActive(false);
            doctorScreen.SetActive(false);

            jobSelected = "Programmer";
            programmer = true;

            //Setting Pay
            switch (educationNow)
            {
                case 1:
                    //biweeklySalary1990 = 0;
                    //biweeklySalary2020 = 0;
                    hourlyRate1990 = 0.00F;
                    hourlyRate2020 = 0.00F;
                    break;
                case 2:
                    //biweeklySalary1990 = 960; // 12
                    //biweeklySalary2020 = 1200; // 15
                    hourlyRate1990 = 12.00F;
                    hourlyRate2020 = 15.00F;
                    break;
                case 3:
                    //biweeklySalary1990 = 1040; // 13
                    //biweeklySalary2020 = 1320; // 16.50
                    hourlyRate1990 = 13.00F;
                    hourlyRate2020 = 16.50F;
                    break;
                case 4:
                    //biweeklySalary1990 = 1200; // 15
                    //biweeklySalary2020 = 1600; // 20
                    hourlyRate1990 = 15.00F;
                    hourlyRate2020 = 20.00F;
                    break;
                case 5:
                    //biweeklySalary1990 = 1440; // 18
                    //biweeklySalary2020 = 2000; // 25
                    hourlyRate1990 = 18.00F;
                    hourlyRate2020 = 25.00F;
                    break;
                case 6:
                    //biweeklySalary1990 = 1680; // 21
                    //biweeklySalary2020 = 2400; // 30
                    hourlyRate1990 = 21.00F;
                    hourlyRate2020 = 30.00F;
                    break;
            }

            hourlyRate1990 = Math.Round(hourlyRate1990, 2);
            hourlyRate2020 = Math.Round(hourlyRate2020, 2);

            jobPayProgrammer1990Text.text = "1990: Hourly Pay: $" + hourlyRate1990 + "/hour!";
            jobPayProgrammer2020Text.text = "2020: Hourly Pay: $" + hourlyRate2020 + "/hour!";

            //Sets Available Housing
            livingWithParentsButton.SetActive(true);
            livingWithRoommatesButton.SetActive(true);
            basicApartmentButton.SetActive(true);
            luxuryApartmentButton.SetActive(true);
            basicHouseButton.SetActive(true);
            luxuryHouseButton.SetActive(true);
        }
        else if (jobNow == 8)
        {
            //Changes Panel View
            jobScreen.SetActive(false);
            waiterScreen.SetActive(false);
            cashierScreen.SetActive(false);
            fryCookScreen.SetActive(false);
            customerServiceAgentScreen.SetActive(false);
            teacherScreen.SetActive(false);
            licensedSalesAgentScreen.SetActive(false);
            programmerScreen.SetActive(false);
            engineerScreen.SetActive(true);
            lawyerScreen.SetActive(false);
            doctorScreen.SetActive(false);

            jobSelected = "Engineer";
            engineer = true;

            //Setting Pay
            switch (educationNow)
            {
                case 1:
                    //biweeklySalary1990 = 0;
                    //biweeklySalary2020 = 0;
                    hourlyRate1990 = 0.00F;
                    hourlyRate2020 = 0.00F;
                    break;
                case 2:
                    //biweeklySalary1990 = 0;
                    //biweeklySalary2020 = 0;
                    hourlyRate1990 = 0.00F;
                    hourlyRate2020 = 0.00F;
                    break;
                case 3:
                    //biweeklySalary1990 = 0;
                    //biweeklySalary2020 = 0;
                    hourlyRate1990 = 0.00F;
                    hourlyRate2020 = 0.00F;
                    break;
                case 4:
                    //biweeklySalary1990 = 0;
                    //biweeklySalary2020 = 0;
                    hourlyRate1990 = 0.00F;
                    hourlyRate2020 = 0.00F;
                    break;
                case 5:
                    //biweeklySalary1990 = 0;
                    //biweeklySalary2020 = 0;
                    hourlyRate1990 = 23.00F;
                    hourlyRate2020 = 30.00F;
                    break;
                case 6:
                    //biweeklySalary1990 = 2000; // 25
                    //biweeklySalary2020 = 2800; // 35
                    hourlyRate1990 = 25.00F;
                    hourlyRate2020 = 35.00F;
                    break;
            }

            hourlyRate1990 = Math.Round(hourlyRate1990, 2);
            hourlyRate2020 = Math.Round(hourlyRate2020, 2);

            jobPayEngineer1990Text.text = "1990: Hourly Pay: $" + hourlyRate1990 + "/hour!";
            jobPayEngineer2020Text.text = "2020: Hourly Pay: $" + hourlyRate2020 + "/hour!";

            //Sets Available Housing
            livingWithParentsButton.SetActive(true);
            livingWithRoommatesButton.SetActive(true);
            basicApartmentButton.SetActive(true);
            luxuryApartmentButton.SetActive(true);
            basicHouseButton.SetActive(true);
            luxuryHouseButton.SetActive(true);
        }
        else if (jobNow == 9)
        {
            //Changes Panel View
            jobScreen.SetActive(false);
            waiterScreen.SetActive(false);
            cashierScreen.SetActive(false);
            fryCookScreen.SetActive(false);
            customerServiceAgentScreen.SetActive(false);
            teacherScreen.SetActive(false);
            licensedSalesAgentScreen.SetActive(false);
            programmerScreen.SetActive(false);
            engineerScreen.SetActive(false);
            lawyerScreen.SetActive(true);
            doctorScreen.SetActive(false);

            jobSelected = "Lawyer";
            lawyer = true;

            //Setting Pay
            switch (educationNow)
            {
                case 1:
                    //biweeklySalary1990 = 0;
                    //biweeklySalary2020 = 0;
                    hourlyRate1990 = 0.00F;
                    hourlyRate2020 = 0.00F;
                    break;
                case 2:
                    //biweeklySalary1990 = 0;
                    //biweeklySalary2020 = 0;
                    hourlyRate1990 = 0.00F;
                    hourlyRate2020 = 0.00F;
                    break;
                case 3:
                    //biweeklySalary1990 = 0;
                    //biweeklySalary2020 = 0;
                    hourlyRate1990 = 0.00F;
                    hourlyRate2020 = 0.00F;
                    break;
                case 4:
                    //biweeklySalary1990 = 0;
                    //biweeklySalary2020 = 0;
                    hourlyRate1990 = 0.00F;
                    hourlyRate2020 = 0.00F;
                    break;
                case 5:
                    //biweeklySalary1990 = 0;
                    //biweeklySalary2020 = 0;
                    hourlyRate1990 = 0.00F;
                    hourlyRate2020 = 0.00F;
                    break;
                case 6:
                    //biweeklySalary1990 = 2200; // 27.50
                    //biweeklySalary2020 = 3000; // 37.50
                    hourlyRate1990 = 27.50F;
                    hourlyRate2020 = 37.50F;
                    break;
            }

            hourlyRate1990 = Math.Round(hourlyRate1990, 2);
            hourlyRate2020 = Math.Round(hourlyRate2020, 2);

            jobPayLawyer1990Text.text = "1990: Bi-Weekly Pay: $" + hourlyRate1990 + "/hour!";
            jobPayLawyer2020Text.text = "2020: Bi-Weekly Pay: $" + hourlyRate2020 + "/hour!";

            //Sets Available Housing
            livingWithParentsButton.SetActive(true);
            livingWithRoommatesButton.SetActive(true);
            basicApartmentButton.SetActive(true);
            luxuryApartmentButton.SetActive(true);
            basicHouseButton.SetActive(true);
            luxuryHouseButton.SetActive(true);
        }
        else if (jobNow == 10)
        {
            //Changes Panel View
            jobScreen.SetActive(false);
            waiterScreen.SetActive(false);
            cashierScreen.SetActive(false);
            fryCookScreen.SetActive(false);
            customerServiceAgentScreen.SetActive(false);
            teacherScreen.SetActive(false);
            licensedSalesAgentScreen.SetActive(false);
            programmerScreen.SetActive(false);
            engineerScreen.SetActive(false);
            lawyerScreen.SetActive(false);
            doctorScreen.SetActive(true);

            jobSelected = "Doctor";
            doctor = true;

            //Setting Pay
            switch (educationNow)
            {
                case 1:
                    //biweeklySalary1990 = 0;
                    //biweeklySalary2020 = 0;
                    hourlyRate1990 = 0.00F;
                    hourlyRate2020 = 0.00F;
                    break;
                case 2:
                    //biweeklySalary1990 = 0;
                    //biweeklySalary2020 = 0;
                    hourlyRate1990 = 0.00F;
                    hourlyRate2020 = 0.00F;
                    break;
                case 3:
                    //biweeklySalary1990 = 0;
                    //biweeklySalary2020 = 0;
                    hourlyRate1990 = 0.00F;
                    hourlyRate2020 = 0.00F;
                    break;
                case 4:
                    //biweeklySalary1990 = 0;
                    //biweeklySalary2020 = 0;
                    hourlyRate1990 = 0.00F;
                    hourlyRate2020 = 0.00F;
                    break;
                case 5:
                    //biweeklySalary1990 = 0;
                    //biweeklySalary2020 = 0;
                    hourlyRate1990 = 0.00F;
                    hourlyRate2020 = 0.00F;
                    break;
                case 6:
                    //biweeklySalary1990 = 2800; // 35
                    //biweeklySalary2020 = 4000; // 50
                    hourlyRate1990 = 35.00F;
                    hourlyRate2020 = 50.00F;
                    break;
            }

            hourlyRate1990 = Math.Round(hourlyRate1990, 2);
            hourlyRate2020 = Math.Round(hourlyRate2020, 2);

            jobPayDoctor1990Text.text = "1990: Hourly Pay: $" + hourlyRate1990 + "/hour!";
            jobPayDoctor2020Text.text = "2020: Hourly Pay: $" + hourlyRate2020 + "/hour!";

            //Sets Available Housing
            livingWithParentsButton.SetActive(true);
            livingWithRoommatesButton.SetActive(true);
            basicApartmentButton.SetActive(true);
            luxuryApartmentButton.SetActive(true);
            basicHouseButton.SetActive(true);
            luxuryHouseButton.SetActive(true);
        }
    }
    public void ChooseJobWaiter()
    {
        forwardButtonClickAudioSource.Play();
        jobNow = 1;
        ChooseJob();
    }
    public void ChooseJobCashier()
    {
        forwardButtonClickAudioSource.Play();
        jobNow = 2;
        ChooseJob();
    }

    public void ChooseJobFryCook()
    {
        forwardButtonClickAudioSource.Play();
        jobNow = 3;
        ChooseJob();
    }
    public void ChooseJobCustomerServiceAgent()
    {
        forwardButtonClickAudioSource.Play();
        jobNow = 4;
        ChooseJob();
    }
    public void ChooseJobTeacher()
    {
        forwardButtonClickAudioSource.Play();
        jobNow = 5;
        ChooseJob();
    }
    public void ChooseJobLicensedSalesAgent()
    {
        forwardButtonClickAudioSource.Play();
        jobNow = 6;
        ChooseJob();
    }
    public void ChooseJobProgrammer()
    {
        forwardButtonClickAudioSource.Play();
        jobNow = 7;
        ChooseJob();
    }
    public void ChooseJobEngineer()
    {
        forwardButtonClickAudioSource.Play();
        jobNow = 8;
        ChooseJob();
    }
    public void ChooseJobLawyer()
    {
        forwardButtonClickAudioSource.Play();
        jobNow = 9;
        ChooseJob();
    }
    public void ChooseJobDoctor()
    {
        forwardButtonClickAudioSource.Play();
        jobNow = 10;
        ChooseJob();
    }



    //Selecting Housing
    public void ChooseHousing()
    {
        switch (houseNow)
        {
            case 1:
                //Changing Panel View
                housingScreen.SetActive(false);
                livingWithParentsScreen.SetActive(true);
                livingWithRoommatesScreen.SetActive(false);
                basicApartmentScreen.SetActive(false);
                luxuryApartmentScreen.SetActive(false);
                basicHouseScreen.SetActive(false);
                luxuryHouseScreen.SetActive(false);

                housingSelected = "Living With Parents";
                livingWithParents = true;
                
                rentCost1990 = UnityEngine.Random.Range(0.00F, 300.00F);
                rentCost2020 = UnityEngine.Random.Range(0.00F, 500.00F);

                rentCost1990 = Math.Round(rentCost1990, 2);
                rentCost2020 = Math.Round(rentCost2020, 2);

                housingCostLWP1990Text.text = "Monthly Housing Cost (1990): $" + rentCost1990 + "!";
                housingCostLWP2020Text.text = "Monthly Housing Cost (2020): $" + rentCost2020 + "!";
                break;
            case 2:
                //Changing Panel View
                housingScreen.SetActive(false);
                livingWithParentsScreen.SetActive(false);
                livingWithRoommatesScreen.SetActive(true);
                basicApartmentScreen.SetActive(false);
                luxuryApartmentScreen.SetActive(false);
                basicHouseScreen.SetActive(false);
                luxuryHouseScreen.SetActive(false);

                housingSelected = "Living With Rommates";
                livingWithRoommates = true;
                
                rentCost1990 = 300.00F;
                rentCost2020 = 500.00F;

                rentCost1990 = Math.Round(rentCost1990, 2);
                rentCost2020 = Math.Round(rentCost2020, 2);

                housingCostLWR1990Text.text = "Monthly Housing Cost (1990): $" + rentCost1990 + "!";
                housingCostLWR2020Text.text = "Monthly Housing Cost (2020): $" + rentCost2020 + "!";
                break;
            case 3:
                //Changing Panel View
                housingScreen.SetActive(false);
                livingWithParentsScreen.SetActive(false);
                livingWithRoommatesScreen.SetActive(false);
                basicApartmentScreen.SetActive(true);
                luxuryApartmentScreen.SetActive(false);
                basicHouseScreen.SetActive(false);
                luxuryHouseScreen.SetActive(false);

                housingSelected = "Basic Apartment";
                basicApartment = true;
                
                rentCost1990 = 500.00F;
                rentCost2020 = 800.00F;

                rentCost1990 = Math.Round(rentCost1990, 2);
                rentCost2020 = Math.Round(rentCost2020, 2);

                housingCostBA1990Text.text = "Monthly Housing Cost (1990): $" + rentCost1990 + "!";
                housingCostBA2020Text.text = "Monthly Housing Cost (2020): $" + rentCost2020 + "!";
                break;
            case 4:
                //Changing Panel View
                housingScreen.SetActive(false);
                livingWithParentsScreen.SetActive(false);
                livingWithRoommatesScreen.SetActive(false);
                basicApartmentScreen.SetActive(false);
                luxuryApartmentScreen.SetActive(true);
                basicHouseScreen.SetActive(false);
                luxuryHouseScreen.SetActive(false);

                housingSelected = "Luxury Apartment";
                luxuryApartment = true;
                
                rentCost1990 = 900.00F;
                rentCost2020 = 1600.00F;

                rentCost1990 = Math.Round(rentCost1990, 2);
                rentCost2020 = Math.Round(rentCost2020, 2);

                housingCostLA1990Text.text = "Monthly Housing Cost (1990): $" + rentCost1990 + "!";
                housingCostLA2020Text.text = "Monthly Housing Cost (2020): $" + rentCost2020 + "!";
                break;
            case 5:
                //Changing Panel View
                housingScreen.SetActive(false);
                livingWithParentsScreen.SetActive(false);
                livingWithRoommatesScreen.SetActive(false);
                basicApartmentScreen.SetActive(false);
                luxuryApartmentScreen.SetActive(false);
                basicHouseScreen.SetActive(true);
                luxuryHouseScreen.SetActive(false);

                housingSelected = "Basic House";
                basicHouse = true;
                
                mortgageCost1990 = 1000.00F;
                mortgageCost2020 = 1400.00F;

                mortgageCost1990 = Math.Round(mortgageCost1990, 2);
                mortgageCost2020 = Math.Round(mortgageCost2020, 2);

                housingCostBH1990Text.text = "Monthly Housing Cost (1990): $" + mortgageCost1990 + "!";
                housingCostBH2020Text.text = "Monthly Housing Cost (2020): $" + mortgageCost2020 + "!";
                break;
            case 6:
                //Changing Panel View
                housingScreen.SetActive(false);
                livingWithParentsScreen.SetActive(false);
                livingWithRoommatesScreen.SetActive(false);
                basicApartmentScreen.SetActive(false);
                luxuryApartmentScreen.SetActive(false);
                basicHouseScreen.SetActive(false);
                luxuryHouseScreen.SetActive(true);

                housingSelected = "Luxury House";
                luxuryHouse = true;
                
                mortgageCost1990 = 1400.00F;
                mortgageCost2020 = 2000.00F;

                mortgageCost1990 = Math.Round(mortgageCost1990, 2);
                mortgageCost2020 = Math.Round(mortgageCost2020, 2);

                housingCostLH1990Text.text = "Monthly Housing Cost (1990): $" + mortgageCost1990 + "!";
                housingCostLH2020Text.text = "Monthly Housing Cost (2020): $" + mortgageCost2020 + "!";
                break;
        }
    }
    public void ChooseHousingLivingWithParents()
    {
        forwardButtonClickAudioSource.Play();
        houseNow = 1;
        ChooseHousing();
    }
    public void ChooseHousingLivingWithRoommates()
    {
        forwardButtonClickAudioSource.Play();
        houseNow = 2;
        ChooseHousing();
    }
    public void ChooseHousingBasicApartment()
    {
        forwardButtonClickAudioSource.Play();
        houseNow = 3;
        ChooseHousing();
    }
    public void ChooseHousingLuxuryApartment()
    {
        forwardButtonClickAudioSource.Play();
        houseNow = 4;
        ChooseHousing();
    }
    public void ChooseHousingBasicHouse()
    {
        forwardButtonClickAudioSource.Play();
        houseNow = 5;
        ChooseHousing();
    }
    public void ChooseHousingLuxuryHouse()
    {
        forwardButtonClickAudioSource.Play();
        houseNow = 6;
        ChooseHousing();
    }



    //Selecting Utilities
    public void ChooseUtilitiesElectric()
    {
        forwardButtonClickAudioSource.Play();
        utilityElectric = true;

        utilityElectric1990Selected = "Electricity";
        utilityElectric2020Selected = "Electricity";

        utilityElectricityCost1990Text.text = "Monthly Electricity Cost (1990): $50.00 - $200.00";
        utilityElectricityCost2020Text.text = "Monthly Electricity Cost (2020): $100.00 - $300.00";

        utilitiesElectricScreen.SetActive(true);
        toUtilitiesScreen.SetActive(false);
    }
    public void ChooseUtilitiesWater()
    {
        forwardButtonClickAudioSource.Play();
        utilityWater = true;

        utilityWater1990Selected = "Water";
        utilityWater2020Selected = "Water";

        utilityWaterCost1990Text.text = "Monthly Water Cost (1990): $15.00 - $40.00";
        utilityWaterCost2020Text.text = "Monthly Water Cost (2020): $25.00 - $50.00";

        utilitiesWaterScreen.SetActive(true);
        utilitiesElectricScreen.SetActive(false);
    }
    public void ChooseUtilitiesCommunications()
    {
        forwardButtonClickAudioSource.Play();

        utilitiesCommunicationsScreen.SetActive(true);

        utilitiesWaterScreen.SetActive(false);
    }
    public void ChooseUtilitiesCommunicationsHousePhone1990()
    {
        forwardButtonClickAudioSource.Play();
        
        utilityCommunications1990 = true;
        housePhone1990 = true;

        utilityCommunications1990Selected = "House Phone";

        utilityCommunicationsCost1990 = 15.00F;
        utilityCommunicationsCost1990 = Math.Round(utilityCommunicationsCost1990, 2);

        utilityCommunicationsHPCost1990Text.text = "Monthly Communication Cost (1990): $" + utilityCommunicationsCost1990 + "!";

        utilitiesCost1990 += utilityCommunicationsCost1990;

        housePhone1990Screen.SetActive(true);
        utilitiesCommunicationsScreen.SetActive(false);
        basicCellPhone1990Button.SetActive(false);

        ContinueFromCommunications();
    }
    public void ChooseUtilitiesCommunicationsHousePhone2020()
    {
        forwardButtonClickAudioSource.Play();
        
        utilityCommunications2020 = true;
        housePhone2020 = true;

        utilityCommunications2020Selected = "House Phone";

        utilityCommunicationsCost2020 = 30.00F;
        utilityCommunicationsCost2020 = Math.Round(utilityCommunicationsCost2020, 2);

        utilityCommunicationsHPCost2020Text.text = "Monthly Communication Cost (2020): $" + utilityCommunicationsCost2020 + "!";

        utilitiesCost2020 += utilityCommunicationsCost2020;

        housePhone2020Screen.SetActive(true);
        utilitiesCommunicationsScreen.SetActive(false);
        basicCellPhone2020Button.SetActive(false);
        unlimitedCellPhone2020Button.SetActive(false);

        ContinueFromCommunications();
    }
    public void ChooseUtilitiesCommunicationsBasicCellPhone1990()
    {
        forwardButtonClickAudioSource.Play();
        
        utilityCommunications1990 = true;
        basicCellPhone1990 = true;

        utilityCommunications1990Selected = "Basic Cell Phone";

        utilityCommunicationsCost1990 = 30.00F;
        utilityCommunicationsCost1990 = Math.Round(utilityCommunicationsCost1990, 2);

        utilityCommunicationsBCPCost1990Text.text = "Monthly Communication Cost (1990): $" + utilityCommunicationsCost1990 + "!";

        utilitiesCost1990 += utilityCommunicationsCost1990;

        basicCellPhone1990Screen.SetActive(true);
        utilitiesCommunicationsScreen.SetActive(false);
        housePhone1990Button.SetActive(false);

        ContinueFromCommunications();
    }
    public void ChooseUtilitiesCommunicationsBasicCellPhone2020()
    {
        forwardButtonClickAudioSource.Play();
        
        utilityCommunications2020 = true;
        basicCellPhone2020 = true;

        utilityCommunications2020Selected = "Basic Cell Phone";

        utilityCommunicationsCost2020 = 50.00F;
        utilityCommunicationsCost2020 = Math.Round(utilityCommunicationsCost2020, 2);

        utilityCommunicationsBCPCost2020Text.text = "Monthly Communication Cost (2020): $" + utilityCommunicationsCost2020 + "!";

        utilitiesCost2020 += utilityCommunicationsCost2020;

        basicCellPhone2020Screen.SetActive(true);
        utilitiesCommunicationsScreen.SetActive(false);
        housePhone2020Button.SetActive(false);
        unlimitedCellPhone2020Button.SetActive(false);

        ContinueFromCommunications();
    }
    public void ChooseUtilitiesCommunicationsUnlimitedCellPhone2020()
    {
        forwardButtonClickAudioSource.Play();
        
        utilityCommunications2020 = true;
        unlimitedCellPhone2020 = true;

        utilityCommunications2020Selected = "Unlimited Cell Phone";

        utilityCommunicationsCost2020 = 80.00F;
        utilityCommunicationsCost2020 = Math.Round(utilityCommunicationsCost2020, 2);

        utilityCommunicationsUCPCost2020Text.text = "Monthly Communication Cost (2020): $" + utilityCommunicationsCost2020 + "!";

        utilitiesCost2020 += utilityCommunicationsCost2020;

        unlimitedCellPhone2020Screen.SetActive(true);
        utilitiesCommunicationsScreen.SetActive(false);
        housePhone2020Button.SetActive(false);
        basicCellPhone2020Button.SetActive(false);

        ContinueFromCommunications();
    }
    public void ChooseUtilitiesEntertainment()
    {
        forwardButtonClickAudioSource.Play();
        
        utilitiesEntertainmentScreen.SetActive(true);

        utilitiesCommunicationsScreen.SetActive(false);
    }

    public void ChooseUtilitiesEntertainmentBasicCable1990()
    {
        forwardButtonClickAudioSource.Play();
        
        utilityEntertainment1990 = true;
        basicCable1990 = true;

        utilityEntertainment1990Selected = "Basic Cable";

        utilityEntertainmentCost1990 = 20.00F;
        utilityEntertainmentCost1990 = Math.Round(utilityEntertainmentCost1990, 2);

        utilityEntertainmentBCCost1990Text.text = "Monthly Entertainment Cost (1990): $" + utilityEntertainmentCost1990 + "!";

        utilitiesCost1990 += utilityEntertainmentCost1990;

        basicCable1990Screen.SetActive(true);
        utilitiesEntertainmentScreen.SetActive(false);
        premiumCable1990Button.SetActive(false);

        ContinueFromEntertainment();
    }
    public void ChooseUtilitiesEntertainmentBasicCable2020()
    {
        forwardButtonClickAudioSource.Play();
        
        utilityEntertainment2020 = true;
        basicCable2020 = true;

        utilityEntertainment2020Selected = "Basic Cable";

        utilityEntertainmentCost2020 = 40.00F;
        utilityEntertainmentCost2020 = Math.Round(utilityEntertainmentCost2020, 2);

        utilityEntertainmentBCCost2020Text.text = "Monthly Entertainment Cost (2020): $" + utilityEntertainmentCost2020 + "!";

        utilitiesCost2020 += utilityEntertainmentCost2020;

        basicCable2020Screen.SetActive(true);
        utilitiesEntertainmentScreen.SetActive(false);
        premiumCable2020Button.SetActive(false);
        streamingService2020Button.SetActive(false);

        ContinueFromEntertainment();
    }
    public void ChooseUtilitiesEntertainmentPremiumCable1990()
    {
        forwardButtonClickAudioSource.Play();
        
        utilityEntertainment1990 = true;
        premiumCable1990 = true;

        utilityEntertainment1990Selected = "Premium Cable";

        utilityEntertainmentCost1990 = 40.00F;
        utilityEntertainmentCost1990 = Math.Round(utilityEntertainmentCost1990, 2);

        utilityEntertainmentPCCost1990Text.text = "Monthly Entertainment Cost (1990): $" + utilityEntertainmentCost1990 + "!";

        utilitiesCost1990 += utilityEntertainmentCost1990;

        premiumCable1990Screen.SetActive(true);
        utilitiesEntertainmentScreen.SetActive(false);
        basicCable1990Button.SetActive(false);

        ContinueFromEntertainment();
    }
    public void ChooseUtilitiesEntertainmentPremiumCable2020()
    {
        forwardButtonClickAudioSource.Play();
        
        utilityEntertainment2020 = true;
        premiumCable2020 = true;

        utilityEntertainment2020Selected = "Premium Cable";

        utilityEntertainmentCost2020 = 80.00F;
        utilityEntertainmentCost2020 = Math.Round(utilityEntertainmentCost2020, 2);

        utilityEntertainmentPCCost2020Text.text = "Monthly Entertainment Cost (2020): $" + utilityEntertainmentCost2020 + "!";

        utilitiesCost2020 += utilityEntertainmentCost2020;

        premiumCable2020Screen.SetActive(true);
        utilitiesEntertainmentScreen.SetActive(false);
        basicCable2020Button.SetActive(false);
        streamingService2020Button.SetActive(false);

        ContinueFromEntertainment();
    }
    public void ChooseUtilitiesEntertainmentStreamingService()
    {
        forwardButtonClickAudioSource.Play();
        
        utilityEntertainment2020 = true;
        streamingService2020 = true;

        utilityEntertainment2020Selected = "Streaming Services";

        utilityEntertainmentCost2020 = 60.00F;
        utilityEntertainmentCost2020 = Math.Round(utilityEntertainmentCost2020, 2);

        utilityEntertainmentSSCost2020Text.text = "Monthly Entertainment Cost (2020): $" + utilityEntertainmentCost2020 + "!";

        utilitiesCost2020 += utilityEntertainmentCost2020;

        streamingService2020Screen.SetActive(true);
        utilitiesEntertainmentScreen.SetActive(false);
        basicCable2020Button.SetActive(false);
        premiumCable2020Button.SetActive(false);

        ContinueFromEntertainment();
    }

    public void ChooseUtilitiesInternet()
    {
        forwardButtonClickAudioSource.Play();
        
        utilitiesInternetScreen.SetActive(true);

        utilitiesEntertainmentScreen.SetActive(false);
    }
    public void ChooseUtilitiesInternetBasicDialUp1990()
    {
        forwardButtonClickAudioSource.Play();
        
        utilityInternet1990 = true;
        basicDialUpInternet1990 = true;

        utilityInternet1990Selected = "Basic Dial-Up Internet";

        utilityInternetBasicDialUpCost1990Text.text = "Monthly Internet Cost (1990): $10.00 - $15.00!";

        utilitiesCost1990 += utilityInternetCost1990;

        basicDialUpInternet1990Screen.SetActive(true);
        utilitiesInternetScreen.SetActive(false);
        premiumDialUpInternet1990Button.SetActive(false);

        ContinueFromInternet();
    }
    public void ChooseUtilitiesInternetPremiumDialUp1990()
    {
        forwardButtonClickAudioSource.Play();
        
        utilityInternet1990 = true;
        premiumDialUpInternet1990 = true;

        utilityInternet1990Selected = "Premium Dial-Up Internet";

        utilityInternetPremiumDialUpCost1990Text.text = "Monthly Internet Cost (1990): $25.00 - $50.00!";

        utilitiesCost1990 += utilityInternetCost1990;

        premiumDialUpInternet1990Screen.SetActive(true);
        utilitiesInternetScreen.SetActive(false);
        basicDialUpInternet1990Button.SetActive(false);

        ContinueFromInternet();
    }
    public void ChooseUtilitiesInternet50MB2020()
    {
        forwardButtonClickAudioSource.Play();
        
        utilityInternet2020 = true;
        mb50Internet2020 = true;

        utilityInternet2020Selected = "50MB/s Internet";

        utilityInternetCost2020 = 25.00F;
        utilityInternetCost2020 = Math.Round(utilityInternetCost2020, 2);

        utilityInternet50Cost2020Text.text = "Monthly Internet Cost (2020): $" + utilityInternetCost2020 + "!";

        utilitiesCost2020 += utilityInternetCost2020;

        mb50Internet2020Screen.SetActive(true);
        utilitiesInternetScreen.SetActive(false);
        mb100Internet2020Button.SetActive(false);
        mb200Internet2020Button.SetActive(false);

        ContinueFromInternet();
    }
    public void ChooseUtilitiesInternet100MB2020()
    {
        forwardButtonClickAudioSource.Play();
        
        utilityInternet2020 = true;
        mb100Internet2020 = true;

        utilityInternet2020Selected = "100MB/s Internet";

        utilityInternetCost2020 = 50.00F;
        utilityInternetCost2020 = Math.Round(utilityInternetCost2020, 2);

        utilityInternet100Cost2020Text.text = "Monthly Internet Cost (2020): $" + utilityInternetCost2020 + "!";

        utilitiesCost2020 += utilityInternetCost2020;

        mb100Internet2020Screen.SetActive(true);
        utilitiesInternetScreen.SetActive(false);
        mb50Internet2020Button.SetActive(false);
        mb200Internet2020Button.SetActive(false);

        ContinueFromInternet();
    }
    public void ChooseUtilitiesInternet200MB2020()
    {
        forwardButtonClickAudioSource.Play();
        
        utilityInternet2020 = true;
        mb200Internet2020 = true;

        utilityInternet2020Selected = "200MB/s Internet";

        utilityInternetCost2020 = 90.00F;
        utilityInternetCost2020 = Math.Round(utilityInternetCost2020, 2);

        utilityInternet200Cost2020Text.text = "Monthly Internet Cost (2020): $" + utilityInternetCost2020 + "!";

        utilitiesCost2020 += utilityInternetCost2020;

        mb200Internet2020Screen.SetActive(true);
        utilitiesInternetScreen.SetActive(false);
        mb50Internet2020Button.SetActive(false);
        mb100Internet2020Button.SetActive(false);

        ContinueFromInternet();
    }
    public void FromCommunicationsUtilities()
    {
        backwardsButtonClickAudioSource.Play();
        
        housePhone1990Screen.SetActive(false);
        housePhone2020Screen.SetActive(false);
        basicCellPhone1990Screen.SetActive(false);
        basicCellPhone2020Screen.SetActive(false);
        unlimitedCellPhone2020Screen.SetActive(false);

        utilitiesCommunicationsScreen.SetActive(true);
    }
    public void FromEntertainmentUtilities()
    {
        backwardsButtonClickAudioSource.Play();
        
        basicCable1990Screen.SetActive(false);
        basicCable2020Screen.SetActive(false);
        premiumCable1990Screen.SetActive(false);
        premiumCable2020Screen.SetActive(false);
        streamingService2020Screen.SetActive(false);

        utilitiesEntertainmentScreen.SetActive(true);
    }
    public void FromInternetUtilities()
    {
        backwardsButtonClickAudioSource.Play();
        
        basicDialUpInternet1990Screen.SetActive(false);
        premiumDialUpInternet1990Screen.SetActive(false);
        mb50Internet2020Screen.SetActive(false);
        mb100Internet2020Screen.SetActive(false);
        mb200Internet2020Screen.SetActive(false);

        utilitiesInternetScreen.SetActive(true);
    }



    //Selecting Transportation
    public void ChooseTransportation()
    {
        switch (travelNow)
        {
            case 1:
                transportationScreen.SetActive(false);
                bicycleScreen.SetActive(true);
                usedCarScreen.SetActive(false);
                newCarScreen.SetActive(false);
                motorcycleScreen.SetActive(false);
                busScreen.SetActive(false);
                trainScreen.SetActive(false);

                transportationSelected = "Bicycle";
                bicycle = true;
                payTransportationTitleText1.text = "Pay Transportation: Bicycle";
                payTransportationTitleText2.text = "Pay Transportation: Bicycle";

                payTransportationDescriptionText.text = "Having a Bicycle may not be as nice as having a car, but at least the maintinance cost is cheap.";
                
                // Bicycle
                //weekB1990 = airPump1990 * workDays; // 2.00 air * 5 day/week
                //weekB2020 = airPump2020 * workDays; // 3.00 air * 5 day/week

                //transportationCost1990 = weekB1990;
                //transportationCost2020 = weekB2020;

                transportationCost1990 = airPump1990 * workDays; // 2.00 air * 5 day/week
                transportationCost2020 = airPump2020 * workDays; // 3.00 air * 5 day/week

                // [(Back-Up)
                //transportationCost1990 = 10.00F;
                //transportationCost2020 = 15.00F;
                // ]

                transportationCost1990 = Math.Round(transportationCost1990, 2);
                transportationCost2020 = Math.Round(transportationCost2020, 2);

                transportationBCost1990Text.text = "Weekly Transportation Cost (1990): $" + transportationCost1990 + "!";
                transportationBCost2020Text.text = "Weekly Transportation Cost (2020): $" + transportationCost2020 + "!";
                break;
            case 2:
                transportationScreen.SetActive(false);
                bicycleScreen.SetActive(false);
                usedCarScreen.SetActive(true);
                newCarScreen.SetActive(false);
                motorcycleScreen.SetActive(false);
                busScreen.SetActive(false);
                trainScreen.SetActive(false);

                transportationSelected = "Used Car";
                usedCar = true;
                payTransportationTitleText1.text = "Pay Transportation: Used Car";
                payTransportationTitleText2.text = "Pay Transportation: Used Car";

                payTransportationDescriptionText.text = "Having a Used Car may not be as flashy as a new one, but at least it is affordable and reliable.";
                
                // Used Car
                //weekUC1990 = gasCost1990 * usedCarTank; // 1.15 gas * 10 gal
                //weekUC2020 = gasCost2020 * usedCarTank; // 2.50 gas * 10 gal

                //transportationCost1990 = weekUC1990;
                //transportationCost2020 = weekUC2020;

                //transportationCost1990 = gasCost1990 * usedCarTank; // 1.15 gas * 10 gal
                //transportationCost2020 = gasCost2020 * usedCarTank; // 2.50 gas * 10 gal

                // [(Back-Up)
                transportationCost1990 = 11.50F; // 1.15 gas * 10 gal
                transportationCost2020 = 25.00F; // 2.50 gas * 10 gal
                // ]

                transportationCost1990 = Math.Round(transportationCost1990, 2);
                transportationCost2020 = Math.Round(transportationCost2020, 2);

                transportationUCCost1990Text.text = "Weekly Transportation Cost (1990): $" + transportationCost1990 + "!";
                transportationUCCost2020Text.text = "Weekly Transportation Cost (2020): $" + transportationCost2020 + "!";
                break;
            case 3:
                transportationScreen.SetActive(false);
                bicycleScreen.SetActive(false);
                usedCarScreen.SetActive(false);
                newCarScreen.SetActive(true);
                motorcycleScreen.SetActive(false);
                busScreen.SetActive(false);
                trainScreen.SetActive(false);

                transportationSelected = "New Car";
                newCar = true;
                payTransportationTitleText1.text = "Pay Transportation: New Car";
                payTransportationTitleText2.text = "Pay Transportation: New Car";

                payTransportationDescriptionText.text = "Having a New Car is definitely something to be proud of. A bit on the expensive side, but definitely a good investment.";
                
                // New Car
                //weekNC1990 = gasCost1990 * newCarTank; // 1.15 gas * 15 gal
                //weekNC2020 = gasCost2020 * newCarTank; // 2.50 gas * 15 gal

                //transportationCost1990 = weekNC1990;
                //transportationCost2020 = weekNC2020;

                //transportationCost1990 = gasCost1990 * newCarTank; // 1.15 gas * 15 gal
                //transportationCost2020 = gasCost2020 * newCarTank; // 2.50 gas * 15 gal

                // [(Back-Up)
                transportationCost1990 = 17.25F; // 1.15 gas * 15 gal
                transportationCost2020 = 37.50F; // 2.50 gas * 15 gal
                // ]

                transportationCost1990 = Math.Round(transportationCost1990, 2);
                transportationCost2020 = Math.Round(transportationCost2020, 2);

                transportationNCCost1990Text.text = "Weekly Transportation Cost: $" + transportationCost1990 + "!";
                transportationNCCost2020Text.text = "Weekly Transportation Cost: $" + transportationCost2020 + "!";
                break;
            case 4:
                transportationScreen.SetActive(false);
                bicycleScreen.SetActive(false);
                usedCarScreen.SetActive(false);
                newCarScreen.SetActive(false);
                motorcycleScreen.SetActive(true);
                busScreen.SetActive(false);
                trainScreen.SetActive(false);

                transportationSelected = "Motorcycle";
                motorcycle = true;
                payTransportationTitleText1.text = "Pay Transportation: Motorcycle";
                payTransportationTitleText2.text = "Pay Transportation: Motorcycle";

                payTransportationDescriptionText.text = "Having a Motorcycle is pretty nice and a sign of living on the wildside. Cheaper than a car, but more reliable than public transportation.";
                
                // Motorcycle
                //weekM1990 = gasCost1990 * motorcycleTank; // 1.15 gas * 4 gal
                //weekM2020 = gasCost2020 * motorcycleTank; // 2.50 gas * 4 gal

                //transportationCost1990 = weekM1990;
                //transportationCost2020 = weekM2020;

                //transportationCost1990 = gasCost1990 * motorcycleTank; // 1.15 gas * 4 gal
                //transportationCost2020 = gasCost2020 * motorcycleTank; // 2.50 gas * 4 gal

                // [(Back-Up)
                transportationCost1990 = 4.60F; // 2.50 gas * 4 gal
                transportationCost2020 = 10.00F; // 2.50 gas * 4 gal
                // ]

                transportationCost1990 = Math.Round(transportationCost1990, 2);
                transportationCost2020 = Math.Round(transportationCost2020, 2);

                transportationMCost1990Text.text = "Weekly Transportation Cost: $" + transportationCost1990 + "!";
                transportationMCost2020Text.text = "Weekly Transportation Cost: $" + transportationCost2020 + "!";
                break;
            case 5:
                transportationScreen.SetActive(false);
                bicycleScreen.SetActive(false);
                usedCarScreen.SetActive(false);
                newCarScreen.SetActive(false);
                motorcycleScreen.SetActive(false);
                busScreen.SetActive(true);
                trainScreen.SetActive(false);

                transportationSelected = "City Bus Transit";
                bus = true;
                payTransportationTitleText1.text = "Pay Transportation: City Bus Transit";
                payTransportationTitleText2.text = "Pay Transportation: City Bus Transit";

                payTransportationDescriptionText.text = "Having to rely on public transportation, like the City Bus, can be frustrating and time consuming, but it is affordable and reliable.";
                
                // City Bus
                //weekBus1990 = busPass1990 * workDays; // 2.00/day * 5 days/week
                //weekBus2020 = busPass2020 * workDays; // 4.50/day * 5 days/week

                //transportationCost1990 = weekBus1990;
                //transportationCost2020 = weekBus2020;

                transportationCost1990 = busPass1990 * workDays; // 2.00/day * 5 days/week
                transportationCost2020 = busPass2020 * workDays; // 4.50/day * 5 days/week

                // [(Back-Up)
                //transportationCost1990 = 10.00F;
                //transportationCost2020 = 22.50F;
                // ]

                transportationCost1990 = Math.Round(transportationCost1990, 2);
                transportationCost2020 = Math.Round(transportationCost2020, 2);

                transportationBusCost1990Text.text = "Weekly Transportation Cost: $" + transportationCost1990 + "!";
                transportationBusCost2020Text.text = "Weekly Transportation Cost: $" + transportationCost2020 + "!";
                break;
            case 6:
                transportationScreen.SetActive(false);
                bicycleScreen.SetActive(false);
                usedCarScreen.SetActive(false);
                newCarScreen.SetActive(false);
                motorcycleScreen.SetActive(false);
                busScreen.SetActive(false);
                trainScreen.SetActive(true);

                transportationSelected = "Train Transit";
                train = true;
                payTransportationTitleText1.text = "Pay Transportation: Train Transit";
                payTransportationTitleText2.text = "Pay Transportation: Train Transit";

                payTransportationDescriptionText.text = "Having to rely on public transportation, like the Train, can be frustrating and time consuming, but it is reliable.";
                
                // Train
                trainPass1990 = UnityEngine.Random.Range(2.25F, 6.75F);
                trainPass2020 = UnityEngine.Random.Range(3.75F, 9.50F);

                //weekT1990 = trainPass1990 * workDays; // (2.25 - 6.75)/day * 5 days/week
                //weekT2020 = trainPass2020 * workDays; // (3.75 - 9.50)/day * 5 days/week

                transportationCost1990 = trainPass1990 * workDays; // (2.25 - 6.75)/day * 5 days/week
                transportationCost2020 = trainPass2020 * workDays; // (3.75 - 9.50)/day * 5 days/week

                //transportationCost1990 = weekT1990; // 1.50/day, 5 day/week
                //transportationCost2020 = weekT2020; // 4.00/day, 5 day/week

                // [(Back-Up)
                //transportationCost1990 = UnityEngine.Random.Range(11.25F, 33.75F);
                //transportationCost2020 = UnityEngine.Random.Range(18.75F, 47.50F);
                // ]

                transportationCost1990 = Math.Round(transportationCost1990, 2);
                transportationCost2020 = Math.Round(transportationCost2020, 2);

                transportationTCost1990Text.text = "Weekly Transportation Cost: $" + transportationCost1990 + "!";
                transportationTCost2020Text.text = "Weekly Transportation Cost: $" + transportationCost2020 + "!";
                break;
        }
    }
    public void ChooseTransportationBicycle()
    {
        forwardButtonClickAudioSource.Play();
        travelNow = 1;
        ChooseTransportation();
    }
    public void ChooseTransportationUsedCar()
    {
        forwardButtonClickAudioSource.Play();
        travelNow = 2;
        ChooseTransportation();
    }
    public void ChooseTransportationNewCar()
    {
        forwardButtonClickAudioSource.Play();
        travelNow = 3;
        ChooseTransportation();
    }
    public void ChooseTransportationMotorcycle()
    {
        forwardButtonClickAudioSource.Play();
        travelNow = 4;
        ChooseTransportation();
    }
    public void ChooseTransportationBus()
    {
        forwardButtonClickAudioSource.Play();
        travelNow = 5;
        ChooseTransportation();
    }
    public void ChooseTransportationTrain()
    {
        forwardButtonClickAudioSource.Play();
        travelNow = 6;
        ChooseTransportation();
    }


    
    //Select Gift Money
    public void ChooseGift()
    {
        moneyGainedAudioSource.Play(); 
        
        giftMoneyScreen1.SetActive(false);
        giftMoneyScreen2.SetActive(true);

        giftMoney = UnityEngine.Random.Range(0.00F, 1000.00F);
        giftMoney = Math.Round(giftMoney, 2);
        giftMoneyText.text = "Gift: $" + giftMoney;
        currentMoney1990 += giftMoney;
        currentMoney2020 += giftMoney;

        //weekMoneyObtained1990 += giftMoney;
        //weekMoneyObtained2020 += giftMoney;
    }



    //Move to Gender Selection Screen
    public void ToToGenderScreen()
    {
        welcomeScreen.SetActive(false);

        forwardButtonClickAudioSource.Play();
        playButtonClickAudioSource.Play();
        introductionBackgroundAudioSource.Play();

        toGenderScreen.SetActive(true);
    }
    public void ToGenderScreen()
    {
        toGenderScreen.SetActive(false);

        forwardButtonClickAudioSource.Play();

        genderScreen.SetActive(true);
    }
    
    //Move to Race Selection Screen
    public void ToToRaceScreen()
    {
        forwardButtonClickAudioSource.Play();
        
        toGenderScreen.SetActive(false);
        genderScreen.SetActive(false);
        maleScreen.SetActive(false);
        femaleScreen.SetActive(false);
        otherGenderScreen.SetActive(false);

        toRaceScreen.SetActive(true);
    }
    public void ToRaceScreen()
    {
        forwardButtonClickAudioSource.Play();
        
        toRaceScreen.SetActive(false);
        raceScreen.SetActive(true);
    }
    
    //Move to Education Selection Screen
    public void ToToEducationScreen()
    {
        forwardButtonClickAudioSource.Play();
        
        toRaceScreen.SetActive(false);
        raceScreen.SetActive(false);
        europeanDescentScreen.SetActive(false);
        africanDescentScreen.SetActive(false);
        nativeAmericanDescentScreen.SetActive(false);
        hispanicDescentScreen.SetActive(false);
        asianDescentScreen.SetActive(false);
        otherDescentScreen.SetActive(false);

        toEducationScreen.SetActive(true);
    }
    public void ToEducationScreen()
    {
        forwardButtonClickAudioSource.Play();
        
        toEducationScreen.SetActive(false);

        educationScreen.SetActive(true);
    }
    
    //Move to Job Selection Screen
    public void ToToJobScreen()
    {
        forwardButtonClickAudioSource.Play();
        
        toEducationScreen.SetActive(false);
        educationScreen.SetActive(false);
        educationScreenNoDegree.SetActive(false);
        educationScreenHSDiploma.SetActive(false);
        educationScreenAssociatesDegree.SetActive(false);
        educationScreenBachelorsDegree.SetActive(false);
        educationScreenMastersDegree.SetActive(false);
        educationScreenAdvancedDegree.SetActive(false);

        toJobScreen.SetActive(true);
    }
    public void ToJobScreen()
    {
        forwardButtonClickAudioSource.Play();
        
        toJobScreen.SetActive(false);
        jobScreen.SetActive(true);
    }

    //Move to Housing Selection Screen
    public void ToToHousingScreen()
    {
        forwardButtonClickAudioSource.Play();
        
        toJobScreen.SetActive(false);
        jobScreen.SetActive(false);
        waiterScreen.SetActive(false);
        cashierScreen.SetActive(false);
        fryCookScreen.SetActive(false);
        customerServiceAgentScreen.SetActive(false);
        teacherScreen.SetActive(false);
        licensedSalesAgentScreen.SetActive(false);
        programmerScreen.SetActive(false);
        engineerScreen.SetActive(false);
        doctorScreen.SetActive(false);
        lawyerScreen.SetActive(false);

        toHousingScreen.SetActive(true);
    }
    public void ToHousingScreen()
    {
        forwardButtonClickAudioSource.Play();
        
        toHousingScreen.SetActive(false);

        housingScreen.SetActive(true);
    }

    //Move to Utility Selection Screen
    public void ToUtilitiesScreen()
    {
        forwardButtonClickAudioSource.Play();
        
        toHousingScreen.SetActive(false);
        housingScreen.SetActive(false);
        livingWithParentsScreen.SetActive(false);
        livingWithRoommatesScreen.SetActive(false);
        basicApartmentScreen.SetActive(false);
        luxuryApartmentScreen.SetActive(false);
        basicHouseScreen.SetActive(false);
        luxuryHouseScreen.SetActive(false);

        toUtilitiesScreen.SetActive(true);
    }

    public void ContinueFromCommunications()
    {
        if (utilityCommunications1990 == true && utilityCommunications2020 == true)
        {
            continueFromCommunicationsButton.SetActive(true);
        }
    }
    public void ContinueFromEntertainment()
    {
        if (utilityEntertainment1990 == true && utilityEntertainment2020 == true)
        {
            continueFromEntertainmentButton.SetActive(true);
        }
    }
    public void ContinueFromInternet()
    {
        if (utilityInternet1990 == true && utilityInternet2020 == true)
        {
            continueFromInternetButton.SetActive(true);
        }
    }
    
    //Move to Transportation Selection Screen
    public void ToToTransportationScreen()
    {
        forwardButtonClickAudioSource.Play();
        
        toUtilitiesScreen.SetActive(false);
        utilitiesElectricScreen.SetActive(false);
        utilitiesWaterScreen.SetActive(false);
        utilitiesCommunicationsScreen.SetActive(false);
        housePhone1990Screen.SetActive(false);
        housePhone2020Screen.SetActive(false);
        basicCellPhone1990Screen.SetActive(false);
        basicCellPhone2020Screen.SetActive(false);
        unlimitedCellPhone2020Screen.SetActive(false);
        utilitiesEntertainmentScreen.SetActive(false);
        basicCable1990Screen.SetActive(false);
        basicCable2020Screen.SetActive(false);
        premiumCable2020Screen.SetActive(false);
        streamingService2020Screen.SetActive(false);
        utilitiesInternetScreen.SetActive(false);
        mb50Internet2020Screen.SetActive(false);
        mb100Internet2020Screen.SetActive(false);
        mb200Internet2020Screen.SetActive(false);

        toTransportationScreen.SetActive(true);
    }
    public void ToTransportationScreen()
    {
        forwardButtonClickAudioSource.Play();
        
        toTransportationScreen.SetActive(false);
        
        transportationScreen.SetActive(true);
    }

    //Move to Gift Selection Screen
    public void ToToGiftMoneyScreen()
    {
        forwardButtonClickAudioSource.Play();
        
        toTransportationScreen.SetActive(false);
        transportationScreen.SetActive(false);
        usedCarScreen.SetActive(false);
        newCarScreen.SetActive(false);
        motorcycleScreen.SetActive(false);
        busScreen.SetActive(false);
        trainScreen.SetActive(false);

        toGiftMoneyScreen.SetActive(true);
    }
    public void ToGiftMoneyScreen()
    {
        forwardButtonClickAudioSource.Play();
        
        toGiftMoneyScreen.SetActive(false);
        
        giftMoneyScreen1.SetActive(true);
    }

    //Introduction Functions - Summary
    public void ToToIntroSummaryScreen()
    {
        forwardButtonClickAudioSource.Play();
        
        giftMoneyScreen2.SetActive(false);

        toIntroSummaryScreen.SetActive(true);
    }
    public void ToIntroSummaryScreen()
    {
        forwardButtonClickAudioSource.Play();
        
        toIntroSummaryScreen.SetActive(false);

        introSummaryScreen.SetActive(true);
    }
    public void ToIntroSummaryScreen1990()
    {
        forwardButtonClickAudioSource.Play();
        
        introSummaryScreen.SetActive(false);

        introSummary1990Screen.SetActive(true);
        introSummary2020Screen.SetActive(false);
        IntroSummary1990();
    }
    public void IntroSummary1990()
    {
        summaryInitialMoney1990Text.text = "Initial Money: $" + initialMoney1990;
        summaryGender1990Text.text = "Gender Status: " + genderSelected;
        summaryRace1990Text.text = "Racial Status: " + raceSelected;
        summaryEducation1990Text.text = "Education Status: " + educationSelected;
        summaryJob1990Text.text = "Employment Status: " + jobSelected;
        summaryJobPay1990Text.text = " - Hourly Pay: $" + hourlyRate1990;
        summaryHousing1990Text.text = "Housing Status: " + housingSelected;
        if (basicHouse == false && luxuryHouse == false)
        {
            summaryHousingRent1990Text.text = " - Monthly Rent: $" + rentCost1990;
        }
        else if (basicHouse == true || luxuryHouse == true)
        {
            summaryHousingRent1990Text.text = " - Monthly Mortgage: $" + mortgageCost1990;
        }
        summaryUtilities1990Text.text = "Utilities Selected: " + utilityCommunications1990Selected + ", " + utilityEntertainment1990Selected + ", " + utilityInternet1990Selected;
        summaryUtilitiesCost1990Text.text = " - Monthly Utilities: $" + utilitiesCost1990;
        summaryTransportation1990Text.text = "Transportation Status: " + transportationSelected;
        summaryTransportationCost1990Text.text = " - Weekly Transportation Cost: $" + transportationCost1990;
        summaryGift1990Text.text = "Gift Received: $" + giftMoney;
        summaryCurrentMoney1990Text.text = "Current Money: $" + currentMoney1990;
    }
    public void ToIntroSummaryScreen2020()
    {
        forwardButtonClickAudioSource.Play();
        
        introSummaryScreen.SetActive(false);

        introSummary1990Screen.SetActive(false);
        introSummary2020Screen.SetActive(true);
        IntroSummary2020();
    }
    public void IntroSummary2020()
    {
        summaryInitialMoney2020Text.text = "Initial Money: $" + initialMoney2020;
        summaryGender2020Text.text = "Gender Status: " + genderSelected;
        summaryRace2020Text.text = "Racial Status: " + raceSelected;
        summaryEducation2020Text.text = "Education Status: " + educationSelected;
        summaryJob2020Text.text = "Employment Status: " + jobSelected;
        summaryJobPay2020Text.text = " - Hourly Pay: $" + hourlyRate2020;
        summaryHousing2020Text.text = "Housing Status: " + housingSelected;
        if (basicHouse == false && luxuryHouse == false)
        {
            summaryHousingRent2020Text.text = " - Monthly Rent: $" + rentCost2020;
        }
        else if (basicHouse == true || luxuryHouse == true)
        {
            summaryHousingRent2020Text.text = " - Monthly Mortgage: $" + mortgageCost2020;
        }
        summaryUtilities2020Text.text = "Utilities Selected: " + utilityCommunications2020Selected + ", " + utilityEntertainment2020Selected + ", " + utilityInternet2020Selected;
        summaryUtilitiesCost2020Text.text = " - Monthly Utilities: $" + utilitiesCost2020;
        summaryTransportation2020Text.text = "Transportation Status: " + transportationSelected;
        summaryTransportationCost2020Text.text = " - Weekly Transportation Cost: $" + transportationCost2020;
        summaryGift2020Text.text = "Gift Received: $" + giftMoney;
        summaryCurrentMoney2020Text.text = "Current Money: $" + currentMoney2020;
    }
    public void ReturnToSummaryScreen()
    {
        backwardsButtonClickAudioSource.Play();
        
        introSummaryScreen.SetActive(true);

        introSummary1990Screen.SetActive(false);
        introSummary2020Screen.SetActive(false);
    }





    
    // Simulation Functions
    // Simulation Functions - Move to Simulation
    public void ToStartScreen()
    {
        simulationSection.SetActive(true);
        simulationStartScreen.SetActive(true);

        introductionBackgroundAudioSource.Stop();

        introSummaryScreen.SetActive(false);
        introductionSection.SetActive(false);
    }
    // Simulation Functions - Start
    public void StartSimulation()
    {
        playButtonClickAudioSource.Play();

        simulationStartScreen.SetActive(false);

        mainSimulationScreen.SetActive(true);

        m1w++;
        m2w++;
        m3w++;

        introductionBackgroundAudioSource.Stop();

        RandomEventCounter = 0;

        // Sets Background Music
        if (m1w == 1 || m2w == 1 || m3w == 1)
        {
            week01BackgroundAudioSource.Play();
        }
        else if (m1w == 2 || m2w == 2 || m3w == 2)
        {
            week02BackgroundAudioSource.Play();
        }
        else if (m1w == 3 || m2w == 3 || m3w == 3)
        {
            week03BackgroundAudioSource.Play();
        }
        else if (m1w == 4 || m2w == 4 || m3w == 4)
        {
            week04BackgroundAudioSource.Play();
        }

        MainSimulationIteration1();
        MainSimulationStatus();
    }
    // Simulation Functions - Pause Menu
    public void ToPauseSimulation()
    {
        forwardButtonClickAudioSource.Play();
        week01BackgroundAudioSource.Pause();
        week02BackgroundAudioSource.Pause();
        week03BackgroundAudioSource.Pause();
        week04BackgroundAudioSource.Pause();
        
        pauseMenuScreen.SetActive(true);
    }
    public void ToResumeSimulation()
    {
        backwardsButtonClickAudioSource.Play();
        week01BackgroundAudioSource.UnPause();
        week02BackgroundAudioSource.UnPause();
        week03BackgroundAudioSource.UnPause();
        week04BackgroundAudioSource.UnPause();
        
        pauseMenuScreen.SetActive(false);
    }
    public void ToQuitSimulation()
    {
        forwardButtonClickAudioSource.Play();

        introductionBackgroundAudioSource.Stop();
        week01BackgroundAudioSource.Stop();
        week02BackgroundAudioSource.Stop();
        week03BackgroundAudioSource.Stop();
        week04BackgroundAudioSource.Stop();
        summaryBackgroundAudioSource.Stop();
        
        SceneManager.LoadScene("MainMenu");
    }

    // Simulation Functions - Tasks
    public void ToTasks()
    {
        forwardButtonClickAudioSource.Play();
        
        tasksScreen.SetActive(true);

        //Tasks();
    }
    public void Tasks()
    {

    }
    
    // Simulation Functions - Player Stats
    public void ToPlayerStats1990()
    {
        forwardButtonClickAudioSource.Play();
        
        playerStats1990Screen.SetActive(true);

        PlayerStats1990();
    }
    public void PlayerStats1990()
    {
        playerStats1990GenderText.text = "Gender: " + genderSelected;
        playerStats1990RaceText.text = "Race: " + raceSelected;
        playerStats1990EducationText.text = "Education: " + educationSelected;
        playerStats1990EmploymentText.text = "Employment: " + jobSelected;
        playerStats1990PayText.text = "Hourly Wage: " + hourlyRate1990 + "/hour";
        playerStats1990HousingText.text = "Housing: " + housingSelected;
        playerStats1990TransportationText.text = "Transportation: " + transportationSelected;
    }
    public void ToPlayerStats2020()
    {
        forwardButtonClickAudioSource.Play();
        
        playerStats2020Screen.SetActive(true);

        PlayerStats2020();
    }
    public void PlayerStats2020()
    {
        playerStats2020GenderText.text = "Gender: " + genderSelected;
        playerStats2020RaceText.text = "Race: " + raceSelected;
        playerStats2020EducationText.text = "Education: " + educationSelected;
        playerStats2020EmploymentText.text = "Employment: " + jobSelected;
        playerStats2020PayText.text = "Hourly Wage: " + hourlyRate2020 + "/hour";
        playerStats2020HousingText.text = "Housing: " + housingSelected;
        playerStats2020TransportationText.text = "Transportation: " + transportationSelected;
    }
    public void BackToSimulation()
    {
        backwardsButtonClickAudioSource.Play();
        
        playerStats1990Screen.SetActive(false);
        playerStats2020Screen.SetActive(false);
        tasksScreen.SetActive(false);
    }

    // Simulation Functions - Main Iteration
    public void MainSimulationIteration()
    {
        // Quarter Cycle
        for (i = 1; i < 4; i++)
        {
            // Establishing & Resetting Variables Each Quarter
            switch(i)
            {
                case 1:
                    quarterNumber = 1;
                    quarterTitle = "Quarter 01";
                    quarterTitleText.text = quarterTitle;
                    quarterSummaryTitleText.text = quarterTitle + " Summary";
                    break;
                case 2:
                    quarterNumber = 2;
                    quarterTitle = "Quarter 02";
                    quarterTitleText.text = quarterTitle;
                    quarterSummaryTitleText.text = quarterTitle + " Summary";
                    break;
                case 3:
                    quarterNumber = 3;
                    quarterTitle = "Quarter 03";
                    quarterTitleText.text = quarterTitle;
                    quarterSummaryTitleText.text = quarterTitle + " Summary";
                    break;
                case 4:
                    quarterNumber = 4;
                    quarterTitle = "Quarter 04";
                    quarterTitleText.text = quarterTitle;
                    quarterSummaryTitleText.text = quarterTitle + " Summary";
                    break;
            }

            quarterNumber = i;

            // Month Cycle
            for (i = 1; i < 4; i++)
            {
                // Establishing & Resetting Variables Each Month
                switch (i)
                {
                    case 1:
                        monthNumber = 1;
                        monthTitle = "Month 01";
                        monthTitleText.text = monthTitle;
                        monthSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + "Summary";

                        rentDue = true;
                        utilitiesDue = true;
                        electricityDue = true;
                        waterDue = true;
                        communicationsDue = true;
                        entertainmentDue = true;
                        internetDue = true;

                        break;
                    case 2:
                        monthNumber = 2;
                        monthTitle = "Month 02";
                        monthTitleText.text = monthTitle;
                        monthSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + "Summary";

                        rentDue = true;
                        utilitiesDue = true;
                        electricityDue = true;
                        waterDue = true;
                        communicationsDue = true;
                        entertainmentDue = true;
                        internetDue = true;

                        break;
                    case 3:
                        monthNumber = 3;
                        monthTitle = "Month 03";
                        monthTitleText.text = monthTitle;
                        monthSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + "Summary";

                        rentDue = true;
                        utilitiesDue = true;
                        electricityDue = true;
                        waterDue = true;
                        communicationsDue = true;
                        entertainmentDue = true;
                        internetDue = true;

                        break;
                }

                monthNumber = i;

                // Week Cycle
                for (j = 1; j < 5; j++)
                {
                    // Establishing & Resetting Variables Each Week
                    switch (j)
                    {
                        case 1:
                            weekNumber = 1;
                            weekTitle = "Week 01";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";

                            payDayNow = true;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;

                            toWeekSummaryButton.SetActive(false);
                            //toPayDayButton.SetActive(true);
                            payDayScreen1.SetActive(true);
                            toPayHousingButton.SetActive(true);
                            toPayUtilitiesButton.SetActive(true);
                            toPayGroceriesButton.SetActive(true);
                            toPayTransportationButton.SetActive(true);

                            toPayUtilitiesElectricityButton.SetActive(true);
                            toPayUtilitiesWaterButton.SetActive(true);
                            toPayUtilitiesCommunicationsButton.SetActive(true);
                            toPayUtilitiesEntertainmentButton.SetActive(true);
                            toPayUtilitiesInternetButton.SetActive(true);

                            break;
                        case 2:
                            weekNumber = 2;
                            weekTitle = "Week 02";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";

                            payDayNow = false;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;

                            toWeekSummaryButton.SetActive(false);
                            //toPayDayButton.SetActive(false);
                            payDayScreen1.SetActive(false);
                            toPayHousingButton.SetActive(false);
                            //toPayUtilitiesButton.SetActive(true);
                            toPayGroceriesButton.SetActive(true);
                            toPayTransportationButton.SetActive(true);
                            
                            break;
                        case 3:
                            weekNumber = 3;
                            weekTitle = "Week 03";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";
                            
                            payDayNow = true;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;

                            toWeekSummaryButton.SetActive(false);
                            //toPayDayButton.SetActive(true);
                            payDayScreen1.SetActive(true);
                            toPayHousingButton.SetActive(false);
                            //toPayUtilitiesButton.SetActive(true);
                            toPayGroceriesButton.SetActive(true);
                            toPayTransportationButton.SetActive(true);

                            break;
                        case 4:
                            weekNumber = 4;
                            weekTitle = "Week 04";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";

                            payDayNow = false;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;
                            
                            toWeekSummaryButton.SetActive(false);
                            //toPayDayButton.SetActive(false);
                            payDayScreen1.SetActive(false);
                            toPayHousingButton.SetActive(false);
                            //toPayUtilitiesButton.SetActive(true);
                            toPayGroceriesButton.SetActive(true);
                            toPayTransportationButton.SetActive(true);

                            break;
                    }

                    weekNumber = j;
                }
            }
        }

        if (utilitiesDue == true)
        {
            toPayUtilitiesButton.SetActive(true);
        }
        else if (utilitiesDue == false)
        {
            toPayUtilitiesButton.SetActive(false);
        }

        if (groceriesDue == true)
        {
            toPayGroceriesButton.SetActive(true);
        }
        else if (groceriesDue == false)
        {
            toPayGroceriesButton.SetActive(false);
        }

        if (transportationDue == true)
        {
            toPayTransportationButton.SetActive(true);
        }
        else if (transportationDue == false)
        {
            toPayTransportationButton.SetActive(false);
        }
    }
    public void MainSimulationIteration1()
    {
        // Establishing & Resetting Variables Each Quarter
        switch (q)
        {
            case 1:
                quarterNumber = 1;
                quarterTitle = "Quarter 01";
                quarterTitleText.text = quarterTitle;
                quarterSummaryTitleText.text = quarterTitle + " Summary";

                // Establishing & Resetting Variables Each Month
                switch (m)
                {
                    case 1:
                        monthNumber = 1;
                        monthTitle = "Month 01";
                        monthTitleText.text = monthTitle;
                        monthSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + "Summary";

                        rentDue = true;
                        utilitiesDue = true;
                        electricityDue = true;
                        waterDue = true;
                        communicationsDue = true;
                        entertainmentDue = true;
                        internetDue = true;

                        // Establishing & Resetting Variables Each Week
                        switch (m1w)
                        {
                            case 1:
                                weekNumber = 1;
                                weekTitle = "Week 01";
                                weekTitleText.text = weekTitle;
                                weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";

                                payDayNow = true;
                                //rentDue = false;
                                //utilitiesDue = true;
                                groceriesDue = true;
                                transportationDue = true;
                                groceryComplete = false;
                                transportationComplete = false;

                                toWeekSummaryButton.SetActive(false);
                                //toPayDayButton.SetActive(true);
                                payDayScreen1.SetActive(true);
                                toPayHousingButton.SetActive(true);
                                toPayUtilitiesButton.SetActive(true);
                                toPayGroceriesButton.SetActive(true);
                                toPayTransportationButton.SetActive(true);

                                toPayUtilitiesElectricityButton.SetActive(true);
                                toPayUtilitiesWaterButton.SetActive(true);
                                toPayUtilitiesCommunicationsButton.SetActive(true);
                                toPayUtilitiesEntertainmentButton.SetActive(true);
                                toPayUtilitiesInternetButton.SetActive(true);

                                break;
                            case 2:
                                weekNumber = 2;
                                weekTitle = "Week 02";
                                weekTitleText.text = weekTitle;
                                weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";

                                payDayNow = false;
                                //rentDue = false;
                                //utilitiesDue = true;
                                groceriesDue = true;
                                transportationDue = true;
                                groceryComplete = false;
                                transportationComplete = false;

                                toWeekSummaryButton.SetActive(false);
                                //toPayDayButton.SetActive(false);
                                payDayScreen1.SetActive(false);
                                toPayHousingButton.SetActive(false);
                                //toPayUtilitiesButton.SetActive(true);
                                toPayGroceriesButton.SetActive(true);
                                toPayTransportationButton.SetActive(true);
                                
                                break;
                            case 3:
                                weekNumber = 3;
                                weekTitle = "Week 03";
                                weekTitleText.text = weekTitle;
                                weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";
                                
                                payDayNow = true;
                                //rentDue = false;
                                //utilitiesDue = true;
                                groceriesDue = true;
                                transportationDue = true;
                                groceryComplete = false;
                                transportationComplete = false;

                                toWeekSummaryButton.SetActive(false);
                                //toPayDayButton.SetActive(true);
                                payDayScreen1.SetActive(true);
                                toPayHousingButton.SetActive(false);
                                //toPayUtilitiesButton.SetActive(true);
                                toPayGroceriesButton.SetActive(true);
                                toPayTransportationButton.SetActive(true);

                                break;
                            case 4:
                                weekNumber = 4;
                                weekTitle = "Week 04";
                                weekTitleText.text = weekTitle;
                                weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";

                                payDayNow = false;
                                //rentDue = false;
                                //utilitiesDue = true;
                                groceriesDue = true;
                                transportationDue = true;
                                groceryComplete = false;
                                transportationComplete = false;

                                toWeekSummaryButton.SetActive(false);
                                //toPayDayButton.SetActive(false);
                                payDayScreen1.SetActive(false);
                                toPayHousingButton.SetActive(false);
                                //toPayUtilitiesButton.SetActive(true);
                                toPayGroceriesButton.SetActive(true);
                                toPayTransportationButton.SetActive(true);

                                break;
                        }

                        break;
                    case 2:
                        monthNumber = 2;
                        monthTitle = "Month 02";
                        monthTitleText.text = monthTitle;
                        monthSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + "Summary";

                        rentDue = true;
                        utilitiesDue = true;
                        electricityDue = true;
                        waterDue = true;
                        communicationsDue = true;
                        entertainmentDue = true;
                        internetDue = true;

                        // Establishing & Resetting Variables Each Week
                        switch (m2w)
                        {
                            case 1:
                                weekNumber = 1;
                                weekTitle = "Week 01";
                                weekTitleText.text = weekTitle;
                                weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";

                                payDayNow = true;
                                //rentDue = false;
                                //utilitiesDue = true;
                                groceriesDue = true;
                                transportationDue = true;
                                groceryComplete = false;
                                transportationComplete = false;

                                toWeekSummaryButton.SetActive(false);
                                //toPayDayButton.SetActive(true);
                                payDayScreen1.SetActive(true);
                                toPayHousingButton.SetActive(true);
                                toPayUtilitiesButton.SetActive(true);
                                toPayGroceriesButton.SetActive(true);
                                toPayTransportationButton.SetActive(true);

                                toPayUtilitiesElectricityButton.SetActive(true);
                                toPayUtilitiesWaterButton.SetActive(true);
                                toPayUtilitiesCommunicationsButton.SetActive(true);
                                toPayUtilitiesEntertainmentButton.SetActive(true);
                                toPayUtilitiesInternetButton.SetActive(true);

                                break;
                            case 2:
                                weekNumber = 2;
                                weekTitle = "Week 02";
                                weekTitleText.text = weekTitle;
                                weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";

                                payDayNow = false;
                                //rentDue = false;
                                //utilitiesDue = true;
                                groceriesDue = true;
                                transportationDue = true;
                                groceryComplete = false;
                                transportationComplete = false;

                                toWeekSummaryButton.SetActive(false);
                                //toPayDayButton.SetActive(false);
                                payDayScreen1.SetActive(false);
                                toPayHousingButton.SetActive(false);
                                //toPayUtilitiesButton.SetActive(true);
                                toPayGroceriesButton.SetActive(true);
                                toPayTransportationButton.SetActive(true);
                                
                                break;
                            case 3:
                                weekNumber = 3;
                                weekTitle = "Week 03";
                                weekTitleText.text = weekTitle;
                                weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";
                                
                                payDayNow = true;
                                //rentDue = false;
                                //utilitiesDue = true;
                                groceriesDue = true;
                                transportationDue = true;
                                groceryComplete = false;
                                transportationComplete = false;

                                toWeekSummaryButton.SetActive(false);
                                //toPayDayButton.SetActive(true);
                                payDayScreen1.SetActive(true);
                                toPayHousingButton.SetActive(false);
                                //toPayUtilitiesButton.SetActive(true);
                                toPayGroceriesButton.SetActive(true);
                                toPayTransportationButton.SetActive(true);

                                break;
                            case 4:
                                weekNumber = 4;
                                weekTitle = "Week 04";
                                weekTitleText.text = weekTitle;
                                weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";

                                payDayNow = false;
                                //rentDue = false;
                                //utilitiesDue = true;
                                groceriesDue = true;
                                transportationDue = true;
                                groceryComplete = false;
                                transportationComplete = false;

                                toWeekSummaryButton.SetActive(false);
                                //toPayDayButton.SetActive(false);
                                payDayScreen1.SetActive(false);
                                toPayHousingButton.SetActive(false);
                                //toPayUtilitiesButton.SetActive(true);
                                toPayGroceriesButton.SetActive(true);
                                toPayTransportationButton.SetActive(true);

                                break;
                        }

                        break;
                    case 3:
                        monthNumber = 3;
                        monthTitle = "Month 03";
                        monthTitleText.text = monthTitle;
                        monthSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + "Summary";

                        rentDue = true;
                        utilitiesDue = true;
                        electricityDue = true;
                        waterDue = true;
                        communicationsDue = true;
                        entertainmentDue = true;
                        internetDue = true;

                        // Establishing & Resetting Variables Each Week
                        switch (m3w)
                        {
                            case 1:
                                weekNumber = 1;
                                weekTitle = "Week 01";
                                weekTitleText.text = weekTitle;
                                weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";

                                payDayNow = true;
                                //rentDue = false;
                                //utilitiesDue = true;
                                groceriesDue = true;
                                transportationDue = true;
                                groceryComplete = false;
                                transportationComplete = false;

                                toWeekSummaryButton.SetActive(false);
                                //toPayDayButton.SetActive(true);
                                payDayScreen1.SetActive(true);
                                toPayHousingButton.SetActive(true);
                                toPayUtilitiesButton.SetActive(true);
                                toPayGroceriesButton.SetActive(true);
                                toPayTransportationButton.SetActive(true);

                                toPayUtilitiesElectricityButton.SetActive(true);
                                toPayUtilitiesWaterButton.SetActive(true);
                                toPayUtilitiesCommunicationsButton.SetActive(true);
                                toPayUtilitiesEntertainmentButton.SetActive(true);
                                toPayUtilitiesInternetButton.SetActive(true);

                                break;
                            case 2:
                                weekNumber = 2;
                                weekTitle = "Week 02";
                                weekTitleText.text = weekTitle;
                                weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";

                                payDayNow = false;
                                //rentDue = false;
                                //utilitiesDue = true;
                                groceriesDue = true;
                                transportationDue = true;
                                groceryComplete = false;
                                transportationComplete = false;

                                toWeekSummaryButton.SetActive(false);
                                //toPayDayButton.SetActive(false);
                                payDayScreen1.SetActive(false);
                                toPayHousingButton.SetActive(false);
                                //toPayUtilitiesButton.SetActive(true);
                                toPayGroceriesButton.SetActive(true);
                                toPayTransportationButton.SetActive(true);
                                
                                break;
                            case 3:
                                weekNumber = 3;
                                weekTitle = "Week 03";
                                weekTitleText.text = weekTitle;
                                weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";
                                
                                payDayNow = true;
                                //rentDue = false;
                                //utilitiesDue = true;
                                groceriesDue = true;
                                transportationDue = true;
                                groceryComplete = false;
                                transportationComplete = false;

                                toWeekSummaryButton.SetActive(false);
                                //toPayDayButton.SetActive(true);
                                payDayScreen1.SetActive(true);
                                toPayHousingButton.SetActive(false);
                                //toPayUtilitiesButton.SetActive(true);
                                toPayGroceriesButton.SetActive(true);
                                toPayTransportationButton.SetActive(true);

                                break;
                            case 4:
                                weekNumber = 4;
                                weekTitle = "Week 04";
                                weekTitleText.text = weekTitle;
                                weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";

                                payDayNow = false;
                                //rentDue = false;
                                //utilitiesDue = true;
                                groceriesDue = true;
                                transportationDue = true;
                                groceryComplete = false;
                                transportationComplete = false;
                                
                                toWeekSummaryButton.SetActive(false);
                                //toPayDayButton.SetActive(false);
                                payDayScreen1.SetActive(false);
                                toPayHousingButton.SetActive(false);
                                //toPayUtilitiesButton.SetActive(true);
                                toPayGroceriesButton.SetActive(true);
                                toPayTransportationButton.SetActive(true);

                                break;
                        }

                        break;
                }

                break;
            case 2:
                quarterNumber = 2;
                quarterTitle = "Quarter 02";
                quarterTitleText.text = quarterTitle;
                quarterSummaryTitleText.text = quarterTitle + " Summary";

                // Establishing & Resetting Variables Each Month
                switch (m)
                {
                    case 1:
                        monthNumber = 1;
                        monthTitle = "Month 01";
                        monthTitleText.text = monthTitle;
                        monthSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + "Summary";

                        rentDue = true;
                        utilitiesDue = true;
                        electricityDue = true;
                        waterDue = true;
                        communicationsDue = true;
                        entertainmentDue = true;
                        internetDue = true;

                        // Establishing & Resetting Variables Each Week
                        switch (m1w)
                        {
                            case 1:
                                weekNumber = 1;
                                weekTitle = "Week 01";
                                weekTitleText.text = weekTitle;
                                weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";

                                payDayNow = true;
                                //rentDue = false;
                                //utilitiesDue = true;
                                groceriesDue = true;
                                transportationDue = true;
                                groceryComplete = false;
                                transportationComplete = false;

                                toWeekSummaryButton.SetActive(false);
                                //toPayDayButton.SetActive(true);
                                payDayScreen1.SetActive(true);
                                toPayHousingButton.SetActive(true);
                                toPayUtilitiesButton.SetActive(true);
                                toPayGroceriesButton.SetActive(true);
                                toPayTransportationButton.SetActive(true);

                                toPayUtilitiesElectricityButton.SetActive(true);
                                toPayUtilitiesWaterButton.SetActive(true);
                                toPayUtilitiesCommunicationsButton.SetActive(true);
                                toPayUtilitiesEntertainmentButton.SetActive(true);
                                toPayUtilitiesInternetButton.SetActive(true);

                                break;
                            case 2:
                                weekNumber = 2;
                                weekTitle = "Week 02";
                                weekTitleText.text = weekTitle;
                                weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";

                                payDayNow = false;
                                //rentDue = false;
                                //utilitiesDue = true;
                                groceriesDue = true;
                                transportationDue = true;
                                groceryComplete = false;
                                transportationComplete = false;

                                toWeekSummaryButton.SetActive(false);
                                //toPayDayButton.SetActive(false);
                                payDayScreen1.SetActive(false);
                                toPayHousingButton.SetActive(false);
                                //toPayUtilitiesButton.SetActive(true);
                                toPayGroceriesButton.SetActive(true);
                                toPayTransportationButton.SetActive(true);
                                
                                break;
                            case 3:
                                weekNumber = 3;
                                weekTitle = "Week 03";
                                weekTitleText.text = weekTitle;
                                weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";
                                
                                payDayNow = true;
                                //rentDue = false;
                                //utilitiesDue = true;
                                groceriesDue = true;
                                transportationDue = true;
                                groceryComplete = false;
                                transportationComplete = false;

                                toWeekSummaryButton.SetActive(false);
                                //toPayDayButton.SetActive(true);
                                payDayScreen1.SetActive(true);
                                toPayHousingButton.SetActive(false);
                                //toPayUtilitiesButton.SetActive(true);
                                toPayGroceriesButton.SetActive(true);
                                toPayTransportationButton.SetActive(true);

                                break;
                            case 4:
                                weekNumber = 4;
                                weekTitle = "Week 04";
                                weekTitleText.text = weekTitle;
                                weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";

                                payDayNow = false;
                                //rentDue = false;
                                //utilitiesDue = true;
                                groceriesDue = true;
                                transportationDue = true;
                                groceryComplete = false;
                                transportationComplete = false;

                                toWeekSummaryButton.SetActive(false);
                                //toPayDayButton.SetActive(false);
                                payDayScreen1.SetActive(false);
                                toPayHousingButton.SetActive(false);
                                //toPayUtilitiesButton.SetActive(true);
                                toPayGroceriesButton.SetActive(true);
                                toPayTransportationButton.SetActive(true);

                                break;
                        }

                        break;
                    case 2:
                        monthNumber = 2;
                        monthTitle = "Month 02";
                        monthTitleText.text = monthTitle;
                        monthSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + "Summary";

                        rentDue = true;
                        utilitiesDue = true;
                        electricityDue = true;
                        waterDue = true;
                        communicationsDue = true;
                        entertainmentDue = true;
                        internetDue = true;

                        // Establishing & Resetting Variables Each Week
                        switch (m2w)
                        {
                            case 1:
                                weekNumber = 1;
                                weekTitle = "Week 01";
                                weekTitleText.text = weekTitle;
                                weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";

                                payDayNow = true;
                                //rentDue = false;
                                //utilitiesDue = true;
                                groceriesDue = true;
                                transportationDue = true;
                                groceryComplete = false;
                                transportationComplete = false;

                                toWeekSummaryButton.SetActive(false);
                                //toPayDayButton.SetActive(true);
                                payDayScreen1.SetActive(true);
                                toPayHousingButton.SetActive(true);
                                toPayUtilitiesButton.SetActive(true);
                                toPayGroceriesButton.SetActive(true);
                                toPayTransportationButton.SetActive(true);

                                toPayUtilitiesElectricityButton.SetActive(true);
                                toPayUtilitiesWaterButton.SetActive(true);
                                toPayUtilitiesCommunicationsButton.SetActive(true);
                                toPayUtilitiesEntertainmentButton.SetActive(true);
                                toPayUtilitiesInternetButton.SetActive(true);

                                break;
                            case 2:
                                weekNumber = 2;
                                weekTitle = "Week 02";
                                weekTitleText.text = weekTitle;
                                weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";

                                payDayNow = false;
                                //rentDue = false;
                                //utilitiesDue = true;
                                groceriesDue = true;
                                transportationDue = true;
                                groceryComplete = false;
                                transportationComplete = false;

                                toWeekSummaryButton.SetActive(false);
                                //toPayDayButton.SetActive(false);
                                payDayScreen1.SetActive(false);
                                toPayHousingButton.SetActive(false);
                                //toPayUtilitiesButton.SetActive(true);
                                toPayGroceriesButton.SetActive(true);
                                toPayTransportationButton.SetActive(true);
                                
                                break;
                            case 3:
                                weekNumber = 3;
                                weekTitle = "Week 03";
                                weekTitleText.text = weekTitle;
                                weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";
                                
                                payDayNow = true;
                                //rentDue = false;
                                //utilitiesDue = true;
                                groceriesDue = true;
                                transportationDue = true;
                                groceryComplete = false;
                                transportationComplete = false;

                                toWeekSummaryButton.SetActive(false);
                                //toPayDayButton.SetActive(true);
                                payDayScreen1.SetActive(true);
                                toPayHousingButton.SetActive(false);
                                //toPayUtilitiesButton.SetActive(true);
                                toPayGroceriesButton.SetActive(true);
                                toPayTransportationButton.SetActive(true);

                                break;
                            case 4:
                                weekNumber = 4;
                                weekTitle = "Week 04";
                                weekTitleText.text = weekTitle;
                                weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";

                                payDayNow = false;
                                //rentDue = false;
                                //utilitiesDue = true;
                                groceriesDue = true;
                                transportationDue = true;
                                groceryComplete = false;
                                transportationComplete = false;

                                toWeekSummaryButton.SetActive(false);
                                //toPayDayButton.SetActive(false);
                                payDayScreen1.SetActive(false);
                                toPayHousingButton.SetActive(false);
                                //toPayUtilitiesButton.SetActive(true);
                                toPayGroceriesButton.SetActive(true);
                                toPayTransportationButton.SetActive(true);

                                break;
                        }

                        break;
                    case 3:
                        monthNumber = 3;
                        monthTitle = "Month 03";
                        monthTitleText.text = monthTitle;
                        monthSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + "Summary";

                        rentDue = true;
                        utilitiesDue = true;
                        electricityDue = true;
                        waterDue = true;
                        communicationsDue = true;
                        entertainmentDue = true;
                        internetDue = true;

                        // Establishing & Resetting Variables Each Week
                        switch (m3w)
                        {
                            case 1:
                                weekNumber = 1;
                                weekTitle = "Week 01";
                                weekTitleText.text = weekTitle;
                                weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";

                                payDayNow = true;
                                //rentDue = false;
                                //utilitiesDue = true;
                                groceriesDue = true;
                                transportationDue = true;
                                groceryComplete = false;
                                transportationComplete = false;

                                toWeekSummaryButton.SetActive(false);
                                //toPayDayButton.SetActive(true);
                                payDayScreen1.SetActive(true);
                                toPayHousingButton.SetActive(true);
                                toPayUtilitiesButton.SetActive(true);
                                toPayGroceriesButton.SetActive(true);
                                toPayTransportationButton.SetActive(true);

                                toPayUtilitiesElectricityButton.SetActive(true);
                                toPayUtilitiesWaterButton.SetActive(true);
                                toPayUtilitiesCommunicationsButton.SetActive(true);
                                toPayUtilitiesEntertainmentButton.SetActive(true);
                                toPayUtilitiesInternetButton.SetActive(true);

                                break;
                            case 2:
                                weekNumber = 2;
                                weekTitle = "Week 02";
                                weekTitleText.text = weekTitle;
                                weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";

                                payDayNow = false;
                                //rentDue = false;
                                //utilitiesDue = true;
                                groceriesDue = true;
                                transportationDue = true;
                                groceryComplete = false;
                                transportationComplete = false;

                                toWeekSummaryButton.SetActive(false);
                                //toPayDayButton.SetActive(false);
                                payDayScreen1.SetActive(false);
                                toPayHousingButton.SetActive(false);
                                //toPayUtilitiesButton.SetActive(true);
                                toPayGroceriesButton.SetActive(true);
                                toPayTransportationButton.SetActive(true);
                                
                                break;
                            case 3:
                                weekNumber = 3;
                                weekTitle = "Week 03";
                                weekTitleText.text = weekTitle;
                                weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";
                                
                                payDayNow = true;
                                //rentDue = false;
                                //utilitiesDue = true;
                                groceriesDue = true;
                                transportationDue = true;
                                groceryComplete = false;
                                transportationComplete = false;

                                toWeekSummaryButton.SetActive(false);
                                //toPayDayButton.SetActive(true);
                                payDayScreen1.SetActive(true);
                                toPayHousingButton.SetActive(false);
                                //toPayUtilitiesButton.SetActive(true);
                                toPayGroceriesButton.SetActive(true);
                                toPayTransportationButton.SetActive(true);

                                break;
                            case 4:
                                weekNumber = 4;
                                weekTitle = "Week 04";
                                weekTitleText.text = weekTitle;
                                weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";

                                payDayNow = false;
                                //rentDue = false;
                                //utilitiesDue = true;
                                groceriesDue = true;
                                transportationDue = true;
                                groceryComplete = false;
                                transportationComplete = false;
                                
                                toWeekSummaryButton.SetActive(false);
                                //toPayDayButton.SetActive(false);
                                payDayScreen1.SetActive(false);
                                toPayHousingButton.SetActive(false);
                                //toPayUtilitiesButton.SetActive(true);
                                toPayGroceriesButton.SetActive(true);
                                toPayTransportationButton.SetActive(true);

                                break;
                        }

                        break;
                }

                break;
            case 3:
                quarterNumber = 3;
                quarterTitle = "Quarter 03";
                quarterTitleText.text = quarterTitle;
                quarterSummaryTitleText.text = quarterTitle + " Summary";

                // Establishing & Resetting Variables Each Month
                switch (m)
                {
                    case 1:
                        monthNumber = 1;
                        monthTitle = "Month 01";
                        monthTitleText.text = monthTitle;
                        monthSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + "Summary";

                        rentDue = true;
                        utilitiesDue = true;
                        electricityDue = true;
                        waterDue = true;
                        communicationsDue = true;
                        entertainmentDue = true;
                        internetDue = true;

                        // Establishing & Resetting Variables Each Week
                        switch (m1w)
                        {
                            case 1:
                                weekNumber = 1;
                                weekTitle = "Week 01";
                                weekTitleText.text = weekTitle;
                                weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";

                                payDayNow = true;
                                //rentDue = false;
                                //utilitiesDue = true;
                                groceriesDue = true;
                                transportationDue = true;
                                groceryComplete = false;
                                transportationComplete = false;

                                toWeekSummaryButton.SetActive(false);
                                //toPayDayButton.SetActive(true);
                                payDayScreen1.SetActive(true);
                                toPayHousingButton.SetActive(true);
                                toPayUtilitiesButton.SetActive(true);
                                toPayGroceriesButton.SetActive(true);
                                toPayTransportationButton.SetActive(true);

                                toPayUtilitiesElectricityButton.SetActive(true);
                                toPayUtilitiesWaterButton.SetActive(true);
                                toPayUtilitiesCommunicationsButton.SetActive(true);
                                toPayUtilitiesEntertainmentButton.SetActive(true);
                                toPayUtilitiesInternetButton.SetActive(true);

                                break;
                            case 2:
                                weekNumber = 2;
                                weekTitle = "Week 02";
                                weekTitleText.text = weekTitle;
                                weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";

                                payDayNow = false;
                                //rentDue = false;
                                //utilitiesDue = true;
                                groceriesDue = true;
                                transportationDue = true;
                                groceryComplete = false;
                                transportationComplete = false;

                                toWeekSummaryButton.SetActive(false);
                                //toPayDayButton.SetActive(false);
                                payDayScreen1.SetActive(false);
                                toPayHousingButton.SetActive(false);
                                //toPayUtilitiesButton.SetActive(true);
                                toPayGroceriesButton.SetActive(true);
                                toPayTransportationButton.SetActive(true);
                                
                                break;
                            case 3:
                                weekNumber = 3;
                                weekTitle = "Week 03";
                                weekTitleText.text = weekTitle;
                                weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";
                                
                                payDayNow = true;
                                //rentDue = false;
                                //utilitiesDue = true;
                                groceriesDue = true;
                                transportationDue = true;
                                groceryComplete = false;
                                transportationComplete = false;

                                toWeekSummaryButton.SetActive(false);
                                //toPayDayButton.SetActive(true);
                                payDayScreen1.SetActive(true);
                                toPayHousingButton.SetActive(false);
                                //toPayUtilitiesButton.SetActive(true);
                                toPayGroceriesButton.SetActive(true);
                                toPayTransportationButton.SetActive(true);

                                break;
                            case 4:
                                weekNumber = 4;
                                weekTitle = "Week 04";
                                weekTitleText.text = weekTitle;
                                weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";

                                payDayNow = false;
                                //rentDue = false;
                                //utilitiesDue = true;
                                groceriesDue = true;
                                transportationDue = true;
                                groceryComplete = false;
                                transportationComplete = false;

                                toWeekSummaryButton.SetActive(false);
                                //toPayDayButton.SetActive(false);
                                payDayScreen1.SetActive(false);
                                toPayHousingButton.SetActive(false);
                                //toPayUtilitiesButton.SetActive(true);
                                toPayGroceriesButton.SetActive(true);
                                toPayTransportationButton.SetActive(true);

                                break;
                        }

                        break;
                    case 2:
                        monthNumber = 2;
                        monthTitle = "Month 02";
                        monthTitleText.text = monthTitle;
                        monthSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + "Summary";

                        rentDue = true;
                        utilitiesDue = true;
                        electricityDue = true;
                        waterDue = true;
                        communicationsDue = true;
                        entertainmentDue = true;
                        internetDue = true;

                        // Establishing & Resetting Variables Each Week
                        switch (m2w)
                        {
                            case 1:
                                weekNumber = 1;
                                weekTitle = "Week 01";
                                weekTitleText.text = weekTitle;
                                weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";

                                payDayNow = true;
                                //rentDue = false;
                                //utilitiesDue = true;
                                groceriesDue = true;
                                transportationDue = true;
                                groceryComplete = false;
                                transportationComplete = false;

                                toWeekSummaryButton.SetActive(false);
                                //toPayDayButton.SetActive(true);
                                payDayScreen1.SetActive(true);
                                toPayHousingButton.SetActive(true);
                                toPayUtilitiesButton.SetActive(true);
                                toPayGroceriesButton.SetActive(true);
                                toPayTransportationButton.SetActive(true);

                                toPayUtilitiesElectricityButton.SetActive(true);
                                toPayUtilitiesWaterButton.SetActive(true);
                                toPayUtilitiesCommunicationsButton.SetActive(true);
                                toPayUtilitiesEntertainmentButton.SetActive(true);
                                toPayUtilitiesInternetButton.SetActive(true);

                                break;
                            case 2:
                                weekNumber = 2;
                                weekTitle = "Week 02";
                                weekTitleText.text = weekTitle;
                                weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";

                                payDayNow = false;
                                //rentDue = false;
                                //utilitiesDue = true;
                                groceriesDue = true;
                                transportationDue = true;
                                groceryComplete = false;
                                transportationComplete = false;

                                toWeekSummaryButton.SetActive(false);
                                //toPayDayButton.SetActive(false);
                                payDayScreen1.SetActive(false);
                                toPayHousingButton.SetActive(false);
                                //toPayUtilitiesButton.SetActive(true);
                                toPayGroceriesButton.SetActive(true);
                                toPayTransportationButton.SetActive(true);
                                
                                break;
                            case 3:
                                weekNumber = 3;
                                weekTitle = "Week 03";
                                weekTitleText.text = weekTitle;
                                weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";
                                
                                payDayNow = true;
                                //rentDue = false;
                                //utilitiesDue = true;
                                groceriesDue = true;
                                transportationDue = true;
                                groceryComplete = false;
                                transportationComplete = false;

                                toWeekSummaryButton.SetActive(false);
                                //toPayDayButton.SetActive(true);
                                payDayScreen1.SetActive(true);
                                toPayHousingButton.SetActive(false);
                                //toPayUtilitiesButton.SetActive(true);
                                toPayGroceriesButton.SetActive(true);
                                toPayTransportationButton.SetActive(true);

                                break;
                            case 4:
                                weekNumber = 4;
                                weekTitle = "Week 04";
                                weekTitleText.text = weekTitle;
                                weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";

                                payDayNow = false;
                                //rentDue = false;
                                //utilitiesDue = true;
                                groceriesDue = true;
                                transportationDue = true;
                                groceryComplete = false;
                                transportationComplete = false;

                                toWeekSummaryButton.SetActive(false);
                                //toPayDayButton.SetActive(false);
                                payDayScreen1.SetActive(false);
                                toPayHousingButton.SetActive(false);
                                //toPayUtilitiesButton.SetActive(true);
                                toPayGroceriesButton.SetActive(true);
                                toPayTransportationButton.SetActive(true);

                                break;
                        }

                        break;
                    case 3:
                        monthNumber = 3;
                        monthTitle = "Month 03";
                        monthTitleText.text = monthTitle;
                        monthSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + "Summary";

                        rentDue = true;
                        utilitiesDue = true;
                        electricityDue = true;
                        waterDue = true;
                        communicationsDue = true;
                        entertainmentDue = true;
                        internetDue = true;

                        // Establishing & Resetting Variables Each Week
                        switch (m3w)
                        {
                            case 1:
                                weekNumber = 1;
                                weekTitle = "Week 01";
                                weekTitleText.text = weekTitle;
                                weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";

                                payDayNow = true;
                                //rentDue = false;
                                //utilitiesDue = true;
                                groceriesDue = true;
                                transportationDue = true;
                                groceryComplete = false;
                                transportationComplete = false;

                                toWeekSummaryButton.SetActive(false);
                                //toPayDayButton.SetActive(true);
                                payDayScreen1.SetActive(true);
                                toPayHousingButton.SetActive(true);
                                toPayUtilitiesButton.SetActive(true);
                                toPayGroceriesButton.SetActive(true);
                                toPayTransportationButton.SetActive(true);

                                toPayUtilitiesElectricityButton.SetActive(true);
                                toPayUtilitiesWaterButton.SetActive(true);
                                toPayUtilitiesCommunicationsButton.SetActive(true);
                                toPayUtilitiesEntertainmentButton.SetActive(true);
                                toPayUtilitiesInternetButton.SetActive(true);

                                break;
                            case 2:
                                weekNumber = 2;
                                weekTitle = "Week 02";
                                weekTitleText.text = weekTitle;
                                weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";

                                payDayNow = false;
                                //rentDue = false;
                                //utilitiesDue = true;
                                groceriesDue = true;
                                transportationDue = true;
                                groceryComplete = false;
                                transportationComplete = false;

                                toWeekSummaryButton.SetActive(false);
                                //toPayDayButton.SetActive(false);
                                payDayScreen1.SetActive(false);
                                toPayHousingButton.SetActive(false);
                                //toPayUtilitiesButton.SetActive(true);
                                toPayGroceriesButton.SetActive(true);
                                toPayTransportationButton.SetActive(true);
                                
                                break;
                            case 3:
                                weekNumber = 3;
                                weekTitle = "Week 03";
                                weekTitleText.text = weekTitle;
                                weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";
                                
                                payDayNow = true;
                                //rentDue = false;
                                //utilitiesDue = true;
                                groceriesDue = true;
                                transportationDue = true;
                                groceryComplete = false;
                                transportationComplete = false;

                                toWeekSummaryButton.SetActive(false);
                                //toPayDayButton.SetActive(true);
                                payDayScreen1.SetActive(true);
                                toPayHousingButton.SetActive(false);
                                //toPayUtilitiesButton.SetActive(true);
                                toPayGroceriesButton.SetActive(true);
                                toPayTransportationButton.SetActive(true);

                                break;
                            case 4:
                                weekNumber = 4;
                                weekTitle = "Week 04";
                                weekTitleText.text = weekTitle;
                                weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";

                                payDayNow = false;
                                //rentDue = false;
                                //utilitiesDue = true;
                                groceriesDue = true;
                                transportationDue = true;
                                groceryComplete = false;
                                transportationComplete = false;
                                
                                toWeekSummaryButton.SetActive(false);
                                //toPayDayButton.SetActive(false);
                                payDayScreen1.SetActive(false);
                                toPayHousingButton.SetActive(false);
                                //toPayUtilitiesButton.SetActive(true);
                                toPayGroceriesButton.SetActive(true);
                                toPayTransportationButton.SetActive(true);

                                break;
                        }

                        break;
                }

                break;
            case 4:
                quarterNumber = 4;
                quarterTitle = "Quarter 04";
                quarterTitleText.text = quarterTitle;
                quarterSummaryTitleText.text = quarterTitle + " Summary";

                // Establishing & Resetting Variables Each Month
                switch (m)
                {
                    case 1:
                        monthNumber = 1;
                        monthTitle = "Month 01";
                        monthTitleText.text = monthTitle;
                        monthSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + "Summary";

                        rentDue = true;
                        utilitiesDue = true;
                        electricityDue = true;
                        waterDue = true;
                        communicationsDue = true;
                        entertainmentDue = true;
                        internetDue = true;

                        // Establishing & Resetting Variables Each Week
                        switch (m1w)
                        {
                            case 1:
                                weekNumber = 1;
                                weekTitle = "Week 01";
                                weekTitleText.text = weekTitle;
                                weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";

                                payDayNow = true;
                                //rentDue = false;
                                //utilitiesDue = true;
                                groceriesDue = true;
                                transportationDue = true;
                                groceryComplete = false;
                                transportationComplete = false;

                                toWeekSummaryButton.SetActive(false);
                                //toPayDayButton.SetActive(true);
                                payDayScreen1.SetActive(true);
                                toPayHousingButton.SetActive(true);
                                toPayUtilitiesButton.SetActive(true);
                                toPayGroceriesButton.SetActive(true);
                                toPayTransportationButton.SetActive(true);

                                toPayUtilitiesElectricityButton.SetActive(true);
                                toPayUtilitiesWaterButton.SetActive(true);
                                toPayUtilitiesCommunicationsButton.SetActive(true);
                                toPayUtilitiesEntertainmentButton.SetActive(true);
                                toPayUtilitiesInternetButton.SetActive(true);

                                break;
                            case 2:
                                weekNumber = 2;
                                weekTitle = "Week 02";
                                weekTitleText.text = weekTitle;
                                weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";

                                payDayNow = false;
                                //rentDue = false;
                                //utilitiesDue = true;
                                groceriesDue = true;
                                transportationDue = true;
                                groceryComplete = false;
                                transportationComplete = false;

                                toWeekSummaryButton.SetActive(false);
                                //toPayDayButton.SetActive(false);
                                payDayScreen1.SetActive(false);
                                toPayHousingButton.SetActive(false);
                                //toPayUtilitiesButton.SetActive(true);
                                toPayGroceriesButton.SetActive(true);
                                toPayTransportationButton.SetActive(true);
                                
                                break;
                            case 3:
                                weekNumber = 3;
                                weekTitle = "Week 03";
                                weekTitleText.text = weekTitle;
                                weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";
                                
                                payDayNow = true;
                                //rentDue = false;
                                //utilitiesDue = true;
                                groceriesDue = true;
                                transportationDue = true;
                                groceryComplete = false;
                                transportationComplete = false;

                                toWeekSummaryButton.SetActive(false);
                                //toPayDayButton.SetActive(true);
                                payDayScreen1.SetActive(true);
                                toPayHousingButton.SetActive(false);
                                //toPayUtilitiesButton.SetActive(true);
                                toPayGroceriesButton.SetActive(true);
                                toPayTransportationButton.SetActive(true);

                                break;
                            case 4:
                                weekNumber = 4;
                                weekTitle = "Week 04";
                                weekTitleText.text = weekTitle;
                                weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";

                                payDayNow = false;
                                //rentDue = false;
                                //utilitiesDue = true;
                                groceriesDue = true;
                                transportationDue = true;
                                groceryComplete = false;
                                transportationComplete = false;

                                toWeekSummaryButton.SetActive(false);
                                //toPayDayButton.SetActive(false);
                                payDayScreen1.SetActive(false);
                                toPayHousingButton.SetActive(false);
                                //toPayUtilitiesButton.SetActive(true);
                                toPayGroceriesButton.SetActive(true);
                                toPayTransportationButton.SetActive(true);

                                break;
                        }

                        break;
                    case 2:
                        monthNumber = 2;
                        monthTitle = "Month 02";
                        monthTitleText.text = monthTitle;
                        monthSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + "Summary";

                        rentDue = true;
                        utilitiesDue = true;
                        electricityDue = true;
                        waterDue = true;
                        communicationsDue = true;
                        entertainmentDue = true;
                        internetDue = true;

                        // Establishing & Resetting Variables Each Week
                        switch (m2w)
                        {
                            case 1:
                                weekNumber = 1;
                                weekTitle = "Week 01";
                                weekTitleText.text = weekTitle;
                                weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";

                                payDayNow = true;
                                //rentDue = false;
                                //utilitiesDue = true;
                                groceriesDue = true;
                                transportationDue = true;
                                groceryComplete = false;
                                transportationComplete = false;

                                toWeekSummaryButton.SetActive(false);
                                //toPayDayButton.SetActive(true);
                                payDayScreen1.SetActive(true);
                                toPayHousingButton.SetActive(true);
                                toPayUtilitiesButton.SetActive(true);
                                toPayGroceriesButton.SetActive(true);
                                toPayTransportationButton.SetActive(true);

                                toPayUtilitiesElectricityButton.SetActive(true);
                                toPayUtilitiesWaterButton.SetActive(true);
                                toPayUtilitiesCommunicationsButton.SetActive(true);
                                toPayUtilitiesEntertainmentButton.SetActive(true);
                                toPayUtilitiesInternetButton.SetActive(true);

                                break;
                            case 2:
                                weekNumber = 2;
                                weekTitle = "Week 02";
                                weekTitleText.text = weekTitle;
                                weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";

                                payDayNow = false;
                                //rentDue = false;
                                //utilitiesDue = true;
                                groceriesDue = true;
                                transportationDue = true;
                                groceryComplete = false;
                                transportationComplete = false;

                                toWeekSummaryButton.SetActive(false);
                                //toPayDayButton.SetActive(false);
                                payDayScreen1.SetActive(false);
                                toPayHousingButton.SetActive(false);
                                //toPayUtilitiesButton.SetActive(true);
                                toPayGroceriesButton.SetActive(true);
                                toPayTransportationButton.SetActive(true);
                                
                                break;
                            case 3:
                                weekNumber = 3;
                                weekTitle = "Week 03";
                                weekTitleText.text = weekTitle;
                                weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";
                                
                                payDayNow = true;
                                //rentDue = false;
                                //utilitiesDue = true;
                                groceriesDue = true;
                                transportationDue = true;
                                groceryComplete = false;
                                transportationComplete = false;

                                toWeekSummaryButton.SetActive(false);
                                //toPayDayButton.SetActive(true);
                                payDayScreen1.SetActive(true);
                                toPayHousingButton.SetActive(false);
                                //toPayUtilitiesButton.SetActive(true);
                                toPayGroceriesButton.SetActive(true);
                                toPayTransportationButton.SetActive(true);

                                break;
                            case 4:
                                weekNumber = 4;
                                weekTitle = "Week 04";
                                weekTitleText.text = weekTitle;
                                weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";

                                payDayNow = false;
                                //rentDue = false;
                                //utilitiesDue = true;
                                groceriesDue = true;
                                transportationDue = true;
                                groceryComplete = false;
                                transportationComplete = false;

                                toWeekSummaryButton.SetActive(false);
                                //toPayDayButton.SetActive(false);
                                payDayScreen1.SetActive(false);
                                toPayHousingButton.SetActive(false);
                                //toPayUtilitiesButton.SetActive(true);
                                toPayGroceriesButton.SetActive(true);
                                toPayTransportationButton.SetActive(true);

                                break;
                        }

                        break;
                    case 3:
                        monthNumber = 3;
                        monthTitle = "Month 03";
                        monthTitleText.text = monthTitle;
                        monthSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + "Summary";

                        rentDue = true;
                        utilitiesDue = true;
                        electricityDue = true;
                        waterDue = true;
                        communicationsDue = true;
                        entertainmentDue = true;
                        internetDue = true;

                        // Establishing & Resetting Variables Each Week
                        switch (m3w)
                        {
                            case 1:
                                weekNumber = 1;
                                weekTitle = "Week 01";
                                weekTitleText.text = weekTitle;
                                weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";

                                payDayNow = true;
                                //rentDue = false;
                                //utilitiesDue = true;
                                groceriesDue = true;
                                transportationDue = true;
                                groceryComplete = false;
                                transportationComplete = false;

                                toWeekSummaryButton.SetActive(false);
                                //toPayDayButton.SetActive(true);
                                payDayScreen1.SetActive(true);
                                toPayHousingButton.SetActive(true);
                                toPayUtilitiesButton.SetActive(true);
                                toPayGroceriesButton.SetActive(true);
                                toPayTransportationButton.SetActive(true);

                                toPayUtilitiesElectricityButton.SetActive(true);
                                toPayUtilitiesWaterButton.SetActive(true);
                                toPayUtilitiesCommunicationsButton.SetActive(true);
                                toPayUtilitiesEntertainmentButton.SetActive(true);
                                toPayUtilitiesInternetButton.SetActive(true);

                                break;
                            case 2:
                                weekNumber = 2;
                                weekTitle = "Week 02";
                                weekTitleText.text = weekTitle;
                                weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";

                                payDayNow = false;
                                //rentDue = false;
                                //utilitiesDue = true;
                                groceriesDue = true;
                                transportationDue = true;
                                groceryComplete = false;
                                transportationComplete = false;

                                toWeekSummaryButton.SetActive(false);
                                //toPayDayButton.SetActive(false);
                                payDayScreen1.SetActive(false);
                                toPayHousingButton.SetActive(false);
                                //toPayUtilitiesButton.SetActive(true);
                                toPayGroceriesButton.SetActive(true);
                                toPayTransportationButton.SetActive(true);
                                
                                break;
                            case 3:
                                weekNumber = 3;
                                weekTitle = "Week 03";
                                weekTitleText.text = weekTitle;
                                weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";
                                
                                payDayNow = true;
                                //rentDue = false;
                                //utilitiesDue = true;
                                groceriesDue = true;
                                transportationDue = true;
                                groceryComplete = false;
                                transportationComplete = false;

                                toWeekSummaryButton.SetActive(false);
                                //toPayDayButton.SetActive(true);
                                payDayScreen1.SetActive(true);
                                toPayHousingButton.SetActive(false);
                                //toPayUtilitiesButton.SetActive(true);
                                toPayGroceriesButton.SetActive(true);
                                toPayTransportationButton.SetActive(true);

                                break;
                            case 4:
                                weekNumber = 4;
                                weekTitle = "Week 04";
                                weekTitleText.text = weekTitle;
                                weekSummaryTitleText.text = quarterTitle + " - " + monthTitle + " - " + weekTitle + " Summary";

                                payDayNow = false;
                                //rentDue = false;
                                //utilitiesDue = true;
                                groceriesDue = true;
                                transportationDue = true;
                                groceryComplete = false;
                                transportationComplete = false;
                                
                                toWeekSummaryButton.SetActive(false);
                                //toPayDayButton.SetActive(false);
                                payDayScreen1.SetActive(false);
                                toPayHousingButton.SetActive(false);
                                //toPayUtilitiesButton.SetActive(true);
                                toPayGroceriesButton.SetActive(true);
                                toPayTransportationButton.SetActive(true);

                                break;
                        }

                        break;
                }

                break;
        }
        

        if (payDayNow == true)
        {
            toPayDayButton.SetActive(true);
        }
        else if (payDayNow == false)
        {
            toPayDayButton.SetActive(false);
        }

        //if (rentDue == true)
        //{
        //    toPayHousingButton.SetActive(true);
        //}
        //else if (rentDue == false)
        //{
        //    toPayHousingButton.SetActive(false);
        //}

        if (utilitiesDue == true)
        {
            toPayUtilitiesButton.SetActive(true);
        }
        else if (utilitiesDue == false)
        {
            toPayUtilitiesButton.SetActive(false);
        }

        if (groceriesDue == true)
        {
            toPayGroceriesButton.SetActive(true);
        }
        else if (groceriesDue == false)
        {
            toPayGroceriesButton.SetActive(false);
        }

        if (transportationDue == true)
        {
            toPayTransportationButton.SetActive(true);
        }
        else if (transportationDue == false)
        {
            toPayTransportationButton.SetActive(false);
        }
    }
    public void RandomEvents1()
    {
        randomEventsScreen1.SetActive(true);

        switch (RandomEventCounter)
        {
            case 1:
                randomEventNumber = UnityEngine.Random.Range(1, 18);
                //randomEventNumber = 14;

                RandomEventChecker();
                break;
            case 2:
                randomEventNumber = UnityEngine.Random.Range(1, 18);
                //randomEventNumber = 17;

                RandomEventChecker();
                break;
            case 3:
                randomEventNumber = UnityEngine.Random.Range(1, 18);
                //randomEventNumber = 18;

                RandomEventChecker();
                break;
        }
    }

    public void RandomEventChecker()
    {
        if (randomEventNumber == 1 && randomEvent01Selected == true)
        {
            RandomEvents1();
        }
        else if (randomEventNumber == 2 && randomEvent02Selected == true)
        {
            RandomEvents1();
        }
        else if (randomEventNumber == 3 && randomEvent03Selected == true)
        {
            RandomEvents1();
        }
        else if (randomEventNumber == 4 && randomEvent04Selected == true)
        {
            RandomEvents1();
        }
        else if (randomEventNumber == 5 && randomEvent05Selected == true)
        {
            RandomEvents1();
        }
        else if (randomEventNumber == 6 && randomEvent06Selected == true)
        {
            RandomEvents1();
        }
        else if (randomEventNumber == 7 && randomEvent07Selected == true)
        {
            RandomEvents1();
        }
        else if (randomEventNumber == 8 && randomEvent08Selected == true)
        {
            RandomEvents1();
        }
        else if (randomEventNumber == 9 && randomEvent09Selected == true)
        {
            RandomEvents1();
        }
        else if (randomEventNumber == 10 && randomEvent10Selected == true)
        {
            RandomEvents1();
        }
        else if (randomEventNumber == 11 && randomEvent11Selected == true)
        {
            RandomEvents1();
        }
        else if (randomEventNumber == 12)
        {
            RandomEvents1();
        }
        else if (randomEventNumber == 13 && randomEvent13Selected == true)
        {
            RandomEvents1();
        }
        else if (randomEventNumber == 14 && randomEvent14Selected == true)
        {
            RandomEvents1();
        }
        else if (randomEventNumber == 15 && randomEvent15Selected == true)
        {
            RandomEvents1();
        }
        else if (randomEventNumber == 16 && randomEvent16Selected == true)
        {
            RandomEvents1();
        }
        else if (randomEventNumber == 17 && randomEvent17Selected == true)
        {
            RandomEvents1();
        }
        else if (randomEventNumber == 18 && randomEvent18Selected == true)
        {
            RandomEvents1();
        }
        else if (randomEventNumber == 19 && randomEvent19Selected == true)
        {
            RandomEvents1();
        }
        else if (randomEventNumber == 20 && randomEvent20Selected == true)
        {
            RandomEvents1();
        }
        else if (randomEventNumber == 21 && randomEvent21Selected == true)
        {
            RandomEvents1();
        }
        else if (randomEventNumber == 22 && randomEvent22Selected == true)
        {
            RandomEvents1();
        }
        else if (randomEventNumber == 23 && randomEvent23Selected == true)
        {
            RandomEvents1();
        }
        else if (randomEventNumber == 24 && randomEvent24Selected == true)
        {
            RandomEvents1();
        }
        else if (randomEventNumber == 25 && randomEvent25Selected == true)
        {
            RandomEvents1();
        }
        else if (randomEventNumber == 26 && randomEvent26Selected == true)
        {
            RandomEvents1();
        }
        else if (randomEventNumber == 27 && randomEvent27Selected == true)
        {
            RandomEvents1();
        }
        else if (randomEventNumber == 28 && randomEvent28Selected == true)
        {
            RandomEvents1();
        }
        else if (randomEventNumber == 29 && randomEvent29Selected == true)
        {
            RandomEvents1();
        }
        else if (randomEventNumber == 30 && randomEvent30Selected == true)
        {
            RandomEvents1();
        }
        else if (randomEventNumber == 31 && randomEvent31Selected == true)
        {
            RandomEvents1();
        }
        else if (randomEventNumber == 32 && randomEvent32Selected == true)
        {
            RandomEvents1();
        }
        else if (randomEventNumber == 33 && randomEvent33Selected == true)
        {
            RandomEvents1();
        }
        else if (randomEventNumber == 34 && randomEvent34Selected == true)
        {
            RandomEvents1();
        }
        else if (randomEventNumber == 35 && randomEvent35Selected == true)
        {
            RandomEvents1();
        }
        else if (randomEventNumber == 36 && randomEvent36Selected == true)
        {
            RandomEvents1();
        }
        else if (randomEventNumber == 37 && randomEvent37Selected == true)
        {
            RandomEvents1();
        }
        else if (randomEventNumber == 38 && randomEvent38Selected == true)
        {
            RandomEvents1();
        }
        else if (randomEventNumber == 39 && randomEvent39Selected == true)
        {
            RandomEvents1();
        }
        else if (randomEventNumber == 40 && randomEvent40Selected == true)
        {
            RandomEvents1();
        }
        else if (randomEventNumber == 41 && randomEvent41Selected == true)
        {
            RandomEvents1();
        }
        else if (randomEventNumber == 42 && randomEvent42Selected == true)
        {
            RandomEvents1();
        }
        else if (randomEventNumber == 43 && randomEvent43Selected == true)
        {
            RandomEvents1();
        }
        else if (randomEventNumber == 44 && randomEvent44Selected == true)
        {
            RandomEvents1();
        }
        else if (randomEventNumber == 45 && randomEvent45Selected == true)
        {
            RandomEvents1();
        }
        else if (randomEventNumber == 46 && randomEvent46Selected == true)
        {
            RandomEvents1();
        }
        else if (randomEventNumber == 47 && randomEvent47Selected == true)
        {
            RandomEvents1();
        }
        else if (randomEventNumber == 48 && randomEvent48Selected == true)
        {
            RandomEvents1();
        }
        else if (randomEventNumber == 49 && randomEvent49Selected == true)
        {
            RandomEvents1();
        }
        else if (randomEventNumber == 50 && randomEvent50Selected == true)
        {
            RandomEvents1();
        }
        else
        {
            RandomEvents2();
        }
    }

    public void RandomEvents2()
    {
        switch (randomEventNumber)
        {
            case 1:
                // Increased Transportation
                negativeEventAudioSource.Play();

                randomEvent01Selected = true;

                randomEventsPage1TitleText.text = "INFLATION! Transportation Cost Increase!";
                randomEventsPage2TitleText.text = "INFLATION! Transportation Cost Increase!";

                generalPercent = UnityEngine.Random.Range(0.01F, 0.15F);
                generalPercent = Math.Round(generalPercent, 2);
                generalPercent1 = (generalPercent * 100);
                generalPercent1 = Math.Round(generalPercent1, 2);;

                //transportationCost1990 = transportationCost1990 + (transportationCost1990 * 0.125);
                //transportationCost2020 = transportationCost2020 + (transportationCost2020 * 0.125);

                randomEventsPage1DescriptionText.text = "Due to unstable inflation, transportation costs are increasing by " + generalPercent1 + "%.";

                RandomEvent12Page1Button.SetActive(false);
                RandomEvent01Page1Button.SetActive(true);

                RandomEvent01Page1ButtonText.text = "New Transportation Cost";

                RandomEventsPage1CloseButton.SetActive(false);

                break;
            case 2:
                // Loan Payment
                negativeEventAudioSource.Play();

                randomEvent02Selected = true;

                randomEventsPage1TitleText.text = "College Loans Are Due!";
                randomEventsPage2TitleText.text = "College Loans Are Due!";

                RandomEvent12Page1Button.SetActive(false);

                if (noDegree ==  true)
                {
                    randomEventsPage1DescriptionText.text = "Just kidding! You don't have any student loans! Lucky You!";

                    studentLoan1990 = 0.00F;
                    studentLoan2020 = 0.00F;
                    studentLoan1990 = Math.Round(studentLoan1990, 2);
                    studentLoan2020 = Math.Round(studentLoan2020, 2);

                    RandomEventsPage1CloseButton.SetActive(true);

                }
                else if (hsDiploma == true)
                {
                    randomEventsPage1DescriptionText.text = "Just kidding! You don't have any student loans! But don't let that discourage you from continuing your education.";

                    studentLoan1990 = 0.00F;
                    studentLoan2020 = 0.00F;
                    studentLoan1990 = Math.Round(studentLoan1990, 2);
                    studentLoan2020 = Math.Round(studentLoan2020, 2);

                    RandomEventsPage1CloseButton.SetActive(true);

                }
                else if (associatesDegree == true)
                {
                    randomEventsPage1DescriptionText.text = "Time to make your student loan payment. They may be annoying but it was a needed investment for your future career.";

                    RandomEvent02Page1Button.SetActive(true);

                    RandomEvent02Page1ButtonText.text = "Make Loan Payment";
                    
                    studentLoan1990 = UnityEngine.Random.Range(75.00F, 150.00F);
                    studentLoan2020 = UnityEngine.Random.Range(100.00F, 200.00F);
                    studentLoan1990 = Math.Round(studentLoan1990, 2);
                    studentLoan2020 = Math.Round(studentLoan2020, 2);

                    RandomEventsPage1CloseButton.SetActive(false);

                }
                else if (bachelorsDegree == true)
                {
                    randomEventsPage1DescriptionText.text = "Time to make your student loan payment. They may be annoying but it was a needed investment for your future career.";

                    RandomEvent02Page1Button.SetActive(true);

                    RandomEvent02Page1ButtonText.text = "Make Loan Payment";

                    studentLoan1990 = UnityEngine.Random.Range(150.00F, 250.00F);
                    studentLoan2020 = UnityEngine.Random.Range(200.00F, 300.00F);
                    studentLoan1990 = Math.Round(studentLoan1990, 2);
                    studentLoan2020 = Math.Round(studentLoan2020, 2);

                    RandomEventsPage1CloseButton.SetActive(false);

                }
                else if (mastersDegree == true)
                {
                    randomEventsPage1DescriptionText.text = "Time to make your student loan payment. They may be annoying but it was a needed investment for your future career.";

                    RandomEvent02Page1Button.SetActive(true);

                    RandomEvent02Page1ButtonText.text = "Make Loan Payment";

                    studentLoan1990 = UnityEngine.Random.Range(300.00F, 450.00F);
                    studentLoan2020 = UnityEngine.Random.Range(400.00F, 600.00F);
                    studentLoan1990 = Math.Round(studentLoan1990, 2);
                    studentLoan2020 = Math.Round(studentLoan2020, 2);

                    RandomEventsPage1CloseButton.SetActive(false);
                }
                else if (advancedDegree == true)
                {
                    randomEventsPage1DescriptionText.text = "Time to make your student loan payment. They may be annoying but it was a needed investment for your future career.";

                    RandomEvent02Page1Button.SetActive(true);

                    RandomEvent02Page1ButtonText.text = "Make Loan Payment";

                    studentLoan1990 = UnityEngine.Random.Range(400.00F, 650.00F);
                    studentLoan2020 = UnityEngine.Random.Range(600.00F, 800.00F);
                    studentLoan1990 = Math.Round(studentLoan1990, 2);
                    studentLoan2020 = Math.Round(studentLoan2020, 2);

                    RandomEventsPage1CloseButton.SetActive(false);
                }
                break;
            case 3:
                // Won Raffle
                positiveEventAudioSource.Play();

                randomEvent03Selected = true;

                randomEventsPage1TitleText.text = "You Won A Raffle!";
                randomEventsPage2TitleText.text = "You Won A Raffle!";
                randomEventsPage1DescriptionText.text = "You recently bought some raffle tickets while out bowling. You weren't expecting anything to come out of it, but you won the grand prize!";

                winnings = UnityEngine.Random.Range(50.00F, 250.00F);
                winnings = Math.Round(winnings, 2);

                RandomEvent12Page1Button.SetActive(false);
                RandomEvent03Page1Button.SetActive(true);
                
                RandomEvent03Page1ButtonText.text = "Collect Winnings";

                RandomEventsPage1CloseButton.SetActive(false);

                break;
            case 4:
                // Increased Wage
                positiveEventAudioSource.Play();

                randomEvent04Selected = true;

                randomEventsPage1TitleText.text = "You Received A Raise!";
                randomEventsPage2TitleText.text = "You Received A Raise!";

                generalPercent = UnityEngine.Random.Range(0.01F, 0.10F);
                generalPercent = Math.Round(generalPercent, 2);
                generalPercent1 = (generalPercent * 100);
                generalPercent1 = Math.Round(generalPercent, 2);

                randomEventsPage1DescriptionText.text = "Your hard work has paid off and you have received a " + generalPercent + "% increase in pay!";

                raise1990 = hourlyRate1990 * generalPercent;
                raise2020 = hourlyRate2020 * generalPercent;

                RandomEvent12Page1Button.SetActive(false);
                RandomEvent04Page1Button.SetActive(true);
                
                RandomEvent04Page1ButtonText.text = "Accept Raise";

                RandomEventsPage1CloseButton.SetActive(false);

                break;
            case 5:
                // Decreased Wage
                negativeEventAudioSource.Play();

                randomEvent05Selected = true;

                randomEventsPage1TitleText.text = "You Took A Pay Cut!";
                randomEventsPage2TitleText.text = "You Took A Pay Cut!";

                generalPercent = UnityEngine.Random.Range(0.01F, 0.15F);
                generalPercent = Math.Round(generalPercent, 2);
                generalPercent1 = generalPercent * 100;
                generalPercent1 = Math.Round(generalPercent1, 2);

                randomEventsPage1DescriptionText.text = "Unfortunately times are tough at your job and you have been forced to take a " + generalPercent1 + "% pay cut. It sucks, but you need this job!";

                payCut1990 = hourlyRate1990 * generalPercent;
                payCut2020 = hourlyRate2020 * generalPercent;

                RandomEvent12Page1Button.SetActive(false);
                RandomEvent05Page1Button.SetActive(true);
                
                RandomEvent05Page1ButtonText.text = "Accept Pay Cut";

                RandomEventsPage1CloseButton.SetActive(false);

                break;
            case 6:
                // Losing Job
                negativeEventAudioSource.Play();

                randomEvent06Selected = true;

                randomEventsPage1TitleText.text = "You Got Fired!";
                randomEventsPageJobTitleText.text = "You Got Fired!";
                randomEventsPage2TitleText.text = "You Got Fired!";

                RandomEvent12Page1Button.SetActive(false);

                if (waiter == true)
                {
                    randomEventsPage1DescriptionText.text = "Oh no. This was unexpected but you have been fired from your job as a Waiter. But that's okay. Now you get to choose a new job.";
                    waiter = false;
                    jobNow = 0;
                    jobSelected = "";

                    if (noDegree == true)
                    {
                        newWaiterButton.SetActive(false);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(false);
                        newCSAButton.SetActive(false);
                        newTeacherButton.SetActive(false);
                        newLSAButton.SetActive(false);
                        newProgrammerButton.SetActive(false);
                        newEngineerButton.SetActive(false);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(false);
                    }
                    else if (hsDiploma == true)
                    {
                        newWaiterButton.SetActive(false);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(true);
                        newCSAButton.SetActive(true);
                        newTeacherButton.SetActive(false);
                        newLSAButton.SetActive(false);
                        newProgrammerButton.SetActive(false);
                        newEngineerButton.SetActive(false);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(false);
                    }
                    else if (associatesDegree == true)
                    {
                        newWaiterButton.SetActive(false);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(true);
                        newCSAButton.SetActive(true);
                        newTeacherButton.SetActive(false);
                        newLSAButton.SetActive(false);
                        newProgrammerButton.SetActive(false);
                        newEngineerButton.SetActive(false);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(false);
                    }
                    else if (bachelorsDegree == true)
                    {
                        newWaiterButton.SetActive(false);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(true);
                        newCSAButton.SetActive(true);
                        newTeacherButton.SetActive(true);
                        newLSAButton.SetActive(true);
                        newProgrammerButton.SetActive(false);
                        newEngineerButton.SetActive(false);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(false);
                    }
                    else if (mastersDegree == true)
                    {
                        newWaiterButton.SetActive(false);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(true);
                        newCSAButton.SetActive(true);
                        newTeacherButton.SetActive(true);
                        newLSAButton.SetActive(true);
                        newProgrammerButton.SetActive(true);
                        newEngineerButton.SetActive(true);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(false);
                    }
                    else if (advancedDegree == true)
                    {
                        newWaiterButton.SetActive(false);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(true);
                        newCSAButton.SetActive(true);
                        newTeacherButton.SetActive(true);
                        newLSAButton.SetActive(true);
                        newProgrammerButton.SetActive(true);
                        newEngineerButton.SetActive(true);
                        newLawyerButton.SetActive(true);
                        newDoctorButton.SetActive(true);
                    }

                }
                else if (cashier == true)
                {
                    randomEventsPage1DescriptionText.text = "Oh no. This was unexpected but you have been fired from your job as a Cashier. But that's okay. Now you get to choose a new job.";
                    cashier = false;
                    jobNow = 0;
                    jobSelected = "";

                    if (noDegree == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(false);
                        newFryCookButton.SetActive(false);
                        newCSAButton.SetActive(false);
                        newTeacherButton.SetActive(false);
                        newLSAButton.SetActive(false);
                        newProgrammerButton.SetActive(false);
                        newEngineerButton.SetActive(false);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(false);
                    }
                    else if (hsDiploma == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(false);
                        newFryCookButton.SetActive(true);
                        newCSAButton.SetActive(true);
                        newTeacherButton.SetActive(false);
                        newLSAButton.SetActive(false);
                        newProgrammerButton.SetActive(false);
                        newEngineerButton.SetActive(false);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(false);
                    }
                    else if (associatesDegree == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(false);
                        newFryCookButton.SetActive(true);
                        newCSAButton.SetActive(true);
                        newTeacherButton.SetActive(false);
                        newLSAButton.SetActive(false);
                        newProgrammerButton.SetActive(false);
                        newEngineerButton.SetActive(false);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(false);
                    }
                    else if (bachelorsDegree == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(false);
                        newFryCookButton.SetActive(true);
                        newCSAButton.SetActive(true);
                        newTeacherButton.SetActive(true);
                        newLSAButton.SetActive(true);
                        newProgrammerButton.SetActive(false);
                        newEngineerButton.SetActive(false);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(false);
                    }
                    else if (mastersDegree == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(false);
                        newFryCookButton.SetActive(true);
                        newCSAButton.SetActive(true);
                        newTeacherButton.SetActive(true);
                        newLSAButton.SetActive(true);
                        newProgrammerButton.SetActive(true);
                        newEngineerButton.SetActive(true);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(false);
                    }
                    else if (advancedDegree == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(false);
                        newFryCookButton.SetActive(true);
                        newCSAButton.SetActive(true);
                        newTeacherButton.SetActive(true);
                        newLSAButton.SetActive(true);
                        newProgrammerButton.SetActive(true);
                        newEngineerButton.SetActive(true);
                        newLawyerButton.SetActive(true);
                        newDoctorButton.SetActive(true);
                    }

                }
                else if (fryCook == true)
                {
                    randomEventsPage1DescriptionText.text = "Oh no. This was unexpected but you have been fired from your job as a Fry Cook. But that's okay. Now you get to choose a new job.";
                    fryCook = false;
                    jobNow = 0;
                    jobSelected = "";

                    if (noDegree == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(false);
                        newCSAButton.SetActive(false);
                        newTeacherButton.SetActive(false);
                        newLSAButton.SetActive(false);
                        newProgrammerButton.SetActive(false);
                        newEngineerButton.SetActive(false);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(false);
                    }
                    else if (hsDiploma == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(false);
                        newCSAButton.SetActive(true);
                        newTeacherButton.SetActive(false);
                        newLSAButton.SetActive(false);
                        newProgrammerButton.SetActive(false);
                        newEngineerButton.SetActive(false);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(false);
                    }
                    else if (associatesDegree == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(false);
                        newCSAButton.SetActive(true);
                        newTeacherButton.SetActive(false);
                        newLSAButton.SetActive(false);
                        newProgrammerButton.SetActive(false);
                        newEngineerButton.SetActive(false);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(false);
                    }
                    else if (bachelorsDegree == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(false);
                        newCSAButton.SetActive(true);
                        newTeacherButton.SetActive(true);
                        newLSAButton.SetActive(true);
                        newProgrammerButton.SetActive(false);
                        newEngineerButton.SetActive(false);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(false);
                    }
                    else if (mastersDegree == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(false);
                        newCSAButton.SetActive(true);
                        newTeacherButton.SetActive(true);
                        newLSAButton.SetActive(true);
                        newProgrammerButton.SetActive(true);
                        newEngineerButton.SetActive(true);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(false);
                    }
                    else if (advancedDegree == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(false);
                        newCSAButton.SetActive(true);
                        newTeacherButton.SetActive(true);
                        newLSAButton.SetActive(true);
                        newProgrammerButton.SetActive(true);
                        newEngineerButton.SetActive(true);
                        newLawyerButton.SetActive(true);
                        newDoctorButton.SetActive(true);
                    }

                }
                else if (customerServiceAgent == true)
                {
                    randomEventsPage1DescriptionText.text = "Oh no. This was unexpected but you have been fired from your job as a Customer Service Agent. But that's okay. Now you get to choose a new job.";
                    customerServiceAgent = false;
                    jobNow = 0;
                    jobSelected = "";

                    if (noDegree == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(false);
                        newCSAButton.SetActive(false);
                        newTeacherButton.SetActive(false);
                        newLSAButton.SetActive(false);
                        newProgrammerButton.SetActive(false);
                        newEngineerButton.SetActive(false);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(false);
                    }
                    else if (hsDiploma == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(true);
                        newCSAButton.SetActive(false);
                        newTeacherButton.SetActive(false);
                        newLSAButton.SetActive(false);
                        newProgrammerButton.SetActive(false);
                        newEngineerButton.SetActive(false);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(false);
                    }
                    else if (associatesDegree == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(true);
                        newCSAButton.SetActive(false);
                        newTeacherButton.SetActive(false);
                        newLSAButton.SetActive(false);
                        newProgrammerButton.SetActive(false);
                        newEngineerButton.SetActive(false);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(false);
                    }
                    else if (bachelorsDegree == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(true);
                        newCSAButton.SetActive(false);
                        newTeacherButton.SetActive(true);
                        newLSAButton.SetActive(true);
                        newProgrammerButton.SetActive(false);
                        newEngineerButton.SetActive(false);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(false);
                    }
                    else if (mastersDegree == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(true);
                        newCSAButton.SetActive(false);
                        newTeacherButton.SetActive(true);
                        newLSAButton.SetActive(true);
                        newProgrammerButton.SetActive(true);
                        newEngineerButton.SetActive(true);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(false);
                    }
                    else if (advancedDegree == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(true);
                        newCSAButton.SetActive(false);
                        newTeacherButton.SetActive(true);
                        newLSAButton.SetActive(true);
                        newProgrammerButton.SetActive(true);
                        newEngineerButton.SetActive(true);
                        newLawyerButton.SetActive(true);
                        newDoctorButton.SetActive(true);
                    }

                }
                else if (teacher == true)
                {
                    randomEventsPage1DescriptionText.text = "Oh no. This was unexpected but you have been fired from your job as a Teacher. But that's okay. Now you get to choose a new job.";
                    teacher = false;
                    jobNow = 0;
                    jobSelected = "";

                    if (noDegree == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(false);
                        newCSAButton.SetActive(false);
                        newTeacherButton.SetActive(false);
                        newLSAButton.SetActive(false);
                        newProgrammerButton.SetActive(false);
                        newEngineerButton.SetActive(false);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(false);
                    }
                    else if (hsDiploma == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(true);
                        newCSAButton.SetActive(true);
                        newTeacherButton.SetActive(false);
                        newLSAButton.SetActive(false);
                        newProgrammerButton.SetActive(false);
                        newEngineerButton.SetActive(false);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(false);
                    }
                    else if (associatesDegree == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(true);
                        newCSAButton.SetActive(true);
                        newTeacherButton.SetActive(false);
                        newLSAButton.SetActive(false);
                        newProgrammerButton.SetActive(false);
                        newEngineerButton.SetActive(false);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(false);
                    }
                    else if (bachelorsDegree == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(true);
                        newCSAButton.SetActive(true);
                        newTeacherButton.SetActive(false);
                        newLSAButton.SetActive(true);
                        newProgrammerButton.SetActive(false);
                        newEngineerButton.SetActive(false);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(false);
                    }
                    else if (mastersDegree == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(true);
                        newCSAButton.SetActive(true);
                        newTeacherButton.SetActive(false);
                        newLSAButton.SetActive(true);
                        newProgrammerButton.SetActive(true);
                        newEngineerButton.SetActive(true);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(false);
                    }
                    else if (advancedDegree == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(true);
                        newCSAButton.SetActive(true);
                        newTeacherButton.SetActive(false);
                        newLSAButton.SetActive(true);
                        newProgrammerButton.SetActive(true);
                        newEngineerButton.SetActive(true);
                        newLawyerButton.SetActive(true);
                        newDoctorButton.SetActive(true);
                    }
                    
                }
                else if (licensedSalesAgent == true)
                {
                    randomEventsPage1DescriptionText.text = "Oh no. This was unexpected but you have been fired from your job as a Licensed Sales Agent. But that's okay. Now you get to choose a new job.";
                    licensedSalesAgent = false;
                    jobNow = 0;
                    jobSelected = "";

                    if (noDegree == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(false);
                        newCSAButton.SetActive(false);
                        newTeacherButton.SetActive(false);
                        newLSAButton.SetActive(false);
                        newProgrammerButton.SetActive(false);
                        newEngineerButton.SetActive(false);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(false);
                    }
                    else if (hsDiploma == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(true);
                        newCSAButton.SetActive(true);
                        newTeacherButton.SetActive(false);
                        newLSAButton.SetActive(false);
                        newProgrammerButton.SetActive(false);
                        newEngineerButton.SetActive(false);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(false);
                    }
                    else if (associatesDegree == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(true);
                        newCSAButton.SetActive(true);
                        newTeacherButton.SetActive(false);
                        newLSAButton.SetActive(false);
                        newProgrammerButton.SetActive(false);
                        newEngineerButton.SetActive(false);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(false);
                    }
                    else if (bachelorsDegree == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(true);
                        newCSAButton.SetActive(true);
                        newTeacherButton.SetActive(true);
                        newLSAButton.SetActive(false);
                        newProgrammerButton.SetActive(false);
                        newEngineerButton.SetActive(false);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(false);
                    }
                    else if (mastersDegree == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(true);
                        newCSAButton.SetActive(true);
                        newTeacherButton.SetActive(true);
                        newLSAButton.SetActive(false);
                        newProgrammerButton.SetActive(true);
                        newEngineerButton.SetActive(true);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(false);
                    }
                    else if (advancedDegree == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(true);
                        newCSAButton.SetActive(true);
                        newTeacherButton.SetActive(true);
                        newLSAButton.SetActive(false);
                        newProgrammerButton.SetActive(true);
                        newEngineerButton.SetActive(true);
                        newLawyerButton.SetActive(true);
                        newDoctorButton.SetActive(true);
                    }

                }
                else if (programmer == true)
                {
                    randomEventsPage1DescriptionText.text = "Oh no. This was unexpected but you have been fired from your job as a Programmer. But that's okay. Now you get to choose a new job.";
                    programmer = false;
                    jobNow = 0;
                    jobSelected = "";

                    if (noDegree == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(false);
                        newCSAButton.SetActive(false);
                        newTeacherButton.SetActive(false);
                        newLSAButton.SetActive(false);
                        newProgrammerButton.SetActive(false);
                        newEngineerButton.SetActive(false);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(false);
                    }
                    else if (hsDiploma == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(true);
                        newCSAButton.SetActive(true);
                        newTeacherButton.SetActive(false);
                        newLSAButton.SetActive(false);
                        newProgrammerButton.SetActive(false);
                        newEngineerButton.SetActive(false);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(false);
                    }
                    else if (associatesDegree == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(true);
                        newCSAButton.SetActive(true);
                        newTeacherButton.SetActive(false);
                        newLSAButton.SetActive(false);
                        newProgrammerButton.SetActive(false);
                        newEngineerButton.SetActive(false);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(false);
                    }
                    else if (bachelorsDegree == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(true);
                        newCSAButton.SetActive(true);
                        newTeacherButton.SetActive(true);
                        newLSAButton.SetActive(true);
                        newProgrammerButton.SetActive(false);
                        newEngineerButton.SetActive(false);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(false);
                    }
                    else if (mastersDegree == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(true);
                        newCSAButton.SetActive(true);
                        newTeacherButton.SetActive(true);
                        newLSAButton.SetActive(true);
                        newProgrammerButton.SetActive(false);
                        newEngineerButton.SetActive(true);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(false);
                    }
                    else if (advancedDegree == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(true);
                        newCSAButton.SetActive(true);
                        newTeacherButton.SetActive(true);
                        newLSAButton.SetActive(true);
                        newProgrammerButton.SetActive(false);
                        newEngineerButton.SetActive(true);
                        newLawyerButton.SetActive(true);
                        newDoctorButton.SetActive(true);
                    }

                }
                else if (engineer == true)
                {
                    randomEventsPage1DescriptionText.text = "Oh no. This was unexpected but you have been fired from your job as an Engineer. But that's okay. Now you get to choose a new job.";
                    engineer = false;
                    jobNow = 0;
                    jobSelected = "";

                    if (noDegree == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(false);
                        newCSAButton.SetActive(false);
                        newTeacherButton.SetActive(false);
                        newLSAButton.SetActive(false);
                        newProgrammerButton.SetActive(false);
                        newEngineerButton.SetActive(false);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(false);
                    }
                    else if (hsDiploma == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(true);
                        newCSAButton.SetActive(true);
                        newTeacherButton.SetActive(false);
                        newLSAButton.SetActive(false);
                        newProgrammerButton.SetActive(false);
                        newEngineerButton.SetActive(false);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(false);
                    }
                    else if (associatesDegree == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(true);
                        newCSAButton.SetActive(true);
                        newTeacherButton.SetActive(false);
                        newLSAButton.SetActive(false);
                        newProgrammerButton.SetActive(false);
                        newEngineerButton.SetActive(false);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(false);
                    }
                    else if (bachelorsDegree == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(true);
                        newCSAButton.SetActive(true);
                        newTeacherButton.SetActive(true);
                        newLSAButton.SetActive(true);
                        newProgrammerButton.SetActive(false);
                        newEngineerButton.SetActive(false);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(false);
                    }
                    else if (mastersDegree == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(true);
                        newCSAButton.SetActive(true);
                        newTeacherButton.SetActive(true);
                        newLSAButton.SetActive(true);
                        newProgrammerButton.SetActive(true);
                        newEngineerButton.SetActive(false);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(false);
                    }
                    else if (advancedDegree == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(true);
                        newCSAButton.SetActive(true);
                        newTeacherButton.SetActive(true);
                        newLSAButton.SetActive(true);
                        newProgrammerButton.SetActive(true);
                        newEngineerButton.SetActive(false);
                        newLawyerButton.SetActive(true);
                        newDoctorButton.SetActive(true);
                    }

                }
                else if (lawyer == true)
                {
                    randomEventsPage1DescriptionText.text = "Oh no. This was unexpected but you have been fired from your job as a Lawyer. But that's okay. Now you get to choose a new job.";
                    lawyer = false;
                    jobNow = 0;
                    jobSelected = "";

                    if (noDegree == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(false);
                        newCSAButton.SetActive(false);
                        newTeacherButton.SetActive(false);
                        newLSAButton.SetActive(false);
                        newProgrammerButton.SetActive(false);
                        newEngineerButton.SetActive(false);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(false);
                    }
                    else if (hsDiploma == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(true);
                        newCSAButton.SetActive(true);
                        newTeacherButton.SetActive(false);
                        newLSAButton.SetActive(false);
                        newProgrammerButton.SetActive(false);
                        newEngineerButton.SetActive(false);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(false);
                    }
                    else if (associatesDegree == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(true);
                        newCSAButton.SetActive(true);
                        newTeacherButton.SetActive(false);
                        newLSAButton.SetActive(false);
                        newProgrammerButton.SetActive(false);
                        newEngineerButton.SetActive(false);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(false);
                    }
                    else if (bachelorsDegree == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(true);
                        newCSAButton.SetActive(true);
                        newTeacherButton.SetActive(true);
                        newLSAButton.SetActive(true);
                        newProgrammerButton.SetActive(false);
                        newEngineerButton.SetActive(false);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(false);
                    }
                    else if (mastersDegree == true)
                    {
                        newWaiterButton.SetActive(false);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(true);
                        newCSAButton.SetActive(true);
                        newTeacherButton.SetActive(true);
                        newLSAButton.SetActive(true);
                        newProgrammerButton.SetActive(true);
                        newEngineerButton.SetActive(true);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(false);
                    }
                    else if (advancedDegree == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(true);
                        newCSAButton.SetActive(true);
                        newTeacherButton.SetActive(true);
                        newLSAButton.SetActive(true);
                        newProgrammerButton.SetActive(true);
                        newEngineerButton.SetActive(true);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(true);
                    }

                }
                else if (doctor == true)
                {
                    randomEventsPage1DescriptionText.text = "Oh no. This was unexpected but you have been fired from your job as a Doctor. But that's okay. Now you get to choose a new job.";
                    doctor = false;
                    jobNow = 0;
                    jobSelected = "";


                    if (noDegree == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(false);
                        newCSAButton.SetActive(false);
                        newTeacherButton.SetActive(false);
                        newLSAButton.SetActive(false);
                        newProgrammerButton.SetActive(false);
                        newEngineerButton.SetActive(false);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(false);
                    }
                    else if (hsDiploma == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(true);
                        newCSAButton.SetActive(true);
                        newTeacherButton.SetActive(false);
                        newLSAButton.SetActive(false);
                        newProgrammerButton.SetActive(false);
                        newEngineerButton.SetActive(false);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(false);
                    }
                    else if (associatesDegree == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(true);
                        newCSAButton.SetActive(true);
                        newTeacherButton.SetActive(false);
                        newLSAButton.SetActive(false);
                        newProgrammerButton.SetActive(false);
                        newEngineerButton.SetActive(false);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(false);
                    }
                    else if (bachelorsDegree == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(true);
                        newCSAButton.SetActive(true);
                        newTeacherButton.SetActive(true);
                        newLSAButton.SetActive(true);
                        newProgrammerButton.SetActive(false);
                        newEngineerButton.SetActive(false);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(false);
                    }
                    else if (mastersDegree == true)
                    {
                        newWaiterButton.SetActive(false);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(true);
                        newCSAButton.SetActive(true);
                        newTeacherButton.SetActive(true);
                        newLSAButton.SetActive(true);
                        newProgrammerButton.SetActive(true);
                        newEngineerButton.SetActive(true);
                        newLawyerButton.SetActive(false);
                        newDoctorButton.SetActive(false);
                    }
                    else if (advancedDegree == true)
                    {
                        newWaiterButton.SetActive(true);
                        newCashierButton.SetActive(true);
                        newFryCookButton.SetActive(true);
                        newCSAButton.SetActive(true);
                        newTeacherButton.SetActive(true);
                        newLSAButton.SetActive(true);
                        newProgrammerButton.SetActive(true);
                        newEngineerButton.SetActive(true);
                        newLawyerButton.SetActive(true);
                        newDoctorButton.SetActive(false);
                    }
                }

                RandomEvent06Page1Button.SetActive(true);

                RandomEvent06Page1ButtonText.text = "Choose New Job";

                RandomEventsPage1CloseButton.SetActive(false);

                break;
            case 7:
                // Improve Education
                positiveEventAudioSource.Play();

                randomEvent07Selected = true;

                RandomEvent12Page1Button.SetActive(false);

                if (noDegree == true)
                {
                    randomEventsPage1TitleText.text = "You Improved Your Education: GED";
                    randomEventsPage2TitleText.text = "You Improved Your Education: GED";
                    randomEventsPage1DescriptionText.text = "";

                    noDegree = false;
                    hsDiploma = true;
                    educationNow = 2;
                    educationSelected = "High School Diploma";

                    hourlyRate1990 += 0.50F;
                    hourlyRate2020 += 1.00F;

                    RandomEvent07Page1Button.SetActive(true);

                    RandomEvent07Page1ButtonText.text = "Congratz!";

                    RandomEventsPage1CloseButton.SetActive(false);

                }
                else if (hsDiploma == true)
                {
                    randomEventsPage1TitleText.text = "You Improved Your Education: Associates Degree";
                    randomEventsPage2TitleText.text = "You Improved Your Education: Associates Degree";
                    randomEventsPage1DescriptionText.text = "";

                    hsDiploma = false;
                    associatesDegree = true;
                    educationNow = 3;
                    educationSelected = "Associate's Degree";

                    hourlyRate1990 += 0.50F;
                    hourlyRate2020 += 1.00F;

                    RandomEvent07Page1Button.SetActive(true);

                    RandomEvent07Page1ButtonText.text = "Congratz!";

                    RandomEventsPage1CloseButton.SetActive(false);

                }
                else if (associatesDegree == true)
                {
                    randomEventsPage1TitleText.text = "You Improved Your Education: Bachelor's Degree";
                    randomEventsPage2TitleText.text = "You Improved Your Education: Bachelor's Degree";
                    randomEventsPage1DescriptionText.text = "";

                    associatesDegree = false;
                    bachelorsDegree = true;
                    educationNow = 4;
                    educationSelected = "Bachelor's Degree";

                    hourlyRate1990 += 0.50F;
                    hourlyRate2020 += 1.00F;

                    RandomEvent07Page1Button.SetActive(true);
                    
                    RandomEvent07Page1ButtonText.text = "Congratz!";

                    RandomEventsPage1CloseButton.SetActive(false);

                }
                else if (bachelorsDegree == true)
                {
                    randomEventsPage1TitleText.text = "You Improved Your Education: Master's Degree";
                    randomEventsPage2TitleText.text = "You Improved Your Education: Master's Degree";
                    randomEventsPage1DescriptionText.text = "";

                    bachelorsDegree = false;
                    mastersDegree = true;
                    educationNow = 5;
                    educationSelected = "Master's Degree";

                    hourlyRate1990 += 0.50F;
                    hourlyRate2020 += 1.00F;

                    RandomEvent07Page1Button.SetActive(true);

                    RandomEvent07Page1ButtonText.text = "Congratz!";

                    RandomEventsPage1CloseButton.SetActive(false);

                }
                else if (mastersDegree == true)
                {
                    randomEventsPage1TitleText.text = "You Improved Your Education: Advanced Degree";
                    randomEventsPage2TitleText.text = "You Improved Your Education: Advanced Degree";
                    randomEventsPage1DescriptionText.text = "";

                    mastersDegree = false;
                    advancedDegree = true;
                    educationNow = 6;
                    educationSelected = "Advanced Degree";

                    hourlyRate1990 += 0.50F;
                    hourlyRate2020 += 1.00F;

                    RandomEvent07Page1Button.SetActive(true);

                    RandomEvent07Page1ButtonText.text = "Congratz!";

                    RandomEventsPage1CloseButton.SetActive(false);
                }
                else if (advancedDegree == true)
                {
                    randomEventsPage1TitleText.text = "You Mastered Your Education";
                    randomEventsPage2TitleText.text = "You Mastered Your Education";
                    randomEventsPage1DescriptionText.text = "";

                    RandomEventsPage1CloseButton.SetActive(true);

                }
                break;
            case 8:
                // Home Sick
                negativeEventAudioSource.Play();

                randomEvent08Selected = true;

                randomEventsPage1TitleText.text = "Home, Sick!";
                randomEventsPage2TitleText.text = "Home, Sick!";

                randomEventsPage1DescriptionText.text = "Oh no! It looks like you've caught some type of cold or flu. This means you'll have to miss a few days of work. Hopefully not too many, because the less days you work, the less you get paid.";
                
                RandomEvent12Page1Button.SetActive(false);
                RandomEvent08Page1Button.SetActive(true);

                RandomEvent08Page1ButtonText.text = "Miss Time Off Work";

                RandomEventsPage1CloseButton.SetActive(false);
                break;
            case 9:
                // Farmer's Strike
                negativeEventAudioSource.Play();

                randomEvent09Selected = true;

                randomEventsPage1TitleText.text = "Farmer's Strike";
                randomEventsPage2TitleText.text = "Farmer's Strike";

                generalPercent = UnityEngine.Random.Range(0.01F, 0.15F);
                generalPercent = Math.Round(generalPercent, 2);
                generalPercent1 = generalPercent * 100;
                generalPercent1 = Math.Round(generalPercent1, 2);

                randomEventsPage1DescriptionText.text = "Farmers have recently gone on strike demanding more money for their produce and livestock. As a result, the price of groceries and food has increased by " + generalPercent1 + "%.";
                
                RandomEvent12Page1Button.SetActive(false);
                RandomEvent09Page1Button.SetActive(true);

                RandomEvent09Page1ButtonText.text = "Food Prices Increase";

                RandomEventsPage1CloseButton.SetActive(false);

                break;
            case 10:
                // Transportation Woes
                negativeEventAudioSource.Play();

                randomEvent10Selected = true;

                RandomEvent12Page1Button.SetActive(false);

                if (bicycle == true)
                {
                    randomEventsPage1TitleText.text = "Transportation Woes: Snapped Chain";
                    randomEventsPage2TitleText.text = "Transportation Woes: Snapped Chain";

                    randomEventsPage1DescriptionText.text = "Oh no! It looks like your bicycle chain has snapped and needs to be repaired.";
                    RandomEvent10Page1ButtonText.text = "Replace Snapped Chain";

                    transportationWoes1990 = UnityEngine.Random.Range(10.00F, 25.00F);
                    transportationWoes2020 = UnityEngine.Random.Range(15.00F, 60.00F);

                    transportationWoes1990 = Math.Round(transportationWoes1990, 2);
                    transportationWoes2020 = Math.Round(transportationWoes2020, 2);
                }
                else if (usedCar == true)
                {
                    randomEventsPage1TitleText.text = "Transportation Woes: Faulty Brakes";
                    randomEventsPage2TitleText.text = "Transportation Woes: Faulty Brakes";

                    randomEventsPage1DescriptionText.text = "Oh no! It looks like the brakes in your Used Car are faulty and need to be replaced.";
                    RandomEvent10Page1ButtonText.text = "Replace Faulty Brakes";

                    transportationWoes1990 = UnityEngine.Random.Range(100.00F, 350.00F);
                    transportationWoes2020 = UnityEngine.Random.Range(200.00F, 800.00F);

                    transportationWoes1990 = Math.Round(transportationWoes1990, 2);
                    transportationWoes2020 = Math.Round(transportationWoes2020, 2);
                }
                else if (newCar == true)
                {
                    randomEventsPage1TitleText.text = "Transportation Woes: Blown Tires";
                    randomEventsPage2TitleText.text = "Transportation Woes: Blown Tires";

                    randomEventsPage1DescriptionText.text = "Oh no! In a struck of bad luck, all you New Car tires have blown out and need to be replaced.";
                    RandomEvent10Page1ButtonText.text = "Replace Blown Tires";

                    transportationWoes1990 = UnityEngine.Random.Range(50.00F, 400.00F); // $12.50 - $100.00 per tire
                    transportationWoes2020 = UnityEngine.Random.Range(200.00F, 800.00F); // $50.00 - $200.00 per tire

                    transportationWoes1990 = Math.Round(transportationWoes1990, 2);
                    transportationWoes2020 = Math.Round(transportationWoes2020, 2);
                }
                else if (motorcycle == true)
                {
                    randomEventsPage1TitleText.text = "Transportation Woes: Battery Problems";
                    randomEventsPage2TitleText.text = "Transportation Woes: Battery Problems";

                    randomEventsPage1DescriptionText.text = "Oh no! It looks like you're having issues with your Motorcycle battery and it needs to be replaced.";
                    RandomEvent10Page1ButtonText.text = "Replace Battery";

                    transportationWoes1990 = UnityEngine.Random.Range(25.00F, 100.00F);
                    transportationWoes2020 = UnityEngine.Random.Range(50.00F, 150.00F);

                    transportationWoes1990 = Math.Round(transportationWoes1990, 2);
                    transportationWoes2020 = Math.Round(transportationWoes2020, 2);
                }
                else if (bus == true)
                {
                    randomEventsPage1TitleText.text = "Transportation Woes: Missed Bus";
                    randomEventsPage2TitleText.text = "Transportation Woes: Missed Bus";

                    randomEventsPage1DescriptionText.text = "Oh no! It looks like you missed your first Bus. Hopefully you can catch the next one.";
                    RandomEvent10Page1ButtonText.text = "Ride Next Bus";

                    hoursMissed = UnityEngine.Random.Range(1, 10);
                    totalHoursMissed += hoursMissed;
                }
                else if (train == true)
                {
                    randomEventsPage1TitleText.text = "Transportation Woes: Train Delay";
                    randomEventsPage2TitleText.text = "Transportation Woes: Train Delay";

                    randomEventsPage1DescriptionText.text = "Oh no! It looks like an accident has caused the Train to be delayed this week.";
                    RandomEvent10Page1ButtonText.text = "Ride Delayed Train";

                    hoursMissed = UnityEngine.Random.Range(1, 5);
                    totalHoursMissed += hoursMissed;
                }
                
                RandomEvent10Page1Button.SetActive(true);

                RandomEventsPage1CloseButton.SetActive(false);
                break;
            case 11:
                // Transportation Loss
                negativeEventAudioSource.Play();

                randomEvent11Selected = true;

                randomEventsPage1TitleText.text = "Transportation Loss";
                randomEventsPageTransportationTitleText.text = "Transportation Loss";
                randomEventsPage2TitleText.text = "Transportation Loss";

                RandomEvent12Page1Button.SetActive(false);

                // Sets Random Event Description
                if (bicycle == true)
                {
                    randomEventsPage1DescriptionText.text = "Oh no! You're reliable Bicycle has been stolen!";

                    newBicycleButton.SetActive(true);
                    newUsedCarButton.SetActive(true);
                    newNewCarButton.SetActive(true);
                    newMotorcycleButton.SetActive(true);
                    newBusButton.SetActive(true);
                    newTrainButton.SetActive(true);
                }
                else if (usedCar == true)
                {
                    randomEventsPage1DescriptionText.text = "Oh no! Your reliable Used Car has been totaled in an accident.";

                    newBicycleButton.SetActive(true);
                    newUsedCarButton.SetActive(true);
                    newNewCarButton.SetActive(true);
                    newMotorcycleButton.SetActive(true);
                    newBusButton.SetActive(true);
                    newTrainButton.SetActive(true);
                }
                else if (newCar == true)
                {
                    randomEventsPage1DescriptionText.text = "Oh no! Your nice New Car has been totaled in an accident.";

                    newBicycleButton.SetActive(true);
                    newUsedCarButton.SetActive(true);
                    newNewCarButton.SetActive(true);
                    newMotorcycleButton.SetActive(true);
                    newBusButton.SetActive(true);
                    newTrainButton.SetActive(true);
                }
                else if (motorcycle == true)
                {
                    randomEventsPage1DescriptionText.text = "Oh no! Your precious Motorcycle was totaled in an accident.";

                    newBicycleButton.SetActive(true);
                    newUsedCarButton.SetActive(true);
                    newNewCarButton.SetActive(true);
                    newMotorcycleButton.SetActive(true);
                    newBusButton.SetActive(true);
                    newTrainButton.SetActive(true);
                }
                else if (bus == true)
                {
                    randomEventsPage1DescriptionText.text = "Oh no! The Bus routes have changed and now are no longer reliable.";

                    newBicycleButton.SetActive(true);
                    newUsedCarButton.SetActive(true);
                    newNewCarButton.SetActive(true);
                    newMotorcycleButton.SetActive(true);
                    newBusButton.SetActive(true);
                    newTrainButton.SetActive(true);
                }
                else if (train == true)
                {
                    randomEventsPage1DescriptionText.text = "Oh no! The Train line you rely on is shutting down service.";

                    newBicycleButton.SetActive(true);
                    newUsedCarButton.SetActive(true);
                    newNewCarButton.SetActive(true);
                    newMotorcycleButton.SetActive(true);
                    newBusButton.SetActive(true);
                    newTrainButton.SetActive(true);
                }

                // Resets Transportation Selection
                transportationSelected = "";
                travelNow = 0;
                payTransportationTitleText1.text = "";
                payTransportationTitleText2.text = "";
                bicycle = false;
                usedCar = false;
                newCar = false;
                motorcycle = false;
                bus = false;
                train = false;

                RandomEvent11Page1Button.SetActive(true);

                RandomEvent11Page1ButtonText.text = "Select New Transportation";

                RandomEventsPage1CloseButton.SetActive(false);

                break;
            case 12:
                // Unexpected Medical Emergency
                negativeEventAudioSource.Play();

                randomEvent12Selected = true;

                randomEventsPage1TitleText.text = "Unexpected Medical Emergency";
                randomEventsPage2TitleText.text = "Unexpected Medical Emergency";

                randomEventsPage1DescriptionText.text = "Oh no! You have had an Unexpected Medical Emergency. You are okay, but now you have a huge medical bill.";

                medicalCost1990 = UnityEngine.Random.Range(150.00F, 400.00F);
                medicalCost2020 = UnityEngine.Random.Range(250.00F, 600.00F);

                medicalCost1990 = Math.Round(medicalCost1990, 2);
                medicalCost2020 = Math.Round(medicalCost2020, 2);

                RandomEvent12Page1Button.SetActive(true);

                RandomEvent12Page1ButtonText.text = "Pay Medical Bill";

                RandomEventsPage1CloseButton.SetActive(false);

                break;
            case 13:
                // Tax Return
                positiveEventAudioSource.Play();

                randomEvent13Selected = true;

                randomEventsPage1TitleText.text = "Tax Return";
                randomEventsPage2TitleText.text = "Tax Return";

                randomEventsPage1DescriptionText.text = "It's tax season. And you are getting a refund!";

                RandomEvent12Page1Button.SetActive(false);

                //Establish Tax Percentage
                if (waiter == true)
                {
                    generalPercent = UnityEngine.Random.Range(0.10F, 0.30F);
                }
                else if (cashier == true || fryCook == true)
                {
                    generalPercent = UnityEngine.Random.Range(0.09F, 0.25F);
                }
                else if (customerServiceAgent == true || teacher == true)
                {
                    generalPercent = UnityEngine.Random.Range(0.08F, 0.20F);
                }
                else if (licensedSalesAgent == true || programmer == true)
                {
                    generalPercent = UnityEngine.Random.Range(0.07F, 0.15F);
                }
                else if (engineer == true || lawyer == true)
                {
                    generalPercent = UnityEngine.Random.Range(0.06F, 0.10F);
                }
                else if (doctor == true)
                {
                    generalPercent = 0.05F;
                }

                RandomEvent13Page1Button.SetActive(true);

                RandomEvent13Page1ButtonText.text = "Collect Tax Refund";

                RandomEventsPage1CloseButton.SetActive(false);

                break;
            case 14:
                // Internet Service Upgrade
                negativeEventAudioSource.Play();

                randomEvent14Selected = true;

                randomEventsPage1TitleText.text = "Internet Upgrade";
                randomEventsPage2TitleText.text = "Internet Upgrade";

                //Establishing Increase
                generalPercent = UnityEngine.Random.Range(0.05F, 0.40F);
                generalPercent = Math.Round(generalPercent, 2);

                generalPercent1 = generalPercent * 100;
                generalPercent1 = Math.Round(generalPercent1, 1);

                randomEventsPage1DescriptionText.text = "Your Internet Service Provider is upgrading the service. While good, this means your Internet cost is increasing by " + generalPercent1 + "%.";

                RandomEvent12Page1Button.SetActive(false);
                RandomEvent14Page1Button.SetActive(true);

                RandomEvent14Page1ButtonText.text = "Internet Upgrade";

                RandomEventsPage1CloseButton.SetActive(false);

                break;
            case 15:
                // Communications Service Upgrade
                negativeEventAudioSource.Play();

                randomEvent15Selected = true;

                randomEventsPage1TitleText.text = "Communications Service Upgrade";
                randomEventsPage2TitleText.text = "Communications Service Upgrade";

                //Establishing Increase
                generalPercent = UnityEngine.Random.Range(0.05F, 0.25F);
                generalPercent = Math.Round(generalPercent, 2);

                generalPercent1 = generalPercent * 100;
                generalPercent1 = Math.Round(generalPercent1, 1);

                randomEventsPage1DescriptionText.text = "Your Phone Service Provider is upgrading the towers. While good, this means your Communication cost is increasing by " + generalPercent1 + "%.";

                RandomEvent12Page1Button.SetActive(false);
                RandomEvent15Page1Button.SetActive(true);

                RandomEvent15Page1ButtonText.text = "Phone Upgrade";

                RandomEventsPage1CloseButton.SetActive(false);

                break;
            case 16:
                // Entertainment Service Upgrade
                negativeEventAudioSource.Play();

                randomEvent16Selected = true;

                randomEventsPage1TitleText.text = "Entertainment Service Upgrade";
                randomEventsPage2TitleText.text = "Entertainment Service Upgrade";

                //Establishing Increase
                generalPercent = UnityEngine.Random.Range(0.05F, 0.25F);
                generalPercent = Math.Round(generalPercent, 2);

                generalPercent1 = generalPercent * 100;
                generalPercent1 = Math.Round(generalPercent1, 1);

                randomEventsPage1DescriptionText.text = "Your Entertainment Service Provider is upgrading the service. While good, this means your Entertainment cost is increasing by " + generalPercent1 + "%.";

                RandomEvent12Page1Button.SetActive(false);
                RandomEvent16Page1Button.SetActive(true);

                RandomEvent16Page1ButtonText.text = "Entertainment Upgrade";

                RandomEventsPage1CloseButton.SetActive(false);

                break;
            case 17:
                // Hurricane Disaster
                negativeEventAudioSource.Play();

                randomEvent17Selected = true;

                randomEventsPage1TitleText.text = "Hurricane Disaster";
                randomEventsPage2TitleText.text = "Hurricane Disaster";

                hotelDays = UnityEngine.Random.Range(3, 5);

                if (livingWithParents == true)
                {
                    hotelRate1990 = UnityEngine.Random.Range(30.00F, 60.00F);
                    hotelRate1990 = Math.Round(hotelRate1990, 2);
                    hotelRate2020 = UnityEngine.Random.Range(60.00F, 90.00F);
                    hotelRate2020 = Math.Round(hotelRate2020, 2);
                }
                else if (livingWithRoommates == true)
                {
                    hotelRate1990 = UnityEngine.Random.Range(30.00F, 60.00F);
                    hotelRate1990 = Math.Round(hotelRate1990, 2);
                    hotelRate2020 = UnityEngine.Random.Range(60.00F, 90.00F);
                    hotelRate2020 = Math.Round(hotelRate2020, 2);
                }
                else if (basicApartment == true)
                {
                    hotelRate1990 = UnityEngine.Random.Range(60.00F, 90.00F);
                    hotelRate1990 = Math.Round(hotelRate1990, 2);
                    hotelRate2020 = UnityEngine.Random.Range(90.00F, 120.00F);
                    hotelRate2020 = Math.Round(hotelRate2020, 2);
                }
                else if (luxuryApartment == true)
                {
                    hotelRate1990 = UnityEngine.Random.Range(90.00F, 120.00F);
                    hotelRate1990 = Math.Round(hotelRate1990, 2);
                    hotelRate2020 = UnityEngine.Random.Range(120.00F, 150.00F);
                    hotelRate2020 = Math.Round(hotelRate2020, 2);
                }
                else if (basicHouse == true)
                {
                    hotelRate1990 = UnityEngine.Random.Range(60.00F, 90.00F);
                    hotelRate1990 = Math.Round(hotelRate1990, 2);
                    hotelRate2020 = UnityEngine.Random.Range(90.00F, 120.00F);
                    hotelRate2020 = Math.Round(hotelRate2020, 2);
                }
                else if (luxuryHouse == true)
                {
                    hotelRate1990 = UnityEngine.Random.Range(90.00F, 120.00F);
                    hotelRate1990 = Math.Round(hotelRate1990, 2);
                    hotelRate2020 = UnityEngine.Random.Range(120.00F, 150.00F);
                    hotelRate2020 = Math.Round(hotelRate2020, 2);
                }

                randomEventsPage1DescriptionText.text = "A hurricane has wrecked through your neighborhood and there is some damage to your home. You will have to temporarily stay in a hotel. You stay in the hotel for " + hotelDays + ".";
              
                RandomEvent12Page1Button.SetActive(false);
                RandomEvent17Page1Button.SetActive(true);

                RandomEvent17Page1ButtonText.text = "Pay Hotel Stay";

                RandomEventsPage1CloseButton.SetActive(false);

                break;
            case 18:
                // Unexpected Medical Emergency
                negativeEventAudioSource.Play();

                randomEvent18Selected = true;

                randomEventsPage1TitleText.text = "Unexpected Medical Emergency";
                randomEventsPage2TitleText.text = "Unexpected Medical Emergency";

                randomEventsPage1DescriptionText.text = "Oh no! You have had an Unexpected Medical Emergency. You are okay, but now you have a huge medical bill.";

                medicalCost1990 = UnityEngine.Random.Range(150.00F, 400.00F);
                medicalCost2020 = UnityEngine.Random.Range(250.00F, 700.00F);

                medicalCost1990 = Math.Round(medicalCost1990, 2);
                medicalCost2020 = Math.Round(medicalCost2020, 2);

                RandomEvent18Page1Button.SetActive(true);

                RandomEvent18Page1ButtonText.text = "Pay Medical Bill";

                RandomEventsPage1CloseButton.SetActive(false);

                break;
            case 19:
                // ???
                //music here

                randomEvent19Selected = true;

                randomEventsPage1TitleText.text = "";
                randomEventsPage2TitleText.text = "";

                randomEventsPage1DescriptionText.text = "";

                RandomEvent19Page1Button.SetActive(true);

                RandomEvent19Page1ButtonText.text = "";

                RandomEventsPage1CloseButton.SetActive(false);

                break;
            case 20:
                // ???
                //music here

                randomEvent20Selected = true;

                randomEventsPage1TitleText.text = "";
                randomEventsPage2TitleText.text = "";

                randomEventsPage1DescriptionText.text = "";

                RandomEvent20Page1Button.SetActive(true);

                RandomEvent20Page1ButtonText.text = "";

                RandomEventsPage1CloseButton.SetActive(false);

                break;
            case 21:
                // ???
                //msic here

                randomEvent21Selected = true;

                randomEventsPage1TitleText.text = "";
                randomEventsPage2TitleText.text = "";

                randomEventsPage1DescriptionText.text = "";

                RandomEvent01Page1Button.SetActive(false);
                RandomEvent02Page1Button.SetActive(false);
                RandomEvent03Page1Button.SetActive(false);
                RandomEvent04Page1Button.SetActive(false);
                RandomEvent05Page1Button.SetActive(false);
                RandomEvent06Page1Button.SetActive(false);
                RandomEvent07Page1Button.SetActive(false);
                RandomEvent08Page1Button.SetActive(false);
                RandomEvent09Page1Button.SetActive(false);
                RandomEvent10Page1Button.SetActive(false);
                RandomEvent11Page1Button.SetActive(false);
                RandomEvent12Page1Button.SetActive(false);
                RandomEvent13Page1Button.SetActive(false);
                RandomEvent14Page1Button.SetActive(false);
                RandomEvent15Page1Button.SetActive(false);
                RandomEvent16Page1Button.SetActive(false);
                RandomEvent17Page1Button.SetActive(false);
                RandomEvent18Page1Button.SetActive(false);
                RandomEvent19Page1Button.SetActive(false);
                RandomEvent20Page1Button.SetActive(false);
                RandomEvent21Page1Button.SetActive(true);
                RandomEvent22Page1Button.SetActive(false);
                RandomEvent23Page1Button.SetActive(false);
                RandomEvent24Page1Button.SetActive(false);
                RandomEvent25Page1Button.SetActive(false);
                RandomEvent26Page1Button.SetActive(false);
                RandomEvent27Page1Button.SetActive(false);
                RandomEvent28Page1Button.SetActive(false);
                RandomEvent29Page1Button.SetActive(false);
                RandomEvent30Page1Button.SetActive(false);
                RandomEvent31Page1Button.SetActive(false);
                RandomEvent32Page1Button.SetActive(false);
                RandomEvent33Page1Button.SetActive(false);
                RandomEvent34Page1Button.SetActive(false);
                RandomEvent35Page1Button.SetActive(false);
                RandomEvent36Page1Button.SetActive(false);
                RandomEvent37Page1Button.SetActive(false);
                RandomEvent38Page1Button.SetActive(false);
                RandomEvent39Page1Button.SetActive(false);
                RandomEvent40Page1Button.SetActive(false);
                RandomEvent41Page1Button.SetActive(false);
                RandomEvent42Page1Button.SetActive(false);
                RandomEvent43Page1Button.SetActive(false);
                RandomEvent44Page1Button.SetActive(false);
                RandomEvent45Page1Button.SetActive(false);
                RandomEvent46Page1Button.SetActive(false);
                RandomEvent47Page1Button.SetActive(false);
                RandomEvent48Page1Button.SetActive(false);
                RandomEvent49Page1Button.SetActive(false);
                RandomEvent50Page1Button.SetActive(false);

                RandomEvent21Page1ButtonText.text = "";

                RandomEventsPage1CloseButton.SetActive(false);

                break;
            case 22:
                // ???
                //music here

                randomEvent22Selected = true;

                randomEventsPage1TitleText.text = "";
                randomEventsPage2TitleText.text = "";

                randomEventsPage1DescriptionText.text = "";

                RandomEvent01Page1Button.SetActive(false);
                RandomEvent02Page1Button.SetActive(false);
                RandomEvent03Page1Button.SetActive(false);
                RandomEvent04Page1Button.SetActive(false);
                RandomEvent05Page1Button.SetActive(false);
                RandomEvent06Page1Button.SetActive(false);
                RandomEvent07Page1Button.SetActive(false);
                RandomEvent08Page1Button.SetActive(false);
                RandomEvent09Page1Button.SetActive(false);
                RandomEvent10Page1Button.SetActive(false);
                RandomEvent11Page1Button.SetActive(false);
                RandomEvent12Page1Button.SetActive(false);
                RandomEvent13Page1Button.SetActive(false);
                RandomEvent14Page1Button.SetActive(false);
                RandomEvent15Page1Button.SetActive(false);
                RandomEvent16Page1Button.SetActive(false);
                RandomEvent17Page1Button.SetActive(false);
                RandomEvent18Page1Button.SetActive(false);
                RandomEvent19Page1Button.SetActive(false);
                RandomEvent20Page1Button.SetActive(false);
                RandomEvent21Page1Button.SetActive(false);
                RandomEvent22Page1Button.SetActive(true);
                RandomEvent23Page1Button.SetActive(false);
                RandomEvent24Page1Button.SetActive(false);
                RandomEvent25Page1Button.SetActive(false);
                RandomEvent26Page1Button.SetActive(false);
                RandomEvent27Page1Button.SetActive(false);
                RandomEvent28Page1Button.SetActive(false);
                RandomEvent29Page1Button.SetActive(false);
                RandomEvent30Page1Button.SetActive(false);
                RandomEvent31Page1Button.SetActive(false);
                RandomEvent32Page1Button.SetActive(false);
                RandomEvent33Page1Button.SetActive(false);
                RandomEvent34Page1Button.SetActive(false);
                RandomEvent35Page1Button.SetActive(false);
                RandomEvent36Page1Button.SetActive(false);
                RandomEvent37Page1Button.SetActive(false);
                RandomEvent38Page1Button.SetActive(false);
                RandomEvent39Page1Button.SetActive(false);
                RandomEvent40Page1Button.SetActive(false);
                RandomEvent41Page1Button.SetActive(false);
                RandomEvent42Page1Button.SetActive(false);
                RandomEvent43Page1Button.SetActive(false);
                RandomEvent44Page1Button.SetActive(false);
                RandomEvent45Page1Button.SetActive(false);
                RandomEvent46Page1Button.SetActive(false);
                RandomEvent47Page1Button.SetActive(false);
                RandomEvent48Page1Button.SetActive(false);
                RandomEvent49Page1Button.SetActive(false);
                RandomEvent50Page1Button.SetActive(false);

                RandomEvent22Page1ButtonText.text = "";

                RandomEventsPage1CloseButton.SetActive(false);

                break;
            case 23:
                // ???
                //music here

                randomEvent23Selected = true;

                randomEventsPage1TitleText.text = "";
                randomEventsPage2TitleText.text = "";

                randomEventsPage1DescriptionText.text = "";

                RandomEvent01Page1Button.SetActive(false);
                RandomEvent02Page1Button.SetActive(false);
                RandomEvent03Page1Button.SetActive(false);
                RandomEvent04Page1Button.SetActive(false);
                RandomEvent05Page1Button.SetActive(false);
                RandomEvent06Page1Button.SetActive(false);
                RandomEvent07Page1Button.SetActive(false);
                RandomEvent08Page1Button.SetActive(false);
                RandomEvent09Page1Button.SetActive(false);
                RandomEvent10Page1Button.SetActive(false);
                RandomEvent11Page1Button.SetActive(false);
                RandomEvent12Page1Button.SetActive(false);
                RandomEvent13Page1Button.SetActive(false);
                RandomEvent14Page1Button.SetActive(false);
                RandomEvent15Page1Button.SetActive(false);
                RandomEvent16Page1Button.SetActive(false);
                RandomEvent17Page1Button.SetActive(false);
                RandomEvent18Page1Button.SetActive(false);
                RandomEvent19Page1Button.SetActive(false);
                RandomEvent20Page1Button.SetActive(false);
                RandomEvent21Page1Button.SetActive(false);
                RandomEvent22Page1Button.SetActive(false);
                RandomEvent23Page1Button.SetActive(true);
                RandomEvent24Page1Button.SetActive(false);
                RandomEvent25Page1Button.SetActive(false);
                RandomEvent26Page1Button.SetActive(false);
                RandomEvent27Page1Button.SetActive(false);
                RandomEvent28Page1Button.SetActive(false);
                RandomEvent29Page1Button.SetActive(false);
                RandomEvent30Page1Button.SetActive(false);
                RandomEvent31Page1Button.SetActive(false);
                RandomEvent32Page1Button.SetActive(false);
                RandomEvent33Page1Button.SetActive(false);
                RandomEvent34Page1Button.SetActive(false);
                RandomEvent35Page1Button.SetActive(false);
                RandomEvent36Page1Button.SetActive(false);
                RandomEvent37Page1Button.SetActive(false);
                RandomEvent38Page1Button.SetActive(false);
                RandomEvent39Page1Button.SetActive(false);
                RandomEvent40Page1Button.SetActive(false);
                RandomEvent41Page1Button.SetActive(false);
                RandomEvent42Page1Button.SetActive(false);
                RandomEvent43Page1Button.SetActive(false);
                RandomEvent44Page1Button.SetActive(false);
                RandomEvent45Page1Button.SetActive(false);
                RandomEvent46Page1Button.SetActive(false);
                RandomEvent47Page1Button.SetActive(false);
                RandomEvent48Page1Button.SetActive(false);
                RandomEvent49Page1Button.SetActive(false);
                RandomEvent50Page1Button.SetActive(false);

                RandomEvent23Page1ButtonText.text = "";

                RandomEventsPage1CloseButton.SetActive(false);

                break;
            case 24:
                // ???
                //music here

                randomEvent24Selected = true;

                randomEventsPage1TitleText.text = "";
                randomEventsPage2TitleText.text = "";

                randomEventsPage1DescriptionText.text = "";

                RandomEvent01Page1Button.SetActive(false);
                RandomEvent02Page1Button.SetActive(false);
                RandomEvent03Page1Button.SetActive(false);
                RandomEvent04Page1Button.SetActive(false);
                RandomEvent05Page1Button.SetActive(false);
                RandomEvent06Page1Button.SetActive(false);
                RandomEvent07Page1Button.SetActive(false);
                RandomEvent08Page1Button.SetActive(false);
                RandomEvent09Page1Button.SetActive(false);
                RandomEvent10Page1Button.SetActive(false);
                RandomEvent11Page1Button.SetActive(false);
                RandomEvent12Page1Button.SetActive(false);
                RandomEvent13Page1Button.SetActive(false);
                RandomEvent14Page1Button.SetActive(false);
                RandomEvent15Page1Button.SetActive(false);
                RandomEvent16Page1Button.SetActive(false);
                RandomEvent17Page1Button.SetActive(false);
                RandomEvent18Page1Button.SetActive(false);
                RandomEvent19Page1Button.SetActive(false);
                RandomEvent20Page1Button.SetActive(false);
                RandomEvent21Page1Button.SetActive(false);
                RandomEvent22Page1Button.SetActive(false);
                RandomEvent23Page1Button.SetActive(false);
                RandomEvent24Page1Button.SetActive(true);
                RandomEvent25Page1Button.SetActive(false);
                RandomEvent26Page1Button.SetActive(false);
                RandomEvent27Page1Button.SetActive(false);
                RandomEvent28Page1Button.SetActive(false);
                RandomEvent29Page1Button.SetActive(false);
                RandomEvent30Page1Button.SetActive(false);
                RandomEvent31Page1Button.SetActive(false);
                RandomEvent32Page1Button.SetActive(false);
                RandomEvent33Page1Button.SetActive(false);
                RandomEvent34Page1Button.SetActive(false);
                RandomEvent35Page1Button.SetActive(false);
                RandomEvent36Page1Button.SetActive(false);
                RandomEvent37Page1Button.SetActive(false);
                RandomEvent38Page1Button.SetActive(false);
                RandomEvent39Page1Button.SetActive(false);
                RandomEvent40Page1Button.SetActive(false);
                RandomEvent41Page1Button.SetActive(false);
                RandomEvent42Page1Button.SetActive(false);
                RandomEvent43Page1Button.SetActive(false);
                RandomEvent44Page1Button.SetActive(false);
                RandomEvent45Page1Button.SetActive(false);
                RandomEvent46Page1Button.SetActive(false);
                RandomEvent47Page1Button.SetActive(false);
                RandomEvent48Page1Button.SetActive(false);
                RandomEvent49Page1Button.SetActive(false);
                RandomEvent50Page1Button.SetActive(false);

                RandomEvent24Page1ButtonText.text = "";

                RandomEventsPage1CloseButton.SetActive(false);

                break;
            case 25:
                // ???
                //music here

                randomEvent25Selected = true;

                randomEventsPage1TitleText.text = "";
                randomEventsPage2TitleText.text = "";

                randomEventsPage1DescriptionText.text = "";

                RandomEvent01Page1Button.SetActive(false);
                RandomEvent02Page1Button.SetActive(false);
                RandomEvent03Page1Button.SetActive(false);
                RandomEvent04Page1Button.SetActive(false);
                RandomEvent05Page1Button.SetActive(false);
                RandomEvent06Page1Button.SetActive(false);
                RandomEvent07Page1Button.SetActive(false);
                RandomEvent08Page1Button.SetActive(false);
                RandomEvent09Page1Button.SetActive(false);
                RandomEvent10Page1Button.SetActive(false);
                RandomEvent11Page1Button.SetActive(false);
                RandomEvent12Page1Button.SetActive(false);
                RandomEvent13Page1Button.SetActive(false);
                RandomEvent14Page1Button.SetActive(false);
                RandomEvent15Page1Button.SetActive(false);
                RandomEvent16Page1Button.SetActive(false);
                RandomEvent17Page1Button.SetActive(false);
                RandomEvent18Page1Button.SetActive(false);
                RandomEvent19Page1Button.SetActive(false);
                RandomEvent20Page1Button.SetActive(false);
                RandomEvent21Page1Button.SetActive(false);
                RandomEvent22Page1Button.SetActive(false);
                RandomEvent23Page1Button.SetActive(false);
                RandomEvent24Page1Button.SetActive(false);
                RandomEvent25Page1Button.SetActive(true);
                RandomEvent26Page1Button.SetActive(false);
                RandomEvent27Page1Button.SetActive(false);
                RandomEvent28Page1Button.SetActive(false);
                RandomEvent29Page1Button.SetActive(false);
                RandomEvent30Page1Button.SetActive(false);
                RandomEvent31Page1Button.SetActive(false);
                RandomEvent32Page1Button.SetActive(false);
                RandomEvent33Page1Button.SetActive(false);
                RandomEvent34Page1Button.SetActive(false);
                RandomEvent35Page1Button.SetActive(false);
                RandomEvent36Page1Button.SetActive(false);
                RandomEvent37Page1Button.SetActive(false);
                RandomEvent38Page1Button.SetActive(false);
                RandomEvent39Page1Button.SetActive(false);
                RandomEvent40Page1Button.SetActive(false);
                RandomEvent41Page1Button.SetActive(false);
                RandomEvent42Page1Button.SetActive(false);
                RandomEvent43Page1Button.SetActive(false);
                RandomEvent44Page1Button.SetActive(false);
                RandomEvent45Page1Button.SetActive(false);
                RandomEvent46Page1Button.SetActive(false);
                RandomEvent47Page1Button.SetActive(false);
                RandomEvent48Page1Button.SetActive(false);
                RandomEvent49Page1Button.SetActive(false);
                RandomEvent50Page1Button.SetActive(false);

                RandomEvent25Page1ButtonText.text = "";

                RandomEventsPage1CloseButton.SetActive(false);

                break;
            case 26:
                // ???
                //music here

                randomEvent26Selected = true;

                randomEventsPage1TitleText.text = "";
                randomEventsPage2TitleText.text = "";

                randomEventsPage1DescriptionText.text = "";

                RandomEvent01Page1Button.SetActive(false);
                RandomEvent02Page1Button.SetActive(false);
                RandomEvent03Page1Button.SetActive(false);
                RandomEvent04Page1Button.SetActive(false);
                RandomEvent05Page1Button.SetActive(false);
                RandomEvent06Page1Button.SetActive(false);
                RandomEvent07Page1Button.SetActive(false);
                RandomEvent08Page1Button.SetActive(false);
                RandomEvent09Page1Button.SetActive(false);
                RandomEvent10Page1Button.SetActive(false);
                RandomEvent11Page1Button.SetActive(false);
                RandomEvent12Page1Button.SetActive(false);
                RandomEvent13Page1Button.SetActive(false);
                RandomEvent14Page1Button.SetActive(false);
                RandomEvent15Page1Button.SetActive(false);
                RandomEvent16Page1Button.SetActive(false);
                RandomEvent17Page1Button.SetActive(false);
                RandomEvent18Page1Button.SetActive(false);
                RandomEvent19Page1Button.SetActive(false);
                RandomEvent20Page1Button.SetActive(false);
                RandomEvent21Page1Button.SetActive(false);
                RandomEvent22Page1Button.SetActive(false);
                RandomEvent23Page1Button.SetActive(false);
                RandomEvent24Page1Button.SetActive(false);
                RandomEvent25Page1Button.SetActive(false);
                RandomEvent26Page1Button.SetActive(true);
                RandomEvent27Page1Button.SetActive(false);
                RandomEvent28Page1Button.SetActive(false);
                RandomEvent29Page1Button.SetActive(false);
                RandomEvent30Page1Button.SetActive(false);
                RandomEvent31Page1Button.SetActive(false);
                RandomEvent32Page1Button.SetActive(false);
                RandomEvent33Page1Button.SetActive(false);
                RandomEvent34Page1Button.SetActive(false);
                RandomEvent35Page1Button.SetActive(false);
                RandomEvent36Page1Button.SetActive(false);
                RandomEvent37Page1Button.SetActive(false);
                RandomEvent38Page1Button.SetActive(false);
                RandomEvent39Page1Button.SetActive(false);
                RandomEvent40Page1Button.SetActive(false);
                RandomEvent41Page1Button.SetActive(false);
                RandomEvent42Page1Button.SetActive(false);
                RandomEvent43Page1Button.SetActive(false);
                RandomEvent44Page1Button.SetActive(false);
                RandomEvent45Page1Button.SetActive(false);
                RandomEvent46Page1Button.SetActive(false);
                RandomEvent47Page1Button.SetActive(false);
                RandomEvent48Page1Button.SetActive(false);
                RandomEvent49Page1Button.SetActive(false);
                RandomEvent50Page1Button.SetActive(false);

                RandomEvent26Page1ButtonText.text = "";

                RandomEventsPage1CloseButton.SetActive(false);

                break;
            case 27:
                // ???
                //music here

                randomEvent01Selected = true;

                randomEventsPage1TitleText.text = "";
                randomEventsPage2TitleText.text = "";

                randomEventsPage1DescriptionText.text = "";

                RandomEvent01Page1Button.SetActive(false);
                RandomEvent02Page1Button.SetActive(false);
                RandomEvent03Page1Button.SetActive(false);
                RandomEvent04Page1Button.SetActive(false);
                RandomEvent05Page1Button.SetActive(false);
                RandomEvent06Page1Button.SetActive(false);
                RandomEvent07Page1Button.SetActive(false);
                RandomEvent08Page1Button.SetActive(false);
                RandomEvent09Page1Button.SetActive(false);
                RandomEvent10Page1Button.SetActive(false);
                RandomEvent11Page1Button.SetActive(false);
                RandomEvent12Page1Button.SetActive(false);
                RandomEvent13Page1Button.SetActive(false);
                RandomEvent14Page1Button.SetActive(false);
                RandomEvent15Page1Button.SetActive(false);
                RandomEvent16Page1Button.SetActive(false);
                RandomEvent17Page1Button.SetActive(false);
                RandomEvent18Page1Button.SetActive(false);
                RandomEvent19Page1Button.SetActive(false);
                RandomEvent20Page1Button.SetActive(false);
                RandomEvent21Page1Button.SetActive(false);
                RandomEvent22Page1Button.SetActive(false);
                RandomEvent23Page1Button.SetActive(false);
                RandomEvent24Page1Button.SetActive(false);
                RandomEvent25Page1Button.SetActive(false);
                RandomEvent26Page1Button.SetActive(false);
                RandomEvent27Page1Button.SetActive(true);
                RandomEvent28Page1Button.SetActive(false);
                RandomEvent29Page1Button.SetActive(false);
                RandomEvent30Page1Button.SetActive(false);
                RandomEvent31Page1Button.SetActive(false);
                RandomEvent32Page1Button.SetActive(false);
                RandomEvent33Page1Button.SetActive(false);
                RandomEvent34Page1Button.SetActive(false);
                RandomEvent35Page1Button.SetActive(false);
                RandomEvent36Page1Button.SetActive(false);
                RandomEvent37Page1Button.SetActive(false);
                RandomEvent38Page1Button.SetActive(false);
                RandomEvent39Page1Button.SetActive(false);
                RandomEvent40Page1Button.SetActive(false);
                RandomEvent41Page1Button.SetActive(false);
                RandomEvent42Page1Button.SetActive(false);
                RandomEvent43Page1Button.SetActive(false);
                RandomEvent44Page1Button.SetActive(false);
                RandomEvent45Page1Button.SetActive(false);
                RandomEvent46Page1Button.SetActive(false);
                RandomEvent47Page1Button.SetActive(false);
                RandomEvent48Page1Button.SetActive(false);
                RandomEvent49Page1Button.SetActive(false);
                RandomEvent50Page1Button.SetActive(false);

                RandomEvent27Page1ButtonText.text = "";

                RandomEventsPage1CloseButton.SetActive(false);

                break;
            case 28:
                // ???
                //music here

                randomEvent28Selected = true;

                randomEventsPage1TitleText.text = "";
                randomEventsPage2TitleText.text = "";

                randomEventsPage1DescriptionText.text = "";

                RandomEvent01Page1Button.SetActive(false);
                RandomEvent02Page1Button.SetActive(false);
                RandomEvent03Page1Button.SetActive(false);
                RandomEvent04Page1Button.SetActive(false);
                RandomEvent05Page1Button.SetActive(false);
                RandomEvent06Page1Button.SetActive(false);
                RandomEvent07Page1Button.SetActive(false);
                RandomEvent08Page1Button.SetActive(false);
                RandomEvent09Page1Button.SetActive(false);
                RandomEvent10Page1Button.SetActive(false);
                RandomEvent11Page1Button.SetActive(false);
                RandomEvent12Page1Button.SetActive(false);
                RandomEvent13Page1Button.SetActive(false);
                RandomEvent14Page1Button.SetActive(false);
                RandomEvent15Page1Button.SetActive(false);
                RandomEvent16Page1Button.SetActive(false);
                RandomEvent17Page1Button.SetActive(false);
                RandomEvent18Page1Button.SetActive(false);
                RandomEvent19Page1Button.SetActive(false);
                RandomEvent20Page1Button.SetActive(false);
                RandomEvent21Page1Button.SetActive(false);
                RandomEvent22Page1Button.SetActive(false);
                RandomEvent23Page1Button.SetActive(false);
                RandomEvent24Page1Button.SetActive(false);
                RandomEvent25Page1Button.SetActive(false);
                RandomEvent26Page1Button.SetActive(false);
                RandomEvent27Page1Button.SetActive(false);
                RandomEvent28Page1Button.SetActive(true);
                RandomEvent29Page1Button.SetActive(false);
                RandomEvent30Page1Button.SetActive(false);
                RandomEvent31Page1Button.SetActive(false);
                RandomEvent32Page1Button.SetActive(false);
                RandomEvent33Page1Button.SetActive(false);
                RandomEvent34Page1Button.SetActive(false);
                RandomEvent35Page1Button.SetActive(false);
                RandomEvent36Page1Button.SetActive(false);
                RandomEvent37Page1Button.SetActive(false);
                RandomEvent38Page1Button.SetActive(false);
                RandomEvent39Page1Button.SetActive(false);
                RandomEvent40Page1Button.SetActive(false);
                RandomEvent41Page1Button.SetActive(false);
                RandomEvent42Page1Button.SetActive(false);
                RandomEvent43Page1Button.SetActive(false);
                RandomEvent44Page1Button.SetActive(false);
                RandomEvent45Page1Button.SetActive(false);
                RandomEvent46Page1Button.SetActive(false);
                RandomEvent47Page1Button.SetActive(false);
                RandomEvent48Page1Button.SetActive(false);
                RandomEvent49Page1Button.SetActive(false);
                RandomEvent50Page1Button.SetActive(false);

                RandomEvent28Page1ButtonText.text = "";

                RandomEventsPage1CloseButton.SetActive(false);

                break;
            case 29:
                // ???
                //music here

                randomEvent29Selected = true;

                randomEventsPage1TitleText.text = "";
                randomEventsPage2TitleText.text = "";

                randomEventsPage1DescriptionText.text = "";

                RandomEvent01Page1Button.SetActive(false);
                RandomEvent02Page1Button.SetActive(false);
                RandomEvent03Page1Button.SetActive(false);
                RandomEvent04Page1Button.SetActive(false);
                RandomEvent05Page1Button.SetActive(false);
                RandomEvent06Page1Button.SetActive(false);
                RandomEvent07Page1Button.SetActive(false);
                RandomEvent08Page1Button.SetActive(false);
                RandomEvent09Page1Button.SetActive(false);
                RandomEvent10Page1Button.SetActive(false);
                RandomEvent11Page1Button.SetActive(false);
                RandomEvent12Page1Button.SetActive(false);
                RandomEvent13Page1Button.SetActive(false);
                RandomEvent14Page1Button.SetActive(false);
                RandomEvent15Page1Button.SetActive(false);
                RandomEvent16Page1Button.SetActive(false);
                RandomEvent17Page1Button.SetActive(false);
                RandomEvent18Page1Button.SetActive(false);
                RandomEvent19Page1Button.SetActive(false);
                RandomEvent20Page1Button.SetActive(false);
                RandomEvent21Page1Button.SetActive(false);
                RandomEvent22Page1Button.SetActive(false);
                RandomEvent23Page1Button.SetActive(false);
                RandomEvent24Page1Button.SetActive(false);
                RandomEvent25Page1Button.SetActive(false);
                RandomEvent26Page1Button.SetActive(false);
                RandomEvent27Page1Button.SetActive(false);
                RandomEvent28Page1Button.SetActive(false);
                RandomEvent29Page1Button.SetActive(true);
                RandomEvent30Page1Button.SetActive(false);
                RandomEvent31Page1Button.SetActive(false);
                RandomEvent32Page1Button.SetActive(false);
                RandomEvent33Page1Button.SetActive(false);
                RandomEvent34Page1Button.SetActive(false);
                RandomEvent35Page1Button.SetActive(false);
                RandomEvent36Page1Button.SetActive(false);
                RandomEvent37Page1Button.SetActive(false);
                RandomEvent38Page1Button.SetActive(false);
                RandomEvent39Page1Button.SetActive(false);
                RandomEvent40Page1Button.SetActive(false);
                RandomEvent41Page1Button.SetActive(false);
                RandomEvent42Page1Button.SetActive(false);
                RandomEvent43Page1Button.SetActive(false);
                RandomEvent44Page1Button.SetActive(false);
                RandomEvent45Page1Button.SetActive(false);
                RandomEvent46Page1Button.SetActive(false);
                RandomEvent47Page1Button.SetActive(false);
                RandomEvent48Page1Button.SetActive(false);
                RandomEvent49Page1Button.SetActive(false);
                RandomEvent50Page1Button.SetActive(false);

                RandomEvent29Page1ButtonText.text = "";

                RandomEventsPage1CloseButton.SetActive(false);

                break;
            case 30:
                // ???
                //music here

                randomEvent30Selected = true;

                randomEventsPage1TitleText.text = "";
                randomEventsPage2TitleText.text = "";

                randomEventsPage1DescriptionText.text = "";

                RandomEvent01Page1Button.SetActive(false);
                RandomEvent02Page1Button.SetActive(false);
                RandomEvent03Page1Button.SetActive(false);
                RandomEvent04Page1Button.SetActive(false);
                RandomEvent05Page1Button.SetActive(false);
                RandomEvent06Page1Button.SetActive(false);
                RandomEvent07Page1Button.SetActive(false);
                RandomEvent08Page1Button.SetActive(false);
                RandomEvent09Page1Button.SetActive(false);
                RandomEvent10Page1Button.SetActive(false);
                RandomEvent11Page1Button.SetActive(false);
                RandomEvent12Page1Button.SetActive(false);
                RandomEvent13Page1Button.SetActive(false);
                RandomEvent14Page1Button.SetActive(false);
                RandomEvent15Page1Button.SetActive(false);
                RandomEvent16Page1Button.SetActive(false);
                RandomEvent17Page1Button.SetActive(false);
                RandomEvent18Page1Button.SetActive(false);
                RandomEvent19Page1Button.SetActive(false);
                RandomEvent20Page1Button.SetActive(false);
                RandomEvent21Page1Button.SetActive(false);
                RandomEvent22Page1Button.SetActive(false);
                RandomEvent23Page1Button.SetActive(false);
                RandomEvent24Page1Button.SetActive(false);
                RandomEvent25Page1Button.SetActive(false);
                RandomEvent26Page1Button.SetActive(false);
                RandomEvent27Page1Button.SetActive(false);
                RandomEvent28Page1Button.SetActive(false);
                RandomEvent29Page1Button.SetActive(false);
                RandomEvent30Page1Button.SetActive(true);
                RandomEvent31Page1Button.SetActive(false);
                RandomEvent32Page1Button.SetActive(false);
                RandomEvent33Page1Button.SetActive(false);
                RandomEvent34Page1Button.SetActive(false);
                RandomEvent35Page1Button.SetActive(false);
                RandomEvent36Page1Button.SetActive(false);
                RandomEvent37Page1Button.SetActive(false);
                RandomEvent38Page1Button.SetActive(false);
                RandomEvent39Page1Button.SetActive(false);
                RandomEvent40Page1Button.SetActive(false);
                RandomEvent41Page1Button.SetActive(false);
                RandomEvent42Page1Button.SetActive(false);
                RandomEvent43Page1Button.SetActive(false);
                RandomEvent44Page1Button.SetActive(false);
                RandomEvent45Page1Button.SetActive(false);
                RandomEvent46Page1Button.SetActive(false);
                RandomEvent47Page1Button.SetActive(false);
                RandomEvent48Page1Button.SetActive(false);
                RandomEvent49Page1Button.SetActive(false);
                RandomEvent50Page1Button.SetActive(false);

                RandomEvent30Page1ButtonText.text = "";

                RandomEventsPage1CloseButton.SetActive(false);

                break;
            case 31:
                // ???
                //music here

                randomEvent31Selected = true;

                randomEventsPage1TitleText.text = "";
                randomEventsPage2TitleText.text = "";

                randomEventsPage1DescriptionText.text = "";

                RandomEvent01Page1Button.SetActive(false);
                RandomEvent02Page1Button.SetActive(false);
                RandomEvent03Page1Button.SetActive(false);
                RandomEvent04Page1Button.SetActive(false);
                RandomEvent05Page1Button.SetActive(false);
                RandomEvent06Page1Button.SetActive(false);
                RandomEvent07Page1Button.SetActive(false);
                RandomEvent08Page1Button.SetActive(false);
                RandomEvent09Page1Button.SetActive(false);
                RandomEvent10Page1Button.SetActive(false);
                RandomEvent11Page1Button.SetActive(false);
                RandomEvent12Page1Button.SetActive(false);
                RandomEvent13Page1Button.SetActive(false);
                RandomEvent14Page1Button.SetActive(false);
                RandomEvent15Page1Button.SetActive(false);
                RandomEvent16Page1Button.SetActive(false);
                RandomEvent17Page1Button.SetActive(false);
                RandomEvent18Page1Button.SetActive(false);
                RandomEvent19Page1Button.SetActive(false);
                RandomEvent20Page1Button.SetActive(false);
                RandomEvent21Page1Button.SetActive(false);
                RandomEvent22Page1Button.SetActive(false);
                RandomEvent23Page1Button.SetActive(false);
                RandomEvent24Page1Button.SetActive(false);
                RandomEvent25Page1Button.SetActive(false);
                RandomEvent26Page1Button.SetActive(false);
                RandomEvent27Page1Button.SetActive(false);
                RandomEvent28Page1Button.SetActive(false);
                RandomEvent29Page1Button.SetActive(false);
                RandomEvent30Page1Button.SetActive(false);
                RandomEvent31Page1Button.SetActive(true);
                RandomEvent32Page1Button.SetActive(false);
                RandomEvent33Page1Button.SetActive(false);
                RandomEvent34Page1Button.SetActive(false);
                RandomEvent35Page1Button.SetActive(false);
                RandomEvent36Page1Button.SetActive(false);
                RandomEvent37Page1Button.SetActive(false);
                RandomEvent38Page1Button.SetActive(false);
                RandomEvent39Page1Button.SetActive(false);
                RandomEvent40Page1Button.SetActive(false);
                RandomEvent41Page1Button.SetActive(false);
                RandomEvent42Page1Button.SetActive(false);
                RandomEvent43Page1Button.SetActive(false);
                RandomEvent44Page1Button.SetActive(false);
                RandomEvent45Page1Button.SetActive(false);
                RandomEvent46Page1Button.SetActive(false);
                RandomEvent47Page1Button.SetActive(false);
                RandomEvent48Page1Button.SetActive(false);
                RandomEvent49Page1Button.SetActive(false);
                RandomEvent50Page1Button.SetActive(false);

                RandomEvent31Page1ButtonText.text = "";

                RandomEventsPage1CloseButton.SetActive(false);

                break;
            case 32:
                // ???
                //music here

                randomEvent32Selected = true;

                randomEventsPage1TitleText.text = "";
                randomEventsPage2TitleText.text = "";

                randomEventsPage1DescriptionText.text = "";

                RandomEvent01Page1Button.SetActive(false);
                RandomEvent02Page1Button.SetActive(false);
                RandomEvent03Page1Button.SetActive(false);
                RandomEvent04Page1Button.SetActive(false);
                RandomEvent05Page1Button.SetActive(false);
                RandomEvent06Page1Button.SetActive(false);
                RandomEvent07Page1Button.SetActive(false);
                RandomEvent08Page1Button.SetActive(false);
                RandomEvent09Page1Button.SetActive(false);
                RandomEvent10Page1Button.SetActive(false);
                RandomEvent11Page1Button.SetActive(false);
                RandomEvent12Page1Button.SetActive(false);
                RandomEvent13Page1Button.SetActive(false);
                RandomEvent14Page1Button.SetActive(false);
                RandomEvent15Page1Button.SetActive(false);
                RandomEvent16Page1Button.SetActive(false);
                RandomEvent17Page1Button.SetActive(false);
                RandomEvent18Page1Button.SetActive(false);
                RandomEvent19Page1Button.SetActive(false);
                RandomEvent20Page1Button.SetActive(false);
                RandomEvent21Page1Button.SetActive(false);
                RandomEvent22Page1Button.SetActive(false);
                RandomEvent23Page1Button.SetActive(false);
                RandomEvent24Page1Button.SetActive(false);
                RandomEvent25Page1Button.SetActive(false);
                RandomEvent26Page1Button.SetActive(false);
                RandomEvent27Page1Button.SetActive(false);
                RandomEvent28Page1Button.SetActive(false);
                RandomEvent29Page1Button.SetActive(false);
                RandomEvent30Page1Button.SetActive(false);
                RandomEvent31Page1Button.SetActive(false);
                RandomEvent32Page1Button.SetActive(true);
                RandomEvent33Page1Button.SetActive(false);
                RandomEvent34Page1Button.SetActive(false);
                RandomEvent35Page1Button.SetActive(false);
                RandomEvent36Page1Button.SetActive(false);
                RandomEvent37Page1Button.SetActive(false);
                RandomEvent38Page1Button.SetActive(false);
                RandomEvent39Page1Button.SetActive(false);
                RandomEvent40Page1Button.SetActive(false);
                RandomEvent41Page1Button.SetActive(false);
                RandomEvent42Page1Button.SetActive(false);
                RandomEvent43Page1Button.SetActive(false);
                RandomEvent44Page1Button.SetActive(false);
                RandomEvent45Page1Button.SetActive(false);
                RandomEvent46Page1Button.SetActive(false);
                RandomEvent47Page1Button.SetActive(false);
                RandomEvent48Page1Button.SetActive(false);
                RandomEvent49Page1Button.SetActive(false);
                RandomEvent50Page1Button.SetActive(false);

                RandomEvent32Page1ButtonText.text = "";

                RandomEventsPage1CloseButton.SetActive(false);

                break;
            case 33:
                // ???
                //music here

                randomEvent33Selected = true;

                randomEventsPage1TitleText.text = "";
                randomEventsPage2TitleText.text = "";

                randomEventsPage1DescriptionText.text = "";

                RandomEvent01Page1Button.SetActive(false);
                RandomEvent02Page1Button.SetActive(false);
                RandomEvent03Page1Button.SetActive(false);
                RandomEvent04Page1Button.SetActive(false);
                RandomEvent05Page1Button.SetActive(false);
                RandomEvent06Page1Button.SetActive(false);
                RandomEvent07Page1Button.SetActive(false);
                RandomEvent08Page1Button.SetActive(false);
                RandomEvent09Page1Button.SetActive(false);
                RandomEvent10Page1Button.SetActive(false);
                RandomEvent11Page1Button.SetActive(false);
                RandomEvent12Page1Button.SetActive(false);
                RandomEvent13Page1Button.SetActive(false);
                RandomEvent14Page1Button.SetActive(false);
                RandomEvent15Page1Button.SetActive(false);
                RandomEvent16Page1Button.SetActive(false);
                RandomEvent17Page1Button.SetActive(false);
                RandomEvent18Page1Button.SetActive(false);
                RandomEvent19Page1Button.SetActive(false);
                RandomEvent20Page1Button.SetActive(false);
                RandomEvent21Page1Button.SetActive(false);
                RandomEvent22Page1Button.SetActive(false);
                RandomEvent23Page1Button.SetActive(false);
                RandomEvent24Page1Button.SetActive(false);
                RandomEvent25Page1Button.SetActive(false);
                RandomEvent26Page1Button.SetActive(false);
                RandomEvent27Page1Button.SetActive(false);
                RandomEvent28Page1Button.SetActive(false);
                RandomEvent29Page1Button.SetActive(false);
                RandomEvent30Page1Button.SetActive(false);
                RandomEvent31Page1Button.SetActive(false);
                RandomEvent32Page1Button.SetActive(false);
                RandomEvent33Page1Button.SetActive(true);
                RandomEvent34Page1Button.SetActive(false);
                RandomEvent35Page1Button.SetActive(false);
                RandomEvent36Page1Button.SetActive(false);
                RandomEvent37Page1Button.SetActive(false);
                RandomEvent38Page1Button.SetActive(false);
                RandomEvent39Page1Button.SetActive(false);
                RandomEvent40Page1Button.SetActive(false);
                RandomEvent41Page1Button.SetActive(false);
                RandomEvent42Page1Button.SetActive(false);
                RandomEvent43Page1Button.SetActive(false);
                RandomEvent44Page1Button.SetActive(false);
                RandomEvent45Page1Button.SetActive(false);
                RandomEvent46Page1Button.SetActive(false);
                RandomEvent47Page1Button.SetActive(false);
                RandomEvent48Page1Button.SetActive(false);
                RandomEvent49Page1Button.SetActive(false);
                RandomEvent50Page1Button.SetActive(false);

                RandomEvent33Page1ButtonText.text = "";

                RandomEventsPage1CloseButton.SetActive(false);

                break;
            case 34:
                // ???
                //music here

                randomEvent34Selected = true;

                randomEventsPage1TitleText.text = "";
                randomEventsPage2TitleText.text = "";

                randomEventsPage1DescriptionText.text = "";

                RandomEvent01Page1Button.SetActive(false);
                RandomEvent02Page1Button.SetActive(false);
                RandomEvent03Page1Button.SetActive(false);
                RandomEvent04Page1Button.SetActive(false);
                RandomEvent05Page1Button.SetActive(false);
                RandomEvent06Page1Button.SetActive(false);
                RandomEvent07Page1Button.SetActive(false);
                RandomEvent08Page1Button.SetActive(false);
                RandomEvent09Page1Button.SetActive(false);
                RandomEvent10Page1Button.SetActive(false);
                RandomEvent11Page1Button.SetActive(false);
                RandomEvent12Page1Button.SetActive(false);
                RandomEvent13Page1Button.SetActive(false);
                RandomEvent14Page1Button.SetActive(false);
                RandomEvent15Page1Button.SetActive(false);
                RandomEvent16Page1Button.SetActive(false);
                RandomEvent17Page1Button.SetActive(false);
                RandomEvent18Page1Button.SetActive(false);
                RandomEvent19Page1Button.SetActive(false);
                RandomEvent20Page1Button.SetActive(false);
                RandomEvent21Page1Button.SetActive(false);
                RandomEvent22Page1Button.SetActive(false);
                RandomEvent23Page1Button.SetActive(false);
                RandomEvent24Page1Button.SetActive(false);
                RandomEvent25Page1Button.SetActive(false);
                RandomEvent26Page1Button.SetActive(false);
                RandomEvent27Page1Button.SetActive(false);
                RandomEvent28Page1Button.SetActive(false);
                RandomEvent29Page1Button.SetActive(false);
                RandomEvent30Page1Button.SetActive(false);
                RandomEvent31Page1Button.SetActive(false);
                RandomEvent32Page1Button.SetActive(false);
                RandomEvent33Page1Button.SetActive(false);
                RandomEvent34Page1Button.SetActive(true);
                RandomEvent35Page1Button.SetActive(false);
                RandomEvent36Page1Button.SetActive(false);
                RandomEvent37Page1Button.SetActive(false);
                RandomEvent38Page1Button.SetActive(false);
                RandomEvent39Page1Button.SetActive(false);
                RandomEvent40Page1Button.SetActive(false);
                RandomEvent41Page1Button.SetActive(false);
                RandomEvent42Page1Button.SetActive(false);
                RandomEvent43Page1Button.SetActive(false);
                RandomEvent44Page1Button.SetActive(false);
                RandomEvent45Page1Button.SetActive(false);
                RandomEvent46Page1Button.SetActive(false);
                RandomEvent47Page1Button.SetActive(false);
                RandomEvent48Page1Button.SetActive(false);
                RandomEvent49Page1Button.SetActive(false);
                RandomEvent50Page1Button.SetActive(false);

                RandomEvent34Page1ButtonText.text = "";

                RandomEventsPage1CloseButton.SetActive(false);

                break;
            case 35:
                // ???
                //music here

                randomEvent35Selected = true;

                randomEventsPage1TitleText.text = "";
                randomEventsPage2TitleText.text = "";

                randomEventsPage1DescriptionText.text = "";

                RandomEvent01Page1Button.SetActive(false);
                RandomEvent02Page1Button.SetActive(false);
                RandomEvent03Page1Button.SetActive(false);
                RandomEvent04Page1Button.SetActive(false);
                RandomEvent05Page1Button.SetActive(false);
                RandomEvent06Page1Button.SetActive(false);
                RandomEvent07Page1Button.SetActive(false);
                RandomEvent08Page1Button.SetActive(false);
                RandomEvent09Page1Button.SetActive(false);
                RandomEvent10Page1Button.SetActive(false);
                RandomEvent11Page1Button.SetActive(false);
                RandomEvent12Page1Button.SetActive(false);
                RandomEvent13Page1Button.SetActive(false);
                RandomEvent14Page1Button.SetActive(false);
                RandomEvent15Page1Button.SetActive(false);
                RandomEvent16Page1Button.SetActive(false);
                RandomEvent17Page1Button.SetActive(false);
                RandomEvent18Page1Button.SetActive(false);
                RandomEvent19Page1Button.SetActive(false);
                RandomEvent20Page1Button.SetActive(false);
                RandomEvent21Page1Button.SetActive(false);
                RandomEvent22Page1Button.SetActive(false);
                RandomEvent23Page1Button.SetActive(false);
                RandomEvent24Page1Button.SetActive(false);
                RandomEvent25Page1Button.SetActive(false);
                RandomEvent26Page1Button.SetActive(false);
                RandomEvent27Page1Button.SetActive(false);
                RandomEvent28Page1Button.SetActive(false);
                RandomEvent29Page1Button.SetActive(false);
                RandomEvent30Page1Button.SetActive(false);
                RandomEvent31Page1Button.SetActive(false);
                RandomEvent32Page1Button.SetActive(false);
                RandomEvent33Page1Button.SetActive(false);
                RandomEvent34Page1Button.SetActive(false);
                RandomEvent35Page1Button.SetActive(true);
                RandomEvent36Page1Button.SetActive(false);
                RandomEvent37Page1Button.SetActive(false);
                RandomEvent38Page1Button.SetActive(false);
                RandomEvent39Page1Button.SetActive(false);
                RandomEvent40Page1Button.SetActive(false);
                RandomEvent41Page1Button.SetActive(false);
                RandomEvent42Page1Button.SetActive(false);
                RandomEvent43Page1Button.SetActive(false);
                RandomEvent44Page1Button.SetActive(false);
                RandomEvent45Page1Button.SetActive(false);
                RandomEvent46Page1Button.SetActive(false);
                RandomEvent47Page1Button.SetActive(false);
                RandomEvent48Page1Button.SetActive(false);
                RandomEvent49Page1Button.SetActive(false);
                RandomEvent50Page1Button.SetActive(false);

                RandomEvent35Page1ButtonText.text = "";

                RandomEventsPage1CloseButton.SetActive(false);

                break;
            case 36:
                // ???
                //music here

                randomEvent36Selected = true;

                randomEventsPage1TitleText.text = "";
                randomEventsPage2TitleText.text = "";

                randomEventsPage1DescriptionText.text = "";

                RandomEvent01Page1Button.SetActive(false);
                RandomEvent02Page1Button.SetActive(false);
                RandomEvent03Page1Button.SetActive(false);
                RandomEvent04Page1Button.SetActive(false);
                RandomEvent05Page1Button.SetActive(false);
                RandomEvent06Page1Button.SetActive(false);
                RandomEvent07Page1Button.SetActive(false);
                RandomEvent08Page1Button.SetActive(false);
                RandomEvent09Page1Button.SetActive(false);
                RandomEvent10Page1Button.SetActive(false);
                RandomEvent11Page1Button.SetActive(false);
                RandomEvent12Page1Button.SetActive(false);
                RandomEvent13Page1Button.SetActive(false);
                RandomEvent14Page1Button.SetActive(false);
                RandomEvent15Page1Button.SetActive(false);
                RandomEvent16Page1Button.SetActive(false);
                RandomEvent17Page1Button.SetActive(false);
                RandomEvent18Page1Button.SetActive(false);
                RandomEvent19Page1Button.SetActive(false);
                RandomEvent20Page1Button.SetActive(false);
                RandomEvent21Page1Button.SetActive(false);
                RandomEvent22Page1Button.SetActive(false);
                RandomEvent23Page1Button.SetActive(false);
                RandomEvent24Page1Button.SetActive(false);
                RandomEvent25Page1Button.SetActive(false);
                RandomEvent26Page1Button.SetActive(false);
                RandomEvent27Page1Button.SetActive(false);
                RandomEvent28Page1Button.SetActive(false);
                RandomEvent29Page1Button.SetActive(false);
                RandomEvent30Page1Button.SetActive(false);
                RandomEvent31Page1Button.SetActive(false);
                RandomEvent32Page1Button.SetActive(false);
                RandomEvent33Page1Button.SetActive(false);
                RandomEvent34Page1Button.SetActive(false);
                RandomEvent35Page1Button.SetActive(false);
                RandomEvent36Page1Button.SetActive(true);
                RandomEvent37Page1Button.SetActive(false);
                RandomEvent38Page1Button.SetActive(false);
                RandomEvent39Page1Button.SetActive(false);
                RandomEvent40Page1Button.SetActive(false);
                RandomEvent41Page1Button.SetActive(false);
                RandomEvent42Page1Button.SetActive(false);
                RandomEvent43Page1Button.SetActive(false);
                RandomEvent44Page1Button.SetActive(false);
                RandomEvent45Page1Button.SetActive(false);
                RandomEvent46Page1Button.SetActive(false);
                RandomEvent47Page1Button.SetActive(false);
                RandomEvent48Page1Button.SetActive(false);
                RandomEvent49Page1Button.SetActive(false);
                RandomEvent50Page1Button.SetActive(false);

                RandomEvent36Page1ButtonText.text = "";

                RandomEventsPage1CloseButton.SetActive(false);

                break;
            case 37:
                // ???
                //music here

                randomEvent37Selected = true;

                randomEventsPage1TitleText.text = "";
                randomEventsPage2TitleText.text = "";

                randomEventsPage1DescriptionText.text = "";

                RandomEvent01Page1Button.SetActive(false);
                RandomEvent02Page1Button.SetActive(false);
                RandomEvent03Page1Button.SetActive(false);
                RandomEvent04Page1Button.SetActive(false);
                RandomEvent05Page1Button.SetActive(false);
                RandomEvent06Page1Button.SetActive(false);
                RandomEvent07Page1Button.SetActive(false);
                RandomEvent08Page1Button.SetActive(false);
                RandomEvent09Page1Button.SetActive(false);
                RandomEvent10Page1Button.SetActive(false);
                RandomEvent11Page1Button.SetActive(false);
                RandomEvent12Page1Button.SetActive(false);
                RandomEvent13Page1Button.SetActive(false);
                RandomEvent14Page1Button.SetActive(false);
                RandomEvent15Page1Button.SetActive(false);
                RandomEvent16Page1Button.SetActive(false);
                RandomEvent17Page1Button.SetActive(false);
                RandomEvent18Page1Button.SetActive(false);
                RandomEvent19Page1Button.SetActive(false);
                RandomEvent20Page1Button.SetActive(false);
                RandomEvent21Page1Button.SetActive(false);
                RandomEvent22Page1Button.SetActive(false);
                RandomEvent23Page1Button.SetActive(false);
                RandomEvent24Page1Button.SetActive(false);
                RandomEvent25Page1Button.SetActive(false);
                RandomEvent26Page1Button.SetActive(false);
                RandomEvent27Page1Button.SetActive(false);
                RandomEvent28Page1Button.SetActive(false);
                RandomEvent29Page1Button.SetActive(false);
                RandomEvent30Page1Button.SetActive(false);
                RandomEvent31Page1Button.SetActive(false);
                RandomEvent32Page1Button.SetActive(false);
                RandomEvent33Page1Button.SetActive(false);
                RandomEvent34Page1Button.SetActive(false);
                RandomEvent35Page1Button.SetActive(false);
                RandomEvent36Page1Button.SetActive(false);
                RandomEvent37Page1Button.SetActive(true);
                RandomEvent38Page1Button.SetActive(false);
                RandomEvent39Page1Button.SetActive(false);
                RandomEvent40Page1Button.SetActive(false);
                RandomEvent41Page1Button.SetActive(false);
                RandomEvent42Page1Button.SetActive(false);
                RandomEvent43Page1Button.SetActive(false);
                RandomEvent44Page1Button.SetActive(false);
                RandomEvent45Page1Button.SetActive(false);
                RandomEvent46Page1Button.SetActive(false);
                RandomEvent47Page1Button.SetActive(false);
                RandomEvent48Page1Button.SetActive(false);
                RandomEvent49Page1Button.SetActive(false);
                RandomEvent50Page1Button.SetActive(false);

                RandomEvent37Page1ButtonText.text = "";

                RandomEventsPage1CloseButton.SetActive(false);

                break;
            case 38:
                // ???
                //music here

                randomEvent38Selected = true;

                randomEventsPage1TitleText.text = "";
                randomEventsPage2TitleText.text = "";

                randomEventsPage1DescriptionText.text = "";

                RandomEvent01Page1Button.SetActive(false);
                RandomEvent02Page1Button.SetActive(false);
                RandomEvent03Page1Button.SetActive(false);
                RandomEvent04Page1Button.SetActive(false);
                RandomEvent05Page1Button.SetActive(false);
                RandomEvent06Page1Button.SetActive(false);
                RandomEvent07Page1Button.SetActive(false);
                RandomEvent08Page1Button.SetActive(false);
                RandomEvent09Page1Button.SetActive(false);
                RandomEvent10Page1Button.SetActive(false);
                RandomEvent11Page1Button.SetActive(false);
                RandomEvent12Page1Button.SetActive(false);
                RandomEvent13Page1Button.SetActive(false);
                RandomEvent14Page1Button.SetActive(false);
                RandomEvent15Page1Button.SetActive(false);
                RandomEvent16Page1Button.SetActive(false);
                RandomEvent17Page1Button.SetActive(false);
                RandomEvent18Page1Button.SetActive(false);
                RandomEvent19Page1Button.SetActive(false);
                RandomEvent20Page1Button.SetActive(false);
                RandomEvent21Page1Button.SetActive(false);
                RandomEvent22Page1Button.SetActive(false);
                RandomEvent23Page1Button.SetActive(false);
                RandomEvent24Page1Button.SetActive(false);
                RandomEvent25Page1Button.SetActive(false);
                RandomEvent26Page1Button.SetActive(false);
                RandomEvent27Page1Button.SetActive(false);
                RandomEvent28Page1Button.SetActive(false);
                RandomEvent29Page1Button.SetActive(false);
                RandomEvent30Page1Button.SetActive(false);
                RandomEvent31Page1Button.SetActive(false);
                RandomEvent32Page1Button.SetActive(false);
                RandomEvent33Page1Button.SetActive(false);
                RandomEvent34Page1Button.SetActive(false);
                RandomEvent35Page1Button.SetActive(false);
                RandomEvent36Page1Button.SetActive(false);
                RandomEvent37Page1Button.SetActive(false);
                RandomEvent38Page1Button.SetActive(true);
                RandomEvent39Page1Button.SetActive(false);
                RandomEvent40Page1Button.SetActive(false);
                RandomEvent41Page1Button.SetActive(false);
                RandomEvent42Page1Button.SetActive(false);
                RandomEvent43Page1Button.SetActive(false);
                RandomEvent44Page1Button.SetActive(false);
                RandomEvent45Page1Button.SetActive(false);
                RandomEvent46Page1Button.SetActive(false);
                RandomEvent47Page1Button.SetActive(false);
                RandomEvent48Page1Button.SetActive(false);
                RandomEvent49Page1Button.SetActive(false);
                RandomEvent50Page1Button.SetActive(false);

                RandomEvent38Page1ButtonText.text = "";

                RandomEventsPage1CloseButton.SetActive(false);

                break;
            case 39:
                // ???
                //music here

                randomEvent39Selected = true;

                randomEventsPage1TitleText.text = "";
                randomEventsPage2TitleText.text = "";

                randomEventsPage1DescriptionText.text = "";

                RandomEvent01Page1Button.SetActive(false);
                RandomEvent02Page1Button.SetActive(false);
                RandomEvent03Page1Button.SetActive(false);
                RandomEvent04Page1Button.SetActive(false);
                RandomEvent05Page1Button.SetActive(false);
                RandomEvent06Page1Button.SetActive(false);
                RandomEvent07Page1Button.SetActive(false);
                RandomEvent08Page1Button.SetActive(false);
                RandomEvent09Page1Button.SetActive(false);
                RandomEvent10Page1Button.SetActive(false);
                RandomEvent11Page1Button.SetActive(false);
                RandomEvent12Page1Button.SetActive(false);
                RandomEvent13Page1Button.SetActive(false);
                RandomEvent14Page1Button.SetActive(false);
                RandomEvent15Page1Button.SetActive(false);
                RandomEvent16Page1Button.SetActive(false);
                RandomEvent17Page1Button.SetActive(false);
                RandomEvent18Page1Button.SetActive(false);
                RandomEvent19Page1Button.SetActive(false);
                RandomEvent20Page1Button.SetActive(false);
                RandomEvent21Page1Button.SetActive(false);
                RandomEvent22Page1Button.SetActive(false);
                RandomEvent23Page1Button.SetActive(false);
                RandomEvent24Page1Button.SetActive(false);
                RandomEvent25Page1Button.SetActive(false);
                RandomEvent26Page1Button.SetActive(false);
                RandomEvent27Page1Button.SetActive(false);
                RandomEvent28Page1Button.SetActive(false);
                RandomEvent29Page1Button.SetActive(false);
                RandomEvent30Page1Button.SetActive(false);
                RandomEvent31Page1Button.SetActive(false);
                RandomEvent32Page1Button.SetActive(false);
                RandomEvent33Page1Button.SetActive(false);
                RandomEvent34Page1Button.SetActive(false);
                RandomEvent35Page1Button.SetActive(false);
                RandomEvent36Page1Button.SetActive(false);
                RandomEvent37Page1Button.SetActive(false);
                RandomEvent38Page1Button.SetActive(false);
                RandomEvent39Page1Button.SetActive(true);
                RandomEvent40Page1Button.SetActive(false);
                RandomEvent41Page1Button.SetActive(false);
                RandomEvent42Page1Button.SetActive(false);
                RandomEvent43Page1Button.SetActive(false);
                RandomEvent44Page1Button.SetActive(false);
                RandomEvent45Page1Button.SetActive(false);
                RandomEvent46Page1Button.SetActive(false);
                RandomEvent47Page1Button.SetActive(false);
                RandomEvent48Page1Button.SetActive(false);
                RandomEvent49Page1Button.SetActive(false);
                RandomEvent50Page1Button.SetActive(false);

                RandomEvent39Page1ButtonText.text = "";

                RandomEventsPage1CloseButton.SetActive(false);

                break;
            case 40:
                // ???
                //music here

                randomEvent40Selected = true;

                randomEventsPage1TitleText.text = "";
                randomEventsPage2TitleText.text = "";

                randomEventsPage1DescriptionText.text = "";

                RandomEvent01Page1Button.SetActive(false);
                RandomEvent02Page1Button.SetActive(false);
                RandomEvent03Page1Button.SetActive(false);
                RandomEvent04Page1Button.SetActive(false);
                RandomEvent05Page1Button.SetActive(false);
                RandomEvent06Page1Button.SetActive(false);
                RandomEvent07Page1Button.SetActive(false);
                RandomEvent08Page1Button.SetActive(false);
                RandomEvent09Page1Button.SetActive(false);
                RandomEvent10Page1Button.SetActive(false);
                RandomEvent11Page1Button.SetActive(false);
                RandomEvent12Page1Button.SetActive(false);
                RandomEvent13Page1Button.SetActive(false);
                RandomEvent14Page1Button.SetActive(false);
                RandomEvent15Page1Button.SetActive(false);
                RandomEvent16Page1Button.SetActive(false);
                RandomEvent17Page1Button.SetActive(false);
                RandomEvent18Page1Button.SetActive(false);
                RandomEvent19Page1Button.SetActive(false);
                RandomEvent20Page1Button.SetActive(false);
                RandomEvent21Page1Button.SetActive(false);
                RandomEvent22Page1Button.SetActive(false);
                RandomEvent23Page1Button.SetActive(false);
                RandomEvent24Page1Button.SetActive(false);
                RandomEvent25Page1Button.SetActive(false);
                RandomEvent26Page1Button.SetActive(false);
                RandomEvent27Page1Button.SetActive(false);
                RandomEvent28Page1Button.SetActive(false);
                RandomEvent29Page1Button.SetActive(false);
                RandomEvent30Page1Button.SetActive(false);
                RandomEvent31Page1Button.SetActive(false);
                RandomEvent32Page1Button.SetActive(false);
                RandomEvent33Page1Button.SetActive(false);
                RandomEvent34Page1Button.SetActive(false);
                RandomEvent35Page1Button.SetActive(false);
                RandomEvent36Page1Button.SetActive(false);
                RandomEvent37Page1Button.SetActive(false);
                RandomEvent38Page1Button.SetActive(false);
                RandomEvent39Page1Button.SetActive(false);
                RandomEvent40Page1Button.SetActive(true);
                RandomEvent41Page1Button.SetActive(false);
                RandomEvent42Page1Button.SetActive(false);
                RandomEvent43Page1Button.SetActive(false);
                RandomEvent44Page1Button.SetActive(false);
                RandomEvent45Page1Button.SetActive(false);
                RandomEvent46Page1Button.SetActive(false);
                RandomEvent47Page1Button.SetActive(false);
                RandomEvent48Page1Button.SetActive(false);
                RandomEvent49Page1Button.SetActive(false);
                RandomEvent50Page1Button.SetActive(false);

                RandomEvent40Page1ButtonText.text = "";

                RandomEventsPage1CloseButton.SetActive(false);

                break;
            case 41:
                // ???
                //music here

                randomEvent41Selected = true;

                randomEventsPage1TitleText.text = "";
                randomEventsPage2TitleText.text = "";

                randomEventsPage1DescriptionText.text = "";

                RandomEvent01Page1Button.SetActive(false);
                RandomEvent02Page1Button.SetActive(false);
                RandomEvent03Page1Button.SetActive(false);
                RandomEvent04Page1Button.SetActive(false);
                RandomEvent05Page1Button.SetActive(false);
                RandomEvent06Page1Button.SetActive(false);
                RandomEvent07Page1Button.SetActive(false);
                RandomEvent08Page1Button.SetActive(false);
                RandomEvent09Page1Button.SetActive(false);
                RandomEvent10Page1Button.SetActive(false);
                RandomEvent11Page1Button.SetActive(false);
                RandomEvent12Page1Button.SetActive(false);
                RandomEvent13Page1Button.SetActive(false);
                RandomEvent14Page1Button.SetActive(false);
                RandomEvent15Page1Button.SetActive(false);
                RandomEvent16Page1Button.SetActive(false);
                RandomEvent17Page1Button.SetActive(false);
                RandomEvent18Page1Button.SetActive(false);
                RandomEvent19Page1Button.SetActive(false);
                RandomEvent20Page1Button.SetActive(false);
                RandomEvent21Page1Button.SetActive(false);
                RandomEvent22Page1Button.SetActive(false);
                RandomEvent23Page1Button.SetActive(false);
                RandomEvent24Page1Button.SetActive(false);
                RandomEvent25Page1Button.SetActive(false);
                RandomEvent26Page1Button.SetActive(false);
                RandomEvent27Page1Button.SetActive(false);
                RandomEvent28Page1Button.SetActive(false);
                RandomEvent29Page1Button.SetActive(false);
                RandomEvent30Page1Button.SetActive(false);
                RandomEvent31Page1Button.SetActive(false);
                RandomEvent32Page1Button.SetActive(false);
                RandomEvent33Page1Button.SetActive(false);
                RandomEvent34Page1Button.SetActive(false);
                RandomEvent35Page1Button.SetActive(false);
                RandomEvent36Page1Button.SetActive(false);
                RandomEvent37Page1Button.SetActive(false);
                RandomEvent38Page1Button.SetActive(false);
                RandomEvent39Page1Button.SetActive(false);
                RandomEvent40Page1Button.SetActive(false);
                RandomEvent41Page1Button.SetActive(true);
                RandomEvent42Page1Button.SetActive(false);
                RandomEvent43Page1Button.SetActive(false);
                RandomEvent44Page1Button.SetActive(false);
                RandomEvent45Page1Button.SetActive(false);
                RandomEvent46Page1Button.SetActive(false);
                RandomEvent47Page1Button.SetActive(false);
                RandomEvent48Page1Button.SetActive(false);
                RandomEvent49Page1Button.SetActive(false);
                RandomEvent50Page1Button.SetActive(false);

                RandomEvent41Page1ButtonText.text = "";

                RandomEventsPage1CloseButton.SetActive(false);

                break;
            case 42:
                // ???
                //music here

                randomEvent42Selected = true;

                randomEventsPage1TitleText.text = "";
                randomEventsPage2TitleText.text = "";

                randomEventsPage1DescriptionText.text = "";

                RandomEvent01Page1Button.SetActive(false);
                RandomEvent02Page1Button.SetActive(false);
                RandomEvent03Page1Button.SetActive(false);
                RandomEvent04Page1Button.SetActive(false);
                RandomEvent05Page1Button.SetActive(false);
                RandomEvent06Page1Button.SetActive(false);
                RandomEvent07Page1Button.SetActive(false);
                RandomEvent08Page1Button.SetActive(false);
                RandomEvent09Page1Button.SetActive(false);
                RandomEvent10Page1Button.SetActive(false);
                RandomEvent11Page1Button.SetActive(false);
                RandomEvent12Page1Button.SetActive(false);
                RandomEvent13Page1Button.SetActive(false);
                RandomEvent14Page1Button.SetActive(false);
                RandomEvent15Page1Button.SetActive(false);
                RandomEvent16Page1Button.SetActive(false);
                RandomEvent17Page1Button.SetActive(false);
                RandomEvent18Page1Button.SetActive(false);
                RandomEvent19Page1Button.SetActive(false);
                RandomEvent20Page1Button.SetActive(false);
                RandomEvent21Page1Button.SetActive(false);
                RandomEvent22Page1Button.SetActive(false);
                RandomEvent23Page1Button.SetActive(false);
                RandomEvent24Page1Button.SetActive(false);
                RandomEvent25Page1Button.SetActive(false);
                RandomEvent26Page1Button.SetActive(false);
                RandomEvent27Page1Button.SetActive(false);
                RandomEvent28Page1Button.SetActive(false);
                RandomEvent29Page1Button.SetActive(false);
                RandomEvent30Page1Button.SetActive(false);
                RandomEvent31Page1Button.SetActive(false);
                RandomEvent32Page1Button.SetActive(false);
                RandomEvent33Page1Button.SetActive(false);
                RandomEvent34Page1Button.SetActive(false);
                RandomEvent35Page1Button.SetActive(false);
                RandomEvent36Page1Button.SetActive(false);
                RandomEvent37Page1Button.SetActive(false);
                RandomEvent38Page1Button.SetActive(false);
                RandomEvent39Page1Button.SetActive(false);
                RandomEvent40Page1Button.SetActive(false);
                RandomEvent41Page1Button.SetActive(false);
                RandomEvent42Page1Button.SetActive(true);
                RandomEvent43Page1Button.SetActive(false);
                RandomEvent44Page1Button.SetActive(false);
                RandomEvent45Page1Button.SetActive(false);
                RandomEvent46Page1Button.SetActive(false);
                RandomEvent47Page1Button.SetActive(false);
                RandomEvent48Page1Button.SetActive(false);
                RandomEvent49Page1Button.SetActive(false);
                RandomEvent50Page1Button.SetActive(false);

                RandomEvent42Page1ButtonText.text = "";

                RandomEventsPage1CloseButton.SetActive(false);

                break;
            case 43:
                // ???
                //music here

                randomEvent43Selected = true;

                randomEventsPage1TitleText.text = "";
                randomEventsPage2TitleText.text = "";

                randomEventsPage1DescriptionText.text = "";

                RandomEvent01Page1Button.SetActive(false);
                RandomEvent02Page1Button.SetActive(false);
                RandomEvent03Page1Button.SetActive(false);
                RandomEvent04Page1Button.SetActive(false);
                RandomEvent05Page1Button.SetActive(false);
                RandomEvent06Page1Button.SetActive(false);
                RandomEvent07Page1Button.SetActive(false);
                RandomEvent08Page1Button.SetActive(false);
                RandomEvent09Page1Button.SetActive(false);
                RandomEvent10Page1Button.SetActive(false);
                RandomEvent11Page1Button.SetActive(false);
                RandomEvent12Page1Button.SetActive(false);
                RandomEvent13Page1Button.SetActive(false);
                RandomEvent14Page1Button.SetActive(false);
                RandomEvent15Page1Button.SetActive(false);
                RandomEvent16Page1Button.SetActive(false);
                RandomEvent17Page1Button.SetActive(false);
                RandomEvent18Page1Button.SetActive(false);
                RandomEvent19Page1Button.SetActive(false);
                RandomEvent20Page1Button.SetActive(false);
                RandomEvent21Page1Button.SetActive(false);
                RandomEvent22Page1Button.SetActive(false);
                RandomEvent23Page1Button.SetActive(false);
                RandomEvent24Page1Button.SetActive(false);
                RandomEvent25Page1Button.SetActive(false);
                RandomEvent26Page1Button.SetActive(false);
                RandomEvent27Page1Button.SetActive(false);
                RandomEvent28Page1Button.SetActive(false);
                RandomEvent29Page1Button.SetActive(false);
                RandomEvent30Page1Button.SetActive(false);
                RandomEvent31Page1Button.SetActive(false);
                RandomEvent32Page1Button.SetActive(false);
                RandomEvent33Page1Button.SetActive(false);
                RandomEvent34Page1Button.SetActive(false);
                RandomEvent35Page1Button.SetActive(false);
                RandomEvent36Page1Button.SetActive(false);
                RandomEvent37Page1Button.SetActive(false);
                RandomEvent38Page1Button.SetActive(false);
                RandomEvent39Page1Button.SetActive(false);
                RandomEvent40Page1Button.SetActive(false);
                RandomEvent41Page1Button.SetActive(false);
                RandomEvent42Page1Button.SetActive(false);
                RandomEvent43Page1Button.SetActive(true);
                RandomEvent44Page1Button.SetActive(false);
                RandomEvent45Page1Button.SetActive(false);
                RandomEvent46Page1Button.SetActive(false);
                RandomEvent47Page1Button.SetActive(false);
                RandomEvent48Page1Button.SetActive(false);
                RandomEvent49Page1Button.SetActive(false);
                RandomEvent50Page1Button.SetActive(false);

                RandomEvent43Page1ButtonText.text = "";

                RandomEventsPage1CloseButton.SetActive(false);

                break;
            case 44:
                // ???
                //music here

                randomEvent44Selected = true;

                randomEventsPage1TitleText.text = "";
                randomEventsPage2TitleText.text = "";

                randomEventsPage1DescriptionText.text = "";

                RandomEvent01Page1Button.SetActive(false);
                RandomEvent02Page1Button.SetActive(false);
                RandomEvent03Page1Button.SetActive(false);
                RandomEvent04Page1Button.SetActive(false);
                RandomEvent05Page1Button.SetActive(false);
                RandomEvent06Page1Button.SetActive(false);
                RandomEvent07Page1Button.SetActive(false);
                RandomEvent08Page1Button.SetActive(false);
                RandomEvent09Page1Button.SetActive(false);
                RandomEvent10Page1Button.SetActive(false);
                RandomEvent11Page1Button.SetActive(false);
                RandomEvent12Page1Button.SetActive(false);
                RandomEvent13Page1Button.SetActive(false);
                RandomEvent14Page1Button.SetActive(false);
                RandomEvent15Page1Button.SetActive(false);
                RandomEvent16Page1Button.SetActive(false);
                RandomEvent17Page1Button.SetActive(false);
                RandomEvent18Page1Button.SetActive(false);
                RandomEvent19Page1Button.SetActive(false);
                RandomEvent20Page1Button.SetActive(false);
                RandomEvent21Page1Button.SetActive(false);
                RandomEvent22Page1Button.SetActive(false);
                RandomEvent23Page1Button.SetActive(false);
                RandomEvent24Page1Button.SetActive(false);
                RandomEvent25Page1Button.SetActive(false);
                RandomEvent26Page1Button.SetActive(false);
                RandomEvent27Page1Button.SetActive(false);
                RandomEvent28Page1Button.SetActive(false);
                RandomEvent29Page1Button.SetActive(false);
                RandomEvent30Page1Button.SetActive(false);
                RandomEvent31Page1Button.SetActive(false);
                RandomEvent32Page1Button.SetActive(false);
                RandomEvent33Page1Button.SetActive(false);
                RandomEvent34Page1Button.SetActive(false);
                RandomEvent35Page1Button.SetActive(false);
                RandomEvent36Page1Button.SetActive(false);
                RandomEvent37Page1Button.SetActive(false);
                RandomEvent38Page1Button.SetActive(false);
                RandomEvent39Page1Button.SetActive(false);
                RandomEvent40Page1Button.SetActive(false);
                RandomEvent41Page1Button.SetActive(false);
                RandomEvent42Page1Button.SetActive(false);
                RandomEvent43Page1Button.SetActive(false);
                RandomEvent44Page1Button.SetActive(true);
                RandomEvent45Page1Button.SetActive(false);
                RandomEvent46Page1Button.SetActive(false);
                RandomEvent47Page1Button.SetActive(false);
                RandomEvent48Page1Button.SetActive(false);
                RandomEvent49Page1Button.SetActive(false);
                RandomEvent50Page1Button.SetActive(false);

                RandomEvent44Page1ButtonText.text = "";

                RandomEventsPage1CloseButton.SetActive(false);

                break;
            case 45:
                // ???
                //music here

                randomEvent45Selected = true;

                randomEventsPage1TitleText.text = "";
                randomEventsPage2TitleText.text = "";

                randomEventsPage1DescriptionText.text = "";

                RandomEvent01Page1Button.SetActive(false);
                RandomEvent02Page1Button.SetActive(false);
                RandomEvent03Page1Button.SetActive(false);
                RandomEvent04Page1Button.SetActive(false);
                RandomEvent05Page1Button.SetActive(false);
                RandomEvent06Page1Button.SetActive(false);
                RandomEvent07Page1Button.SetActive(false);
                RandomEvent08Page1Button.SetActive(false);
                RandomEvent09Page1Button.SetActive(false);
                RandomEvent10Page1Button.SetActive(false);
                RandomEvent11Page1Button.SetActive(false);
                RandomEvent12Page1Button.SetActive(false);
                RandomEvent13Page1Button.SetActive(false);
                RandomEvent14Page1Button.SetActive(false);
                RandomEvent15Page1Button.SetActive(false);
                RandomEvent16Page1Button.SetActive(false);
                RandomEvent17Page1Button.SetActive(false);
                RandomEvent18Page1Button.SetActive(false);
                RandomEvent19Page1Button.SetActive(false);
                RandomEvent20Page1Button.SetActive(false);
                RandomEvent21Page1Button.SetActive(false);
                RandomEvent22Page1Button.SetActive(false);
                RandomEvent23Page1Button.SetActive(false);
                RandomEvent24Page1Button.SetActive(false);
                RandomEvent25Page1Button.SetActive(false);
                RandomEvent26Page1Button.SetActive(false);
                RandomEvent27Page1Button.SetActive(false);
                RandomEvent28Page1Button.SetActive(false);
                RandomEvent29Page1Button.SetActive(false);
                RandomEvent30Page1Button.SetActive(false);
                RandomEvent31Page1Button.SetActive(false);
                RandomEvent32Page1Button.SetActive(false);
                RandomEvent33Page1Button.SetActive(false);
                RandomEvent34Page1Button.SetActive(false);
                RandomEvent35Page1Button.SetActive(false);
                RandomEvent36Page1Button.SetActive(false);
                RandomEvent37Page1Button.SetActive(false);
                RandomEvent38Page1Button.SetActive(false);
                RandomEvent39Page1Button.SetActive(false);
                RandomEvent40Page1Button.SetActive(false);
                RandomEvent41Page1Button.SetActive(false);
                RandomEvent42Page1Button.SetActive(false);
                RandomEvent43Page1Button.SetActive(false);
                RandomEvent44Page1Button.SetActive(false);
                RandomEvent45Page1Button.SetActive(true);
                RandomEvent46Page1Button.SetActive(false);
                RandomEvent47Page1Button.SetActive(false);
                RandomEvent48Page1Button.SetActive(false);
                RandomEvent49Page1Button.SetActive(false);
                RandomEvent50Page1Button.SetActive(false);

                RandomEvent45Page1ButtonText.text = "";

                RandomEventsPage1CloseButton.SetActive(false);

                break;
            case 46:
                // ???
                //music here

                randomEvent46Selected = true;

                randomEventsPage1TitleText.text = "";
                randomEventsPage2TitleText.text = "";

                randomEventsPage1DescriptionText.text = "";

                RandomEvent01Page1Button.SetActive(false);
                RandomEvent02Page1Button.SetActive(false);
                RandomEvent03Page1Button.SetActive(false);
                RandomEvent04Page1Button.SetActive(false);
                RandomEvent05Page1Button.SetActive(false);
                RandomEvent06Page1Button.SetActive(false);
                RandomEvent07Page1Button.SetActive(false);
                RandomEvent08Page1Button.SetActive(false);
                RandomEvent09Page1Button.SetActive(false);
                RandomEvent10Page1Button.SetActive(false);
                RandomEvent11Page1Button.SetActive(false);
                RandomEvent12Page1Button.SetActive(false);
                RandomEvent13Page1Button.SetActive(false);
                RandomEvent14Page1Button.SetActive(false);
                RandomEvent15Page1Button.SetActive(false);
                RandomEvent16Page1Button.SetActive(false);
                RandomEvent17Page1Button.SetActive(false);
                RandomEvent18Page1Button.SetActive(false);
                RandomEvent19Page1Button.SetActive(false);
                RandomEvent20Page1Button.SetActive(false);
                RandomEvent21Page1Button.SetActive(false);
                RandomEvent22Page1Button.SetActive(false);
                RandomEvent23Page1Button.SetActive(false);
                RandomEvent24Page1Button.SetActive(false);
                RandomEvent25Page1Button.SetActive(false);
                RandomEvent26Page1Button.SetActive(false);
                RandomEvent27Page1Button.SetActive(false);
                RandomEvent28Page1Button.SetActive(false);
                RandomEvent29Page1Button.SetActive(false);
                RandomEvent30Page1Button.SetActive(false);
                RandomEvent31Page1Button.SetActive(false);
                RandomEvent32Page1Button.SetActive(false);
                RandomEvent33Page1Button.SetActive(false);
                RandomEvent34Page1Button.SetActive(false);
                RandomEvent35Page1Button.SetActive(false);
                RandomEvent36Page1Button.SetActive(false);
                RandomEvent37Page1Button.SetActive(false);
                RandomEvent38Page1Button.SetActive(false);
                RandomEvent39Page1Button.SetActive(false);
                RandomEvent40Page1Button.SetActive(false);
                RandomEvent41Page1Button.SetActive(false);
                RandomEvent42Page1Button.SetActive(false);
                RandomEvent43Page1Button.SetActive(false);
                RandomEvent44Page1Button.SetActive(false);
                RandomEvent45Page1Button.SetActive(false);
                RandomEvent46Page1Button.SetActive(true);
                RandomEvent47Page1Button.SetActive(false);
                RandomEvent48Page1Button.SetActive(false);
                RandomEvent49Page1Button.SetActive(false);
                RandomEvent50Page1Button.SetActive(false);

                RandomEvent46Page1ButtonText.text = "";

                RandomEventsPage1CloseButton.SetActive(false);

                break;
            case 47:
                // ???
                //music here

                randomEvent47Selected = true;

                randomEventsPage1TitleText.text = "";
                randomEventsPage2TitleText.text = "";

                randomEventsPage1DescriptionText.text = "";

                RandomEvent01Page1Button.SetActive(false);
                RandomEvent02Page1Button.SetActive(false);
                RandomEvent03Page1Button.SetActive(false);
                RandomEvent04Page1Button.SetActive(false);
                RandomEvent05Page1Button.SetActive(false);
                RandomEvent06Page1Button.SetActive(false);
                RandomEvent07Page1Button.SetActive(false);
                RandomEvent08Page1Button.SetActive(false);
                RandomEvent09Page1Button.SetActive(false);
                RandomEvent10Page1Button.SetActive(false);
                RandomEvent11Page1Button.SetActive(false);
                RandomEvent12Page1Button.SetActive(false);
                RandomEvent13Page1Button.SetActive(false);
                RandomEvent14Page1Button.SetActive(false);
                RandomEvent15Page1Button.SetActive(false);
                RandomEvent16Page1Button.SetActive(false);
                RandomEvent17Page1Button.SetActive(false);
                RandomEvent18Page1Button.SetActive(false);
                RandomEvent19Page1Button.SetActive(false);
                RandomEvent20Page1Button.SetActive(false);
                RandomEvent21Page1Button.SetActive(false);
                RandomEvent22Page1Button.SetActive(false);
                RandomEvent23Page1Button.SetActive(false);
                RandomEvent24Page1Button.SetActive(false);
                RandomEvent25Page1Button.SetActive(false);
                RandomEvent26Page1Button.SetActive(false);
                RandomEvent27Page1Button.SetActive(false);
                RandomEvent28Page1Button.SetActive(false);
                RandomEvent29Page1Button.SetActive(false);
                RandomEvent30Page1Button.SetActive(false);
                RandomEvent31Page1Button.SetActive(false);
                RandomEvent32Page1Button.SetActive(false);
                RandomEvent33Page1Button.SetActive(false);
                RandomEvent34Page1Button.SetActive(false);
                RandomEvent35Page1Button.SetActive(false);
                RandomEvent36Page1Button.SetActive(false);
                RandomEvent37Page1Button.SetActive(false);
                RandomEvent38Page1Button.SetActive(false);
                RandomEvent39Page1Button.SetActive(false);
                RandomEvent40Page1Button.SetActive(false);
                RandomEvent41Page1Button.SetActive(false);
                RandomEvent42Page1Button.SetActive(false);
                RandomEvent43Page1Button.SetActive(false);
                RandomEvent44Page1Button.SetActive(false);
                RandomEvent45Page1Button.SetActive(false);
                RandomEvent46Page1Button.SetActive(false);
                RandomEvent47Page1Button.SetActive(true);
                RandomEvent48Page1Button.SetActive(false);
                RandomEvent49Page1Button.SetActive(false);
                RandomEvent50Page1Button.SetActive(false);

                RandomEvent47Page1ButtonText.text = "";

                RandomEventsPage1CloseButton.SetActive(false);

                break;
            case 48:
                // ???
                //music here

                randomEvent48Selected = true;

                randomEventsPage1TitleText.text = "";
                randomEventsPage2TitleText.text = "";

                randomEventsPage1DescriptionText.text = "";

                RandomEvent01Page1Button.SetActive(false);
                RandomEvent02Page1Button.SetActive(false);
                RandomEvent03Page1Button.SetActive(false);
                RandomEvent04Page1Button.SetActive(false);
                RandomEvent05Page1Button.SetActive(false);
                RandomEvent06Page1Button.SetActive(false);
                RandomEvent07Page1Button.SetActive(false);
                RandomEvent08Page1Button.SetActive(false);
                RandomEvent09Page1Button.SetActive(false);
                RandomEvent10Page1Button.SetActive(false);
                RandomEvent11Page1Button.SetActive(false);
                RandomEvent12Page1Button.SetActive(false);
                RandomEvent13Page1Button.SetActive(false);
                RandomEvent14Page1Button.SetActive(false);
                RandomEvent15Page1Button.SetActive(false);
                RandomEvent16Page1Button.SetActive(false);
                RandomEvent17Page1Button.SetActive(false);
                RandomEvent18Page1Button.SetActive(false);
                RandomEvent19Page1Button.SetActive(false);
                RandomEvent20Page1Button.SetActive(false);
                RandomEvent21Page1Button.SetActive(false);
                RandomEvent22Page1Button.SetActive(false);
                RandomEvent23Page1Button.SetActive(false);
                RandomEvent24Page1Button.SetActive(false);
                RandomEvent25Page1Button.SetActive(false);
                RandomEvent26Page1Button.SetActive(false);
                RandomEvent27Page1Button.SetActive(false);
                RandomEvent28Page1Button.SetActive(false);
                RandomEvent29Page1Button.SetActive(false);
                RandomEvent30Page1Button.SetActive(false);
                RandomEvent31Page1Button.SetActive(false);
                RandomEvent32Page1Button.SetActive(false);
                RandomEvent33Page1Button.SetActive(false);
                RandomEvent34Page1Button.SetActive(false);
                RandomEvent35Page1Button.SetActive(false);
                RandomEvent36Page1Button.SetActive(false);
                RandomEvent37Page1Button.SetActive(false);
                RandomEvent38Page1Button.SetActive(false);
                RandomEvent39Page1Button.SetActive(false);
                RandomEvent40Page1Button.SetActive(false);
                RandomEvent41Page1Button.SetActive(false);
                RandomEvent42Page1Button.SetActive(false);
                RandomEvent43Page1Button.SetActive(false);
                RandomEvent44Page1Button.SetActive(false);
                RandomEvent45Page1Button.SetActive(false);
                RandomEvent46Page1Button.SetActive(false);
                RandomEvent47Page1Button.SetActive(false);
                RandomEvent48Page1Button.SetActive(true);
                RandomEvent49Page1Button.SetActive(false);
                RandomEvent50Page1Button.SetActive(false);

                RandomEvent48Page1ButtonText.text = "";

                RandomEventsPage1CloseButton.SetActive(false);

                break;
            case 49:
                // ???
                //music here

                randomEvent49Selected = true;

                randomEventsPage1TitleText.text = "";
                randomEventsPage2TitleText.text = "";

                randomEventsPage1DescriptionText.text = "";

                RandomEvent01Page1Button.SetActive(false);
                RandomEvent02Page1Button.SetActive(false);
                RandomEvent03Page1Button.SetActive(false);
                RandomEvent04Page1Button.SetActive(false);
                RandomEvent05Page1Button.SetActive(false);
                RandomEvent06Page1Button.SetActive(false);
                RandomEvent07Page1Button.SetActive(false);
                RandomEvent08Page1Button.SetActive(false);
                RandomEvent09Page1Button.SetActive(false);
                RandomEvent10Page1Button.SetActive(false);
                RandomEvent11Page1Button.SetActive(false);
                RandomEvent12Page1Button.SetActive(false);
                RandomEvent13Page1Button.SetActive(false);
                RandomEvent14Page1Button.SetActive(false);
                RandomEvent15Page1Button.SetActive(false);
                RandomEvent16Page1Button.SetActive(false);
                RandomEvent17Page1Button.SetActive(false);
                RandomEvent18Page1Button.SetActive(false);
                RandomEvent19Page1Button.SetActive(false);
                RandomEvent20Page1Button.SetActive(false);
                RandomEvent21Page1Button.SetActive(false);
                RandomEvent22Page1Button.SetActive(false);
                RandomEvent23Page1Button.SetActive(false);
                RandomEvent24Page1Button.SetActive(false);
                RandomEvent25Page1Button.SetActive(false);
                RandomEvent26Page1Button.SetActive(false);
                RandomEvent27Page1Button.SetActive(false);
                RandomEvent28Page1Button.SetActive(false);
                RandomEvent29Page1Button.SetActive(false);
                RandomEvent30Page1Button.SetActive(false);
                RandomEvent31Page1Button.SetActive(false);
                RandomEvent32Page1Button.SetActive(false);
                RandomEvent33Page1Button.SetActive(false);
                RandomEvent34Page1Button.SetActive(false);
                RandomEvent35Page1Button.SetActive(false);
                RandomEvent36Page1Button.SetActive(false);
                RandomEvent37Page1Button.SetActive(false);
                RandomEvent38Page1Button.SetActive(false);
                RandomEvent39Page1Button.SetActive(false);
                RandomEvent40Page1Button.SetActive(false);
                RandomEvent41Page1Button.SetActive(false);
                RandomEvent42Page1Button.SetActive(false);
                RandomEvent43Page1Button.SetActive(false);
                RandomEvent44Page1Button.SetActive(false);
                RandomEvent45Page1Button.SetActive(false);
                RandomEvent46Page1Button.SetActive(false);
                RandomEvent47Page1Button.SetActive(false);
                RandomEvent48Page1Button.SetActive(false);
                RandomEvent49Page1Button.SetActive(true);
                RandomEvent50Page1Button.SetActive(false);

                RandomEvent49Page1ButtonText.text = "";

                RandomEventsPage1CloseButton.SetActive(false);

                break;
            case 50:
                // ???
                //music here

                randomEvent50Selected = true;

                randomEventsPage1TitleText.text = "";
                randomEventsPage2TitleText.text = "";

                randomEventsPage1DescriptionText.text = "";

                RandomEvent01Page1Button.SetActive(false);
                RandomEvent02Page1Button.SetActive(false);
                RandomEvent03Page1Button.SetActive(false);
                RandomEvent04Page1Button.SetActive(false);
                RandomEvent05Page1Button.SetActive(false);
                RandomEvent06Page1Button.SetActive(false);
                RandomEvent07Page1Button.SetActive(false);
                RandomEvent08Page1Button.SetActive(false);
                RandomEvent09Page1Button.SetActive(false);
                RandomEvent10Page1Button.SetActive(false);
                RandomEvent11Page1Button.SetActive(false);
                RandomEvent12Page1Button.SetActive(false);
                RandomEvent13Page1Button.SetActive(false);
                RandomEvent14Page1Button.SetActive(false);
                RandomEvent15Page1Button.SetActive(false);
                RandomEvent16Page1Button.SetActive(false);
                RandomEvent17Page1Button.SetActive(false);
                RandomEvent18Page1Button.SetActive(false);
                RandomEvent19Page1Button.SetActive(false);
                RandomEvent20Page1Button.SetActive(false);
                RandomEvent21Page1Button.SetActive(false);
                RandomEvent22Page1Button.SetActive(false);
                RandomEvent23Page1Button.SetActive(false);
                RandomEvent24Page1Button.SetActive(false);
                RandomEvent25Page1Button.SetActive(false);
                RandomEvent26Page1Button.SetActive(false);
                RandomEvent27Page1Button.SetActive(false);
                RandomEvent28Page1Button.SetActive(false);
                RandomEvent29Page1Button.SetActive(false);
                RandomEvent30Page1Button.SetActive(false);
                RandomEvent31Page1Button.SetActive(false);
                RandomEvent32Page1Button.SetActive(false);
                RandomEvent33Page1Button.SetActive(false);
                RandomEvent34Page1Button.SetActive(false);
                RandomEvent35Page1Button.SetActive(false);
                RandomEvent36Page1Button.SetActive(false);
                RandomEvent37Page1Button.SetActive(false);
                RandomEvent38Page1Button.SetActive(false);
                RandomEvent39Page1Button.SetActive(false);
                RandomEvent40Page1Button.SetActive(false);
                RandomEvent41Page1Button.SetActive(false);
                RandomEvent42Page1Button.SetActive(false);
                RandomEvent43Page1Button.SetActive(false);
                RandomEvent44Page1Button.SetActive(false);
                RandomEvent45Page1Button.SetActive(false);
                RandomEvent46Page1Button.SetActive(false);
                RandomEvent47Page1Button.SetActive(false);
                RandomEvent48Page1Button.SetActive(false);
                RandomEvent49Page1Button.SetActive(false);
                RandomEvent50Page1Button.SetActive(true);

                RandomEvent50Page1ButtonText.text = "";

                RandomEventsPage1CloseButton.SetActive(false);

                break;
        }
    }
    public void RandomEvent01a()
    {
        // Transportation Increase
        forwardButtonClickAudioSource.Play();

        RandomEvent01Page1Button.SetActive(false);
        randomEventsScreen1.SetActive(false);
        randomEventsScreen2.SetActive(true);

        transportationCost1990 += (transportationCost1990 * generalPercent);
        transportationCost2020 += (transportationCost2020 * generalPercent);

        transportationCost1990 = Math.Round(transportationCost1990, 2);
        transportationCost2020 = Math.Round(transportationCost2020, 2);

        randomEventsPage2DescriptionText1.text = "Inflation can truly be a pain.";
        randomEventsPage2DescriptionText2.text = "1990: Your weekly transportation cost will now be: $" + transportationCost1990 + "!";
        randomEventsPage2DescriptionText3.text = "2020: Your weekly transportation cost will now be: $" + transportationCost2020 + "!";
        
        RandomEventsPage2CloseButton.SetActive(true);

        //generalPercent = 0.00F;
        //generalPercent1 = 0.00F;
    }
    public void RandomEvent02a()
    {
        // Loan Payment
        forwardButtonClickAudioSource.Play();

        RandomEvent02Page1Button.SetActive(false);
        randomEventsScreen1.SetActive(false);
        randomEventsScreen2.SetActive(true);
        
        randomEventsPage2DescriptionText1.text = "Good job! You are on your way to soon having all your student debt paid paid off!";
        randomEventsPage2DescriptionText2.text = "1990: You have made a student loan payment of $" + studentLoan1990 + ".";
        randomEventsPage2DescriptionText3.text = "2020: You have made a student loan payment of $" + studentLoan2020 + ".";
        
        //otherCost1990 += studentLoan1990;
        //otherCost2020 += studentLoan2020;

        otherPaid1990 += studentLoan1990;
        otherPaid2020 += studentLoan2020;

        currentMoney1990 -= studentLoan1990;
        currentMoney2020 -= studentLoan2020;

        weekMoneyLoss1990 += studentLoan1990;
        weekMoneyLoss2020 += studentLoan2020;

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent03a()
    {
        // Win Raffle
        forwardButtonClickAudioSource.Play();

        RandomEvent03Page1Button.SetActive(false);
        randomEventsScreen1.SetActive(false);
        randomEventsScreen2.SetActive(true);


        randomEventsPage2DescriptionText1.text = "You have won $" + winnings + "! Now what will you do with it?";

        currentMoney1990 += winnings;
        currentMoney2020 += winnings;
        weekMoneyObtained1990 += winnings;
        weekMoneyObtained2020 += winnings;

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent04a()
    {
        // Pay Raise
        forwardButtonClickAudioSource.Play();

        RandomEvent04Page1Button.SetActive(false);
        randomEventsScreen1.SetActive(false);
        randomEventsScreen2.SetActive(true);

        hourlyRate1990 += raise1990;
        hourlyRate2020 += raise2020;
        hourlyRate1990 = Math.Round(hourlyRate1990, 2);
        hourlyRate2020 = Math.Round(hourlyRate2020, 2);

        randomEventsPage2DescriptionText1.text = "It feels great to be rewarded for hard work.";
        randomEventsPage2DescriptionText2.text = "1990: Hourly Pay: $" + hourlyRate1990 + "/hour!";
        randomEventsPage2DescriptionText3.text = "2020: Hourly Pay: $" + hourlyRate2020 + "/hour!";

        RandomEventsPage2CloseButton.SetActive(true);

        //generalPercent = 0.00F;
        //generalPercent1 = 0.00F;
    }
    public void RandomEvent05a()
    {
        // Descreased Wage
        forwardButtonClickAudioSource.Play();

        RandomEvent05Page1Button.SetActive(false);
        randomEventsScreen1.SetActive(false);
        randomEventsScreen2.SetActive(true);

        hourlyRate1990 -= payCut1990;
        hourlyRate2020 -= payCut2020;
        hourlyRate1990 = Math.Round(hourlyRate1990, 2);
        hourlyRate2020 = Math.Round(hourlyRate2020, 2);

        randomEventsPage2DescriptionText1.text = "Hopefully this will only be a temporary arrangement.";
        randomEventsPage2DescriptionText2.text = "1990: Hourly Pay: $" + hourlyRate1990 + "/hour!";
        randomEventsPage2DescriptionText3.text = "2020: Hourly Pay: $" + hourlyRate2020 + "/hour!";

        RandomEventsPage2CloseButton.SetActive(true);

        //generalPercent = 0.00F;
        //generalPercent1 = 0.00F;
    }
    public void RandomEvent06a()
    {
        // Lose Job
        forwardButtonClickAudioSource.Play();

        RandomEvent06Page1Button.SetActive(false);
        randomEventsScreen1.SetActive(false);
        randomEventsScreenJob.SetActive(true);

        randomEventsPageJobDescriptionText1.text = "You can now choose a new job from the available jobs listed. As this is a new job, you will be starting at the base pay.";
    }
    public void RandomEvent06bWaiter()
    {
        // Loss Job
        forwardButtonClickAudioSource.Play();

        newWaiterButton.SetActive(false);
        newCashierButton.SetActive(false);
        newFryCookButton.SetActive(false);
        newCSAButton.SetActive(false);
        newTeacherButton.SetActive(false);
        newLSAButton.SetActive(false);
        newProgrammerButton.SetActive(false);
        newEngineerButton.SetActive(false);
        newLawyerButton.SetActive(false);
        newDoctorButton.SetActive(false);

        randomEventsScreenJob.SetActive(false);
        randomEventsScreen2.SetActive(true);

        waiter = true;
        jobNow = 1;
        jobSelected = "Waiter";

        //Setting Pay
        switch (educationNow)
        {
            case 1:
                //biweeklySalary1990 = 240; // 3 (3 x 80 = 240)
                //biweeklySalary2020 = 480; // 6 (6 x 80 = 480)
                hourlyRate1990 = 1.50F;
                hourlyRate2020 = 3.00F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
            case 2:
                //biweeklySalary1990 = 280; // 3.50 (3.50 x 80 = 280)
                //biweeklySalary2020 = 580; // 7.25 (7.25 x 80 = 580)
                hourlyRate1990 = 1.75F;
                hourlyRate2020 = 3.75F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
            case 3:
                //biweeklySalary1990 = 300; // 3.75 (3.75 x 80 = 300)
                //biweeklySalary2020 = 620; // 7.75 (7.75 x 80 = 620)
                hourlyRate1990 = 2.00F;
                hourlyRate2020 = 4.00F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
            case 4:
                //biweeklySalary1990 = 320; // 4 (4 x 80 hr = 320)
                //biweeklySalary2020 = 684.80; // 8.56 (8.56 x 80 = hr)
                hourlyRate1990 = 2.00F;
                hourlyRate2020 = 4.25F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
            case 5:
                //biweeklySalary1990 = 360; // 4.50 (4.50 x 80 = 360)
                //biweeklySalary2020 = 740; // 9.25 (9.25 x 80 = 740)
                hourlyRate1990 = 2.25F;
                hourlyRate2020 = 5.75F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
            case 6:
                //biweeklySalary1990 = 400; // 5 (5 x 80 = 400)
                //biweeklySalary2020 = 800; // 10 (10 x 80 = 800)
                hourlyRate1990 = 2.50F;
                hourlyRate2020 = 5.00F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
        }

        randomEventsPage2DescriptionText1.text = "You have selected the job of " + jobSelected + "!";
        randomEventsPage2DescriptionText2.text = "1990: Your hourly pay will now be: $" + hourlyRate1990 + "/hour!";
        randomEventsPage2DescriptionText3.text = "2020: Your hourly pay will now be: $" + hourlyRate2020 + "/hour!";

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent06bCashier()
    {
        // Job Loss
        forwardButtonClickAudioSource.Play();

        newWaiterButton.SetActive(false);
        newCashierButton.SetActive(false);
        newFryCookButton.SetActive(false);
        newCSAButton.SetActive(false);
        newTeacherButton.SetActive(false);
        newLSAButton.SetActive(false);
        newProgrammerButton.SetActive(false);
        newEngineerButton.SetActive(false);
        newLawyerButton.SetActive(false);
        newDoctorButton.SetActive(false);

        randomEventsScreenJob.SetActive(false);
        randomEventsScreen2.SetActive(true);

        cashier = true;
        jobNow = 2;
        jobSelected = "Cashier";

        //Setting Pay
        switch (educationNow)
        {
            case 1:
                //biweeklySalary1990 = 320; //4
                //biweeklySalary2020 = 684.80; //8.56
                hourlyRate1990 = 4.00F;
                hourlyRate2020 = 8.50F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
            case 2:
                //biweeklySalary1990 = 360; //4.50
                //biweeklySalary2020 = 720; //9
                hourlyRate1990 = 4.50F;
                hourlyRate2020 = 9.00;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
            case 3:
                //biweeklySalary1990 = 380; // 4.75
                //biweeklySalary2020 = 740; // 9.25
                hourlyRate1990 = 4.75F;
                hourlyRate2020 = 9.25F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
            case 4:
                //biweeklySalary1990 = 400; //5
                //biweeklySalary2020 = 760; //9.50
                hourlyRate1990 = 5.00F;
                hourlyRate2020 = 9.50F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
            case 5:
                //biweeklySalary1990 = 440; //5.50
                //biweeklySalary2020 = 800; //10
                hourlyRate1990 = 5.50F;
                hourlyRate2020 = 10.00F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
            case 6:
                //biweeklySalary1990 = 480; //6
                //biweeklySalary2020 = 840; //10.50
                hourlyRate1990 = 6.00F;
                hourlyRate2020 = 10.50F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
        }

        randomEventsPage2DescriptionText1.text = "You have selected the job of " + jobSelected + "!";
        randomEventsPage2DescriptionText2.text = "1990: Your hourly pay will now be: $" + hourlyRate1990 + "/hour!";
        randomEventsPage2DescriptionText3.text = "2020: Your hourly pay will now be: $" + hourlyRate2020 + "/hour!";

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent06FryCook()
    {
        // Job Loss
        forwardButtonClickAudioSource.Play();

        newWaiterButton.SetActive(false);
        newCashierButton.SetActive(false);
        newFryCookButton.SetActive(false);
        newCSAButton.SetActive(false);
        newTeacherButton.SetActive(false);
        newLSAButton.SetActive(false);
        newProgrammerButton.SetActive(false);
        newEngineerButton.SetActive(false);
        newLawyerButton.SetActive(false);
        newDoctorButton.SetActive(false);

        randomEventsScreenJob.SetActive(false);
        randomEventsScreen2.SetActive(true);

        fryCook = true;
        jobNow = 3;
        jobSelected = "Fry Cook";

        //Setting Pay
        switch (educationNow)
        {
            case 1:
                //biweeklySalary1990 = 320; // 4
                //biweeklySalary2020 = 684.80; // 8.56
                hourlyRate1990 = 4.00F;
                hourlyRate2020 = 8.50F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
            case 2:
                //biweeklySalary1990 = 420; // 5.25
                //biweeklySalary2020 = 780; // 9.75
                hourlyRate1990 = 5.25F;
                hourlyRate2020 = 9.75F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
            case 3:
                //biweeklySalary1990 = 460; // 5.75
                //biweeklySalary2020 =  820; // 10.25
                hourlyRate1990 = 5.75F;
                hourlyRate2020 = 10.25F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
            case 4:
                //biweeklySalary1990 = 520; // 6.50
                //biweeklySalary2020 = 880; // 11
                hourlyRate1990 = 6.50F;
                hourlyRate2020 = 11.00F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
            case 5:
                //biweeklySalary1990 = 620; // 7.75
                //biweeklySalary2020 = 980; // 12.25
                hourlyRate1990 = 7.75F;
                hourlyRate2020 = 12.25F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
            case 6:
                //biweeklySalary1990 = 720; // 9
                //biweeklySalary2020 = 1080; // 13.50
                hourlyRate1990 = 9.00F;
                hourlyRate2020 = 13.50F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
        }

        randomEventsPage2DescriptionText1.text = "You have selected the job of Fry Cook!";
        randomEventsPage2DescriptionText2.text = "1990: Your bi-weekly pay will now be: $" + hourlyRate1990 + "/hour!";
        randomEventsPage2DescriptionText3.text = "2020: Your bi-weekly pay will now be: $" + hourlyRate2020 + "/hour!";

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent06bCSA()
    {
        // Job Loss
        forwardButtonClickAudioSource.Play();

        newWaiterButton.SetActive(false);
        newCashierButton.SetActive(false);
        newFryCookButton.SetActive(false);
        newCSAButton.SetActive(false);
        newTeacherButton.SetActive(false);
        newLSAButton.SetActive(false);
        newProgrammerButton.SetActive(false);
        newEngineerButton.SetActive(false);
        newLawyerButton.SetActive(false);
        newDoctorButton.SetActive(false);

        randomEventsScreenJob.SetActive(false);
        randomEventsScreen2.SetActive(true);

        customerServiceAgent = true;
        jobNow = 4;
        jobSelected = "Customer Service Agent";

        //Setting Pay
        switch (educationNow)
        {
            case 1:
                //biweeklySalary1990 = 320; // 4
                //biweeklySalary2020 = 684.80; // 8.56
                hourlyRate1990 = 4.00F;
                hourlyRate2020 = 8.50F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
            case 2:
                //biweeklySalary1990 = 420; // 5.25
                //biweeklySalary2020 = 780; // 9.75
                hourlyRate1990 = 5.25F;
                hourlyRate2020 = 9.75F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
            case 3:
                //biweeklySalary1990 = 460; // 5.75
                //biweeklySalary2020 =  820; // 10.25
                hourlyRate1990 = 5.75F;
                hourlyRate2020 = 10.25F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
            case 4:
                //biweeklySalary1990 = 520; // 6.50
                //biweeklySalary2020 = 880; // 11
                hourlyRate1990 = 6.50F;
                hourlyRate2020 = 11.00F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
            case 5:
                //biweeklySalary1990 = 620; // 7.75
                //biweeklySalary2020 = 980; // 12.25
                hourlyRate1990 = 7.75F;
                hourlyRate2020 = 12.25F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
            case 6:
                //biweeklySalary1990 = 720; // 9
                //biweeklySalary2020 = 1080; // 13.50
                hourlyRate1990 = 9.00F;
                hourlyRate2020 = 13.50F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
        }

        randomEventsPage2DescriptionText1.text = "You have selected the job of " + jobSelected + "!";
        randomEventsPage2DescriptionText2.text = "1990: Your hourly pay will now be: $" + hourlyRate1990 + "/hour!";
        randomEventsPage2DescriptionText3.text = "2020: Your hourly pay will now be: $" + hourlyRate2020 + "/hour!";

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent06bTeacher()
    {
        // Job Loss
        forwardButtonClickAudioSource.Play();

        newWaiterButton.SetActive(false);
        newCashierButton.SetActive(false);
        newFryCookButton.SetActive(false);
        newCSAButton.SetActive(false);
        newTeacherButton.SetActive(false);
        newLSAButton.SetActive(false);
        newProgrammerButton.SetActive(false);
        newEngineerButton.SetActive(false);
        newLawyerButton.SetActive(false);
        newDoctorButton.SetActive(false);

        randomEventsScreenJob.SetActive(false);
        randomEventsScreen2.SetActive(true);

        teacher = true;
        jobNow = 5;
        jobSelected = "Teacher";

        //Setting Pay
        switch (educationNow)
        {
            case 1:
                //biweeklySalary1990 = 0;
                //biweeklySalary2020 = 0;
                hourlyRate1990 = 0.00F;
                hourlyRate2020 = 0.00F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
            case 2:
                //biweeklySalary1990 = 0;
                //biweeklySalary2020 = 0;
                hourlyRate1990 = 0.00F;
                hourlyRate2020 = 0.00F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
            case 3: 
                //biweeklySalary1990 = 0;
                //biweeklySalary2020 = 0;
                hourlyRate1990 = 0.00F;
                hourlyRate2020 = 0.00F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
            case 4:
                //biweeklySalary1990 = 800; // 10
                //biweeklySalary2020 = 1200; // 15
                hourlyRate1990 = 10.00F;
                hourlyRate2020 = 15.00F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
            case 5:
                //biweeklySalary1990 = 960; // 12
                //biweeklySalary2020 = 1600; // 20
                hourlyRate1990 = 12.00F;
                hourlyRate2020 = 20.00F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
            case 6:
                //biweeklySalary1990 = 1200; // 15
                //biweeklySalary2020 = 2000; // 25
                hourlyRate1990 = 15.00F;
                hourlyRate2020 = 25.00F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
        }

        randomEventsPage2DescriptionText1.text = "You have selected the job of " + jobSelected + "!";
        randomEventsPage2DescriptionText2.text = "1990: Your hourly pay will now be: $" + hourlyRate1990 + "/hour!";
        randomEventsPage2DescriptionText3.text = "2020: Your hourly pay will now be: $" + hourlyRate2020 + "/hour!";

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent06bLSA()
    {
        // Job Loss
        forwardButtonClickAudioSource.Play();

        newWaiterButton.SetActive(false);
        newCashierButton.SetActive(false);
        newFryCookButton.SetActive(false);
        newCSAButton.SetActive(false);
        newTeacherButton.SetActive(false);
        newLSAButton.SetActive(false);
        newProgrammerButton.SetActive(false);
        newEngineerButton.SetActive(false);
        newLawyerButton.SetActive(false);
        newDoctorButton.SetActive(false);

        randomEventsScreenJob.SetActive(false);
        randomEventsScreen2.SetActive(true);

        licensedSalesAgent = true;
        jobNow = 6;
        jobSelected = "Licensed Sales Agent";

        //Setting Pay
        switch (educationNow)
        {
            case 1:
                //biweeklySalary1990 = 0;
                //biweeklySalary2020 = 0;
                hourlyRate1990 = 0.00F;
                hourlyRate2020 = 0.00F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
            case 2:
                //biweeklySalary1990 = 800; // 10
                //biweeklySalary2020 = 1200; // 15
                hourlyRate1990 = 10.00F;
                hourlyRate2020 = 15.00F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
            case 3:
                //biweeklySalary1990 = 880; // 11
                //biweeklySalary2020 = 1300; // 16.25
                hourlyRate1990 = 11.00F;
                hourlyRate2020 = 16.25F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
            case 4:
                //biweeklySalary1990 = 1000; // 12.50
                //biweeklySalary2020 = 1440; // 18
                hourlyRate1990 = 12.50F;
                hourlyRate2020 = 18.00F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
            case 5:
                //biweeklySalary1990 = 1200; // 15
                //biweeklySalary2020 = 1680; // 21
                hourlyRate1990 = 15.00F;
                hourlyRate2020 = 21.00F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
            case 6:
                //biweeklySalary1990 = 1400; // 17.50
                //biweeklySalary2020 = 1920; // 24
                hourlyRate1990 = 17.50F;
                hourlyRate2020 = 24.00F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
        }

        randomEventsPage2DescriptionText1.text = "You have selected the job of " + jobSelected + "!";
        randomEventsPage2DescriptionText2.text = "1990: Your hourly pay will now be: $" + hourlyRate1990 + "/hour!";
        randomEventsPage2DescriptionText3.text = "2020: Your hourly pay will now be: $" + hourlyRate2020 + "/hour!";

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent06bProgrammer()
    {
        // Job Loss
        forwardButtonClickAudioSource.Play();

        newWaiterButton.SetActive(false);
        newCashierButton.SetActive(false);
        newFryCookButton.SetActive(false);
        newCSAButton.SetActive(false);
        newTeacherButton.SetActive(false);
        newLSAButton.SetActive(false);
        newProgrammerButton.SetActive(false);
        newEngineerButton.SetActive(false);
        newLawyerButton.SetActive(false);
        newDoctorButton.SetActive(false);

        randomEventsScreenJob.SetActive(false);
        randomEventsScreen2.SetActive(true);

        programmer = true;
        jobNow = 7;
        jobSelected = "Programmer";

        //Setting Pay
        switch (educationNow)
        {
            case 1:
                //biweeklySalary1990 = 0;
                //biweeklySalary2020 = 0;
                hourlyRate1990 = 0.00F;
                hourlyRate2020 = 0.00F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
            case 2:
                //biweeklySalary1990 = 960; // 12
                //biweeklySalary2020 = 1200; // 15
                hourlyRate1990 = 12.00F;
                hourlyRate2020 = 15.00F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
            case 3:
                //biweeklySalary1990 = 1040; // 13
                //biweeklySalary2020 = 1320; // 16.50
                hourlyRate1990 = 13.00F;
                hourlyRate2020 = 16.50F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
            case 4:
                //biweeklySalary1990 = 1200; // 15
                //biweeklySalary2020 = 1600; // 20
                hourlyRate1990 = 15.00F;
                hourlyRate2020 = 20.00F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
            case 5:
                //biweeklySalary1990 = 1440; // 18
                //biweeklySalary2020 = 2000; // 25
                hourlyRate1990 = 18.00F;
                hourlyRate2020 = 25.00F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
            case 6:
                //biweeklySalary1990 = 1680; // 21
                //biweeklySalary2020 = 2400; // 30
                hourlyRate1990 = 21.00F;
                hourlyRate2020 = 30.00F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
        }

        randomEventsPage2DescriptionText1.text = "You have selected the job of " +  jobSelected + "!";
        randomEventsPage2DescriptionText2.text = "1990: Your hourly pay will now be: $" + hourlyRate1990 + "/hour!";
        randomEventsPage2DescriptionText3.text = "2020: Your hourly pay will now be: $" + hourlyRate2020 + "/hour!";

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent06bEngineer()
    {
        // Job Loss
        forwardButtonClickAudioSource.Play();

        newWaiterButton.SetActive(false);
        newCashierButton.SetActive(false);
        newFryCookButton.SetActive(false);
        newCSAButton.SetActive(false);
        newTeacherButton.SetActive(false);
        newLSAButton.SetActive(false);
        newProgrammerButton.SetActive(false);
        newEngineerButton.SetActive(false);
        newLawyerButton.SetActive(false);
        newDoctorButton.SetActive(false);

        randomEventsScreenJob.SetActive(false);
        randomEventsScreen2.SetActive(true);

        engineer = true;
        jobNow = 8;
        jobSelected = "Engineer";

        //Setting Pay
        switch (educationNow)
        {
            case 1:
                //biweeklySalary1990 = 0;
                //biweeklySalary2020 = 0;
                hourlyRate1990 = 0.00F;
                hourlyRate2020 = 0.00F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
            case 2:
                //biweeklySalary1990 = 0;
                //biweeklySalary2020 = 0;
                hourlyRate1990 = 0.00F;
                hourlyRate2020 = 0.00F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
            case 3:
                //biweeklySalary1990 = 0;
                //biweeklySalary2020 = 0;
                hourlyRate1990 = 0.00F;
                hourlyRate2020 = 0.00F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
            case 4:
                //biweeklySalary1990 = 0;
                //biweeklySalary2020 = 0;
                hourlyRate1990 = 0.00F;
                hourlyRate2020 = 0.00F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
            case 5:
                //biweeklySalary1990 = 0;
                //biweeklySalary2020 = 0;
                hourlyRate1990 = 23.00F;
                hourlyRate2020 = 30.00F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
            case 6:
                //biweeklySalary1990 = 2000; // 25
                //biweeklySalary2020 = 2800; // 35
                hourlyRate1990 = 25.00F;
                hourlyRate2020 = 35.00F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
        }

        randomEventsPage2DescriptionText1.text = "You have selected the job of " + jobSelected + "!";
        randomEventsPage2DescriptionText2.text = "1990: Your hourly pay will now be: $" + hourlyRate1990 + "/hour!";
        randomEventsPage2DescriptionText3.text = "2020: Your hourly pay will now be: $" + hourlyRate2020 + "/hour!";

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent06bLawyer()
    {
        // Job Loss
        forwardButtonClickAudioSource.Play();

        newWaiterButton.SetActive(false);
        newCashierButton.SetActive(false);
        newFryCookButton.SetActive(false);
        newCSAButton.SetActive(false);
        newTeacherButton.SetActive(false);
        newLSAButton.SetActive(false);
        newProgrammerButton.SetActive(false);
        newEngineerButton.SetActive(false);
        newLawyerButton.SetActive(false);
        newDoctorButton.SetActive(false);

        randomEventsScreenJob.SetActive(false);
        randomEventsScreen2.SetActive(true);

        lawyer = true;
        jobNow = 9;
        jobSelected = "Lawyer";

        //Setting Pay
        switch (educationNow)
        {
            case 1:
                //biweeklySalary1990 = 0;
                //biweeklySalary2020 = 0;
                hourlyRate1990 = 0.00F;
                hourlyRate2020 = 0.00F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
            case 2:
                //biweeklySalary1990 = 0;
                //biweeklySalary2020 = 0;
                hourlyRate1990 = 0.00F;
                hourlyRate2020 = 0.00F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
            case 3:
                //biweeklySalary1990 = 0;
                //biweeklySalary2020 = 0;
                hourlyRate1990 = 0.00F;
                hourlyRate2020 = 0.00F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
            case 4:
                //biweeklySalary1990 = 0;
                //biweeklySalary2020 = 0;
                hourlyRate1990 = 0.00F;
                hourlyRate2020 = 0.00F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
            case 5:
                //biweeklySalary1990 = 0;
                //biweeklySalary2020 = 0;
                hourlyRate1990 = 0.00F;
                hourlyRate2020 = 0.00F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
            case 6:
                //biweeklySalary1990 = 2200; // 27.50
                //biweeklySalary2020 = 3000; // 37.50
                hourlyRate1990 = 27.50F;
                hourlyRate2020 = 37.50F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
        }

        randomEventsPage2DescriptionText1.text = "You have selected the job of " + jobSelected + "!";
        randomEventsPage2DescriptionText2.text = "1990: Your hourly pay will now be: $" + hourlyRate1990 + "/hour!";
        randomEventsPage2DescriptionText3.text = "2020: Your hourly pay will now be: $" + hourlyRate2020 + "/hour!";

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent06bDoctor()
    {
        // Job Loss
        forwardButtonClickAudioSource.Play();

        newWaiterButton.SetActive(false);
        newCashierButton.SetActive(false);
        newFryCookButton.SetActive(false);
        newCSAButton.SetActive(false);
        newTeacherButton.SetActive(false);
        newLSAButton.SetActive(false);
        newProgrammerButton.SetActive(false);
        newEngineerButton.SetActive(false);
        newLawyerButton.SetActive(false);
        newDoctorButton.SetActive(false);

        randomEventsScreenJob.SetActive(false);
        randomEventsScreen2.SetActive(true);

        doctor = true;
        jobNow = 10;
        jobSelected = "Doctor";

        //Setting Pay
        switch (educationNow)
        {
            case 1:
                //biweeklySalary1990 = 0;
                //biweeklySalary2020 = 0;
                hourlyRate1990 = 0.00F;
                hourlyRate2020 = 0.00F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
            case 2:
                //biweeklySalary1990 = 0;
                //biweeklySalary2020 = 0;
                hourlyRate1990 = 0.00F;
                hourlyRate2020 = 0.00F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
            case 3:
                //biweeklySalary1990 = 0;
                //biweeklySalary2020 = 0;
                hourlyRate1990 = 0.00F;
                hourlyRate2020 = 0.00F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
            case 4:
                //biweeklySalary1990 = 0;
                //biweeklySalary2020 = 0;
                hourlyRate1990 = 0.00F;
                hourlyRate2020 = 0.00F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
            case 5:
                //biweeklySalary1990 = 0;
                //biweeklySalary2020 = 0;
                hourlyRate1990 = 0.00F;
                hourlyRate2020 = 0.00F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
            case 6:
                //biweeklySalary1990 = 2800; // 35
                //biweeklySalary2020 = 4000; // 50
                hourlyRate1990 = 35.00F;
                hourlyRate2020 = 50.00F;
                hourlyRate1990 = Math.Round(hourlyRate1990, 2);
                hourlyRate2020 = Math.Round(hourlyRate2020, 2);
                break;
        }

        randomEventsPage2DescriptionText1.text = "You have selected the job of " + jobSelected + "!";
        randomEventsPage2DescriptionText2.text = "1990: Your hourly pay will now be: $" + hourlyRate1990 + "/hour!";
        randomEventsPage2DescriptionText3.text = "2020: Your hourly pay will now be: $" + hourlyRate2020 + "/hour!";

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent07a()
    {
        // Improve Education
        forwardButtonClickAudioSource.Play();

        RandomEvent07Page1Button.SetActive(false);
        randomEventsScreen1.SetActive(false);
        randomEventsScreen2.SetActive(true);

        randomEventsPage2DescriptionText1.text = "Improving your education comes with perks, including higher pay!";
        randomEventsPage2DescriptionText2.text = "1990: Your hourly pay will now be: $" + hourlyRate1990 + "/hour!";
        randomEventsPage2DescriptionText3.text = "2020: Your hourly pay will now be: $" + hourlyRate2020 + "/hour!";

        RandomEventsPage2CloseButton.SetActive(true);

    }
    public void RandomEvent08a()
    {
        // Sick
        forwardButtonClickAudioSource.Play();

        RandomEvent08Page1Button.SetActive(false);
        randomEventsScreen1.SetActive(false);
        randomEventsScreen2.SetActive(true);

        daysMissed = UnityEngine.Random.Range(1, 5);
        totalDaysMissed += daysMissed;

        randomEventsPage2DescriptionText1.text = "You will miss " + daysMissed + " days of work due to being sick.";
        
        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent09a()
    {
        // Farmer's Strike
        forwardButtonClickAudioSource.Play();

        RandomEvent09Page1Button.SetActive(false);
        randomEventsScreen1.SetActive(false);
        randomEventsScreen2.SetActive(true);

        foodGroceryCost1990 += foodGroceryCost1990 * generalPercent;
        foodGroceryCost2020 += foodGroceryCost2020 * generalPercent;
        foodFastFoodCost1990 += foodFastFoodCost1990 * generalPercent;
        foodFastFoodCost2020 += foodFastFoodCost2020 * generalPercent;
        foodEatingOutCost1990 += foodEatingOutCost1990 * generalPercent;
        foodEatingOutCost2020 += foodEatingOutCost2020 * generalPercent;

        foodGroceryCost1990 = Math.Round(foodGroceryCost1990, 2);
        foodGroceryCost2020 = Math.Round(foodGroceryCost2020, 2);
        foodFastFoodCost1990 = Math.Round(foodFastFoodCost1990, 2);
        foodFastFoodCost2020 = Math.Round(foodFastFoodCost2020, 2);
        foodEatingOutCost1990 = Math.Round(foodEatingOutCost1990, 2);
        foodEatingOutCost2020 = Math.Round(foodEatingOutCost2020, 2);

        randomEventsPage2DescriptionText1.text = "Weekly Food costs have increased to:";
        randomEventsPage2DescriptionText2.text = "1990: \nGroceries: $" + foodGroceryCost1990 + "\nFast Food: $" + foodFastFoodCost1990 + "\nEating Out: $" + foodEatingOutCost1990;
        randomEventsPage2DescriptionText3.text = "2020: \nGroceries: $" + foodGroceryCost2020 + "\nFast Food: $" + foodFastFoodCost2020 + "\nEating Out: $" + foodEatingOutCost2020;
        
        RandomEventsPage2CloseButton.SetActive(true);

        //generalPercent = 0.00;
        //generalPercent1 = 0.00;
    }
    public void RandomEvent10a()
    {
        // Transportation Repairs
        forwardButtonClickAudioSource.Play();

        RandomEvent10Page1Button.SetActive(false);
        randomEventsScreen1.SetActive(false);
        randomEventsScreen2.SetActive(true);

        if (bicycle == true)
        {
            randomEventsPage2DescriptionText1.text = "You replaced the Chain on your Bicycle!";
            randomEventsPage2DescriptionText2.text = "1990: Replacement Cost: $" + transportationWoes1990;
            randomEventsPage2DescriptionText3.text = "2020: Replacement Cost: $" + transportationWoes2020;

            otherPaid1990 += transportationWoes1990;
            otherPaid2020 += transportationWoes2020;
            currentMoney1990 -= transportationWoes1990;
            currentMoney2020 -= transportationWoes2020;
            weekMoneyLoss1990 += transportationWoes1990;
            weekMoneyLoss2020 += transportationWoes2020;
        }
        else if (usedCar == true)
        {
            randomEventsPage2DescriptionText1.text = "You replaced the Brakes on your Used Car!";
            randomEventsPage2DescriptionText2.text = "1990: Replacement Cost: $" + transportationWoes1990;
            randomEventsPage2DescriptionText3.text = "2020: Replacement Cost: $" + transportationWoes2020;

            otherPaid1990 += transportationWoes1990;
            otherPaid2020 += transportationWoes2020;
            currentMoney1990 -= transportationWoes1990;
            currentMoney2020 -= transportationWoes2020;
            weekMoneyLoss1990 += transportationWoes1990;
            weekMoneyLoss2020 += transportationWoes2020;
        }
        else if (newCar == true)
        {
            randomEventsPage2DescriptionText1.text = "You replaced the Tires on your New Car!";
            randomEventsPage2DescriptionText2.text = "1990: Replacement Cost: $" + transportationWoes1990;
            randomEventsPage2DescriptionText3.text = "2020: Replacement Cost: $" + transportationWoes2020;;

            otherPaid1990 += transportationWoes1990;
            otherPaid2020 += transportationWoes2020;
            currentMoney1990 -= transportationWoes1990;
            currentMoney2020 -= transportationWoes2020;
            weekMoneyLoss1990 += transportationWoes1990;
            weekMoneyLoss2020 += transportationWoes2020;
        }
        else if (motorcycle == true)
        {
            randomEventsPage2DescriptionText1.text = "You replaced the Battery on your Motorcycle!";
            randomEventsPage2DescriptionText2.text = "1990: Replacement Cost: $" + transportationWoes1990;
            randomEventsPage2DescriptionText3.text = "2020: Replacement Cost: $" + transportationWoes2020;

            otherPaid1990 += transportationWoes1990;
            otherPaid2020 += transportationWoes2020;
            currentMoney1990 -= transportationWoes1990;
            currentMoney2020 -= transportationWoes2020;
            weekMoneyLoss1990 += transportationWoes1990;
            weekMoneyLoss2020 += transportationWoes2020;
        }
        else if (bus == true)
        {
            randomEventsPage2DescriptionText1.text = "You made it to work, but you missed " + hoursMissed + " hours this week.";
        }
        else if (train == true)
        {
            randomEventsPage2DescriptionText1.text = "You made it to work, but you missed " + hoursMissed + " hours this week.";
        }
        
        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent11a()
    {
        // Transportation Loss
        forwardButtonClickAudioSource.Play();

        RandomEvent11Page1Button.SetActive(false);
        randomEventsScreen1.SetActive(false);
        randomEventsScreenTransportation.SetActive(true);

        randomEventsPageTransportationDescriptionText1.text = "You must now choose a new form of transportation.";
    }
    public void RandomEvent11bBicycle()
    {
        // Transportation Loss
        forwardButtonClickAudioSource.Play();

        travelNow = 1;
        transportationSelected = "Bicycle";
        payTransportationTitleText1.text = "Pay Transportation: Bicycle";
        payTransportationTitleText2.text = "Pay Transportation: Bicycle";

        newBicycleButton.SetActive(false);
        newUsedCarButton.SetActive(false);
        newNewCarButton.SetActive(false);
        newMotorcycleButton.SetActive(false);
        newBusButton.SetActive(false);
        newTrainButton.SetActive(false);

        randomEventsScreenTransportation.SetActive(false);
        randomEventsScreen2.SetActive(true);

        bicycleCost1990 = UnityEngine.Random.Range(100.00F, 200.00F);
        bicycleCost2020 = UnityEngine.Random.Range(150.00F, 350.00F);

        bicycleCost1990 = Math.Round(bicycleCost1990, 2);
        bicycleCost2020 = Math.Round(bicycleCost2020, 2);

        currentMoney1990 -= bicycleCost1990;
        currentMoney2020 -= bicycleCost2020;

        transportationPaid1990 += bicycleCost1990;
        transportationPaid2020 += bicycleCost2020;

        weekMoneyLoss1990 -= bicycleCost1990;
        weekMoneyLoss2020 -= bicycleCost2020;

        //weekB1990 = (airPump1990 * workDays); // 2.00 air * 5 days
        //weekB2020 = (airPump2020 * workDays); // 2.00 air * 5 days

        //transportationCost1990 = weekB1990;
        //transportationCost2020 = weekB2020;

        transportationCost1990 = airPump1990 * workDays; // 2.00 air * 5 days
        transportationCost2020 = airPump2020 * workDays; // 2.00 air * 5 days

        transportationCost1990 = Math.Round(transportationCost1990, 2);
        transportationCost2020 = Math.Round(transportationCost2020, 2);

        randomEventsPage2DescriptionText1.text = "You have selected Bicycle. Besides the initial cost to buy the vehicle, the only other costs come from keeping air in the tires.";
        randomEventsPage2DescriptionText2.text = "1990: \nBicycle Cost: $" + bicycleCost1990 + "\nTransportation Cost: $" + transportationCost1990;
        randomEventsPage2DescriptionText3.text = "2020: \nBicycle Cost: $" + bicycleCost2020 + "\nTransportation Cost: $" + transportationCost2020;

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent11bUsedCar()
    {
        // Transportation Loss
        forwardButtonClickAudioSource.Play();

        travelNow = 2;
        transportationSelected = "Used Car";
        payTransportationTitleText1.text = "Pay Transportation: Used Car";
        payTransportationTitleText2.text = "Pay Transportation: Used Car";

        newBicycleButton.SetActive(false);
        newUsedCarButton.SetActive(false);
        newNewCarButton.SetActive(false);
        newMotorcycleButton.SetActive(false);
        newBusButton.SetActive(false);
        newTrainButton.SetActive(false);

        randomEventsScreenTransportation.SetActive(false);
        randomEventsScreen2.SetActive(true);

        weeklyUsedCarCost1990 = UnityEngine.Random.Range(30.00F, 75.00F);
        weeklyUsedCarCost2020 = UnityEngine.Random.Range(50.00F, 100.00F);

        weeklyUsedCarCost1990 = Math.Round(weeklyUsedCarCost1990, 2);
        weeklyUsedCarCost2020 = Math.Round(weeklyUsedCarCost2020, 2);

        //weekUC1990 = gasCost1990 * usedCarTank; // 1.15 gas * 10 gal
        //weekUC2020 = gasCost2020 * usedCarTank; // 2.50 gas * 10 gal

        //transportationCost1990 = (weeklyUsedCarCost1990 + weekUC1990);
        //transportationCost2020 = (weeklyUsedCarCost2020 + weekUC2020);

        // [(Back-Up)
        transportationCost1990 = 11.50F; // 1.15 gas * 10 gal
        transportationCost2020 = 25.00F; // 2.50 gas * 10 gal
        // ]

        transportationCost1990 += weeklyUsedCarCost1990;
        transportationCost2020 += weeklyUsedCarCost2020;

        transportationCost1990 = Math.Round(transportationCost1990, 2);
        transportationCost2020 = Math.Round(transportationCost2020, 2);

        randomEventsPage2DescriptionText1.text = "You have selected Used Car. This transportation option does have a weekly purchase payment, which will be added to the weekly transportation cost for gas.";
        randomEventsPage2DescriptionText2.text = "1990: \nUsed Car Cost: $" + weeklyUsedCarCost1990 + "\nWeekly Transportation Cost: $" + transportationCost1990;
        randomEventsPage2DescriptionText3.text = "2020: \nUsed Car Cost: $" + weeklyUsedCarCost2020 + "\nWeekly Transportation Cost: $" + transportationCost2020;

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent11bNewCar()
    {
        // Transportation Loss
        forwardButtonClickAudioSource.Play();

        travelNow = 3;
        transportationSelected = "New Car";
        payTransportationTitleText1.text = "Pay Transportation: New Car";
        payTransportationTitleText2.text = "Pay Transportation: New Car";

        newBicycleButton.SetActive(false);
        newUsedCarButton.SetActive(false);
        newNewCarButton.SetActive(false);
        newMotorcycleButton.SetActive(false);
        newBusButton.SetActive(false);
        newTrainButton.SetActive(false);

        randomEventsScreenTransportation.SetActive(false);
        randomEventsScreen2.SetActive(true);

        weeklyNewCarCost1990 = UnityEngine.Random.Range(50.00F, 100.00F);
        weeklyNewCarCost2020 = UnityEngine.Random.Range(100.00F, 150.00F);

        weeklyNewCarCost1990 = Math.Round(weeklyNewCarCost1990, 2);
        weeklyNewCarCost2020 = Math.Round(weeklyNewCarCost2020, 2);

        //weekNC1990 = gasCost1990 * newCarTank; // 1.15 gas * 15 gal
        //weekNC2020 = gasCost2020 * newCarTank; // 2.50 gas * 15 gal

        //transportationCost1990 = (weeklyNewCarCost1990 + weekNC1990);
        //transportationCost2020 = (weeklyNewCarCost2020 + weekNC2020);

        // [(Back-Up)
        transportationCost1990 = 17.25F; // 1.15 gas * 15 gal
        transportationCost2020 = 37.50F; // 2.50 gas * 15 gal
        // ]

        transportationCost1990 += weeklyNewCarCost1990;
        transportationCost2020 += weeklyNewCarCost2020;

        transportationCost1990 = Math.Round(transportationCost1990, 2);
        transportationCost2020 = Math.Round(transportationCost2020, 2);

        randomEventsPage2DescriptionText1.text = "You have selected New Car. This transportation option does have a weekly purchase payment, which will be added to the weekly transportation cost for gas.";
        randomEventsPage2DescriptionText2.text = "1990: \nNew Car Cost: $" + weeklyNewCarCost1990 + "\nWeekly Transportation Cost: $" + transportationCost1990;
        randomEventsPage2DescriptionText3.text = "2020: \nNew Car Cost: $" + weeklyNewCarCost2020 + "\nWeekly Transportation Cost: $" + transportationCost2020;

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent11bMotorcycle()
    {
        // Transportation Loss
        forwardButtonClickAudioSource.Play();

        travelNow = 4;
        transportationSelected = "Motorcycle";
        payTransportationTitleText1.text = "Pay Transportation: Motorcycle";
        payTransportationTitleText2.text = "Pay Transportation: Motorcycle";

        newBicycleButton.SetActive(false);
        newUsedCarButton.SetActive(false);
        newNewCarButton.SetActive(false);
        newMotorcycleButton.SetActive(false);
        newBusButton.SetActive(false);
        newTrainButton.SetActive(false);

        randomEventsScreenTransportation.SetActive(false);
        randomEventsScreen2.SetActive(true);

        weeklyMotorcycleCost1990 = UnityEngine.Random.Range(25.00F, 55.00F);
        weeklyMotorcycleCost2020 = UnityEngine.Random.Range(40.00F, 75.00F);

        weeklyMotorcycleCost1990 = Math.Round(weeklyMotorcycleCost1990, 2);
        weeklyMotorcycleCost2020 = Math.Round(weeklyMotorcycleCost2020, 2);

        //weekM1990 = gasCost1990 * motorcycleTank; // 1.15 gas * 4 gal
        //weekM2020 = gasCost2020 * motorcycleTank; // 2.50 gas * 4 gal

        //transportationCost1990 = weeklyMotorcycleCost1990 + weekM1990;
        //transportationCost2020 = weeklyMotorcycleCost2020 + weekM2020;

        // [(Back-Up)
        transportationCost1990 = 4.60F; // 2.50 gas * 4 gal
        transportationCost2020 = 10.00F; // 2.50 gas * 4 gal
        // ]

        transportationCost1990 += weeklyMotorcycleCost1990;
        transportationCost2020 += weeklyMotorcycleCost2020;

        transportationCost1990 = Math.Round(transportationCost1990, 2);
        transportationCost2020 = Math.Round(transportationCost2020, 2);

        randomEventsPage2DescriptionText1.text = "You have selected Motorcycle! This transportation option does have a weekly purchase payment, which will be added to the weekly transportation cost for gas.";
        randomEventsPage2DescriptionText2.text = "1990: \nMotorcycle Cost: $" + weeklyMotorcycleCost1990 + "\nWeekly Transportation Cost: $" + transportationCost1990;
        randomEventsPage2DescriptionText3.text = "2020: \nMotorcycle Cost: $" + weeklyMotorcycleCost2020 + "\nWeekly Transportation Cost: $" + transportationCost2020;

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent11bBus()
    {
        // Transportation Loss
        forwardButtonClickAudioSource.Play();

        travelNow = 5;
        transportationSelected = "City Bus Transit";
        payTransportationTitleText1.text = "Pay Transportation: City Bus Transit";
        payTransportationTitleText2.text = "Pay Transportation: City Bus Transit";

        newBicycleButton.SetActive(false);
        newUsedCarButton.SetActive(false);
        newNewCarButton.SetActive(false);
        newMotorcycleButton.SetActive(false);
        newBusButton.SetActive(false);
        newTrainButton.SetActive(false);

        randomEventsScreenTransportation.SetActive(false);
        randomEventsScreen2.SetActive(true);

        //weekBus1990 = (busPass1990 * workDays); // 2.00/day * 5 days
        //weekBus2020 = (busPass2020 * workDays); // 4.50/day * 5 days

        //transportationCost1990 = weekBus1990;
        //transportationCost2020 = weekBus2020;

        transportationCost1990 = (busPass1990 * workDays); // 2.00/day * 5 days
        transportationCost2020 = (busPass2020 * workDays); // 4.50/day * 5 days

        transportationCost1990 = Math.Round(transportationCost1990, 2);
        transportationCost2020 = Math.Round(transportationCost2020, 2);

        randomEventsPage2DescriptionText1.text = "You have selected City Bus! This mode of transportation requires a daily Bus Pass, which is purchased every week.";
        randomEventsPage2DescriptionText2.text = "1990: \nDaily Bus Pass: $" + busPass1990 + "\nWeekly Transportation Cost: $" + transportationCost1990;
        randomEventsPage2DescriptionText3.text = "2020: \nDaily Bus Pass: $" + busPass2020 + "\nWeekly Transportation Cost: $" + transportationCost2020;

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent11bTrain()
    {
        // Transportation Loss
        forwardButtonClickAudioSource.Play();

        travelNow = 6;
        transportationSelected = "Train Transit";
        payTransportationTitleText1.text = "Pay Transportation: Train Transit";
        payTransportationTitleText2.text = "Pay Transportation: Train Transit";

        newBicycleButton.SetActive(false);
        newUsedCarButton.SetActive(false);
        newNewCarButton.SetActive(false);
        newMotorcycleButton.SetActive(false);
        newBusButton.SetActive(false);
        newTrainButton.SetActive(false);

        randomEventsScreenTransportation.SetActive(false);
        randomEventsScreen2.SetActive(true);

        trainPass1990 = UnityEngine.Random.Range(2.25F, 6.75F);
        trainPass2020 = UnityEngine.Random.Range(3.75F, 9.50F);

        trainPass1990 = Math.Round(trainPass1990, 2);
        trainPass2020 = Math.Round(trainPass2020, 2);

        weekT1990 = (trainPass1990 * workDays); // (2.25 - 6.75)/day * 5 days
        weekT2020 = (trainPass2020 * workDays); // (3.75 - 9.50)/day * 5 days

        transportationCost1990 = weekT1990;
        transportationCost2020 = weekT2020;

        transportationCost1990 = Math.Round(transportationCost1990, 2);
        transportationCost2020 = Math.Round(transportationCost2020, 2);

        randomEventsPage2DescriptionText1.text = "You have selected Train! This mode of transportation requires a daily Round-Trip Pass, which is purchased every week.";
        randomEventsPage2DescriptionText2.text = "1990: \nDaily Bus Pass: $" + trainPass1990 + "\nWeekly Transportation Cost: $" + transportationCost1990;
        randomEventsPage2DescriptionText3.text = "2020: \nDaily Bus Pass: $" + trainPass2020 + "\nWeekly Transportation Cost: $" + transportationCost2020;

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent12a()
    {
        // Unexpected Medical Emergency
        forwardButtonClickAudioSource.Play();

        RandomEvent12Page1Button.SetActive(false);
        randomEventsScreen1.SetActive(false);
        randomEventsScreen2.SetActive(true);

        randomEventsPage2DescriptionText1.text = "Hopefully you won't have any medical emergencies in the future.";
        randomEventsPage2DescriptionText2.text = "1990: Medical Cost: $" + medicalCost1990;
        randomEventsPage2DescriptionText3.text = "2020: Medical Cost: $" + medicalCost2020;

        currentMoney1990 -= medicalCost1990;
        currentMoney2020 -= medicalCost2020;

        otherPaid1990 += medicalCost1990;
        otherPaid2020 += medicalCost2020;

        weekMoneyLoss1990 += medicalCost1990;
        weekMoneyLoss2020 += medicalCost2020;

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent13a()
    {
        // Tax Return
        moneyGainedAudioSource.Play();

        RandomEvent13Page1Button.SetActive(false);
        randomEventsScreen1.SetActive(false);
        randomEventsScreen2.SetActive(true);

        taxReturn1990 = incomeTaxPaid1990 * generalPercent;
        taxReturn2020 = incomeTaxPaid2020 * generalPercent;

        taxReturn1990 = Math.Round(taxReturn1990, 2);
        taxReturn2020 = Math.Round(taxReturn2020, 2);

        currentMoney1990 += taxReturn1990;
        currentMoney2020 += taxReturn2020;

        weekMoneyObtained1990 += taxReturn1990;
        weekMoneyObtained2020 += taxReturn2020;

        randomEventsPage2DescriptionText1.text = "Hopefully this tax return will be helpful!";
        randomEventsPage2DescriptionText2.text = "1990: Tax Return: $" + taxReturn1990;
        randomEventsPage2DescriptionText3.text = "2020: Tax Return: $" + taxReturn2020;

        incomeTaxPaid1990 = 0.00F;
        incomeTaxPaid2020 = 0.00F;
        taxReturn1990 = 0.00F;
        taxReturn2020 = 0.00F;

        RandomEventsPage2CloseButton.SetActive(true);

        //generalPercent = 0.00;
        //generalPercent1 = 0.00;
    }
    public void RandomEvent14a()
    {
        // Internet Service Upgrade
        forwardButtonClickAudioSource.Play();

        RandomEvent14Page1Button.SetActive(false);
        randomEventsScreen1.SetActive(false);
        randomEventsScreen2.SetActive(true);

        //utilityInternetCost1990 += utilityInternetCost1990 * generalPercent;
        utilityInternetCost2020 += utilityInternetCost2020 * generalPercent;

        //utilityInternetCost1990 = Math.Round(utilityInternetCost1990, 2);
        utilityInternetCost2020 = Math.Round(utilityInternetCost2020, 2);

        randomEventsPage2DescriptionText1.text = "It sucks that your Internet bill increased, but at least the Internet service will be better.";
        if (basicDialUpInternet1990 == true)
        {
            randomEventsPage2DescriptionText2.text = "1990: Weekly Internet Cost: Varies";
        }
        else if (premiumDialUpInternet1990 == true)
        {
            randomEventsPage2DescriptionText2.text = "1990: Weekly Internet Cost: Varies";
        }
        randomEventsPage2DescriptionText3.text = "2020: Weekly Internet Cost: $" + utilityInternetCost2020;

        RandomEventsPage2CloseButton.SetActive(true);

        //generalPercent = 0.00F;
        //generalPercent1 = 0.00F;
    }
    public void RandomEvent15a()
    {
        // Communications Service Upgrade
        forwardButtonClickAudioSource.Play();

        RandomEvent15Page1Button.SetActive(false);
        randomEventsScreen1.SetActive(false);
        randomEventsScreen2.SetActive(true);

        utilityCommunicationsCost1990 += utilityCommunicationsCost1990 * generalPercent;
        utilityCommunicationsCost2020 += utilityCommunicationsCost2020 * generalPercent;

        utilityCommunicationsCost1990 = Math.Round(utilityCommunicationsCost1990, 2);
        utilityCommunicationsCost2020 = Math.Round(utilityCommunicationsCost2020, 2);

        randomEventsPage2DescriptionText1.text = "It sucks that your Communications bill increased, but at least the Phone service will be better.";
        randomEventsPage2DescriptionText2.text = "1990: Weekly Communications Cost: $" + utilityCommunicationsCost1990;
        randomEventsPage2DescriptionText3.text = "2020: Weekly Communications Cost: $" + utilityCommunicationsCost2020;

        RandomEventsPage2CloseButton.SetActive(true);

        //generalPercent = 0.00F;
        //generalPercent1 = 0.00F;
    }
    public void RandomEvent16a()
    {
        // Entertainment Service Upgrade
        forwardButtonClickAudioSource.Play();

        RandomEvent15Page1Button.SetActive(false);
        randomEventsScreen1.SetActive(false);
        randomEventsScreen2.SetActive(true);

        utilityEntertainmentCost1990 += utilityEntertainmentCost1990 * generalPercent;
        utilityEntertainmentCost2020 += utilityEntertainmentCost2020 * generalPercent;

        utilityEntertainmentCost1990 = Math.Round(utilityEntertainmentCost1990, 2);
        utilityEntertainmentCost2020 = Math.Round(utilityEntertainmentCost2020, 2);

        randomEventsPage2DescriptionText1.text = "It sucks that your Entertainment bill increased, but at least the service will be better.";
        randomEventsPage2DescriptionText2.text = "1990: Weekly Entertainment Cost: $" + utilityEntertainmentCost1990;
        randomEventsPage2DescriptionText3.text = "2020: Weekly Entertainment Cost: $" + utilityEntertainmentCost2020;

        RandomEventsPage2CloseButton.SetActive(true);

        //generalPercent = 0.00F;
        //generalPercent1 = 0.00F;
    }
    public void RandomEvent17a()
    {
        // Hurricane Destruction
        forwardButtonClickAudioSource.Play();

        RandomEvent17Page1Button.SetActive(false);
        randomEventsScreen1.SetActive(false);
        randomEventsScreen2.SetActive(true);

        hotelStay1990 = hotelRate1990 * hotelDays;
        hotelStay2020 = hotelRate2020 * hotelDays;

        hotelStay1990 = Math.Round(hotelStay1990, 2);
        hotelStay2020 = Math.Round(hotelStay2020, 2);

        currentMoney1990 -= hotelStay1990;
        currentMoney2020 -= hotelStay2020;

        otherPaid1990 += hotelStay1990;
        otherPaid2020 += hotelStay2020;

        weekMoneyLoss1990 += hotelStay1990;
        weekMoneyLoss2020 += hotelStay2020;

        randomEventsPage2DescriptionText1.text = "It sucks that you have to spend extra money on a hotel as your home damage is being repaired.";
        randomEventsPage2DescriptionText2.text = "1990: Hotel Stay Paid: $" + hotelStay1990;
        randomEventsPage2DescriptionText3.text = "2020: Hotel Stay Paid: $" + hotelStay2020;

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent18a()
    {
        // Unexpected Medical Emergency
        forwardButtonClickAudioSource.Play();

        RandomEvent12Page1Button.SetActive(false);
        randomEventsScreen1.SetActive(false);
        randomEventsScreen2.SetActive(true);

        randomEventsPage2DescriptionText1.text = "Hopefully you won't have any medical emergencies in the future.";
        randomEventsPage2DescriptionText2.text = "1990: Medical Cost: $" + medicalCost1990;
        randomEventsPage2DescriptionText3.text = "2020: Medical Cost: $" + medicalCost2020;

        currentMoney1990 -= medicalCost1990;
        currentMoney2020 -= medicalCost2020;

        otherPaid1990 += medicalCost1990;
        otherPaid2020 += medicalCost2020;

        weekMoneyLoss1990 += medicalCost1990;
        weekMoneyLoss2020 += medicalCost2020;

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent19a()
    {
        // ???
        forwardButtonClickAudioSource.Play();

        RandomEvent19Page1Button.SetActive(false);
        randomEventsScreen1.SetActive(false);
        randomEventsScreen2.SetActive(true);

        randomEventsPage2DescriptionText1.text = "";
        randomEventsPage2DescriptionText2.text = "";
        randomEventsPage2DescriptionText3.text = "";

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent20a()
    {
        // ???
        forwardButtonClickAudioSource.Play();

        RandomEvent20Page1Button.SetActive(false);
        randomEventsScreen1.SetActive(false);
        randomEventsScreen2.SetActive(true);

        randomEventsPage2DescriptionText1.text = "";
        randomEventsPage2DescriptionText2.text = "";
        randomEventsPage2DescriptionText3.text = "";

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent21a()
    {
        // ???
        forwardButtonClickAudioSource.Play();

        RandomEvent21Page1Button.SetActive(false);
        randomEventsScreen1.SetActive(false);
        randomEventsScreen2.SetActive(true);

        randomEventsPage2DescriptionText1.text = "";
        randomEventsPage2DescriptionText2.text = "";
        randomEventsPage2DescriptionText3.text = "";

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent22a()
    {
        // ???
        forwardButtonClickAudioSource.Play();

        RandomEvent22Page1Button.SetActive(false);
        randomEventsScreen1.SetActive(false);
        randomEventsScreen2.SetActive(true);

        randomEventsPage2DescriptionText1.text = "";
        randomEventsPage2DescriptionText2.text = "";
        randomEventsPage2DescriptionText3.text = "";

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent23a()
    {
        // ???
        forwardButtonClickAudioSource.Play();

        RandomEvent23Page1Button.SetActive(false);
        randomEventsScreen1.SetActive(false);
        randomEventsScreen2.SetActive(true);

        randomEventsPage2DescriptionText1.text = "";
        randomEventsPage2DescriptionText2.text = "";
        randomEventsPage2DescriptionText3.text = "";

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent24a()
    {
        // ???
        forwardButtonClickAudioSource.Play();

        RandomEvent24Page1Button.SetActive(false);
        randomEventsScreen1.SetActive(false);
        randomEventsScreen2.SetActive(true);

        randomEventsPage2DescriptionText1.text = "";
        randomEventsPage2DescriptionText2.text = "";
        randomEventsPage2DescriptionText3.text = "";

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent25a()
    {
        // ???
        forwardButtonClickAudioSource.Play();

        RandomEvent25Page1Button.SetActive(false);
        randomEventsScreen1.SetActive(false);
        randomEventsScreen2.SetActive(true);

        randomEventsPage2DescriptionText1.text = "";
        randomEventsPage2DescriptionText2.text = "";
        randomEventsPage2DescriptionText3.text = "";

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent26a()
    {
        // ???
        forwardButtonClickAudioSource.Play();

        RandomEvent26Page1Button.SetActive(false);
        randomEventsScreen1.SetActive(false);
        randomEventsScreen2.SetActive(true);

        randomEventsPage2DescriptionText1.text = "";
        randomEventsPage2DescriptionText2.text = "";
        randomEventsPage2DescriptionText3.text = "";

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent27a()
    {
        // ???
        forwardButtonClickAudioSource.Play();

        RandomEvent27Page1Button.SetActive(false);
        randomEventsScreen1.SetActive(false);
        randomEventsScreen2.SetActive(true);

        randomEventsPage2DescriptionText1.text = "";
        randomEventsPage2DescriptionText2.text = "";
        randomEventsPage2DescriptionText3.text = "";

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent28a()
    {
        // ???
        forwardButtonClickAudioSource.Play();

        RandomEvent28Page1Button.SetActive(false);
        randomEventsScreen1.SetActive(false);
        randomEventsScreen2.SetActive(true);

        randomEventsPage2DescriptionText1.text = "";
        randomEventsPage2DescriptionText2.text = "";
        randomEventsPage2DescriptionText3.text = "";

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent29a()
    {
        // ???
        forwardButtonClickAudioSource.Play();

        RandomEvent29Page1Button.SetActive(false);
        randomEventsScreen1.SetActive(false);
        randomEventsScreen2.SetActive(true);

        randomEventsPage2DescriptionText1.text = "";
        randomEventsPage2DescriptionText2.text = "";
        randomEventsPage2DescriptionText3.text = "";

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent30a()
    {
        // ???
        forwardButtonClickAudioSource.Play();

        RandomEvent30Page1Button.SetActive(false);
        randomEventsScreen1.SetActive(false);
        randomEventsScreen2.SetActive(true);

        randomEventsPage2DescriptionText1.text = "";
        randomEventsPage2DescriptionText2.text = "";
        randomEventsPage2DescriptionText3.text = "";

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent31a()
    {
        // ???
        forwardButtonClickAudioSource.Play();

        RandomEvent31Page1Button.SetActive(false);
        randomEventsScreen1.SetActive(false);
        randomEventsScreen2.SetActive(true);

        randomEventsPage2DescriptionText1.text = "";
        randomEventsPage2DescriptionText2.text = "";
        randomEventsPage2DescriptionText3.text = "";

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent32a()
    {
        // ???
        forwardButtonClickAudioSource.Play();

        RandomEvent32Page1Button.SetActive(false);
        randomEventsScreen1.SetActive(false);
        randomEventsScreen2.SetActive(true);

        randomEventsPage2DescriptionText1.text = "";
        randomEventsPage2DescriptionText2.text = "";
        randomEventsPage2DescriptionText3.text = "";

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent33a()
    {
        // ???
        forwardButtonClickAudioSource.Play();

        RandomEvent33Page1Button.SetActive(false);
        randomEventsScreen1.SetActive(false);
        randomEventsScreen2.SetActive(true);

        randomEventsPage2DescriptionText1.text = "";
        randomEventsPage2DescriptionText2.text = "";
        randomEventsPage2DescriptionText3.text = "";

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent34a()
    {
        // ???
        forwardButtonClickAudioSource.Play();

        RandomEvent34Page1Button.SetActive(false);
        randomEventsScreen1.SetActive(false);
        randomEventsScreen2.SetActive(true);

        randomEventsPage2DescriptionText1.text = "";
        randomEventsPage2DescriptionText2.text = "";
        randomEventsPage2DescriptionText3.text = "";

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent35a()
    {
        // ???
        forwardButtonClickAudioSource.Play();

        RandomEvent35Page1Button.SetActive(false);
        randomEventsScreen1.SetActive(false);
        randomEventsScreen2.SetActive(true);

        randomEventsPage2DescriptionText1.text = "";
        randomEventsPage2DescriptionText2.text = "";
        randomEventsPage2DescriptionText3.text = "";

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent36a()
    {
        // ???
        forwardButtonClickAudioSource.Play();

        RandomEvent36Page1Button.SetActive(false);
        randomEventsScreen1.SetActive(false);
        randomEventsScreen2.SetActive(true);

        randomEventsPage2DescriptionText1.text = "";
        randomEventsPage2DescriptionText2.text = "";
        randomEventsPage2DescriptionText3.text = "";

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent37a()
    {
        // ???
        forwardButtonClickAudioSource.Play();

        RandomEvent37Page1Button.SetActive(false);
        randomEventsScreen1.SetActive(false);
        randomEventsScreen2.SetActive(true);

        randomEventsPage2DescriptionText1.text = "";
        randomEventsPage2DescriptionText2.text = "";
        randomEventsPage2DescriptionText3.text = "";

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent38a()
    {
        // ???
        forwardButtonClickAudioSource.Play();

        RandomEvent38Page1Button.SetActive(false);
        randomEventsScreen1.SetActive(false);
        randomEventsScreen2.SetActive(true);

        randomEventsPage2DescriptionText1.text = "";
        randomEventsPage2DescriptionText2.text = "";
        randomEventsPage2DescriptionText3.text = "";

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent39a()
    {
        // ???
        forwardButtonClickAudioSource.Play();

        RandomEvent39Page1Button.SetActive(false);
        randomEventsScreen1.SetActive(false);
        randomEventsScreen2.SetActive(true);

        randomEventsPage2DescriptionText1.text = "";
        randomEventsPage2DescriptionText2.text = "";
        randomEventsPage2DescriptionText3.text = "";

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent40a()
    {
        // ???
        forwardButtonClickAudioSource.Play();

        RandomEvent40Page1Button.SetActive(false);
        randomEventsScreen1.SetActive(false);
        randomEventsScreen2.SetActive(true);

        randomEventsPage2DescriptionText1.text = "";
        randomEventsPage2DescriptionText2.text = "";
        randomEventsPage2DescriptionText3.text = "";

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent41a()
    {
        // ???
        forwardButtonClickAudioSource.Play();

        RandomEvent41Page1Button.SetActive(false);
        randomEventsScreen1.SetActive(false);
        randomEventsScreen2.SetActive(true);

        randomEventsPage2DescriptionText1.text = "";
        randomEventsPage2DescriptionText2.text = "";
        randomEventsPage2DescriptionText3.text = "";

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent42a()
    {
        // ???
        forwardButtonClickAudioSource.Play();

        RandomEvent42Page1Button.SetActive(false);
        randomEventsScreen1.SetActive(false);
        randomEventsScreen2.SetActive(true);

        randomEventsPage2DescriptionText1.text = "";
        randomEventsPage2DescriptionText2.text = "";
        randomEventsPage2DescriptionText3.text = "";

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent43a()
    {
        // ???
        forwardButtonClickAudioSource.Play();

        RandomEvent43Page1Button.SetActive(false);
        randomEventsScreen1.SetActive(false);
        randomEventsScreen2.SetActive(true);

        randomEventsPage2DescriptionText1.text = "";
        randomEventsPage2DescriptionText2.text = "";
        randomEventsPage2DescriptionText3.text = "";

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent44a()
    {
        // ???
        forwardButtonClickAudioSource.Play();

        RandomEvent44Page1Button.SetActive(false);
        randomEventsScreen1.SetActive(false);
        randomEventsScreen2.SetActive(true);

        randomEventsPage2DescriptionText1.text = "";
        randomEventsPage2DescriptionText2.text = "";
        randomEventsPage2DescriptionText3.text = "";

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent45a()
    {
        // ???
        forwardButtonClickAudioSource.Play();

        RandomEvent45Page1Button.SetActive(false);
        randomEventsScreen1.SetActive(false);
        randomEventsScreen2.SetActive(true);

        randomEventsPage2DescriptionText1.text = "";
        randomEventsPage2DescriptionText2.text = "";
        randomEventsPage2DescriptionText3.text = "";

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent46a()
    {
        // ???
        forwardButtonClickAudioSource.Play();

        RandomEvent46Page1Button.SetActive(false);
        randomEventsScreen1.SetActive(false);
        randomEventsScreen2.SetActive(true);

        randomEventsPage2DescriptionText1.text = "";
        randomEventsPage2DescriptionText2.text = "";
        randomEventsPage2DescriptionText3.text = "";

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent47a()
    {
        // ???
        forwardButtonClickAudioSource.Play();

        RandomEvent47Page1Button.SetActive(false);
        randomEventsScreen1.SetActive(false);
        randomEventsScreen2.SetActive(true);

        randomEventsPage2DescriptionText1.text = "";
        randomEventsPage2DescriptionText2.text = "";
        randomEventsPage2DescriptionText3.text = "";

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent48a()
    {
        // ???
        forwardButtonClickAudioSource.Play();

        RandomEvent48Page1Button.SetActive(false);
        randomEventsScreen1.SetActive(false);
        randomEventsScreen2.SetActive(true);

        randomEventsPage2DescriptionText1.text = "";
        randomEventsPage2DescriptionText2.text = "";
        randomEventsPage2DescriptionText3.text = "";

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent49a()
    {
        // ???
        forwardButtonClickAudioSource.Play();

        RandomEvent49Page1Button.SetActive(false);
        randomEventsScreen1.SetActive(false);
        randomEventsScreen2.SetActive(true);

        randomEventsPage2DescriptionText1.text = "";
        randomEventsPage2DescriptionText2.text = "";
        randomEventsPage2DescriptionText3.text = "";

        RandomEventsPage2CloseButton.SetActive(true);
    }
    public void RandomEvent50a()
    {
        // ???
        forwardButtonClickAudioSource.Play();

        RandomEvent50Page1Button.SetActive(false);
        randomEventsScreen1.SetActive(false);
        randomEventsScreen2.SetActive(true);

        randomEventsPage2DescriptionText1.text = "";
        randomEventsPage2DescriptionText2.text = "";
        randomEventsPage2DescriptionText3.text = "";

        RandomEventsPage2CloseButton.SetActive(true);
    }

    
    public void MainSimulationStatus()
    {
        currentMoney1990 = Math.Round(currentMoney1990, 2);
        currentMoney2020 = Math.Round(currentMoney2020, 2);
        housingPaid1990 = Math.Round(housingPaid1990, 2);
        housingPaid2020 = Math.Round(housingPaid2020, 2);
        utilitiesPaid1990 = Math.Round(utilitiesPaid1990, 2);
        utilitiesPaid2020 = Math.Round(utilitiesPaid2020, 2);
        groceryPaid1990 = Math.Round(groceryPaid1990, 2);
        groceryPaid2020 = Math.Round(groceryPaid2020, 2);
        transportationPaid1990 = Math.Round(transportationPaid1990, 2);
        transportationPaid2020 = Math.Round(transportationPaid2020, 2);
        otherPaid1990 = Math.Round(otherPaid1990, 2);
        otherPaid2020 = Math.Round(otherPaid2020, 2);
        
        simCurrentMoney1990Text.text = "Current Money: $" + currentMoney1990;
        simCurrentMoney2020Text.text = "Current Money: $" + currentMoney2020;
        simHousing1990PaidText.text = "Housing Paid: $" + housingPaid1990;
        simHousing2020PaidText.text = "Housing Paid: $" + housingPaid2020;
        simUtilities1990PaidText.text = "Utilities Paid: $" + utilitiesPaid1990;
        simUtilities2020PaidText.text = "Utilities Paid: $" + utilitiesPaid2020;
        simGroceries1990PaidText.text = "Food Paid: $" + groceryPaid1990;
        simGroceries2020PaidText.text = "Food Paid: $" + groceryPaid2020;
        simTransportation1990PaidText.text = "Transportation Paid: $" + transportationPaid1990;
        simTransportation2020PaidText.text = "Transportation Paid: $" + transportationPaid2020;
        simOtherCost1990PaidText.text = "Other Cost Paid: $" + otherPaid1990;
        simOtherCost2020PaidText.text = "Other Cost Paid: $" + otherPaid2020;
    }

    //Simulation Functions - Selection Buttons
    public void ToPayDay()
    {
        forwardButtonClickAudioSource.Play();
        
        payDayScreen1.SetActive(true);
    }
    public void ToPayHousing()
    {
        forwardButtonClickAudioSource.Play();
        
        payRentScreen1.SetActive(true);
    }
    public void ToPayUtilities()
    {
        forwardButtonClickAudioSource.Play();
        
        payUtilitiesScreen.SetActive(true);

        if (electricityPaid ==  true && waterPaid == true && communicationsPaid == true && entertainmentPaid == true && internetPaid == true)
        {
            utilitiesCompleteTextObject.SetActive(true);

            utilitiesCompleteText.text = "You have paid all required Utilities for this month.";
        }
        else if (electricityPaid ==  false || waterPaid == false || communicationsPaid == false || entertainmentPaid == false || internetPaid == false)
        {
            utilitiesCompleteTextObject.SetActive(false);
        }
    }
    public void ToPayUtilitiesElectricity()
    {
        forwardButtonClickAudioSource.Play();
        
        payUtilitiesElectricityScreen.SetActive(true);

        payUtilitiesScreen.SetActive(false);
    }
    public void ToPayUtilitiesWater()
    {
        forwardButtonClickAudioSource.Play();
        
        payUtilitiesWaterScreen.SetActive(true);

        payUtilitiesScreen.SetActive(false);
    }
    public void ToPayUtilitiesCommunications()
    {
        forwardButtonClickAudioSource.Play();
        
        payUtilitiesCommunicationsScreen.SetActive(true);

        payUtilitiesScreen.SetActive(false);
    }
    public void ToPayUtilitiesEntertainment()
    {
        forwardButtonClickAudioSource.Play();
        
        payUtilitiesEntertainmentScreen.SetActive(true);

        payUtilitiesScreen.SetActive(false);
    }
    public void ToPayUtilitiesInternet()
    {
        forwardButtonClickAudioSource.Play();
        
        payUtilitiesInternetScreen.SetActive(true);

        payUtilitiesScreen.SetActive(false);
    }
    public void ToPayFood()
    {
        forwardButtonClickAudioSource.Play();
        
        payFoodScreen.SetActive(true);
    }
    public void ToPayTransportation()
    {
        forwardButtonClickAudioSource.Play();
        
        payTransportationScreen1.SetActive(true);
    }

    //Simulation Functions - Action Buttons
    public void CollectPayCheck()
    {
        moneyGainedAudioSource.Play();
        
        payDayScreen1.SetActive(false);
        payDayScreen2.SetActive(true);
        
        if (waiter == true)
        {
            dailyTips1990 = UnityEngine.Random.Range(0.00F, 100.00F);
            dailyTips2020 = UnityEngine.Random.Range(0.00F, 150.00F);

            tipsMade1990 = (dailyTips1990 * daysWorked);
            tipsMade2020 = (dailyTips2020 * daysWorked);
            
            biweeklySalary1990 = ((hourlyRate1990 * ((hoursWorked * (daysWorked - totalDaysMissed)) - totalHoursMissed)) + tipsMade1990);
            biweeklySalary2020 = ((hourlyRate2020 * ((hoursWorked * (daysWorked - totalDaysMissed)) - totalHoursMissed)) + tipsMade2020);

            biweeklySalary1990 = Math.Round(biweeklySalary1990, 2);
            biweeklySalary2020 = Math.Round(biweeklySalary2020, 2);
        }
        else if (waiter == false)
        {
            biweeklySalary1990 = (hourlyRate1990 * ((hoursWorked * (daysWorked - totalDaysMissed)) - totalHoursMissed));
            biweeklySalary2020 = (hourlyRate2020 * ((hoursWorked * (daysWorked - totalDaysMissed)) - totalHoursMissed));

            biweeklySalary1990 = Math.Round(biweeklySalary1990, 2);
            biweeklySalary2020 = Math.Round(biweeklySalary2020, 2);
        }
        
        incomeTaxPaid1990 += (biweeklySalary1990 * incomeTax1990);
        incomeTaxPaid2020 += (biweeklySalary2020 * incomeTax2020);

        incomeTaxPaid1990 = Math.Round(biweeklySalary1990, 2);
        incomeTaxPaid2020 = Math.Round(biweeklySalary2020, 2);
        
        payRecieved1990 = (biweeklySalary1990 * (1 - incomeTax1990));
        payRecieved2020 = (biweeklySalary2020 * (1 - incomeTax2020));

        payRecieved1990 = Math.Round(payRecieved1990, 2);
        payRecieved2020 = Math.Round(payRecieved2020, 2);

        toPayDayButton.SetActive(false);

        payDay1990Text.text = "You just got paid: $" + payRecieved1990 + "!";
        payDay2020Text.text = "You just got paid: $" + payRecieved2020 + "!";

        currentMoney1990 += payRecieved1990;
        currentMoney2020 += payRecieved2020;

        weekMoneyObtained1990 += payRecieved1990;
        weekMoneyObtained2020 += payRecieved2020;
    }
    public void PayHousing()
    {
        moneyLossAudioSource.Play();
        
        payRentScreen2.SetActive(true);
        
        payRentScreen1.SetActive(false);

        if (livingWithParents == true || livingWithRoommates == true || basicApartment == true || luxuryApartment == true)
        {
            rentPaid1990 = rentCost1990;
            rentPaid2020 = rentCost2020;

            rentPaid1990 = Math.Round(rentPaid1990, 2);
            rentPaid2020 = Math.Round(rentPaid2020, 2);
            
            rentPaid1990Text.text = "Rent Paid: $" + rentPaid1990;
            rentPaid2020Text.text = "Rent Paid: $" + rentPaid2020;

            housingPaid1990 = rentPaid1990;
            housingPaid2020 = rentPaid2020;
            
            currentMoney1990 -= rentPaid1990;
            currentMoney2020 -= rentPaid2020;

            weekMoneyLoss1990 += rentPaid1990;
            weekMoneyLoss2020 += rentPaid2020;
        }
        else if (basicHouse == true || luxuryHouse == true)
        {
            mortgagePaid1990 = mortgageCost1990;
            mortgagePaid2020 = mortgageCost2020;

            mortgagePaid1990 = Math.Round(mortgagePaid1990, 2);
            mortgagePaid2020 = Math.Round(mortgagePaid2020, 2);
            
            rentPaid1990Text.text = "Mortgage Paid: $" + mortgagePaid1990;
            rentPaid2020Text.text = "Mortgage Paid: $" + mortgagePaid2020;

            housingPaid1990 = mortgagePaid1990;
            housingPaid2020 = mortgagePaid2020;
            
            currentMoney1990 -= mortgagePaid1990;
            currentMoney2020 -= mortgagePaid2020;

            weekMoneyLoss1990 += mortgagePaid1990;
            weekMoneyLoss2020 += mortgagePaid2020;
        }

        housingComplete = true;
    }
    public void PayUtilitiesElectricity1990()
    {
        moneyLossAudioSource.Play();
        
        payUtilitiesElectricity1990Button.SetActive(false);
        electricity1990PaidTextObject.SetActive(true);

        utilityElectricCost1990 = UnityEngine.Random.Range(50.00F, 200.00F);
        utilityElectricPaid1990 = utilityElectricCost1990;
        utilityElectricPaid1990 = Math.Round(utilityElectricPaid1990, 2);

        electricity1990PaidText.text = "Electricity Paid: $" + utilityElectricPaid1990;

        currentMoney1990 -= utilityElectricPaid1990;

        utilitiesPaid1990 += utilityElectricPaid1990;
        electricity1990Paid = true;

        PayUtilitiesElectricityCompleted();
    }
    public void PayUtilitiesElectricity2020()
    {
        moneyLossAudioSource.Play();
        
        payUtilitiesElectricity2020Button.SetActive(false);
        electricity2020PaidTextObject.SetActive(true);

        utilityElectricCost2020 = UnityEngine.Random.Range(100.00F, 300.00F);
        utilityElectricPaid2020 = utilityElectricCost2020;
        utilityElectricPaid2020 = Math.Round(utilityElectricPaid2020, 2);

        electricity2020PaidText.text = "Electricity Paid: $" + utilityElectricPaid2020;

        currentMoney2020 -= utilityElectricPaid2020;

        utilitiesPaid2020 += utilityElectricPaid2020;
        electricity2020Paid = true;

        PayUtilitiesElectricityCompleted();
    }
    public void PayUtilitiesElectricityCompleted()
    {
        if (electricity1990Paid == true && electricity2020Paid == true)
        {
            electricityPaid = true;
            electricityCloseButton.SetActive(true);
        }
        else
        {
            electricityPaid = false;
        }
    }
    public void PayUtilitiesWater1990()
    {
        moneyLossAudioSource.Play();
        
        payUtilitiesWater1990Button.SetActive(false);
        water1990PaidTextObject.SetActive(true);

        utilityWaterCost1990 = UnityEngine.Random.Range(10.00F, 35.00F);
        utilityWaterPaid1990 = utilityWaterCost1990;
        utilityWaterPaid1990 = Math.Round(utilityWaterPaid1990, 2);

        water1990PaidText.text = "Water Paid: $" + utilityWaterPaid1990;

        currentMoney1990 -= utilityWaterPaid1990;

        utilitiesPaid1990 += utilityWaterPaid1990;
        water1990Paid = true;

        PayUtilitiesWaterCompleted();
    }
    public void PayUtilitiesWater2020()
    {
        moneyLossAudioSource.Play(); 
        
        payUtilitiesWater2020Button.SetActive(false);
        water2020PaidTextObject.SetActive(true);

        utilityWaterCost2020 = UnityEngine.Random.Range(15.00F, 50.00F);
        utilityWaterPaid2020 = utilityWaterCost2020;
        utilityWaterPaid2020 = Math.Round(utilityWaterPaid2020, 2);

        water2020PaidText.text = "Water Paid: $" + utilityWaterPaid2020;

        currentMoney2020 -= utilityWaterPaid2020;

        utilitiesPaid2020 += utilityWaterPaid2020;
        water2020Paid = true;

        PayUtilitiesWaterCompleted();
    }
    public void PayUtilitiesWaterCompleted()
    {
        if (water1990Paid == true && water2020Paid == true)
        {
            waterPaid = true;
            waterCloseButton.SetActive(true);
        }
        else
        {
            waterPaid = false;
        }
    }
    public void PayUtilitiesCommunications1990()
    {
        moneyLossAudioSource.Play();
        
        payUtilitiesCommunications1990Button.SetActive(false);
        communications1990PaidTextObject.SetActive(true);

        utilityCommunicationsPaid1990 = utilityCommunicationsCost1990;

        communications1990PaidText.text = "Communication Paid: $" + utilityCommunicationsPaid1990;

        currentMoney1990 -= utilityCommunicationsPaid1990;

        utilitiesPaid1990 += utilityCommunicationsPaid1990;
        communications1990Paid = true;

        PayUtilitiesCommunicationsCompleted();
    }
    public void PayUtilitiesCommunications2020()
    {
        moneyLossAudioSource.Play();
        
        payUtilitiesCommunications2020Button.SetActive(false);
        communications2020PaidTextObject.SetActive(true);

        utilityCommunicationsPaid2020 = utilityCommunicationsCost2020;

        communications2020PaidText.text = "Communication Paid: $" + utilityCommunicationsPaid2020;

        currentMoney2020 -= utilityCommunicationsPaid2020;

        utilitiesPaid2020 += utilityCommunicationsPaid2020;
        communications2020Paid = true;

        PayUtilitiesCommunicationsCompleted();
    }
    public void PayUtilitiesCommunicationsCompleted()
    {
        if (communications1990Paid == true && communications2020Paid == true)
        {
            communicationsPaid = true;
            communicationsCloseButton.SetActive(true);
        }
        else
        {
            communicationsPaid = false;
        }
    }
    public void PayUtilitiesEntertainment1990()
    {
        moneyLossAudioSource.Play();
        
        payUtilitiesEntertainment1990Button.SetActive(false);
        entertainment1990PaidTextObject.SetActive(true);

        utilityEntertainmentPaid1990 = utilityEntertainmentCost1990;

        entertainment1990PaidText.text = "Entertainment Paid: $" + utilityEntertainmentPaid1990;

        currentMoney1990 -= utilityEntertainmentPaid1990;

        utilitiesPaid1990 += utilityEntertainmentPaid1990;
        entertainment1990Paid = true;

        PayUtilitiesEntertainmentCompleted();
    }
    public void PayUtilitiesEntertainment2020()
    {
        moneyLossAudioSource.Play();
        
        payUtilitiesEntertainment2020Button.SetActive(false);
        entertainment2020PaidTextObject.SetActive(true);

        utilityEntertainmentPaid2020 = utilityEntertainmentCost2020;

        entertainment2020PaidText.text = "Entertainment Paid: $" + utilityEntertainmentPaid2020;

        currentMoney2020 -= utilityEntertainmentPaid2020;

        utilitiesPaid2020 += utilityEntertainmentPaid2020;
        entertainment2020Paid = true;

        PayUtilitiesEntertainmentCompleted();
    }
    public void PayUtilitiesEntertainmentCompleted()
    {
        if (entertainment1990Paid == true && entertainment2020Paid == true)
        {
            entertainmentPaid = true;
            entertainmentCloseButton.SetActive(true);
        }
        else
        {
            entertainmentPaid = false;
        }
    }
    public void PayUtilitiesInternet1990()
    {
        moneyLossAudioSource.Play();
        
        payUtilitiesInternet1990Button.SetActive(false);
        internet1990PaidTextObject.SetActive(true);

        if (basicDialUpInternet1990 == true)
        {
            utilityInternetCost1990 = UnityEngine.Random.Range(10.00F, 15.00F);
        }
        else if (premiumDialUpInternet1990 == true)
        {
            utilityInternetCost1990 = UnityEngine.Random.Range(25.00F, 50.00F);
        }
        
        utilityInternetCost1990 = Math.Round(utilityInternetCost1990, 2);

        utilityInternetPaid1990 = utilityInternetCost1990;

        internet1990PaidText.text = "Internet Paid: $" + utilityInternetPaid1990;

        currentMoney2020 -= utilityInternetPaid1990;

        utilitiesPaid1990 += utilityInternetPaid1990;
        internet1990Paid = true;

        PayUtilitiesInternetCompleted();
    }
    public void PayUtilitiesInternet2020()
    {
        moneyLossAudioSource.Play();
        
        payUtilitiesInternet2020Button.SetActive(false);
        internet2020PaidTextObject.SetActive(true);

        utilityInternetPaid2020 = utilityInternetCost2020;

        internet2020PaidText.text = "Internet Paid: $" + utilityInternetPaid2020;

        currentMoney2020 -= utilityInternetPaid2020;
        
        utilitiesPaid2020 += utilityInternetPaid2020;

        internet2020Paid = true;

        PayUtilitiesInternetCompleted();
    }
    public void PayUtilitiesInternetCompleted()
    {
        if (internet1990Paid == true && internet2020Paid == true)
        {
            internetPaid = true;
            internetCloseButton.SetActive(true);
        }
        else
        {
            internetPaid = false;
        }
    }
    public void PayFoodGroceries()
    {
        moneyLossAudioSource.Play();
        
        payFoodGroceriesScreen.SetActive(true);

        foodCost1990 = foodGroceryCost1990;
        foodCost2020 = foodGroceryCost2020;

        groceryPaid1990 = foodCost1990;
        groceryPaid2020 = foodCost2020;

        groceries1990PaidText.text = "You paid $" + groceryPaid1990 + " for Buying Groceries this week!";
        groceries2020PaidText.text = "You paid $" + groceryPaid2020 + " for Buying Groceries this week!";

        currentMoney1990 -= groceryPaid1990;
        currentMoney2020 -= groceryPaid1990;

        weekMoneyLoss1990 += groceryPaid1990;
        weekMoneyLoss2020 += groceryPaid2020;

        groceryComplete = true;
        
        payFoodScreen.SetActive(false);
    }
    public void PayFoodFastFood()
    {
        moneyLossAudioSource.Play();
        
        payFoodFastFoodScreen.SetActive(true);

        foodCost1990 = foodFastFoodCost1990;
        foodCost2020 = foodFastFoodCost2020;

        groceryPaid1990 = foodCost1990;
        groceryPaid2020 = foodCost2020;

        fastFood1990PaidText.text = "You paid $" + groceryPaid1990 + " for Fast Food this week!";
        fastFood2020PaidText.text = "You paid $" + groceryPaid2020 + " for Fast Food this week!";

        currentMoney1990 -= groceryPaid1990;
        currentMoney2020 -= groceryPaid2020;

        weekMoneyLoss1990 += groceryPaid1990;
        weekMoneyLoss2020 += groceryPaid2020;

        groceryComplete = true;
        
        payFoodScreen.SetActive(false);
    }
    public void PayFoodEatingOut()
    {
        moneyLossAudioSource.Play();
        
        payFoodEatingOutScreen.SetActive(true);

        foodCost1990 = foodEatingOutCost1990;
        foodCost2020 = foodEatingOutCost2020;

        groceryPaid1990 = foodCost1990;
        groceryPaid2020 = foodCost2020;

        eatingOut1990PaidText.text = "You paid $" + groceryPaid1990 + " for Eating Out this week!";
        eatingOut2020PaidText.text = "You paid $" + groceryPaid2020 + " for Eating Out this week!";

        currentMoney1990 -= groceryPaid1990;
        currentMoney2020 -= groceryPaid2020;

        weekMoneyLoss1990 += groceryPaid1990;
        weekMoneyLoss2020 += groceryPaid2020;

        groceryComplete = true;
        
        payFoodScreen.SetActive(false);
    }
    public void PayTransportation()
    {
        moneyLossAudioSource.Play();
        
        payTransportationScreen2.SetActive(true);

        transportationPaid1990 = transportationCost1990;
        transportationPaid2020 = transportationCost2020;

        transportation1990PaidText.text = "You paid $" + transportationPaid1990 + " for Transportation this week!";
        transportation2020PaidText.text = "You paid $" + transportationPaid2020 + " for Transportation this week!";

        currentMoney1990 -= transportationPaid1990;
        currentMoney2020 -= transportationPaid2020;

        weekMoneyLoss1990 += transportationPaid1990;
        weekMoneyLoss2020 += transportationPaid2020;

        transportationComplete = true;
        
        payTransportationScreen1.SetActive(false);
        //payTransportationButton.SetActive(false);
    }

    //Simulation Functions - Random Events Buttons
    public void BackFromRandomEvents()
    {
        backwardsButtonClickAudioSource.Play();
        
        randomEventsScreen1.SetActive(false);
        randomEventsScreen2.SetActive(false);
        randomEventsScreenJob.SetActive(false);
        RandomEvent = false;

        // Resets
        // Resets Event Buttons
        RandomEvent01Page1Button.SetActive(false);
        RandomEvent02Page1Button.SetActive(false);
        RandomEvent03Page1Button.SetActive(false);
        RandomEvent04Page1Button.SetActive(false);
        RandomEvent05Page1Button.SetActive(false);
        RandomEvent06Page1Button.SetActive(false);
        RandomEvent07Page1Button.SetActive(false);
        RandomEvent08Page1Button.SetActive(false);
        RandomEvent09Page1Button.SetActive(false);
        RandomEvent10Page1Button.SetActive(false);
        RandomEvent11Page1Button.SetActive(false);
        RandomEvent12Page1Button.SetActive(false);
        RandomEvent13Page1Button.SetActive(false);
        RandomEvent14Page1Button.SetActive(false);
        RandomEvent15Page1Button.SetActive(false);
        RandomEvent16Page1Button.SetActive(false);
        RandomEvent17Page1Button.SetActive(false);
        RandomEvent18Page1Button.SetActive(false);
        RandomEvent19Page1Button.SetActive(false);
        RandomEvent20Page1Button.SetActive(false);
        RandomEvent21Page1Button.SetActive(false);
        RandomEvent22Page1Button.SetActive(false);
        RandomEvent23Page1Button.SetActive(false);
        RandomEvent24Page1Button.SetActive(false);
        RandomEvent25Page1Button.SetActive(false);
        RandomEvent26Page1Button.SetActive(false);
        RandomEvent27Page1Button.SetActive(false);
        RandomEvent28Page1Button.SetActive(false);
        RandomEvent29Page1Button.SetActive(false);
        RandomEvent30Page1Button.SetActive(false);
        RandomEvent31Page1Button.SetActive(false);
        RandomEvent32Page1Button.SetActive(false);
        RandomEvent33Page1Button.SetActive(false);
        RandomEvent34Page1Button.SetActive(false);
        RandomEvent35Page1Button.SetActive(false);
        RandomEvent36Page1Button.SetActive(false);
        RandomEvent37Page1Button.SetActive(false);
        RandomEvent38Page1Button.SetActive(false);
        RandomEvent39Page1Button.SetActive(false);
        RandomEvent40Page1Button.SetActive(false);
        RandomEvent41Page1Button.SetActive(false);
        RandomEvent42Page1Button.SetActive(false);
        RandomEvent43Page1Button.SetActive(false);
        RandomEvent44Page1Button.SetActive(false);
        RandomEvent45Page1Button.SetActive(false);
        RandomEvent46Page1Button.SetActive(false);
        RandomEvent47Page1Button.SetActive(false);
        RandomEvent48Page1Button.SetActive(false);
        RandomEvent49Page1Button.SetActive(false);
        RandomEvent50Page1Button.SetActive(false);

        // Resets Close Button
        RandomEventsPage1CloseButton.SetActive(true);
        RandomEventsPage2CloseButton.SetActive(true);

        // Reset Job Buttons
        newWaiterButton.SetActive(true);
        newCashierButton.SetActive(true);
        newFryCookButton.SetActive(true);
        newCSAButton.SetActive(true);
        newTeacherButton.SetActive(true);
        newLSAButton.SetActive(true);
        newProgrammerButton.SetActive(true);
        newEngineerButton.SetActive(true);
        newLawyerButton.SetActive(true);
        newDoctorButton.SetActive(true);

        // Reset Transportation Buttons
        newBicycleButton.SetActive(true);
        newUsedCarButton.SetActive(true);
        newNewCarButton.SetActive(true);
        newMotorcycleButton.SetActive(true);
        newBusButton.SetActive(true);
        newTrainButton.SetActive(true);

        // Reset Random Events Text
        randomEventsPage1TitleText.text = "";
        randomEventsPage2TitleText.text = "";
        randomEventsPageJobTitleText.text = "";
        randomEventsPage1DescriptionText.text = "";
        randomEventsPage2DescriptionText1.text = "";
        randomEventsPage2DescriptionText2.text = "";
        randomEventsPage2DescriptionText3.text = "";

        mainSimulationScreen.SetActive(true);

        otherCost1990 = 0.00;
        otherCost2020 = 0.00;

        MainSimulationStatus();
    }

    //Simulation Functions - Back Buttons
    public void BackFromPlayerStats()
    {
        backwardsButtonClickAudioSource.Play();
        
        playerStats1990Screen.SetActive(false);
        playerStats2020Screen.SetActive(false);

        MainSimulationStatus();
    }
    public void BackFromPayDay()
    {
        backwardsButtonClickAudioSource.Play();
        
        payDayScreen2.SetActive(false);

        // Reset Money Variables
        daysWorked = 14;
        daysMissed = 0;
        dailyTips1990 = 0;
        dailyTips2020 = 0;
        tipsMade1990 = 0;
        tipsMade2020 = 0;
        biweeklySalary1990 = 0;
        biweeklySalary2020 = 0;
        
        MainSimulationStatus();
    }
    public void BackFromPayRent()
    {
        backwardsButtonClickAudioSource.Play();
        
        payRentScreen2.SetActive(false);

        rentDue = false;

        toPayHousingButton.SetActive(false);

        if (housingComplete == true && utilitiesComplete == true && groceryComplete == true && transportationComplete == true)
        {
            toWeekSummaryButton.SetActive(true);
        }

        MainSimulationStatus();
    }
    public void BackFromPayUtilities()
    {
        backwardsButtonClickAudioSource.Play();
        
        payUtilitiesScreen.SetActive(false);

        if (m1w == 4 || m2w == 4 || m3w == 4)
        {
            if (electricityComplete == true && waterComplete == true && communicationsComplete == true && entertainmentComplete == true && internetComplete == true)
            {
                utilitiesComplete = true;
                utilitiesDue = false;
            }
            else
            {
                utilitiesComplete = false;
                utilitiesDue = true;
            }
        }
        else if (m1w != 4 || m2w != 4 || m3w != 4)
        {
            if (electricityComplete == true || waterComplete == true || communicationsComplete == true || entertainmentComplete == true || internetComplete == true)
            {
                utilitiesComplete = true;
                utilitiesDue = false;
            }
            else
            {
                utilitiesComplete = false;
                utilitiesDue = true;
            }
        }

        toPayUtilitiesButton.SetActive(false);

        if (housingComplete == true && utilitiesComplete == true && groceryComplete == true && transportationComplete == true)
        {
            toWeekSummaryButton.SetActive(true);
        }

        //currentMoney1990 -= utilitiesPaid1990;
        //currentMoney2020 -= utilitiesPaid2020;

        weekMoneyLoss1990 += utilitiesPaid1990;
        weekMoneyLoss2020 += utilitiesPaid2020;

        // Random Event Trigger
        RandomEvent = true;
        RandomEventCounter++;
        RandomEvents1();

        MainSimulationStatus();
    }
    public void BackFromPayUtilitiesElectricity()
    {
        backwardsButtonClickAudioSource.Play();
        
        payUtilitiesElectricityScreen.SetActive(false);

        electricityComplete = true;

        payUtilitiesScreen.SetActive(true);
        toPayUtilitiesElectricityButton.SetActive(false);
    }
    public void BackFromPayUtilitiesWater()
    {
        backwardsButtonClickAudioSource.Play();
        
        payUtilitiesWaterScreen.SetActive(false);

        waterComplete = true;

        payUtilitiesScreen.SetActive(true);
        toPayUtilitiesWaterButton.SetActive(false);
    }
    public void BackFromPayUtilitiesCommunications()
    {
        backwardsButtonClickAudioSource.Play();
        
        payUtilitiesCommunicationsScreen.SetActive(false);

        communicationsComplete = true;

        payUtilitiesScreen.SetActive(true);
        toPayUtilitiesCommunicationsButton.SetActive(false);
    }
    public void BackFromPayUtilitiesEntertainment()
    {
        backwardsButtonClickAudioSource.Play();
        
        payUtilitiesEntertainmentScreen.SetActive(false);

        entertainmentComplete = true;

        payUtilitiesScreen.SetActive(true);
        toPayUtilitiesEntertainmentButton.SetActive(false);
    }
    public void BackFromPayUtilitiesInternet()
    {
        backwardsButtonClickAudioSource.Play();
        
        payUtilitiesInternetScreen.SetActive(false);

        internetComplete = true;

        payUtilitiesScreen.SetActive(true);
        toPayUtilitiesInternetButton.SetActive(false);
    }
    public void BackFromPayFood()
    {
        backwardsButtonClickAudioSource.Play();
        
        payFoodScreen.SetActive(false);
        payFoodFastFoodScreen.SetActive(false);
        payFoodGroceriesScreen.SetActive(false);
        payFoodEatingOutScreen.SetActive(false);

        //MainSimulationStatus();

        toPayGroceriesButton.SetActive(false);

        if (housingComplete == true && utilitiesComplete == true && groceryComplete == true && transportationComplete == true)
        {
            toWeekSummaryButton.SetActive(true);
        }

        // Random Event Trigger
        RandomEvent = true;
        RandomEventCounter++;
        RandomEvents1();

        MainSimulationStatus();
    }
    public void BackFromPayTransportation()
    {
        backwardsButtonClickAudioSource.Play();
        
        payTransportationScreen2.SetActive(false);

        // MainSimulationStatus();

        toPayTransportationButton.SetActive(false);

        if (housingComplete == true && utilitiesComplete == true && groceryComplete == true && transportationComplete == true)
        {
            toWeekSummaryButton.SetActive(true);
        }

        // Random Event Trigger
        RandomEvent = true;
        RandomEventCounter++;
        RandomEvents1();

        MainSimulationStatus();
    }
    
    // The Final Summary
    // The Final Summary - Week Summary
    public void ToWeekSummary()
    {
        forwardButtonClickAudioSource.Play();
        week01BackgroundAudioSource.Stop();
        week02BackgroundAudioSource.Stop();
        week03BackgroundAudioSource.Stop();
        week04BackgroundAudioSource.Stop();
        summaryBackgroundAudioSource.Play();
        
        summarySection.SetActive(true);
        weekSummaryScreen.SetActive(true);

        mainSimulationScreen.SetActive(false);
        simulationSection.SetActive(false);

        WeekSummary();
    }
    public void WeekSummary()
    {
        // Shows Weekly Money Gained and Loss
        weekSummaryMoneyObtained1990Text.text = "Money Obtained: $" + weekMoneyObtained1990;
        weekSummaryMoneyObtained2020Text.text = "Money Obtained: $" + weekMoneyObtained2020;
        weekSummaryMoneyLoss1990Text.text = "Money Loss: $" + weekMoneyLoss1990;
        weekSummaryMoneyLoss2020Text.text = "Money Loss: $" + weekMoneyLoss2020;

        // Calculates Weekly Money Remaining
        weekMoneyRemaining1990 = weekMoneyObtained1990 - weekMoneyLoss1990;
        weekMoneyRemaining2020 = weekMoneyObtained2020 - weekMoneyLoss2020;

        weekMoneyRemaining1990 = Math.Round(weekMoneyRemaining1990, 2);
        weekMoneyRemaining2020 = Math.Round(weekMoneyRemaining2020, 2);

        // Shows Weekly Money Recieved
        weekSummaryMoneyRemaining1990Text.text = "Money Remaining: $" + weekMoneyRemaining1990;
        weekSummaryMoneyRemaining2020Text.text = "Money Remaining: $" + weekMoneyRemaining2020;

        // Adds Week Monetary Values to Month Monetary Values
        monthMoneyObtained1990 += weekMoneyObtained1990;
        monthMoneyObtained2020 += weekMoneyObtained2020;
        monthMoneyLoss1990 += weekMoneyLoss1990;
        monthMoneyLoss2020 += weekMoneyLoss2020;

        //Makes the Month Summary Section Available every 4 Weeks
        if (m1w == 4 || m2w == 4 || m3w == 4)
        {
            continueSimulationFromWeekButton.SetActive(false);
            toMonthSummaryButton.SetActive(true);
        }
    }
    public void ToWeekSummary1990()
    {
        forwardButtonClickAudioSource.Play();
        
        weekSummary1990Screen.SetActive(true);
        weekSummaryScreen.SetActive(false);

        WeekSummary1990();
    }
    public void WeekSummary1990()
    {

    }
    public void ToWeekSummary2020()
    {
        forwardButtonClickAudioSource.Play();
        
        weekSummary2020Screen.SetActive(true);
        weekSummaryScreen.SetActive(false);

        WeekSummary2020();
    }
    public void WeekSummary2020()
    {

    }
    public void BackToWeekSummary()
    {
        backwardsButtonClickAudioSource.Play();

        weekSummaryScreen.SetActive(true);
        weekSummary1990Screen.SetActive(false);
        weekSummary2020Screen.SetActive(false);
    }
    public void ToNextWeek()
    {
        // //Resets Week Monetary Collection Values
        // weekMoneyObtained1990 = 0;
        // weekMoneyObtained2020 = 0;
        // weekMoneyLoss1990 = 0;
        // weekMoneyLoss2020 = 0;
        // weekMoneyRemaining1990 = 0;
        // weekMoneyRemaining2020 = 0;
        forwardButtonClickAudioSource.Play();
        
        simulationSection.SetActive(true);
        simulationStartScreen.SetActive(true);

        // continueSimulationFromWeekButton.SetActive(true);
        summaryBackgroundAudioSource.Stop();

        weekSummaryScreen.SetActive(false);
        summarySection.SetActive(false);

        WeekReset();
    }
    public void WeekReset()
    {
        //Increases the Week Counter by 1
        //m1w++;
        //m2w++;
        //m3w++;

        // Resets Week Monetary Collection Values
        weekMoneyObtained1990 = 0.00;
        weekMoneyObtained2020 = 0.00;
        weekMoneyLoss1990 = 0.00;
        weekMoneyLoss2020 = 0.00;
        weekMoneyRemaining1990 = 0.00;
        weekMoneyRemaining2020 = 0.00;

        // Resets Paid Monetary Values
        housingPaid1990 = 0.00;
        housingPaid2020 = 0.00;
        utilitiesPaid1990 = 0.00;
        utilitiesPaid2020 = 0.00;


        //utilityElectricPaid1990 = 0;
        //utilityElectricPaid2020 = 0;
        //utilityWaterPaid1990 = 0;
        //utilityWaterPaid2020 = 0;
        //utilityCommunicationsPaid1990 = 0;
        //utilityCommunicationsPaid2020 = 0;
        //utilityEntertainmentPaid1990 = 0;
        //utilityEntertainmentPaid2020 = 0;
        //utilityInternetPaid1990 = 0;
        //utilityInternetPaid2020 = 0;

        groceryPaid1990 = 0.00;
        groceryPaid2020 = 0.00;
        transportationPaid1990 = 0.00;
        transportationPaid2020 = 0.00;
        otherPaid1990 = 0.00;
        otherPaid2020 = 0.00;

        continueSimulationFromWeekButton.SetActive(true);
    }



    //The Final Summary - Month Summary
    public void ToMonthSummary()
    {
        forwardButtonClickAudioSource.Play();
        //mainSimulationScreen.SetActive(false);
        //simulationSection.SetActive(false);
        weekSummaryScreen.SetActive(false);
        monthSummaryScreen.SetActive(true);

        MonthSummary();

    }
    public void MonthSummary()
    {
        //Shows Monthly Money Gained and Loss
        monthSummaryMoneyObtained1990Text.text = "Money Obtained: $" + monthMoneyObtained1990;
        monthSummaryMoneyObtained2020Text.text = "Money Obtained: $" + monthMoneyObtained2020;
        monthSummaryMoneyLoss1990Text.text = "Money Loss: $" + monthMoneyLoss1990;
        monthSummaryMoneyLoss2020Text.text = "Money Loss: $" + monthMoneyLoss2020;

        //Calculates Monthly Money Remaining
        monthMoneyRemaining1990 = monthMoneyObtained1990 - monthMoneyLoss1990;
        monthMoneyRemaining2020 = monthMoneyObtained2020 - monthMoneyLoss2020;

        monthMoneyRemaining1990 = Math.Round(weekMoneyRemaining1990, 2);
        monthMoneyRemaining2020 = Math.Round(weekMoneyRemaining2020, 2);

        //Shows Monthly Money Remaining
        monthSummaryMoneyRemaining1990Text.text = "Money Remaining: $" + monthMoneyRemaining1990;
        monthSummaryMoneyRemaining2020Text.text = "Money Remaining: $" + monthMoneyRemaining2020;

        //Status Text based on 1990 Value
        if (monthMoneyRemaining1990 >= 0)
        {
            monthSummaryStatus1990Text.text = "You have done very well this Month!";
        }
        else if (monthMoneyRemaining1990 < 0)
        {
            monthSummaryStatus1990Text.text = "You seemed to have struggled a bit this past Month. Maybe next Month will be better!";
        }

        //Status Text based on 2020 Value
        if (monthMoneyRemaining2020 >= 0)
        {
            monthSummaryStatus2020Text.text = "You have done very well this Month!";
        }
        else if (monthMoneyRemaining2020 < 0)
        {
            monthSummaryStatus2020Text.text = "You seemed to have struggled a bit this past Month. Maybe next Month will be better!";
        }

        //Sets Monetary Values to each Month
        switch (m)
        {
            case 1:
                month01MoneyObtained1990 = monthMoneyObtained1990;
                month01MoneyObtained2020 = monthMoneyObtained2020;
                month01MoneyLoss1990 = monthMoneyLoss1990;
                month01MoneyLoss2020 = monthMoneyLoss2020;
                break;
            case 2: 
                month02MoneyObtained1990 = monthMoneyObtained1990;
                month02MoneyObtained2020 = monthMoneyObtained2020;
                month02MoneyLoss1990 = monthMoneyLoss1990;
                month02MoneyLoss2020 = monthMoneyLoss2020;
                break;
            case 3:
                month03MoneyObtained1990 = monthMoneyObtained1990;
                month03MoneyObtained2020 = monthMoneyObtained2020;
                month03MoneyLoss1990 = monthMoneyLoss1990;
                month03MoneyLoss2020 = monthMoneyLoss2020;

                //Makes the Quarter Summary Section Available
                continueSimulationFromMonthButton.SetActive(false);
                toQuarterSummaryButton.SetActive(true);
                break;
        }
    }
    public void ToMonthSummary1990()
    {
        forwardButtonClickAudioSource.Play();
        
        monthSummary1990Screen.SetActive(true);
        monthSummaryScreen.SetActive(false);

        MonthSummary1990();
    }
    public void MonthSummary1990()
    {

    }
    public void ToMonthSummary2020()
    {
        forwardButtonClickAudioSource.Play();
        
        monthSummary2020Screen.SetActive(true);
        monthSummaryScreen.SetActive(false);

        MonthSummary2020();
    }
    public void MonthSummary2020()
    {

    }
    public void BackToMonthSummary()
    {
        backwardsButtonClickAudioSource.Play();
        
        monthSummaryScreen.SetActive(true);

        monthSummary1990Screen.SetActive(false);
        monthSummary2020Screen.SetActive(false);
    }
    public void ToNextMonth()
    {
        forwardButtonClickAudioSource.Play();
        summaryBackgroundAudioSource.Stop();
        
        toMonthSummaryButton.SetActive(false);
        monthSummaryScreen.SetActive(false);
        //monthSummary1990Screen.SetActive(false);
        //monthSummary2020Screen.SetActive(false);
        summarySection.SetActive(false);

        // //Increases Month Counter By 1 and Resets Week Counter to 1
        // m++;
        // m1w = 1;
        // m2w = 1;
        // m3w = 1;

        // //Resets Month Monetary Collection Values
        // monthMoneyObtained1990 = 0;
        // monthMoneyObtained2020 = 0;
        // monthMoneyLoss1990 = 0;
        // monthMoneyLoss2020 = 0;
        // monthMoneyRemaining1990 = 0;
        // monthMoneyRemaining2020 = 0;

        // //Resets Week Monetary Collection Values
        // weekMoneyObtained1990 = 0;
        // weekMoneyObtained2020 = 0;
        // weekMoneyLoss1990 = 0;
        // weekMoneyLoss2020 = 0;
        // weekMoneyRemaining1990 = 0;
        // weekMoneyRemaining2020 = 0;

        // //Resets Paid Monetary Values
        // rentPaid1990 = 0;
        // rentPaid2020 = 0;
        // utilitiesPaid1990 = 0;
        // utilitiesPaid2020 = 0;
        // utilityElectricPaid1990 = 0;
        // utilityElectricPaid2020 = 0;
        // utilityWaterPaid1990 = 0;
        // utilityWaterPaid2020 = 0;
        // utilityCommunicationsPaid1990 = 0;
        // utilityCommunicationsPaid2020 = 0;
        // utilityEntertainmentPaid1990 = 0;
        // utilityEntertainmentPaid2020 = 0;
        // utilityInternetPaid1990 = 0;
        // utilityInternetPaid2020 = 0;
        // groceryPaid1990 = 0;
        // groceryPaid2020 = 0;
        // transportationPaid1990 = 0;
        // transportationPaid2020 = 0;
        
        // //Reset Completition Status
        // electricityComplete = false;
        // waterComplete = false;
        // communicationsComplete = false;
        // entertainmentComplete = false;
        // internetComplete = false;
        // housingComplete = false;
        // utilitiesComplete = false;
        // groceryComplete = false;
        // transportationComplete = false;
        summaryBackgroundAudioSource.Stop();

        simulationSection.SetActive(true);
        simulationStartScreen.SetActive(true);

        MonthReset();
    }
    public void MonthReset()
    {
        // Increases Month Counter by 1
        m++;

        // Resets Week Counter to 0 (then 1)
        m1w = 0;
        m2w = 0;
        m3w = 0;

        // Resets Month Monetary Collection Values
        monthMoneyObtained1990 = 0.00;
        monthMoneyObtained2020 = 0.00;
        monthMoneyLoss1990 = 0.00;
        monthMoneyLoss2020 = 0.00;
        monthMoneyRemaining1990 = 0.00;
        monthMoneyRemaining2020 = 0.00;

        // Resets Week Monetary Collection Values
        weekMoneyObtained1990 = 0.00;
        weekMoneyObtained2020 = 0.00;
        weekMoneyLoss1990 = 0.00;
        weekMoneyLoss2020 = 0.00;
        weekMoneyRemaining1990 = 0.00;
        weekMoneyRemaining2020 = 0.00;

        // Resets Paid Monetary Values
        housingPaid1990 = 0.00;
        housingPaid2020 = 0.00;
        utilitiesPaid1990 = 0.00;
        utilitiesPaid2020 = 0.00;
        utilityElectricPaid1990 = 0.00;
        utilityElectricPaid2020 = 0.00;
        utilityWaterPaid1990 = 0.00;
        utilityWaterPaid2020 = 0.00;
        utilityCommunicationsPaid1990 = 0.00;
        utilityCommunicationsPaid2020 = 0.00;
        utilityEntertainmentPaid1990 = 0.00;
        utilityEntertainmentPaid2020 = 0.00;
        utilityInternetPaid1990 = 0.00;
        utilityInternetPaid2020 = 0.00;
        groceryPaid1990 = 0.00;
        groceryPaid2020 = 0.00;
        transportationPaid1990 = 0.00;
        transportationPaid2020 = 0.00;
        otherPaid1990 = 0.00;
        otherPaid2020 = 0.00;
        
        // Reset Completition Status
        electricityComplete = false;
        waterComplete = false;
        communicationsComplete = false;
        entertainmentComplete = false;
        internetComplete = false;
        housingComplete = false;
        utilitiesComplete = false;
        groceryComplete = false;
        transportationComplete = false;

        electricityPaid = false;
        electricity1990Paid = false;
        electricity2020Paid = false;
        waterPaid = false;
        water1990Paid = false;
        water2020Paid = false;
        communicationsPaid = false;
        communications1990Paid = false;
        communications2020Paid = false;
        entertainmentPaid = false;
        entertainment1990Paid = false;
        entertainment2020Paid = false;
        internetPaid = false;
        internet1990Paid = false;
        internet2020Paid = false;

        // Reset Utility Options
        payUtilitiesElectricity1990Button.SetActive(true);
        payUtilitiesElectricity2020Button.SetActive(true);
        payUtilitiesWater1990Button.SetActive(true);
        payUtilitiesWater2020Button.SetActive(true);
        payUtilitiesCommunications1990Button.SetActive(true);
        payUtilitiesCommunications2020Button.SetActive(true);
        payUtilitiesEntertainment1990Button.SetActive(true);
        payUtilitiesEntertainment2020Button.SetActive(true);
        payUtilitiesInternet1990Button.SetActive(true);
        payUtilitiesInternet2020Button.SetActive(true);

        electricity1990PaidTextObject.SetActive(false);
        electricity2020PaidTextObject.SetActive(false);
        water1990PaidTextObject.SetActive(false);
        water2020PaidTextObject.SetActive(false);
        communications1990PaidTextObject.SetActive(false);
        communications2020PaidTextObject.SetActive(false);
        entertainment1990PaidTextObject.SetActive(false);
        entertainment2020PaidTextObject.SetActive(false);
        internet1990PaidTextObject.SetActive(false);
        internet2020PaidTextObject.SetActive(false);

        electricityCloseButton.SetActive(false);
        waterCloseButton.SetActive(false);
        communicationsCloseButton.SetActive(false);
        entertainmentCloseButton.SetActive(false);
        internetCloseButton.SetActive(false);
        utilitiesCompleteTextObject.SetActive(false);

        // Reset Random Event Selections
        randomEvent01Selected = false;
        randomEvent02Selected = false;
        randomEvent03Selected = false;
        randomEvent04Selected = false;
        randomEvent05Selected = false;
        randomEvent06Selected = false;
        randomEvent07Selected = false;
        randomEvent08Selected = false;
        randomEvent09Selected = false;
        randomEvent10Selected = false;
        randomEvent11Selected = false;
        randomEvent12Selected = false;
        randomEvent13Selected = false;
        randomEvent14Selected = false;
        randomEvent15Selected = false;
        randomEvent16Selected = false;
        randomEvent17Selected = false;
        randomEvent18Selected = false;
        randomEvent19Selected = false;
        randomEvent20Selected = false;
        randomEvent21Selected = false;
        randomEvent22Selected = false;
        randomEvent23Selected = false;
        randomEvent24Selected = false;
        randomEvent25Selected = false;
        randomEvent26Selected = false;
        randomEvent27Selected = false;
        randomEvent28Selected = false;
        randomEvent29Selected = false;
        randomEvent30Selected = false;
        randomEvent31Selected = false;
        randomEvent32Selected = false;
        randomEvent33Selected = false;
        randomEvent34Selected = false;
        randomEvent35Selected = false;
        randomEvent36Selected = false;
        randomEvent37Selected = false;
        randomEvent38Selected = false;
        randomEvent39Selected = false;
        randomEvent40Selected = false;
        randomEvent41Selected = false;
        randomEvent42Selected = false;
        randomEvent43Selected = false;
        randomEvent44Selected = false;
        randomEvent45Selected = false;
        randomEvent46Selected = false;
        randomEvent47Selected = false;
        randomEvent48Selected = false;
        randomEvent49Selected = false;
        randomEvent50Selected = false;

        continueSimulationFromWeekButton.SetActive(true);
        continueSimulationFromMonthButton.SetActive(true);
    }



    // The Final Summary - Quarter Summary
    public void ToQuarterSummary()
    {
        forwardButtonClickAudioSource.Play();
        //mainSimulationScreen.SetActive(false);
        //simulationSection.SetActive(false);
        monthSummaryScreen.SetActive(false);

        // Calculate Quarterly Money Gained & Loss
        quarterMoneyObtained1990 = month01MoneyObtained1990 + month02MoneyObtained1990 + month03MoneyObtained1990;
        quarterMoneyObtained2020 = month01MoneyObtained2020 + month02MoneyObtained2020 + month03MoneyObtained2020;
        quarterMoneyLoss1990 = month01MoneyLoss1990 + month02MoneyLoss1990 + month03MoneyLoss1990;
        quarterMoneyLoss2020 = month01MoneyLoss2020 + month02MoneyLoss2020 + month03MoneyLoss2020;

        quarterSummaryScreen.SetActive(true);

        QuarterSummary();

    }
    public void QuarterSummary()
    {
        // Shows Quarterly Money Gained and Loss
        quarterSummaryMoneyObtained1990Text.text = "Money Obtained: $" + quarterMoneyObtained1990;
        quarterSummaryMoneyObtained2020Text.text = "Money Obtained: $" + quarterMoneyObtained2020;
        quarterSummaryMoneyLoss1990Text.text = "Money Loss: $" + quarterMoneyLoss1990;
        quarterSummaryMoneyLoss2020Text.text = "Money Loss: $" + quarterMoneyLoss2020;

        // Calculates Quarterly Money Remaining
        quarterMoneyRemaining1990 = quarterMoneyObtained1990 - quarterMoneyLoss1990;
        quarterMoneyRemaining2020 = quarterMoneyObtained2020 - quarterMoneyLoss2020;

        quarterMoneyRemaining1990 = Math.Round(weekMoneyRemaining1990, 2);
        quarterMoneyRemaining2020 = Math.Round(weekMoneyRemaining2020, 2);

        // Shows Quarterly Money Remaining
        quarterSummaryMoneyRemaining1990Text.text = "Money Remaining: $" + quarterMoneyRemaining1990;
        quarterSummaryMoneyRemaining2020Text.text = "Money Remaining: $" + quarterMoneyRemaining2020;

        // Status Text based on 1990 Value
        if (quarterMoneyRemaining1990 >= 0.00)
        {
            quarterSummaryStatus1990Text.text = "You have done very well this Quarter!";
        }
        else if (quarterMoneyRemaining1990 < 0.00)
        {
            quarterSummaryStatus1990Text.text = "You seemed to have struggled a bit this past Quarter. Maybe next Quarter will be better!";
        }

        // Status Text based on 2020 Value
        if (quarterMoneyRemaining2020 >= 0.00)
        {
            quarterSummaryStatus2020Text.text = "You have done very well this Quarter!";
        }
        else if (quarterMoneyRemaining2020 < 0.00)
        {
            quarterSummaryStatus2020Text.text = "You seemed to have struggled a bit this past Quarter. Maybe next Quarter will be better!";
        }

        //Sets Monetary Values to each Month
        switch (q)
        {
            case 1:
                quarter01MoneyObtained1990 = quarterMoneyObtained1990;
                quarter01MoneyObtained2020 = quarterMoneyObtained2020;
                quarter01MoneyLoss1990 = quarterMoneyLoss1990;
                quarter01MoneyLoss2020 = quarterMoneyLoss2020;
                break;
            case 2: 
                quarter02MoneyObtained1990 = quarterMoneyObtained1990;
                quarter02MoneyObtained2020 = quarterMoneyObtained2020;
                quarter02MoneyLoss1990 = quarterMoneyLoss1990;
                quarter02MoneyLoss2020 = quarterMoneyLoss2020;
                break;
            case 3:
                quarter03MoneyObtained1990 = quarterMoneyObtained1990;
                quarter03MoneyObtained2020 = quarterMoneyObtained2020;
                quarter03MoneyLoss1990 = quarterMoneyLoss1990;
                quarter03MoneyLoss2020 = quarterMoneyLoss2020;
                break;
            case 4: 
                quarter04MoneyObtained1990 = quarterMoneyObtained1990;
                quarter04MoneyObtained2020 = quarterMoneyObtained2020;
                quarter04MoneyLoss1990 = quarterMoneyLoss1990;
                quarter04MoneyLoss2020 = quarterMoneyLoss2020;

                // Makes the Final Summary Section Available
                continueSimulationFromQuarterButton.SetActive(false);
                toFinalSummaryButton.SetActive(true);
                break;
        }
    }
    public void ToQuarterSummary1990()
    {
        forwardButtonClickAudioSource.Play();
        
        quarterSummary1990Screen.SetActive(true);

        quarterSummaryScreen.SetActive(false);

        QuarterSummary1990();
    }
    public void QuarterSummary1990()
    {

    }
    public void ToQuarterSummary2020()
    {
        forwardButtonClickAudioSource.Play();
        
        quarterSummary2020Screen.SetActive(true);

        quarterSummaryScreen.SetActive(false);

        QuarterSummary2020();
    }
    public void QuarterSummary2020()
    {

    }
    public void BackToQuarterSummary()
    {
        backwardsButtonClickAudioSource.Play();
        
        quarterSummaryScreen.SetActive(true);

        quarterSummary1990Screen.SetActive(false);
        quarterSummary2020Screen.SetActive(false);
    }
    public void ToNextQuarter()
    {
        forwardButtonClickAudioSource.Play();
        summaryBackgroundAudioSource.Stop();
        
        toQuarterSummaryButton.SetActive(false);
        quarterSummaryScreen.SetActive(false);
        //monthSummary1990Screen.SetActive(false);
        //monthSummary2020Screen.SetActive(false);
        summarySection.SetActive(false);

        // //Increases Month Counter By 1 and Resets Week Counter to 1
        // m++;
        // m1w = 1;
        // m2w = 1;
        // m3w = 1;

        // //Resets Month Monetary Collection Values
        // monthMoneyObtained1990 = 0;
        // monthMoneyObtained2020 = 0;
        // monthMoneyLoss1990 = 0;
        // monthMoneyLoss2020 = 0;
        // monthMoneyRemaining1990 = 0;
        // monthMoneyRemaining2020 = 0;

        // //Resets Week Monetary Collection Values
        // weekMoneyObtained1990 = 0;
        // weekMoneyObtained2020 = 0;
        // weekMoneyLoss1990 = 0;
        // weekMoneyLoss2020 = 0;
        // weekMoneyRemaining1990 = 0;
        // weekMoneyRemaining2020 = 0;

        // //Resets Paid Monetary Values
        // rentPaid1990 = 0;
        // rentPaid2020 = 0;
        // utilitiesPaid1990 = 0;
        // utilitiesPaid2020 = 0;
        // utilityElectricPaid1990 = 0;
        // utilityElectricPaid2020 = 0;
        // utilityWaterPaid1990 = 0;
        // utilityWaterPaid2020 = 0;
        // utilityCommunicationsPaid1990 = 0;
        // utilityCommunicationsPaid2020 = 0;
        // utilityEntertainmentPaid1990 = 0;
        // utilityEntertainmentPaid2020 = 0;
        // utilityInternetPaid1990 = 0;
        // utilityInternetPaid2020 = 0;
        // groceryPaid1990 = 0;
        // groceryPaid2020 = 0;
        // transportationPaid1990 = 0;
        // transportationPaid2020 = 0;
        
        // //Reset Completition Status
        // electricityComplete = false;
        // waterComplete = false;
        // communicationsComplete = false;
        // entertainmentComplete = false;
        // internetComplete = false;
        // housingComplete = false;
        // utilitiesComplete = false;
        // groceryComplete = false;
        // transportationComplete = false;
        summaryBackgroundAudioSource.Stop();

        simulationSection.SetActive(true);
        simulationStartScreen.SetActive(true);

        QuarterReset();
    }
    public void QuarterReset()
    {
        // Increases Quarter Counter by 1
        q++; 
        
        // Increases Month Counter by 1
        m++;

        // Resets Week Counter to 0 (eventually 1)
        m1w = 0;
        m2w = 0;
        m3w = 0;

        // Resets Quarter Monetary Collection Values
        quarterMoneyObtained1990 = 0.00;
        quarterMoneyObtained2020 = 0.00;
        quarterMoneyLoss1990 = 0.00;
        quarterMoneyLoss2020 = 0.00;
        quarterMoneyRemaining1990 = 0.00;
        quarterMoneyRemaining2020 = 0.00;
        
        // Resets Month Monetary Collection Values
        monthMoneyObtained1990 = 0.00;
        monthMoneyObtained2020 = 0.00;
        monthMoneyLoss1990 = 0.00;
        monthMoneyLoss2020 = 0.00;
        monthMoneyRemaining1990 = 0.00;
        monthMoneyRemaining2020 = 0.00;

        // Resets Week Monetary Collection Values
        weekMoneyObtained1990 = 0.00;
        weekMoneyObtained2020 = 0.00;
        weekMoneyLoss1990 = 0.00;
        weekMoneyLoss2020 = 0.00;
        weekMoneyRemaining1990 = 0.00;
        weekMoneyRemaining2020 = 0.00;

        // Resets Paid Monetary Values
        housingPaid1990 = 0.00;
        housingPaid2020 = 0.00;
        utilitiesPaid1990 = 0.00;
        utilitiesPaid2020 = 0.00;
        utilityElectricPaid1990 = 0.00;
        utilityElectricPaid2020 = 0.00;
        utilityWaterPaid1990 = 0.00;
        utilityWaterPaid2020 = 0.00;
        utilityCommunicationsPaid1990 = 0.00;
        utilityCommunicationsPaid2020 = 0.00;
        utilityEntertainmentPaid1990 = 0.00;
        utilityEntertainmentPaid2020 = 0.00;
        utilityInternetPaid1990 = 0.00;
        utilityInternetPaid2020 = 0.00;
        groceryPaid1990 = 0.00;
        groceryPaid2020 = 0.00;
        transportationPaid1990 = 0.00;
        transportationPaid2020 = 0.00;
        otherPaid1990 = 0.00;
        otherPaid2020 = 0.00;
        
        // Reset Completition Status
        electricityComplete = false;
        waterComplete = false;
        communicationsComplete = false;
        entertainmentComplete = false;
        internetComplete = false;
        housingComplete = false;
        utilitiesComplete = false;
        groceryComplete = false;
        transportationComplete = false;

        electricityPaid = false;
        electricity1990Paid = false;
        electricity2020Paid = false;
        waterPaid = false;
        water1990Paid = false;
        water2020Paid = false;
        communicationsPaid = false;
        communications1990Paid = false;
        communications2020Paid = false;
        entertainmentPaid = false;
        entertainment1990Paid = false;
        entertainment2020Paid = false;
        internetPaid = false;
        internet1990Paid = false;
        internet2020Paid = false;

        // Reset Utility Options
        payUtilitiesElectricity1990Button.SetActive(true);
        payUtilitiesElectricity2020Button.SetActive(true);
        payUtilitiesWater1990Button.SetActive(true);
        payUtilitiesWater2020Button.SetActive(true);
        payUtilitiesCommunications1990Button.SetActive(true);
        payUtilitiesCommunications2020Button.SetActive(true);
        payUtilitiesEntertainment1990Button.SetActive(true);
        payUtilitiesEntertainment2020Button.SetActive(true);
        payUtilitiesInternet2020Button.SetActive(true);

        electricity1990PaidTextObject.SetActive(false);
        electricity2020PaidTextObject.SetActive(false);
        water1990PaidTextObject.SetActive(false);
        water2020PaidTextObject.SetActive(false);
        communications1990PaidTextObject.SetActive(false);
        communications2020PaidTextObject.SetActive(false);
        entertainment1990PaidTextObject.SetActive(false);
        entertainment2020PaidTextObject.SetActive(false);
        internet1990PaidTextObject.SetActive(false);
        internet2020PaidTextObject.SetActive(false);

        electricityCloseButton.SetActive(false);
        waterCloseButton.SetActive(false);
        communicationsCloseButton.SetActive(false);
        entertainmentCloseButton.SetActive(false);
        internetCloseButton.SetActive(false);
        utilitiesCompleteTextObject.SetActive(false);

        // Reset Random Event Selections
        randomEvent01Selected = false;
        randomEvent02Selected = false;
        randomEvent03Selected = false;
        randomEvent04Selected = false;
        randomEvent05Selected = false;
        randomEvent06Selected = false;
        randomEvent07Selected = false;
        randomEvent08Selected = false;
        randomEvent09Selected = false;
        randomEvent10Selected = false;
        randomEvent11Selected = false;
        randomEvent12Selected = false;
        randomEvent13Selected = false;
        randomEvent14Selected = false;
        randomEvent15Selected = false;
        randomEvent16Selected = false;
        randomEvent17Selected = false;
        randomEvent18Selected = false;
        randomEvent19Selected = false;
        randomEvent20Selected = false;
        randomEvent21Selected = false;
        randomEvent22Selected = false;
        randomEvent23Selected = false;
        randomEvent24Selected = false;
        randomEvent25Selected = false;
        randomEvent26Selected = false;
        randomEvent27Selected = false;
        randomEvent28Selected = false;
        randomEvent29Selected = false;
        randomEvent30Selected = false;
        randomEvent31Selected = false;
        randomEvent32Selected = false;
        randomEvent33Selected = false;
        randomEvent34Selected = false;
        randomEvent35Selected = false;
        randomEvent36Selected = false;
        randomEvent37Selected = false;
        randomEvent38Selected = false;
        randomEvent39Selected = false;
        randomEvent40Selected = false;
        randomEvent41Selected = false;
        randomEvent42Selected = false;
        randomEvent43Selected = false;
        randomEvent44Selected = false;
        randomEvent45Selected = false;
        randomEvent46Selected = false;
        randomEvent47Selected = false;
        randomEvent48Selected = false;
        randomEvent49Selected = false;
        randomEvent50Selected = false;

        continueSimulationFromWeekButton.SetActive(true);
        continueSimulationFromMonthButton.SetActive(true);
    }



    // Simulation Functions - Final Summary
    public void ToFinalSummary()
    {
        forwardButtonClickAudioSource.Play();
        summaryBackgroundAudioSource.Play();
        
        monthSummaryScreen.SetActive(false);
        //monthSummary1990Screen.SetActive(false);
        toFinalSummaryButton.SetActive(false);
        //monthSummary2020Screen.SetActive(false);

        // Calculate Yearly Money Gained & Loss
        finalMoneyObtained1990 = quarter01MoneyObtained1990 + quarter02MoneyObtained1990 + quarter03MoneyObtained1990 + quarter04MoneyObtained1990;
        finalMoneyObtained2020 = quarter01MoneyObtained2020 + quarter02MoneyObtained2020 + quarter03MoneyObtained2020 + quarter04MoneyObtained2020;
        finalMoneyLoss1990 = quarter01MoneyLoss1990 + quarter02MoneyLoss1990 + quarter03MoneyLoss1990 + quarter04MoneyLoss1990;
        finalMoneyLoss2020 = quarter01MoneyLoss2020 + quarter02MoneyLoss2020 + quarter03MoneyLoss2020 + quarter04MoneyLoss2020;
        
        finalSummaryScreen.SetActive(true);

        FinalSummary();
    }
    public void FinalSummary()
    {
        // Shows Final Money Gained and Loss
        finalSummaryMoneyObtained1990Text.text = "Money Obtained: $" + finalMoneyObtained1990;
        finalSummaryMoneyObtained2020Text.text = "Money Obtained: $" + finalMoneyObtained2020;
        finalSummaryMoneyLoss1990Text.text = "Money Loss: $" + finalMoneyLoss1990;
        finalSummaryMoneyLoss2020Text.text = "Money Loss: $" + finalMoneyLoss2020;

        // Calculates Final Money Remaining
        finalMoneyRemaining1990 = finalMoneyObtained1990 - finalMoneyLoss1990;
        finalMoneyRemaining2020 = finalMoneyObtained2020 - finalMoneyLoss2020;

        // Shows Final Money Remaining
        finalSummaryMoneyRemaining1990Text.text = "Money Remaining: $" + finalMoneyRemaining1990;
        finalSummaryMoneyRemaining2020Text.text = "Money Remaining: $" + finalMoneyRemaining2020;

        // Final Status Text based on 1990 Value
        if (finalMoneyRemaining1990 >= 0.00)
        {
            finalSummaryStatus1990Text.text = "You have done very well this Year!";
        }
        else if (finalMoneyRemaining1990 < 0.00)
        {
            finalSummaryStatus1990Text.text = "You seemed to have struggled a bit this past Year. Maybe next Year will be better!";
        }

        // Final Status Text based on 2020 Value
        if (finalMoneyRemaining2020 >= 0.00)
        {
            finalSummaryStatus2020Text.text = "You have done very well this Year!";
        }
        else if (finalMoneyRemaining2020 < 0.00)
        {
            finalSummaryStatus2020Text.text = "You seemed to have struggled a bit this past Year. Maybe next Year will be better!";
        }
    }
    public void GameComplete1()
    {
        forwardButtonClickAudioSource.Play();
        
        SceneManager.LoadScene("MainMenu");
    }
    public void GameComplete2()
    {
        forwardButtonClickAudioSource.Play();
        
        Application.Quit();
    }
    public void ToMainMenu()
    {
        forwardButtonClickAudioSource.Play();
        
        SceneManager.LoadScene("MainMenu");
    }



    public void ToCurrentMoneySimulation()
    {
        forwardButtonClickAudioSource.Play();
        
        currentMoneyUpdateSimulationScreen.SetActive(true);
    }
    public void ToCurrentMoneySummary()
    {
        forwardButtonClickAudioSource.Play();
        
        currentMoneyUpdateSummaryScreen.SetActive(true);
    }
    public void BackFromCurrentMoneySimulation()
    {
       backwardsButtonClickAudioSource.Play(); 
        
        currentMoneyUpdateSimulationScreen.SetActive(false);
    }
    public void BackFromCurrentMoneySummary()
    {
       backwardsButtonClickAudioSource.Play(); 
        
        currentMoneyUpdateSummaryScreen.SetActive(false);
    }

    // Debug Tool
    public void DebugRandomIntro()
    {
        // Gender Selection
        genderNow = 1;
        genderSelected = "Male";
        maleGender = true;

        // Race Selection
        raceNow = 2;
        raceSelected = "African Descent";
        africanDescent = true;

        // Education Selection
        educationNow = 4;
        educationSelected = "Bachelor's Degree";
        bachelorsDegree = true;

        // Job Selection
        jobNow = 6;
        jobSelected = "Licensed Sales Agent";
        licensedSalesAgent = true;
        hourlyRate1990 = 12.50F;
        hourlyRate2020 = 18.00F;

        // Housing Selection
        houseNow = 4;
        housingSelected = "Luxury Apartment";
        luxuryApartment = true;
        rentCost1990 = 900.00F;
        rentCost2020 = 1600.00F;

        // Utilities Selection
        utilityElectric = true;
        utilityElectric1990Selected = "Electricity";
        utilityElectric2020Selected = "Electricity";

        utilityWater = true;
        utilityWater1990Selected = "Water";
        utilityWater2020Selected = "Water";

        utilityCommunications1990 = true;
        basicCellPhone1990 = true;
        utilityCommunications1990Selected = "Basic Cell Phone";
        utilityCommunicationsCost1990 = 30.00F;

        utilityCommunications2020 = true;
        basicCellPhone2020 = true;
        utilityCommunications2020Selected = "Basic Cell Phone";
        utilityCommunicationsCost2020 = 50.00F;

        utilityEntertainment1990 = true;
        premiumCable1990 = true;
        utilityEntertainment1990Selected = "Premium Cable";
        utilityEntertainmentCost1990 = 40.00F;

        utilityEntertainment2020 = true;
        premiumCable2020 = true;
        utilityEntertainment2020Selected = "Premium Cable";
        utilityEntertainmentCost2020 = 80.00F;

        utilityInternet1990 = true;
        premiumDialUpInternet1990 = true;
        utilityInternet1990Selected = "Premium Dial-Up Internet";

        utilityInternet2020 = true;
        mb100Internet2020 = true;
        utilityInternet2020Selected = "100MB/s Internet";
        utilityInternetCost2020 = 50.00F;

        // Transportation Selection
        travelNow = 2;
        transportationSelected = "Used Car";
        usedCar = true;
        payTransportationTitleText1.text = "Pay Transportation: Used Car";
        payTransportationTitleText2.text = "Pay Transportation: Used Car";
        transportationCost1990 = 11.25F;
        transportationCost2020 = 25.00F;

        // Gift Money Selection
        giftMoney = UnityEngine.Random.Range(0.00F, 1000.00F);
        giftMoney = Math.Round(giftMoney, 2);
        currentMoney1990 += giftMoney;
        currentMoney2020 += giftMoney;

        // Screens
        welcomeScreen.SetActive(false);

        introSummaryScreen.SetActive(true);
    }
}

