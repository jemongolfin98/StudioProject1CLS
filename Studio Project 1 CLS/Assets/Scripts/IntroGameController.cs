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
    public GameObject bachelorsDegreeButton;
    public GameObject mastersDegreeButton;
    public GameObject advancedDegreeButton;
    //Introduction - Game Buttons - Employment
    public GameObject cashierButton;
    public GameObject fryCookButton;
    public GameObject waiterButton;
    public GameObject customerServiceAgentButton;
    public GameObject teacherButton;
    public GameObject licensedSalesAgentButton;
    public GameObject programmerButton;
    public GameObject unknownJobButton;
    public GameObject doctorButton;
    public GameObject lawyerButton;
    //Introduction - Game Buttons - Housing
    public GameObject livingWithParentsButton;
    public GameObject livingWithRoommatesButton;
    public GameObject basicApartmentButton;
    public GameObject luxuryApartmentButton;
    public GameObject basicHouseButton;
    public GameObject luxuryHouseButton;
    //Introduction - Game Buttons - Utilities
    public GameObject utilitiesElectricButton;
    public GameObject utilitiesWaterButton;
    public GameObject utilitiesCommunicationsButton;
    public GameObject housePhone1990Button;
    public GameObject housePhone2020Button;
    public GameObject basicCellPhone1990Button;
    public GameObject basicCellPhone2020Button;
    public GameObject unlimitedCellPhone2020Button;
    public GameObject utilitiesEntertainmentButton;
    public GameObject basicCable1990Button;
    public GameObject basicCable2020Button;
    public GameObject premiumCable1990Button;
    public GameObject premiumCable2020Button;
    public GameObject streamingService2020Button;
    public GameObject utilitiesInternetButton;
    public GameObject basicInternet1990Button;
    public GameObject mb50Internet2020Button;
    public GameObject mb100Internet2020Button;
    public GameObject mb200Internet2020Button;
    public GameObject toTransportationScreenButton;
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
    public GameObject genderScreen;
    public GameObject maleScreen;
    public GameObject femaleScreen;
    public GameObject otherGenderScreen;
    //Introduction - Game Screens - Race
    public GameObject raceScreen;
    public GameObject europeanDescentScreen;
    public GameObject africanDescentScreen;
    public GameObject nativeAmericanDescentScreen;
    public GameObject hispanicDescentScreen;
    public GameObject asianDescentScreen;
    public GameObject otherDescentScreen;
    //Introduction - Game Screens - Education
    public GameObject educationScreen;
    public GameObject educationScreenNoDegree;
    public GameObject educationScreenHSDiploma;
    public GameObject educationScreenBachelorsDegree;
    public GameObject educationScreenMastersDegree;
    public GameObject educationScreenAdvancedDegree;
    //Introduction - Game Screens - Employment
    public GameObject jobScreen;
    public GameObject cashierScreen;
    public GameObject fryCookScreen;
    public GameObject waiterScreen;
    public GameObject customerServiceAgentScreen;
    public GameObject teacherScreen;
    public GameObject licensedSalesAgentScreen;
    public GameObject programmerScreen;
    public GameObject unknownJobScreen;
    public GameObject doctorScreen;
    public GameObject lawyerScreen;
    //Introduction - Game Screens - Housing
    public GameObject housingScreen;
    public GameObject livingWithParentsScreen;
    public GameObject livingWithRoommatesScreen;
    public GameObject basicApartmentScreen;
    public GameObject luxuryApartmentScreen;
    public GameObject basicHouseScreen;
    public GameObject luxuryHouseScreen;
    //Introduction - Game Screens - Utilities
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
    public GameObject basicInternet1990Screen;
    public GameObject mb50Internet2020Screen;
    public GameObject mb100Internet2020Screen;
    public GameObject mb200Internet2020Screen;
    //Introduction - Game Screens - Transportation
    public GameObject transportationScreen;
    public GameObject bicycleScreen;
    public GameObject usedCarScreen;
    public GameObject newCarScreen;
    public GameObject motorcycleScreen;
    public GameObject busScreen;
    public GameObject trainScreen;
    //Introduction - Game Screens - Gift Money
    public GameObject giftMoneyScreen1;
    public GameObject giftMoneyScreen2;
    //Introduction - Game Screens - Summary
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
    public bool bachelorsDegree = false;
    public bool mastersDegree = false;
    public bool advancedDegree = false;
    //Introduction - Game Setting Variables - Employment
    public bool cashier = false;
    public bool fryCook = false;
    public bool waiter = false;
    public bool customerServiceAgent = false;
    public bool teacher = false;
    public bool licensedSalesAgent = false;
    public bool programmer = false;
    public bool unknownJob = false;
    public bool doctor = false;
    public bool lawyer = false;
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
    public bool utilityInternet2020 = false;
    public bool basicInternet1990 = false;
    public bool mb50Internet = false;
    public bool mb100Internet = false;
    public bool mb200Internet = false;
    //Introduction - Game Setting Variables - Transportation
    public bool bicycle = false;
    public bool usedCar = false;
    public bool newCar = false;
    public bool motorcycle = false;
    public bool bus = false;
    public bool train = false;


    //Introduction - Text
    public TMPro.TMP_Text jobPayCashier1990Text;
    public TMPro.TMP_Text jobPayCashier2020Text;
    public TMPro.TMP_Text jobPayFryCook1990Text;
    public TMPro.TMP_Text jobPayFryCook2020Text;
    public TMPro.TMP_Text jobPayWaiter1990Text;
    public TMPro.TMP_Text jobPayWaiter2020Text;
    public TMPro.TMP_Text jobPayCSA1990Text;
    public TMPro.TMP_Text jobPayCSA2020Text;
    public TMPro.TMP_Text jobPayTeacher1990Text;
    public TMPro.TMP_Text jobPayTeacher2020Text;
    public TMPro.TMP_Text jobPayLSA1990Text;
    public TMPro.TMP_Text jobPayLSA2020Text;
    public TMPro.TMP_Text jobPayProgrammer1990Text;
    public TMPro.TMP_Text jobPayProgrammer2020Text;
    public TMPro.TMP_Text jobPayUnknownJob1990Text;
    public TMPro.TMP_Text jobPayUnknownJob2020Text;
    public TMPro.TMP_Text jobPayDoctor1990Text;
    public TMPro.TMP_Text jobPayDoctor2020Text;
    public TMPro.TMP_Text jobPayLawyer1990Text;
    public TMPro.TMP_Text jobPayLawyer2020Text;
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
    public double mortgageCost2020 = 0.00;
    public double utilitiesCost1990 = 0.00;
    public double utilitiesCost2020 = 0.00;
    public double groceryCost1990 = 0.00;
    public double groceryCost2020 = 0.00;
    public double airPump1990 = 2.00;
    public double airPump2020 = 3.00;
    public double gasCost1990 = 1.15;
    public double gasCost2020 = 2.50;
    public double busFare1990 = 2.00;
    public double busFare2020 = 4.50;
    public double trainFare1990 = 1.50;
    public double trainFare2020 = 4.00;
    public double transportationCost1990 = 0.00;
    public double transportationCost2020 = 0.00;
    public double otherCost1990 = 0.00;
    public double otherCost2020 = 0.00;

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
    public double weekBusFare1990 = 0.00;
    public double weekBusFare2020 = 0.00;
    public double weekTrainFare1990 = 0.00;
    public double weekTrainFare2020 = 0.00;


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
    public string utilityInternet2020Selected;

    //Game - Other Variables
    public GameObject introductionSection;
    public GameObject simulationSection;
    public GameObject summarySection;
    public GameObject introGameController1;
    public GameObject backFromCommunicationsButton;
    public GameObject backFromEntertainmentButton;
    public GameObject backFromInternetButton;
    public int genderNow;
    public int raceNow;
    public int educationNow;
    public int jobNow;
    public int houseNow;
    public int utilitiesNow;
    public int travelNow;
    public int utilitiesSelected = 0;
    public int i = 0;
    public int j = 0;




    //Game Audio Variables
    public AudioSource introductionAudioSource;
    public AudioSource simulationAudioSource;
    public AudioSource buttonClickAudioSource;
    public AudioSource payDayAudioSource;
    public AudioSource positiveEventAudioSource;
    public AudioSource negativeEventAudioSource;
    public AudioSource successAudioSource;
    public AudioSource failureAudioSource;




    //Simulation Variables
    //Simulation - Screens
    public GameObject simulationStartScreen;
    public GameObject mainSimulationScreen;
    public GameObject pauseMenuScreen;
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
    public GameObject payGroceriesScreen;
    public GameObject payGroceriesFastFoodScreen;
    public GameObject payGroceriesCookingScreen;
    public GameObject payGroceriesEatingOutScreen;
    public GameObject payTransportationScreen1;
    public GameObject payTransportationScreen2;
    //Simulation - Screens - Random Events
    public GameObject randomEventScreen1;
    public GameObject randomEventScreen2;

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
    public GameObject payGroceriesFastFoodButton;
    public GameObject payGroceriesCookingButton;
    public GameObject payGroceriesEatingOutButton;
    public GameObject toPayTransportationButton;
    public GameObject payTransportationButton;

    //Simulation - Text
    //Simulation - Text - Title
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
    public TMPro.TMP_Text playerStats1990EmploymentText;
    public TMPro.TMP_Text playerStats2020EmploymentText;
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
    public TMPro.TMP_Text fastFood1990PaidText;
    public TMPro.TMP_Text fastFood2020PaidText;
    public TMPro.TMP_Text cooking1990PaidText;
    public TMPro.TMP_Text cooking2020PaidText;
    public TMPro.TMP_Text eatingOut1990PaidText;
    public TMPro.TMP_Text eatingOut2020PaidText;
    public TMPro.TMP_Text payTransportationTitleText1;
    public TMPro.TMP_Text payTransportationTitleText2;
    public TMPro.TMP_Text payTransportationDescriptionText;
    public TMPro.TMP_Text transportation1990PaidText;
    public TMPro.TMP_Text transportation2020PaidText;
    //Simulation - Text (Additional)

    //Simulation - Strings
    //Simulation - Strings - Titles
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
    public bool randomEvent = false;
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
    public int monthNumber;
    public int weekNumber;
    public int randomEventCounter;
    public int randomEventNumber;
    //Simulation - Variables - Iteration (Try)
    public int m = 1;
    public int m1 = 0;
    public int m2 = 0;
    public int m3 = 0;
    public int m4 = 0;
    public int m5 = 0;
    public int m6 = 0;
    public int m7 = 0;
    public int m8 = 0;
    public int m9 = 0;
    public int m10 = 0;
    public int m11 = 0;
    public int m12 = 0;


    //Summary - Screens
    public GameObject weekSummaryScreen;
    public GameObject weekSummary1990Screen;
    public GameObject weekSummary2020Screen;
    public GameObject monthSummaryScreen;
    public GameObject monthSummary1990Screen;
    public GameObject monthSummary2020Screen;
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
    public double month04MoneyObtained1990 = 0.00;
    public double month04MoneyObtained2020 = 0.00;
    public double month05MoneyObtained1990 = 0.00;
    public double month05MoneyObtained2020 = 0.00;
    public double month06MoneyObtained1990 = 0.00;
    public double month06MoneyObtained2020 = 0.00;
    public double month07MoneyObtained1990 = 0.00;
    public double month07MoneyObtained2020 = 0.00;
    public double month08MoneyObtained1990 = 0.00;
    public double month08MoneyObtained2020 = 0.00;
    public double month09MoneyObtained1990 = 0.00;
    public double month09MoneyObtained2020 = 0.00;
    public double month10MoneyObtained1990 = 0.00;
    public double month10MoneyObtained2020 = 0.00;
    public double month11MoneyObtained1990 = 0.00;
    public double month11MoneyObtained2020 = 0.00;
    public double month12MoneyObtained1990 = 0.00;
    public double month12MoneyObtained2020 = 0.00;
    public double monthMoneyLoss1990 = 0.00;
    public double monthMoneyLoss2020 = 0.00;
    public double month01MoneyLoss1990 = 0.00;
    public double month01MoneyLoss2020 = 0.00;
    public double month02MoneyLoss1990 = 0.00;
    public double month02MoneyLoss2020 = 0.00;
    public double month03MoneyLoss1990 = 0.00;
    public double month03MoneyLoss2020 = 0.00;
    public double month04MoneyLoss1990 = 0.00;
    public double month04MoneyLoss2020 = 0.00;
    public double month05MoneyLoss1990 = 0.00;
    public double month05MoneyLoss2020 = 0.00;
    public double month06MoneyLoss1990 = 0.00;
    public double month06MoneyLoss2020 = 0.00;
    public double month07MoneyLoss1990 = 0.00;
    public double month07MoneyLoss2020 = 0.00;
    public double month08MoneyLoss1990 = 0.00;
    public double month08MoneyLoss2020 = 0.00;
    public double month09MoneyLoss1990 = 0.00;
    public double month09MoneyLoss2020 = 0.00;
    public double month10MoneyLoss1990 = 0.00;
    public double month10MoneyLoss2020 = 0.00;
    public double month11MoneyLoss1990 = 0.00;
    public double month11MoneyLoss2020 = 0.00;
    public double month12MoneyLoss1990 = 0.00;
    public double month12MoneyLoss2020 = 0.00;
    public double monthMoneyRemaining1990 = 0.00;
    public double monthMoneyRemaining2020 = 0.00;
    //Summary - Variables - Final
    public double finalMoneyObtained1990 = 0.00;
    public double finalMoneyObtained2020 = 0.00;
    public double finalMoneyLoss1990 = 0.00;
    public double finalMoneyLoss2020 = 0.00;
    public double finalMoneyRemaining1990 = 0.00;
    public double finalMoneyRemaining2020 = 0.00;

    //Summary - Text
    public TMPro.TMP_Text weekSummaryTitleText;
    public TMPro.TMP_Text monthSummaryTitleText;
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
    



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Allowing to Press Escape Key to Quit Game from Level
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }

        //Updating Current Money
        //currentMoney1990 = initialMoney1990 + giftMoney;
        //currentMoney2020 = initialMoney2020 + giftMoney;

        //Updating Utility Cost
        //utilitiesCost1990 = utilityElectricCost1990 + utilityWaterCost1990 + utilityCommunicationsCost1990 + utilityEntertainmentCost1990;
        //utilitiesCost2020 = utilityElectricCost2020 + utilityWaterCost2020 + utilityCommunicationsCost2020 + utilityEntertainmentCost2020 + utilityInternetCost2020;

        //The Introduction
        //The Introduction - Summary
        //IntroSummary1990();
        //IntroSummary2020();

        //The Simulation
        //The Simulation - Status
        //MainSimulationStatus();
        //The Simulation - Player Stats
        //PlayerStats1990();
        //PlayerStats2020();
        //The Simulation - The Iteration
        //MainSimulationIteration();
        //MainSimulationIteration1();
        //The Simulation - Random Events
        //RandomEvents();

        //The Final Summary
        //The FInal Summary - Week Summary
        //WeekSummary1990();
        //WeekSummary2020();
        //The Summary - Month Summary
        //MonthSummary1990();
        //MonthSummary2020();
    }

    

    //Selecting Gender
    public void ChooseGender()
    {
        if (maleGender == true)
        {
            genderScreen.SetActive(false);
            maleScreen.SetActive(true);
            femaleScreen.SetActive(false);
            otherGenderScreen.SetActive(false);

            genderSelected = "Male";
            genderNow = 1;
        }
        else if (femaleGender == true)
        {
            genderScreen.SetActive(false);
            maleScreen.SetActive(false);
            femaleScreen.SetActive(true);
            otherGenderScreen.SetActive(false);

            genderSelected = "Female";
            genderNow = 2;
        }
        else if (otherGender == true)
        {
            genderScreen.SetActive(false);
            maleScreen.SetActive(false);
            femaleScreen.SetActive(false);
            otherGenderScreen.SetActive(true);

            genderSelected = "Other Gender";
            genderNow = 3;
        }
    }

    public void ChooseGenderMale()
    {
        maleGender = true;
        ChooseGender();
    }

    public void ChooseGenderFemale()
    {
        femaleGender = true;
        ChooseGender();
    }

    public void ChooseGenderNoGender()
    {
        otherGender = true;
        ChooseGender();
    }



    //Selecting Race
    public void ChooseRace()
    {
        if (europeanDescent == true)
        {
            raceScreen.SetActive(false);
            europeanDescentScreen.SetActive(true);
            africanDescentScreen.SetActive(false);
            nativeAmericanDescentScreen.SetActive(false);
            hispanicDescentScreen.SetActive(false);
            asianDescentScreen.SetActive(false);
            otherDescentScreen.SetActive(false);

            raceSelected = "European Descent";
            raceNow = 1;
        }
        else if (africanDescent == true)
        {
            raceScreen.SetActive(false);
            europeanDescentScreen.SetActive(false);
            africanDescentScreen.SetActive(true);
            nativeAmericanDescentScreen.SetActive(false);
            hispanicDescentScreen.SetActive(false);
            asianDescentScreen.SetActive(false);
            otherDescentScreen.SetActive(false);

            raceSelected = "African Descent";
            raceNow = 2;
        }
        else if (nativeAmericanDescent == true)
        {
            raceScreen.SetActive(false);
            europeanDescentScreen.SetActive(false);
            africanDescentScreen.SetActive(false);
            nativeAmericanDescentScreen.SetActive(true);
            hispanicDescentScreen.SetActive(false);
            asianDescentScreen.SetActive(false);
            otherDescentScreen.SetActive(false);

            raceSelected = "Native American Descent";
            raceNow = 3;
        }
        else if (hispanicDescent == true)
        {
            raceScreen.SetActive(false);
            europeanDescentScreen.SetActive(false);
            africanDescentScreen.SetActive(false);
            nativeAmericanDescentScreen.SetActive(false);
            hispanicDescentScreen.SetActive(true);
            asianDescentScreen.SetActive(false);
            otherDescentScreen.SetActive(false);

            raceSelected = "Hispanic Descent";
            raceNow = 4;
        }
        else if (asianDescent == true)
        {
            raceScreen.SetActive(false);
            europeanDescentScreen.SetActive(false);
            africanDescentScreen.SetActive(false);
            nativeAmericanDescentScreen.SetActive(false);
            hispanicDescentScreen.SetActive(false);
            asianDescentScreen.SetActive(true);
            otherDescentScreen.SetActive(false);

            raceSelected = "Asian Descent";
            raceNow = 5;
        }
        else if (otherDescent == true)
        {
            raceScreen.SetActive(false);
            europeanDescentScreen.SetActive(false);
            africanDescentScreen.SetActive(false);
            nativeAmericanDescentScreen.SetActive(false);
            hispanicDescentScreen.SetActive(false);
            asianDescentScreen.SetActive(false);
            otherDescentScreen.SetActive(true);

            raceSelected = "Other Descent";
            raceNow = 6;
        }
    }
    
    public void ChooseRaceEuropeanDescent()
    {
        europeanDescent = true;
        ChooseRace();
    }

    public void ChooseRaceAfricanDescent()
    {
        africanDescent = true;
        ChooseRace();
    }

    public void ChooseRaceNativeAmericanDescent()
    {
        nativeAmericanDescent = true;
        ChooseRace();
    }

    public void ChooseRaceHispanicDescent()
    {
        hispanicDescent = true;
        ChooseRace();
    }

    public void ChooseRaceAsianDescent()
    {
        asianDescent = true;
        ChooseRace();
    }

    public void ChooseRaceOtherDescent()
    {
        otherDescent = true;
        ChooseRace();
    }



    //Selecting Education
    public void ChooseEducation()
    {
        if (noDegree == true)
        {
            //Changes Panel View
            educationScreen.SetActive(false);
            educationScreenNoDegree.SetActive(true);
            educationScreenHSDiploma.SetActive(false);
            educationScreenBachelorsDegree.SetActive(false);
            educationScreenMastersDegree.SetActive(false);
            educationScreenAdvancedDegree.SetActive(false);

            educationSelected = "No Degree";
            educationNow = 1;

            //Sets Available Jobs
            waiterButton.SetActive(true);
            cashierButton.SetActive(true);
            fryCookButton.SetActive(true);
            customerServiceAgentButton.SetActive(true);
            teacherButton.SetActive(false);
            licensedSalesAgentButton.SetActive(false);
            programmerButton.SetActive(false);
            unknownJobButton.SetActive(false);
            doctorButton.SetActive(false);
            lawyerButton.SetActive(false);
        }
        else if (hsDiploma == true)
        {
            //Changes Panel View
            educationScreen.SetActive(false);
            educationScreenNoDegree.SetActive(false);
            educationScreenHSDiploma.SetActive(true);
            educationScreenBachelorsDegree.SetActive(false);
            educationScreenMastersDegree.SetActive(false);
            educationScreenAdvancedDegree.SetActive(false);

            educationSelected = "High School Diploma";
            educationNow = 2;

            //Sets Available Jobs
            waiterButton.SetActive(true);
            cashierButton.SetActive(true);
            fryCookButton.SetActive(true);
            customerServiceAgentButton.SetActive(true);
            teacherButton.SetActive(true);
            licensedSalesAgentButton.SetActive(true);
            programmerButton.SetActive(false);
            unknownJobButton.SetActive(false);
            doctorButton.SetActive(false);
            lawyerButton.SetActive(false);
        }
        else if (bachelorsDegree == true)
        {
            //Changes Panel View
            educationScreen.SetActive(false);
            educationScreenNoDegree.SetActive(false);
            educationScreenHSDiploma.SetActive(false);
            educationScreenBachelorsDegree.SetActive(true);
            educationScreenMastersDegree.SetActive(false);
            educationScreenAdvancedDegree.SetActive(false);

            educationSelected = "Bachelor's Degree";
            educationNow = 3;

            //Sets Available Jobs
            waiterButton.SetActive(true);
            cashierButton.SetActive(true);
            fryCookButton.SetActive(true);
            customerServiceAgentButton.SetActive(true);
            teacherButton.SetActive(true);
            licensedSalesAgentButton.SetActive(true);
            programmerButton.SetActive(true);
            unknownJobButton.SetActive(false);
            doctorButton.SetActive(false);
            lawyerButton.SetActive(false);
        }
        else if (mastersDegree == true)
        {
            //Changes Panel View
            educationScreen.SetActive(false);
            educationScreenNoDegree.SetActive(false);
            educationScreenHSDiploma.SetActive(false);
            educationScreenBachelorsDegree.SetActive(false);
            educationScreenMastersDegree.SetActive(true);
            educationScreenAdvancedDegree.SetActive(false);

            educationSelected = "Master's Degreee";
            educationNow = 4;

            //Sets Available Jobs
            waiterButton.SetActive(true);
            cashierButton.SetActive(true);
            fryCookButton.SetActive(true);
            customerServiceAgentButton.SetActive(true);
            teacherButton.SetActive(true);
            licensedSalesAgentButton.SetActive(true);
            programmerButton.SetActive(true);
            unknownJobButton.SetActive(false);
            doctorButton.SetActive(false);
            lawyerButton.SetActive(false);
        }
        else if (advancedDegree == true)
        {
            //Changes Panel View
            educationScreen.SetActive(false);
            educationScreenNoDegree.SetActive(false);
            educationScreenHSDiploma.SetActive(false);
            educationScreenBachelorsDegree.SetActive(false);
            educationScreenMastersDegree.SetActive(false);
            educationScreenAdvancedDegree.SetActive(true);

            educationSelected = "Advanced Degree";
            educationNow = 5;

            //Sets Available Jobs
            waiterButton.SetActive(true);
            cashierButton.SetActive(true);
            fryCookButton.SetActive(true);
            customerServiceAgentButton.SetActive(true);
            teacherButton.SetActive(true);
            licensedSalesAgentButton.SetActive(true);
            programmerButton.SetActive(true);
            unknownJobButton.SetActive(true);
            doctorButton.SetActive(true);
            lawyerButton.SetActive(true);
        }
    }
    
    public void ChooseEducationNoDegree()
    {
        noDegree = true;
        ChooseEducation();
    }

    public void ChooseEducationHighSchoolDiploma()
    {
        hsDiploma = true;
        ChooseEducation();
    }

    public void ChooseEducationBachelorsDegree()
    {
        bachelorsDegree = true;
        ChooseEducation();
    }

    public void ChooseEducationMastersDegree()
    {
        mastersDegree = true;
        ChooseEducation();
    }

    public void ChooseEducationPhDDegree()
    {
        advancedDegree = true;
        ChooseEducation();
    }



    //Selecting Employment
    public void ChooseJob()
    {
        if (waiter == true)
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
            unknownJobScreen.SetActive(false);
            doctorScreen.SetActive(false);
            lawyerScreen.SetActive(false);

            jobSelected = "Waiter";
            jobNow = 1;

            //Setting Pay
            switch (educationNow)
            {
                case 1:
                    biweeklySalary1990 = 240.00; // 3.00
                    biweeklySalary2020 = 480.00; // 6.00
                    break;
                case 2:
                    biweeklySalary1990 = 280.00; // 3.50
                    biweeklySalary2020 = 580.00; // 7.25
                    break;
                case 3:
                    biweeklySalary1990 = 320.00; // 4.00
                    biweeklySalary2020 = 684.80; // 8.56
                    break;
                case 4:
                    biweeklySalary1990 = 360.00; // 4.50
                    biweeklySalary2020 = 740.00; // 9.25
                    break;
                case 5:
                    biweeklySalary1990 = 400.00; // 5.00
                    biweeklySalary2020 = 800.00; // 10.00
                    break;
            }

            jobPayWaiter1990Text.text = "1990: Bi-Weekly Pay: $" + biweeklySalary1990;
            jobPayWaiter2020Text.text = "2020: Bi-Weekly Pay: $" + biweeklySalary2020;

            //Sets Available Housing
            livingWithParentsButton.SetActive(true);
            livingWithRoommatesButton.SetActive(true);
            basicApartmentButton.SetActive(true);
            luxuryApartmentButton.SetActive(false);
            basicHouseButton.SetActive(false);
            luxuryHouseButton.SetActive(false);
        }
        else if (cashier == true)
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
            unknownJobScreen.SetActive(false);
            doctorScreen.SetActive(false);
            lawyerScreen.SetActive(false);

            jobSelected = "Cashier";
            jobNow = 2;

            //Setting Pay
            switch (educationNow)
            {
                case 1:
                    biweeklySalary1990 = 320.00; //4.00
                    biweeklySalary2020 = 684.80; //8.56
                    break;
                case 2:
                    biweeklySalary1990 = 360.00; //4.50
                    biweeklySalary2020 = 720.00; //9.00
                    break;
                case 3:
                    biweeklySalary1990 = 400.00; //5.00
                    biweeklySalary2020 = 760.00; //9.50
                    break;
                case 4:
                    biweeklySalary1990 = 440.00; //5.50
                    biweeklySalary2020 = 800.00; //10.00
                    break;
                case 5:
                    biweeklySalary1990 = 480.00; //6.00
                    biweeklySalary2020 = 840.00; //10.50
                    break;
            }

            jobPayCashier1990Text.text = "1990: Bi-Weekly Pay: $" + biweeklySalary1990;
            jobPayCashier2020Text.text = "2020: Bi-Weekly Pay: $" + biweeklySalary2020;

            //Sets Available Housing
            livingWithParentsButton.SetActive(true);
            livingWithRoommatesButton.SetActive(true);
            basicApartmentButton.SetActive(true);
            luxuryApartmentButton.SetActive(false);
            basicHouseButton.SetActive(false);
            luxuryHouseButton.SetActive(false);
        }
        else if (fryCook == true)
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
            unknownJobScreen.SetActive(false);
            doctorScreen.SetActive(false);
            lawyerScreen.SetActive(false);

            jobSelected = "Fry Cook";
            jobNow = 3;

            //Setting Pay
            switch (educationNow)
            {
                case 1:
                    biweeklySalary1990 = 320.00; // 4.00
                    biweeklySalary2020 = 684.80; // 8.56
                    break;
                case 2:
                    biweeklySalary1990 = 400.00; // 5.00
                    biweeklySalary2020 = 760.00; // 9.50
                    break;
                case 3:
                    biweeklySalary1990 = 480.00; // 6.00
                    biweeklySalary2020 = 840.00; // 10.50
                    break;
                case 4:
                    biweeklySalary1990 = 560.00; // 7.00
                    biweeklySalary2020 = 920.00; // 11.50
                    break;
                case 5:
                    biweeklySalary1990 = 640.00; // 8.00
                    biweeklySalary2020 = 1000.00; // 12.50
                    break;
            }

            jobPayFryCook1990Text.text = "1990: Bi-Weekly Pay: $" + biweeklySalary1990;
            jobPayFryCook2020Text.text = "2020: Bi-Weekly Pay: $" + biweeklySalary2020;

            //Sets Available Housing
            livingWithParentsButton.SetActive(true);
            livingWithRoommatesButton.SetActive(true);
            basicApartmentButton.SetActive(true);
            luxuryApartmentButton.SetActive(false);
            basicHouseButton.SetActive(false);
            luxuryHouseButton.SetActive(false);
        }
        else if (customerServiceAgent == true)
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
            unknownJobScreen.SetActive(false);
            doctorScreen.SetActive(false);
            lawyerScreen.SetActive(false);

            jobSelected = "Call Center Agent";
            jobNow = 4;

            //Setting Pay
            switch (educationNow)
            {
                case 1:
                    biweeklySalary1990 = 320.00; // 4.00
                    biweeklySalary2020 = 684.80; // 8.56
                    break;
                case 2:
                    biweeklySalary1990 = 420.00; // 5.25
                    biweeklySalary2020 = 780.00; // 9.75
                    break;
                case 3:
                    biweeklySalary1990 = 520.00; // 6.50
                    biweeklySalary2020 = 880.00; // 11.00
                    break;
                case 4:
                    biweeklySalary1990 = 620.00; // 7.75
                    biweeklySalary2020 = 980.00; // 12.25
                    break;
                case 5:
                    biweeklySalary1990 = 720.00; // 9.00
                    biweeklySalary2020 = 1080.00; // 13.50
                    break;
            }

            jobPayCSA1990Text.text = "1990: Bi-Weekly Pay: $" + biweeklySalary1990;
            jobPayCSA2020Text.text = "2020: Bi-Weekly Pay: $" + biweeklySalary2020;

            //Sets Available Housing
            livingWithParentsButton.SetActive(true);
            livingWithRoommatesButton.SetActive(true);
            basicApartmentButton.SetActive(true);
            luxuryApartmentButton.SetActive(false);
            basicHouseButton.SetActive(true);
            luxuryHouseButton.SetActive(false);
        }
        else if (teacher == true)
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
            unknownJobScreen.SetActive(false);
            doctorScreen.SetActive(false);
            lawyerScreen.SetActive(false);

            jobSelected = "Teacher";
            jobNow = 5;

            //Setting Pay
            switch (educationNow)
            {
                case 1:
                    biweeklySalary1990 = 0.00;
                    biweeklySalary2020 = 0.00;
                    break;
                case 2:
                    biweeklySalary1990 = 0.00;
                    biweeklySalary2020 = 0.00;
                    break;
                case 3:
                    biweeklySalary1990 = 800.00; // 10.00
                    biweeklySalary2020 = 1200.00; // 15.00
                    break;
                case 4:
                    biweeklySalary1990 = 960.00; // 12.00
                    biweeklySalary2020 = 1600.00; // 20.00
                    break;
                case 5:
                    biweeklySalary1990 = 1200.00; // 15.00
                    biweeklySalary2020 = 2000.00; // 25.00
                    break;
            }

            jobPayTeacher1990Text.text = "1990: Bi-Weekly Pay: $" + biweeklySalary1990;
            jobPayTeacher2020Text.text = "2020: Bi-Weekly Pay: $" + biweeklySalary2020;

            //Sets Available Housing
            livingWithParentsButton.SetActive(true);
            livingWithRoommatesButton.SetActive(true);
            basicApartmentButton.SetActive(true);
            luxuryApartmentButton.SetActive(true);
            basicHouseButton.SetActive(true);
            luxuryHouseButton.SetActive(true);
        }
        else if (licensedSalesAgent == true)
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
            unknownJobScreen.SetActive(false);
            doctorScreen.SetActive(false);
            lawyerScreen.SetActive(false);

            jobSelected = "Licensed Sales Agent";
            jobNow = 6;

            //Setting Pay
            switch (educationNow)
            {
                case 1:
                    biweeklySalary1990 = 0.00;
                    biweeklySalary2020 = 0.00;
                    break;
                case 2:
                    biweeklySalary1990 = 800.00; // 10.00
                    biweeklySalary2020 = 1200.00; // 15.00
                    break;
                case 3:
                    biweeklySalary1990 = 1000.00; // 12.50
                    biweeklySalary2020 = 1440.00; // 18.00
                    break;
                case 4:
                    biweeklySalary1990 = 1200.00; // 15.00
                    biweeklySalary2020 = 1680.00; // 21.00
                    break;
                case 5:
                    biweeklySalary1990 = 1400.00; // 17.50
                    biweeklySalary2020 = 1920.00; // 24.00
                    break;
            }

            jobPayLSA1990Text.text = "1990: Bi-Weekly Pay: $" + biweeklySalary1990;
            jobPayLSA2020Text.text = "2020: Bi-Weekly Pay: $" + biweeklySalary2020;

            //Sets Available Housing
            livingWithParentsButton.SetActive(true);
            livingWithRoommatesButton.SetActive(true);
            basicApartmentButton.SetActive(true);
            luxuryApartmentButton.SetActive(true);
            basicHouseButton.SetActive(true);
            luxuryHouseButton.SetActive(true);
        }
        else if (programmer == true)
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
            unknownJobScreen.SetActive(false);
            doctorScreen.SetActive(false);
            lawyerScreen.SetActive(false);

            jobSelected = "Programmer";
            jobNow = 7;

            //Setting Pay
            switch (educationNow)
            {
                case 1:
                    biweeklySalary1990 = 0.00;
                    biweeklySalary2020 = 0.00;
                    break;
                case 2:
                    biweeklySalary1990 = 960.00; // 12.00
                    biweeklySalary2020 = 1200.00; // 15.00
                    break;
                case 3:
                    biweeklySalary1990 = 1200.00; // 15.00
                    biweeklySalary2020 = 1600.00; // 20.00
                    break;
                case 4:
                    biweeklySalary1990 = 1440.00; // 18.00
                    biweeklySalary2020 = 2000.00; // 25.00
                    break;
                case 5:
                    biweeklySalary1990 = 1680.00; // 21.00
                    biweeklySalary2020 = 2400.00; // 30.00
                    break;
            }

            jobPayProgrammer1990Text.text = "1990: Bi-Weekly Pay: $" + biweeklySalary1990;
            jobPayProgrammer2020Text.text = "2020: Bi-Weekly Pay: $" + biweeklySalary2020;

            //Sets Available Housing
            livingWithParentsButton.SetActive(true);
            livingWithRoommatesButton.SetActive(true);
            basicApartmentButton.SetActive(true);
            luxuryApartmentButton.SetActive(true);
            basicHouseButton.SetActive(true);
            luxuryHouseButton.SetActive(true);
        }
        else if (unknownJob == true)
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
            unknownJobScreen.SetActive(true);
            doctorScreen.SetActive(false);
            lawyerScreen.SetActive(false);

            jobSelected = "Unknown Job";
            jobNow = 8;

            //Setting Pay
            switch (educationNow)
            {
                case 1:
                    biweeklySalary1990 = 0.00;
                    biweeklySalary2020 = 0.00;
                    break;
                case 2:
                    biweeklySalary1990 = 0.00;
                    biweeklySalary2020 = 0.00;
                    break;
                case 3:
                    biweeklySalary1990 = 0.00;
                    biweeklySalary2020 = 0.00;
                    break;
                case 4:
                    biweeklySalary1990 = 0.00;
                    biweeklySalary2020 = 0.00;
                    break;
                case 5:
                    biweeklySalary1990 = 2000.00; // 25.00
                    biweeklySalary2020 = 2800.00; // 35.00
                    break;
            }

            jobPayUnknownJob1990Text.text = "1990: Bi-Weekly Pay: $" + biweeklySalary1990;
            jobPayUnknownJob2020Text.text = "2020: Bi-Weekly Pay: $" + biweeklySalary2020;

            //Sets Available Housing
            livingWithParentsButton.SetActive(true);
            livingWithRoommatesButton.SetActive(true);
            basicApartmentButton.SetActive(true);
            luxuryApartmentButton.SetActive(true);
            basicHouseButton.SetActive(true);
            luxuryHouseButton.SetActive(true);
        }
        else if (doctor == true)
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
            unknownJobScreen.SetActive(false);
            doctorScreen.SetActive(true);
            lawyerScreen.SetActive(false);

            jobSelected = "Doctor";
            jobNow = 9;

            //Setting Pay
            switch (educationNow)
            {
                case 1:
                    biweeklySalary1990 = 0.00;
                    biweeklySalary2020 = 0.00;
                    break;
                case 2:
                    biweeklySalary1990 = 0.00;
                    biweeklySalary2020 = 0.00;
                    break;
                case 3:
                    biweeklySalary1990 = 0.00;
                    biweeklySalary2020 = 0.00;
                    break;
                case 4:
                    biweeklySalary1990 = 0.00;
                    biweeklySalary2020 = 0.00;
                    break;
                case 5:
                    biweeklySalary1990 = 2800.00; // 35.00
                    biweeklySalary2020 = 4000.00; // 50.00
                    break;
            }

            jobPayDoctor1990Text.text = "1990: Bi-Weekly Pay: $" + biweeklySalary1990;
            jobPayDoctor2020Text.text = "2020: Bi-Weekly Pay: $" + biweeklySalary2020;

            //Sets Available Housing
            livingWithParentsButton.SetActive(true);
            livingWithRoommatesButton.SetActive(true);
            basicApartmentButton.SetActive(true);
            luxuryApartmentButton.SetActive(true);
            basicHouseButton.SetActive(true);
            luxuryHouseButton.SetActive(true);
        }
        else if (lawyer == true)
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
            unknownJobScreen.SetActive(false);
            doctorScreen.SetActive(false);
            lawyerScreen.SetActive(true);

            jobSelected = "Lawyer";
            jobNow = 10;

            //Setting Pay
            switch (educationNow)
            {
                case 1:
                    biweeklySalary1990 = 0.00;
                    biweeklySalary2020 = 0.00;
                    break;
                case 2:
                    biweeklySalary1990 = 0.00;
                    biweeklySalary2020 = 0.00;
                    break;
                case 3:
                    biweeklySalary1990 = 0.00;
                    biweeklySalary2020 = 0.00;
                    break;
                case 4:
                    biweeklySalary1990 = 0.00;
                    biweeklySalary2020 = 0.00;
                    break;
                case 5:
                    biweeklySalary1990 = 2200.00;
                    biweeklySalary2020 = 3000.00;
                    break;
            }

            jobPayLawyer1990Text.text = "1990: Bi-Weekly Pay: $" + biweeklySalary1990;
            jobPayLawyer2020Text.text = "2020: Bi-Weekly Pay: $" + biweeklySalary2020;

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
        waiter = true;
        ChooseJob();
    }

    public void ChooseJobCashier()
    {
        cashier = true;
        ChooseJob();
    }

    public void ChooseJobFryCook()
    {
        fryCook = true;
        ChooseJob();
    }

    public void ChooseJobCustomerServiceAgent()
    {
        customerServiceAgent = true;
        ChooseJob();
    }

    public void ChooseJobTeacher()
    {
        teacher = true;
        ChooseJob();
    }

    public void ChooseJobLicensedSalesAgent()
    {
        licensedSalesAgent = true;
        ChooseJob();
    }

    public void ChooseJobProgrammer()
    {
        programmer = true;
        ChooseJob();
    }

    public void ChooseJobUnknown()
    {
        unknownJob = true;
        ChooseJob();
    }

    public void ChooseJobDoctor()
    {
        doctor = true;
        ChooseJob();
    }

    public void ChooseJobLawyer()
    {
        lawyer = true;
        ChooseJob();
    }



    //Selecting Housing
    public void ChooseHousing()
    {
        if (livingWithParents == true)
        {
            //Changing Panel View
            housingScreen.SetActive(false);
            livingWithParentsScreen.SetActive(true);
            livingWithRoommatesScreen.SetActive(false);
            basicApartmentScreen.SetActive(false);
            luxuryApartmentScreen.SetActive(false);
            basicHouseScreen.SetActive(false);
            luxuryHouseScreen.SetActive(false);

            housingSelected = "Living With Parents";
            houseNow = 1;
        }
        else if (livingWithRoommates == true)
        {
            //Changing Panel View
            housingScreen.SetActive(false);
            livingWithParentsScreen.SetActive(false);
            livingWithRoommatesScreen.SetActive(true);
            basicApartmentScreen.SetActive(false);
            luxuryApartmentScreen.SetActive(false);
            basicHouseScreen.SetActive(false);
            luxuryHouseScreen.SetActive(false);

            housingSelected = "Living With Rommates";
            houseNow = 2;
        }
        else if (basicApartment == true)
        {
            //Changing Panel View
            housingScreen.SetActive(false);
            livingWithParentsScreen.SetActive(false);
            livingWithRoommatesScreen.SetActive(false);
            basicApartmentScreen.SetActive(true);
            luxuryApartmentScreen.SetActive(false);
            basicHouseScreen.SetActive(false);
            luxuryHouseScreen.SetActive(false);

            housingSelected = "Basic Apartment";
            houseNow = 3;
        }
        else if (luxuryApartment == true)
        {
            //Changing Panel View
            housingScreen.SetActive(false);
            livingWithParentsScreen.SetActive(false);
            livingWithRoommatesScreen.SetActive(false);
            basicApartmentScreen.SetActive(false);
            luxuryApartmentScreen.SetActive(true);
            basicHouseScreen.SetActive(false);
            luxuryHouseScreen.SetActive(false);

            housingSelected = "Luxury Apartment";
            houseNow = 4;
        }
        else if (basicHouse == true)
        {
            //Changing Panel View
            housingScreen.SetActive(false);
            livingWithParentsScreen.SetActive(false);
            livingWithRoommatesScreen.SetActive(false);
            basicApartmentScreen.SetActive(false);
            luxuryApartmentScreen.SetActive(false);
            basicHouseScreen.SetActive(true);
            luxuryHouseScreen.SetActive(false);

            housingSelected = "Basic House";
            houseNow = 5;
        }
        else if (luxuryHouse == true)
        {
            //Changing Panel View
            housingScreen.SetActive(false);
            livingWithParentsScreen.SetActive(false);
            livingWithRoommatesScreen.SetActive(false);
            basicApartmentScreen.SetActive(false);
            luxuryApartmentScreen.SetActive(false);
            basicHouseScreen.SetActive(false);
            luxuryHouseScreen.SetActive(true);

            housingSelected = "Luxury House";
            houseNow = 6;
        }

        switch (houseNow)
        {
            case 1:
                rentCost1990 = Random.Range(0, 300);
                rentCost2020 = Random.Range(0, 500);
                housingCostLWP1990Text.text = "Your monthly Housing Cost will be: $" + rentCost1990 + "!";
                housingCostLWP2020Text.text = "Your monthly Housing Cost will be: $" + rentCost2020 + "!";
                break;
            case 2:
                rentCost1990 = 300.00;
                rentCost2020 = 500.00;
                housingCostLWR1990Text.text = "Your monthly Housing Cost will be: $" + rentCost1990 + "!";
                housingCostLWR2020Text.text = "Your monthly Housing Cost will be: $" + rentCost2020 + "!";
                break;
            case 3:
                rentCost1990 = 500.00;
                rentCost2020 = 800.00;
                housingCostBA1990Text.text = "Your monthly Housing Cost will be: $" + rentCost1990 + "!";
                housingCostBA2020Text.text = "Your monthly Housing Cost will be: $" + rentCost2020 + "!";
                break;
            case 4:
                rentCost1990 = 900.00;
                rentCost2020 = 1600.00;
                housingCostLA1990Text.text = "Your monthly Housing Cost will be: $" + rentCost1990 + "!";
                housingCostLA2020Text.text = "Your monthly Housing Cost will be: $" + rentCost2020 + "!";
                break;
            case 5:
                mortgageCost1990 = 1000.00;
                mortgageCost2020 = 1400.00;
                housingCostBH1990Text.text = "Your monthly Housing Cost will be: $" + mortgageCost1990 + "!";
                housingCostBH2020Text.text = "Your monthly Housing Cost will be: $" + mortgageCost2020 + "!";
                break;
            case 6:
                mortgageCost1990 = 1400.00;
                mortgageCost2020 = 2000.00;
                housingCostLH1990Text.text = "Your monthly Housing Cost will be: $" + mortgageCost1990 + "!";
                housingCostLH2020Text.text = "Your monthly Housing Cost will be: $" + mortgageCost2020 + "!";
                break;
        }
    }
    
    public void ChooseHousingLivingWithParents()
    {
        livingWithParents = true;
        ChooseHousing();
    }
    public void ChooseHousingLivingWithRoommates()
    {
        livingWithRoommates = true;
        ChooseHousing();
    }

    public void ChooseHousingBasicApartment()
    {
        basicApartment = true;
        ChooseHousing();
    }

    public void ChooseHousingLuxuryApartment()
    {
        luxuryApartment = true;
        ChooseHousing();
    }

    public void ChooseHousingBasicHouse()
    {
        basicHouse = true;
        ChooseHousing();
    }

    public void ChooseHousingLuxuryHouse()
    {
        luxuryHouse = true;
        ChooseHousing();
    }


    //Selecting Utilities
    public void ChooseUtilitiesElectric()
    {
        utilityElectric = true;

        utilityElectric1990Selected = "Electricity";
        utilityElectric2020Selected = "Electricity";

        //utilityElectricCost1990 = Random.Range(50, 200);
        //utilityElectricCost2020 = Random.Range(100, 300);

        //utilitiesCost1990 += utilityElectricCost1990;
        //utilitiesCost2020 += utilityElectricCost2020;

        utilitiesElectricScreen.SetActive(true);
        utilitiesElectricButton.SetActive(false);
        utilitiesScreen.SetActive(false);
    }

    public void ChooseUtilitiesWater()
    {
        utilityWater = true;

        utilityWater1990Selected = "Water";
        utilityWater2020Selected = "Water";

        //utilityWaterCost1990 = Random.Range(15, 40);
        //utilityWaterCost2020 = Random.Range(25, 50);

        //utilitiesCost1990 += utilityWaterCost1990;
        //utilitiesCost2020 += utilityWaterCost2020;

        utilitiesWaterScreen.SetActive(true);
        utilitiesWaterButton.SetActive(false);
        utilitiesScreen.SetActive(false);
    }

    public void ChooseUtilitiesCommunications()
    {
        utilitiesCommunicationsScreen.SetActive(true);

        utilitiesCommunicationsButton.SetActive(false);
        utilitiesScreen.SetActive(false);
    }

    public void ChooseUtilitiesCommunicationsHousePhone1990()
    {
        utilityCommunications1990 = true;
        housePhone1990 = true;

        utilityCommunications1990Selected = "House Phone";

        utilityCommunicationsCost1990 = 15.00;

        utilityCommunicationsHPCost1990Text.text = "Your monthly bill will be: $" + utilityCommunicationsCost1990 + "!";

        utilitiesCost1990 += utilityCommunicationsCost1990;

        housePhone1990Screen.SetActive(true);
        utilitiesCommunicationsScreen.SetActive(false);
        basicCellPhone1990Button.SetActive(false);

        BackFromCommunications();
    }

    public void ChooseUtilitiesCommunicationsHousePhone2020()
    {
        utilityCommunications2020 = true;
        housePhone2020 = true;

        utilityCommunications2020Selected = "House Phone";

        utilityCommunicationsCost2020 = 30.00;

        utilityCommunicationsHPCost2020Text.text = "Your monthly bill will be: $" + utilityCommunicationsCost2020 + "!";

        utilitiesCost2020 += utilityCommunicationsCost2020;

        housePhone2020Screen.SetActive(true);
        utilitiesCommunicationsScreen.SetActive(false);
        basicCellPhone2020Button.SetActive(false);
        unlimitedCellPhone2020Button.SetActive(false);

        BackFromCommunications();
    }

    public void ChooseUtilitiesCommunicationsBasicCellPhone1990()
    {
        utilityCommunications1990 = true;
        basicCellPhone1990 = true;

        utilityCommunications1990Selected = "Basic Cell Phone";

        utilityCommunicationsCost1990 = 30.00;

        utilityCommunicationsBCPCost1990Text.text = "Your monthly bill will be: $" + utilityCommunicationsCost1990 + "!";

        utilitiesCost1990 += utilityCommunicationsCost1990;

        basicCellPhone1990Screen.SetActive(true);
        utilitiesCommunicationsScreen.SetActive(false);
        housePhone1990Button.SetActive(false);

        BackFromCommunications();
    }

    public void ChooseUtilitiesCommunicationsBasicCellPhone2020()
    {
        utilityCommunications2020 = true;
        basicCellPhone2020 = true;

        utilityCommunications2020Selected = "Basic Cell Phone";

        utilityCommunicationsCost2020 = 50.00;

        utilityCommunicationsBCPCost2020Text.text = "Your monthly bill will be: $" + utilityCommunicationsCost2020 + "!";

        utilitiesCost2020 += utilityCommunicationsCost2020;

        basicCellPhone2020Screen.SetActive(true);
        utilitiesCommunicationsScreen.SetActive(false);
        housePhone2020Button.SetActive(false);
        unlimitedCellPhone2020Button.SetActive(false);

        BackFromCommunications();
    }

    public void ChooseUtilitiesCommunicationsUnlimitedCellPhone2020()
    {
        utilityCommunications2020 = true;
        unlimitedCellPhone2020 = true;

        utilityCommunications2020Selected = "Unlimited Cell Phone";

        utilityCommunicationsCost2020 = 80.00;

        utilityCommunicationsUCPCost2020Text.text = "Your monthly bill will be: $" + utilityCommunicationsCost2020 + "!";

        utilitiesCost2020 += utilityCommunicationsCost2020;

        unlimitedCellPhone2020Screen.SetActive(true);
        utilitiesCommunicationsScreen.SetActive(false);
        housePhone2020Button.SetActive(false);
        basicCellPhone2020Button.SetActive(false);

        BackFromCommunications();
    }

    public void ChooseUtilitiesEntertainment()
    {
        utilitiesEntertainmentScreen.SetActive(true);

        utilitiesEntertainmentButton.SetActive(false);
        utilitiesScreen.SetActive(false);
    }

    public void ChooseUtilitiesEntertainmentBasicCable1990()
    {
        utilityEntertainment1990 = true;
        basicCable1990 = true;

        utilityEntertainment1990Selected = "Basic Cable";

        utilityEntertainmentCost1990 = 20.00;

        utilityEntertainmentBCCost1990Text.text = "Your monthly bill will be: $" + utilityEntertainmentCost1990 + "!";

        utilitiesCost1990 += utilityEntertainmentCost1990;

        basicCable1990Screen.SetActive(true);
        utilitiesEntertainmentScreen.SetActive(false);
        premiumCable1990Button.SetActive(false);

        BackFromEntertainment();
    }

    public void ChooseUtilitiesEntertainmentBasicCable2020()
    {
        utilityEntertainment2020 = true;
        basicCable2020 = true;

        utilityEntertainment2020Selected = "Basic Cable";

        utilityEntertainmentCost2020 = 40.00;

        utilityEntertainmentBCCost2020Text.text = "Your monthly bill will be: $" + utilityEntertainmentCost2020 + "!";

        utilitiesCost2020 += utilityEntertainmentCost2020;

        basicCable2020Screen.SetActive(true);
        utilitiesEntertainmentScreen.SetActive(false);
        premiumCable2020Button.SetActive(false);
        streamingService2020Button.SetActive(false);

        BackFromEntertainment();
    }

    public void ChooseUtilitiesEntertainmentPremiumCable1990()
    {
        utilityEntertainment1990 = true;
        premiumCable1990 = true;

        utilityEntertainment1990Selected = "Premium Cable";

        utilityEntertainmentCost1990 = 40.00;

        utilityEntertainmentPCCost1990Text.text = "Your monthly bill will be: $" + utilityEntertainmentCost1990 + "!";

        utilitiesCost1990 += utilityEntertainmentCost1990;

        premiumCable1990Screen.SetActive(true);
        utilitiesEntertainmentScreen.SetActive(false);
        basicCable1990Button.SetActive(false);

        BackFromEntertainment();
    }

    public void ChooseUtilitiesEntertainmentPremiumCable2020()
    {
        utilityEntertainment2020 = true;
        premiumCable2020 = true;

        utilityEntertainment2020Selected = "Premium Cable";

        utilityEntertainmentCost2020 = 80.00;

        utilityEntertainmentPCCost2020Text.text = "Your monthly bill will be: $" + utilityEntertainmentCost2020 + "!";

        utilitiesCost2020 += utilityEntertainmentCost2020;

        premiumCable2020Screen.SetActive(true);
        utilitiesEntertainmentScreen.SetActive(false);
        basicCable2020Button.SetActive(false);
        streamingService2020Button.SetActive(false);

        BackFromEntertainment();
    }

    public void ChooseUtilitiesEntertainmentStreamingService()
    {
        utilityEntertainment2020 = true;
        streamingService2020 = true;

        utilityEntertainment2020Selected = "Streaming Service";

        utilityEntertainmentCost2020 = 60.00;

        utilityEntertainmentSSCost2020Text.text = "Your monthly bill will be: $" + utilityEntertainmentCost2020 + "!";

        utilitiesCost2020 += utilityEntertainmentCost2020;

        streamingService2020Screen.SetActive(true);
        utilitiesEntertainmentScreen.SetActive(false);
        basicCable2020Button.SetActive(false);
        premiumCable2020Button.SetActive(false);

        BackFromEntertainment();
    }

    public void ChooseUtilitiesInternet()
    {
        utilitiesInternetScreen.SetActive(true);

        utilitiesInternetButton.SetActive(false);
        utilitiesScreen.SetActive(false);
    }

    public void ChooseUtilitiesInternet50MB()
    {
        utilityInternet2020 = true;
        mb50Internet = true;

        utilityInternet2020Selected = "50MB/s Internet";

        utilityInternetCost2020 = 20.00;

        utilityInternet50Cost2020Text.text = "Your monthly bill will be: $" + utilityInternetCost2020 + "!";

        utilitiesCost2020 += utilityInternetCost2020;

        mb50Internet2020Screen.SetActive(true);
        utilitiesInternetScreen.SetActive(false);
        mb100Internet2020Button.SetActive(false);
        mb200Internet2020Button.SetActive(false);

        BackFromInternet();
    }

    public void ChooseUtilitiesInternet100MB()
    {
        utilityInternet2020 = true;
        mb100Internet = true;

        utilityInternet2020Selected = "100MB/s Internet";

        utilityInternetCost2020 = 40.00;

        utilityInternet100Cost2020Text.text = "Your monthly bill will be: $" + utilityInternetCost2020 + "!";

        utilitiesCost2020 += utilityInternetCost2020;

        mb100Internet2020Screen.SetActive(true);
        utilitiesInternetScreen.SetActive(false);
        mb50Internet2020Button.SetActive(false);
        mb200Internet2020Button.SetActive(false);

        BackFromInternet();
    }

    public void ChooseUtilitiesInternet200MB()
    {
        utilityInternet2020 = true;
        mb200Internet = true;

        utilityInternet2020Selected = "200MB/s Internet";

        utilityInternetCost2020 = 70.00;

        utilityInternet200Cost2020Text.text = "Your monthly bill will be: $" + utilityInternetCost2020 + "!";

        utilitiesCost2020 += utilityInternetCost2020;

        mb200Internet2020Screen.SetActive(true);
        utilitiesInternetScreen.SetActive(false);
        mb50Internet2020Button.SetActive(false);
        mb100Internet2020Button.SetActive(false);

        BackFromInternet();
    }

    //Returning From Utilities
    public void FromGeneralUtilities()
    {
        utilitiesElectricScreen.SetActive(false);
        utilitiesWaterScreen.SetActive(false);
        utilitiesCommunicationsScreen.SetActive(false);
        utilitiesEntertainmentScreen.SetActive(false);
        utilitiesInternetScreen.SetActive(false);

        utilitiesSelected ++;

        utilitiesScreen.SetActive(true);

        if (utilitiesSelected >= 5)
        {
            toTransportationScreenButton.SetActive(true);
        }
    }

    public void FromCommunicationsUtilities()
    {
        housePhone1990Screen.SetActive(false);
        housePhone2020Screen.SetActive(false);
        basicCellPhone1990Screen.SetActive(false);
        basicCellPhone2020Screen.SetActive(false);
        unlimitedCellPhone2020Screen.SetActive(false);

        utilitiesCommunicationsScreen.SetActive(true);
    }

    public void FromEntertainmentUtilities()
    {
        basicCable1990Screen.SetActive(false);
        basicCable2020Screen.SetActive(false);
        premiumCable1990Screen.SetActive(false);
        premiumCable2020Screen.SetActive(false);
        streamingService2020Screen.SetActive(false);

        utilitiesEntertainmentScreen.SetActive(true);
    }

    public void FromInternetUtilities()
    {
        mb50Internet2020Screen.SetActive(false);
        mb100Internet2020Screen.SetActive(false);
        mb200Internet2020Screen.SetActive(false);

        utilitiesInternetScreen.SetActive(true);
    }



    //Selecting Transportation
    public void ChooseTransportation()
    {
        if (bicycle == true)
        {
            transportationScreen.SetActive(false);
            bicycleScreen.SetActive(true);
            usedCarScreen.SetActive(false);
            newCarScreen.SetActive(false);
            motorcycleScreen.SetActive(false);
            busScreen.SetActive(false);
            trainScreen.SetActive(false);

            transportationSelected = "Bicycle";
            payTransportationTitleText1.text = "Pay Transportation: Bicycle";
            payTransportationTitleText2.text = "Pay Transportation: Bicycle";
            travelNow = 1;

            payTransportationDescriptionText.text = "Having a Bicycle may not be as nice as having a car, but at least the maintinance is cheap.";
        }
        else if (usedCar == true)
        {
            transportationScreen.SetActive(false);
            bicycleScreen.SetActive(false);
            usedCarScreen.SetActive(true);
            newCarScreen.SetActive(false);
            motorcycleScreen.SetActive(false);
            busScreen.SetActive(false);
            trainScreen.SetActive(false);

            transportationSelected = "Used Car";
            payTransportationTitleText1.text = "Pay Transportation: Used Car";
            payTransportationTitleText2.text = "Pay Transportation: Used Car";

            travelNow = 2;

            payTransportationDescriptionText.text = "???";
        }
        else if (newCar == true)
        {
            transportationScreen.SetActive(false);
            bicycleScreen.SetActive(false);
            usedCarScreen.SetActive(false);
            newCarScreen.SetActive(true);
            motorcycleScreen.SetActive(false);
            busScreen.SetActive(false);
            trainScreen.SetActive(false);

            transportationSelected = "New Car";
            payTransportationTitleText1.text = "Pay Transportation: New Car";
            payTransportationTitleText2.text = "Pay Transportation: New Car";

            travelNow = 3;

            payTransportationDescriptionText.text = "???";
        }
        else if (motorcycle == true)
        {
            transportationScreen.SetActive(false);
            bicycleScreen.SetActive(false);
            usedCarScreen.SetActive(false);
            newCarScreen.SetActive(false);
            motorcycleScreen.SetActive(true);
            busScreen.SetActive(false);
            trainScreen.SetActive(false);

            transportationSelected = "Motorcycle";
            payTransportationTitleText1.text = "Pay Transportation: Motorcycle";
            payTransportationTitleText2.text = "Pay Transportation: Motorcycle";

            travelNow = 4;

            payTransportationDescriptionText.text = "???";
        }
        else if (bus == true)
        {
            transportationScreen.SetActive(false);
            bicycleScreen.SetActive(false);
            usedCarScreen.SetActive(false);
            newCarScreen.SetActive(false);
            motorcycleScreen.SetActive(false);
            busScreen.SetActive(true);
            trainScreen.SetActive(false);

            transportationSelected = "City Bus Transit";
            payTransportationTitleText1.text = "Pay Transportation: City Bus Transit";
            payTransportationTitleText2.text = "Pay Transportation: City Bus Transit";

            travelNow = 5;

            payTransportationDescriptionText.text = "???";
        }
        if (train == true)
        {
            transportationScreen.SetActive(false);
            bicycleScreen.SetActive(false);
            usedCarScreen.SetActive(false);
            newCarScreen.SetActive(false);
            motorcycleScreen.SetActive(false);
            busScreen.SetActive(false);
            trainScreen.SetActive(true);

            transportationSelected = "Train Transit";
            payTransportationTitleText1.text = "Pay Transportation: Train Transit";
            payTransportationTitleText2.text = "Pay Transportation: Train Transit";

            travelNow = 6;

            payTransportationDescriptionText.text = "???";
        }

        switch (travelNow)
        {
            case 1:
                //weekB1990 = airPump1990 * 5; // 2.00 air, 5 day/week
                //weekB2020 = airPump2020 * 5; // 3.00 air, 5 day/week
                //transportationCost1990 = weekB1990; // 2.00 air, 5 day/week
                //transportationCost2020 = weekB2020; // 3.00 air, 5 day/week

                //transportationCost1990 = airPump1990 * 5; // 2.00 air, 5 day/week
                //transportationCost2020 = airPump2020 * 5; // 3.00 air, 5 day/week

                transportationCost1990 = 10.00; // 2.00 air, 5 day/week
                transportationCost2020 = 15.00; // 3.00 air, 5 day/week
                transportationBCost1990Text.text = "Your weekly cost will be: $" + transportationCost1990 + "!";
                transportationBCost2020Text.text = "Your weekly cost will be: $" + transportationCost2020 + "!";
                break;
            case 2:
                //weekUC1990 = gasCost1990 * 10; // 10 gal, 1.15 gas
                //weekUC2020 = gasCost2020 * 10; // 10 gal, 2.50 gas
                //transportationCost1990 = weekUC1990; // 10 gal, 1.15 gas
                //transportationCost2020 = weekUC2020; // 10 gal, 2.50 gas

                //transportationCost1990 = gasCost1990 * 10; // 10 gal, 1.15 gas
                //transportationCost2020 = gasCost2020 * 10; // 10 gal, 2.50 gas

                transportationCost1990 = 11.50; // 10 gal, 1.15 gas
                transportationCost2020 = 25.00; // 10 gal, 2.50 gas
                transportationUCCost1990Text.text = "Your weekly cost will be: $" + transportationCost1990 + "!";
                transportationUCCost2020Text.text = "Your weekly cost will be: $" + transportationCost2020 + "!";
                break;
            case 3:
                //weekNC1990 = gasCost1990 * 15; // 15 gal, 1.15 gas
                //weekNC2020 = gasCost2020 * 15; // 15 gal, 2.50 gas
                //transportationCost1990 = weekNC1990; // 15 gal, 1.15 gas
                //transportationCost2020 = weekNC2020; // 15 gal, 2.50 gas

                //transportationCost1990 = gasCost1990 * 15; // 15 gal, 1.15 gas
                //transportationCost2020 = gasCost2020 * 15; // 15 gal, 2.50 gas

                transportationCost1990 = 17.25; // 15 gal, 1.15 gas
                transportationCost2020 = 37.50; // 15 gal, 2.50 gas
                transportationNCCost1990Text.text = "Your weekly cost will be: $" + transportationCost1990 + "!";
                transportationNCCost2020Text.text = "Your weekly cost will be: $" + transportationCost2020 + "!";
                break;
            case 4:
                //weekM1990 = gasCost1990 * 4; // 4 gal, 1.15 gas 
                //weekM2020 = gasCost2020 * 4; // 4 gal, 2.50 gas
                //transportationCost1990 = weekM1990; // 4 gal, 1.15 gas
                //transportationCost2020 = weekM2020; // 4 gal, 2.50 gas

                //transportationCost1990 = gasCost1990 * 4; // 4 gal, 1.15 gas
                //transportationCost2020 = gasCost2020 * 4; // 4 gal, 2.50 gas

                transportationCost1990 = 4.60; // 4 gal, 1.15 gas
                transportationCost2020 = 10.00; // 4 gal,2.50 gas
                transportationMCost1990Text.text = "Your weekly cost will be: $" + transportationCost1990 + "!";
                transportationMCost2020Text.text = "Your weekly cost will be: $" + transportationCost2020 + "!";
                break;
            case 5:
                //weekBusFare1990 = busFare1990 * 5; // 2.00/day, 5 day/week
                //weekBusFare2020 = busFare2020 * 5; // 4.50/day, 5 day/week
                //transportationCost1990 = weekBusFare1990; // 2.00/day, 5 day/week
                //transportationCost2020 = weekBusFare2020; // 4.50/day, 5 day/week

                //transportationCost1990 = busFare1990 * 5; // 2.00/day, 5 day/week
                //transportationCost2020 = busFare2020 * 5; // 4.50/day, 5 day/week

                transportationCost1990 = 10.00; // 2.00/day, 5 day/week
                transportationCost2020 = 22.50; // 4.50/day,5 day/week
                transportationBusCost1990Text.text = "Your weekly cost will be: $" + transportationCost1990 + "!";
                transportationBusCost2020Text.text = "Your weekly cost will be: $" + transportationCost2020 + "!";
                break;
            case 6:
                //weekTrainFare1990 = trainFare1990 * 5; // 1.50/day, 5 day/week
                //weekTrainFare2020 = trainFare2020 * 5; // 4.00/day, 5 day/week
                //transportationCost1990 = weekTrainFare1990; // 1.50/day, 5 day/week
                //transportationCost2020 = weekTrainFare2020; // 4.00/day, 5 day/week

                //transportationCost1990 = (trainFare1990 * 5); // 1.50/day, 5 day/week
                //transportationCost2020 = (trainFare2020 * 5); // 4.00/day, 5 day/week

                transportationCost1990 = 7.50; // 1.50/day, 5 day/week
                transportationCost2020 = 20.00; // 4.00/day, 5 day/week
                transportationTCost1990Text.text = "Your weekly cost will be: $" + transportationCost1990 + "!";
                transportationTCost2020Text.text = "Your weekly cost will be: $" + transportationCost2020 + "!";
                break;
        }
    }

    public void ChooseTransportationBucycle()
    {
        bicycle = true;
        ChooseTransportation();
    }
    
    public void ChooseTransportationUsedCar()
    {
        usedCar = true;
        ChooseTransportation();
    }

    public void ChooseTransportationNewCar()
    {
        newCar = true;
        ChooseTransportation();
    }

    public void ChooseTransportationMotorcycle()
    {
        motorcycle = true;
        ChooseTransportation();
    }

    public void ChooseTransportationBus()
    {
        bus = true;
        ChooseTransportation();
    }

    public void ChooseTransportationTrain()
    {
        train = true;
        ChooseTransportation();
    }

    
    //Select Gift Money
    public void ChooseGift()
    {
        giftMoneyScreen1.SetActive(false);
        giftMoneyScreen2.SetActive(true);

        giftMoney = Random.Range(0, 1000);
        giftMoneyText.text = "Gift: $" + giftMoney;
        currentMoney1990 += giftMoney;
        currentMoney2020 += giftMoney;

        weekMoneyObtained1990 += giftMoney;
        weekMoneyObtained2020 += giftMoney;
    }



    //Move to Gender Selection Screen
    public void ToGenderScreen()
    {
        welcomeScreen.SetActive(false);

        genderScreen.SetActive(true);
    }
    
    //Move to Race Selection Screen
    public void ToRaceScreen()
    {
        genderScreen.SetActive(false);
        maleScreen.SetActive(false);
        femaleScreen.SetActive(false);
        otherGenderScreen.SetActive(false);

        raceScreen.SetActive(true);
    }
    
    
    //Move to Education Selection Screen
    public void ToEducationScreen()
    {
        raceScreen.SetActive(false);
        europeanDescentScreen.SetActive(false);
        africanDescentScreen.SetActive(false);
        nativeAmericanDescentScreen.SetActive(false);
        hispanicDescentScreen.SetActive(false);
        asianDescentScreen.SetActive(false);
        otherDescentScreen.SetActive(false);

        educationScreen.SetActive(true);
    }
    
    //Move to Job Selection Screen
    public void ToJobScreen()
    {
        educationScreen.SetActive(false);
        educationScreenNoDegree.SetActive(false);
        educationScreenHSDiploma.SetActive(false);
        educationScreenBachelorsDegree.SetActive(false);
        educationScreenMastersDegree.SetActive(false);
        educationScreenAdvancedDegree.SetActive(false);

        jobScreen.SetActive(true);
    }

    //Move to Housing Selection Screen
    public void ToHousingScreen()
    {
        jobScreen.SetActive(false);
        waiterScreen.SetActive(false);
        cashierScreen.SetActive(false);
        fryCookScreen.SetActive(false);
        customerServiceAgentScreen.SetActive(false);
        teacherScreen.SetActive(false);
        licensedSalesAgentScreen.SetActive(false);
        programmerScreen.SetActive(false);
        unknownJobScreen.SetActive(false);
        doctorScreen.SetActive(false);
        lawyerScreen.SetActive(false);

        housingScreen.SetActive(true);
    }

    //Move to Utility Selection Screen
    public void ToUtilitiesScreen()
    {
        housingScreen.SetActive(false);
        livingWithParentsScreen.SetActive(false);
        livingWithRoommatesScreen.SetActive(false);
        basicApartmentScreen.SetActive(false);
        luxuryApartmentScreen.SetActive(false);
        basicHouseScreen.SetActive(false);
        luxuryHouseScreen.SetActive(false);

        utilitiesScreen.SetActive(true);
    }

    public void BackFromCommunications()
    {
        if (utilityCommunications1990 == true && utilityCommunications2020 == true)
        {
            backFromCommunicationsButton.SetActive(true);
        }
    }

    public void BackFromEntertainment()
    {
        if (utilityEntertainment1990 == true && utilityEntertainment2020 == true)
        {
            backFromEntertainmentButton.SetActive(true);
        }
    }

    public void BackFromInternet()
    {
        if (utilityInternet2020 == true)
        {
            backFromInternetButton.SetActive(true);
        }
    }
    
    //Move to Transportation Selection Screen
    public void ToTransportationScreen()
    {
        utilitiesScreen.SetActive(false);
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
        
        transportationScreen.SetActive(true);
    }

    //Move to Gift Selection Screen
    public void ToGiftScreen()
    {
        transportationScreen.SetActive(false);
        usedCarScreen.SetActive(false);
        newCarScreen.SetActive(false);
        motorcycleScreen.SetActive(false);
        busScreen.SetActive(false);
        trainScreen.SetActive(false);

        giftMoneyScreen1.SetActive(true);
    }

    //Introduction Functions - Summary
    public void ToIntroSummaryScreen()
    {
        giftMoneyScreen2.SetActive(false);

        introSummaryScreen.SetActive(true);
    }
    public void ToIntroSummaryScreen1990()
    {
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
        summaryJobPay1990Text.text = " - Bi-Weekly Salary: $" + biweeklySalary1990;
        summaryHousing1990Text.text = "Housing Status: " + housingSelected;
        if (basicHouse == false && luxuryHouse == false)
        {
            summaryHousingRent1990Text.text = " - Monthly Rent: $" + rentCost1990;
        }
        else if (basicHouse == true || luxuryHouse == true)
        {
            summaryHousingRent1990Text.text = " - Monthly Mortgage: $" + mortgageCost1990;
        }
        summaryUtilities1990Text.text = "Utilities Selected: " + utilityCommunications1990Selected + ", " + utilityEntertainment1990Selected;
        summaryUtilitiesCost1990Text.text = " - Monthly Utilities: $" + utilitiesCost1990;
        summaryTransportation1990Text.text = "Transportation Status: " + transportationSelected;
        summaryTransportationCost1990Text.text = " - Weekly Transportation Cost: $" + transportationCost1990;
        summaryGift1990Text.text = "Gift Received: $" + giftMoney;
        summaryCurrentMoney1990Text.text = "Current Money: $" + currentMoney1990;
    }
    public void ToIntroSummaryScreen2020()
    {
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
        summaryJobPay2020Text.text = " - Bi-Weekly Salary: $" + biweeklySalary2020;
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
        introSummaryScreen.SetActive(true);

        introSummary1990Screen.SetActive(false);
        introSummary2020Screen.SetActive(false);
    }





    //Move to Simulation
    public void ToMainSimulation()
    {
        simulationSection.SetActive(true);
        mainSimulationScreen.SetActive(true);

        introSummaryScreen.SetActive(false);
        introductionSection.SetActive(false);

        m1++;
        m2++;
        m3++;
        m4++;
        m5++;
        m6++;
        m7++;
        m8++;
        m9++;
        m10++;
        m11++;
        m12++;

        // rentPaid1990 = 0.00;
        // rentPaid2020 = 0.00;
        // utilitiesPaid1990 = 0.00;
        // utilitiesPaid2020 = 0.00;
        // groceryPaid1990 = 0.00;
        // groceryPaid2020 = 0.00;
        // transportationPaid1990 = 0.00;
        // transportationPaid2020 = 0.00;

        MainSimulationIteration1();
        MainSimulationStatus();        
        //SceneManager.LoadScene(Week01);
    }

    public void ToStartScreen()
    {
        simulationSection.SetActive(true);
        simulationStartScreen.SetActive(true);

        introSummaryScreen.SetActive(false);
        introductionSection.SetActive(false);
    }



    //Simulation Functions
    //Simulation Functions - Start
    public void StartSimulation()
    {
        simulationStartScreen.SetActive(false);

        mainSimulationScreen.SetActive(true);

        m1++;
        m2++;
        m3++;
        m4++;
        m5++;
        m6++;
        m7++;
        m8++;
        m9++;
        m10++;
        m11++;
        m12++;

        // rentPaid1990 = 0.00;
        // rentPaid2020 = 0.00;
        // utilitiesPaid1990 = 0.00;
        // utilitiesPaid2020 = 0.00;
        // groceryPaid1990 = 0.00;
        // groceryPaid2020 = 0.00;
        // transportationPaid1990 = 0.00;
        // transportationPaid2020 = 0.00;

        // toWeekSummaryButton.SetActive(false);
        // groceryComplete = false;
        // transportationComplete = false;
        // payTransportationButton.SetActive(true);

        MainSimulationIteration1();
        MainSimulationStatus();

        // if (m1 == 1 || m1 == 3 || m2 == 1 || m2 == 3 || m3 == 1 || m3 == 3 || m4 == 1 || m4 == 3 || m5 == 1 || m5 == 3 || m6 == 1 || m6 == 3 || m7 == 1 || m7 == 3 || m8 == 1 || m8 == 3 || m9 == 1 || m9 == 3 || m10 == 1 || m10 == 3 || m11 == 1 || m11 == 3 || m12 == 1 || m12 == 3)
        // {
        //     payDayButton.SetActive(true);
        // }
        // else
        // {
        //     payDayButton.SetActive(false);
        // }

        // if (m1 == 1 || m2 == 1 || m3 == 1 || m4 == 1 || m5 == 1 || m6 == 1 || m7 == 1 || m8 == 1 || m9 == 1 || m10 == 1 || m11 == 1 || m12 == 1)
        // {
        //     selectPayRentButton.SetActive(true);

        //     selectPayUtilitiesElectricityButton.SetActive(true);
        //     selectPayUtilitiesWaterButton.SetActive(true);
        //     selectPayUtilitiesCommunicationsButton.SetActive(true);
        //     selectPayUtilitiesEntertainmentButton.SetActive(true);
        //     selectPayUtilitiesInternetButton.SetActive(true);
        // }
    }
    //Simulation Functions - Pause Menu
    public void ToPauseSimulation()
    {
        pauseMenuScreen.SetActive(true);
    }
    public void ToResumeSimulation()
    {
        pauseMenuScreen.SetActive(false);
    }
    public void ToQuitSimulation()
    {
        //SceneManager.LoadScene(MainMenu);
    }

    //Simulation Functions - Player Stats
    public void ToPlayerStats1990()
    {
        playerStats1990Screen.SetActive(true);
        PlayerStats1990();
    }
    public void PlayerStats1990()
    {
        playerStats1990GenderText.text = "Gender: " + genderSelected;
        playerStats1990RaceText.text = "Race: " + raceSelected;
        playerStats1990EmploymentText.text = "Employment: " + jobSelected;
        playerStats1990HousingText.text = "Housing: " + housingSelected;
        playerStats1990TransportationText.text = "Transportation: " + transportationSelected;
    }
    public void ToPlayerStats2020()
    {
        playerStats2020Screen.SetActive(true);
        PlayerStats2020();
    }
    public void PlayerStats2020()
    {
        playerStats2020GenderText.text = "Gender: " + genderSelected;
        playerStats2020RaceText.text = "Race: " + raceSelected;
        playerStats2020EmploymentText.text = "Employment: " + jobSelected;
        playerStats2020HousingText.text = "Housing: " + housingSelected;
        playerStats2020TransportationText.text = "Transportation: " + transportationSelected;
    }
    public void BackToSimulation()
    {
        playerStats1990Screen.SetActive(false);
        playerStats2020Screen.SetActive(false);
    }

    //Simulation Functions - Main Iteration
    public void MainSimulationIteration()
    {
        for (i = 1; i < 4; i++)
        {
            //Establishing & Resetting Variables Each Month
            switch (i)
            {
                case 1:
                    monthTitle = "Month 01";
                    monthTitleText.text = monthTitle;

                    rentDue = true;
                    utilitiesDue = true;
                    electricityDue = true;
                    waterDue = true;
                    communicationsDue = true;
                    entertainmentDue = true;
                    internetDue = true;

                    break;
                case 2:
                    monthNumber =2;
                    monthTitle = "Month 02";
                    monthTitleText.text = monthTitle;

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

                    rentDue = true;
                    utilitiesDue = true;
                    electricityDue = true;
                    waterDue = true;
                    communicationsDue = true;
                    entertainmentDue = true;
                    internetDue = true;

                    break;
                case 4:
                    monthNumber = 4;
                    monthTitle = "Month 04";
                    monthTitleText.text = monthTitle;

                    rentDue = true;
                    utilitiesDue = true;
                    electricityDue = true;
                    waterDue = true;
                    communicationsDue = true;
                    entertainmentDue = true;
                    internetDue = true;

                    break;
                case 5:
                    monthNumber = 5;
                    monthTitle = "Month 05";
                    monthTitleText.text = monthTitle;

                    rentDue = true;
                    utilitiesDue = true;
                    electricityDue = true;
                    waterDue = true;
                    communicationsDue = true;
                    entertainmentDue = true;
                    internetDue = true;

                    break;
                case 6:
                    monthNumber =6;
                    monthTitle = "Month 06";
                    monthTitleText.text = monthTitle;

                    rentDue = true;
                    utilitiesDue = true;
                    electricityDue = true;
                    waterDue = true;
                    communicationsDue = true;
                    entertainmentDue = true;
                    internetDue = true;

                    break;
                case 7:
                    monthNumber = 7;
                    monthTitle = "Month 07";
                    monthTitleText.text = monthTitle;

                    rentDue = true;
                    utilitiesDue = true;
                    electricityDue = true;
                    waterDue = true;
                    communicationsDue = true;
                    entertainmentDue = true;
                    internetDue = true;

                    break;
                case 8:
                    monthNumber = 8;
                    monthTitle = "Month 08";
                    monthTitleText.text = monthTitle;

                    rentDue = true;
                    utilitiesDue = true;
                    electricityDue = true;
                    waterDue = true;
                    communicationsDue = true;
                    entertainmentDue = true;
                    internetDue = true;

                    break;
                case 9:
                    monthNumber = 9;
                    monthTitle = "Month 09";
                    monthTitleText.text = monthTitle;

                    rentDue = true;
                    utilitiesDue = true;
                    electricityDue = true;
                    waterDue = true;
                    communicationsDue = true;
                    entertainmentDue = true;
                    internetDue = true;

                    break;
                case 10:
                    monthNumber = 10;
                    monthTitle = "Month 10";
                    monthTitleText.text = monthTitle;

                    rentDue = true;
                    utilitiesDue = true;
                    electricityDue = true;
                    waterDue = true;
                    communicationsDue = true;
                    entertainmentDue = true;
                    internetDue = true;

                    break;
                case 11:
                    monthNumber = 11;
                    monthTitle = "Month 11";
                    monthTitleText.text = monthTitle;

                    rentDue = true;
                    utilitiesDue = true;
                    electricityDue = true;
                    waterDue = true;
                    communicationsDue = true;
                    entertainmentDue = true;
                    internetDue = true;

                    break;
                case 12:
                    monthNumber = 12;
                    monthTitle = "Month 12";
                    monthTitleText.text = monthTitle;

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

            for (j = 0; j < 5; j++)
            {
                //Establishing & Resetting Variables Each Week
                switch (j)
                {
                    case 1:
                        weekTitle = "Week 01";
                        weekTitleText.text = weekTitle;

                        payDayNow = true;
                        groceriesDue = true;
                        transportationDue = true;

                        break;
                    case 2:
                        weekTitle = "Week 02";
                        weekTitleText.text = weekTitle;

                        payDayNow = false;
                        groceriesDue = true;
                        transportationDue = true;
                        
                        break;
                    case 3:
                        weekTitle = "Week 03";
                        weekTitleText.text = weekTitle;
                        
                        payDayNow = true;
                        groceriesDue = true;
                        transportationDue = true;

                        toPayDayButton.SetActive(true);

                        break;
                    case 4:
                        weekTitle = "Week 04";
                        weekTitleText.text = weekTitle;

                        payDayNow = false;
                        groceriesDue = true;
                        transportationDue = true;

                        break;
                }

                weekNumber = j;
            }
        }
    }
    public void MainSimulationIteration1()
    {
        //Establishing & Resetting Variables Each Month
            switch (m)
            {
                case 1:
                    monthNumber = 1;
                    monthTitle = "Month 01";
                    monthTitleText.text = monthTitle;
                    monthSummaryTitleText.text = "Month 01 Summary";

                    rentDue = true;
                    utilitiesDue = true;
                    electricityDue = true;
                    waterDue = true;
                    communicationsDue = true;
                    entertainmentDue = true;
                    internetDue = true;

                    //Establishing & Resetting Variables Each Week
                    switch (m1)
                    {
                        case 1:
                            weekTitle = "Week 01";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = "Month 01 - Week 01 Summary";

                            payDayNow = true;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;

                            toWeekSummaryButton.SetActive(false);
                            toPayDayButton.SetActive(true);
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
                            weekTitle = "Week 02";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = "Month 01 - Week 02 Summary";

                            payDayNow = false;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;

                            toWeekSummaryButton.SetActive(false);
                            toPayDayButton.SetActive(false);
                            toPayHousingButton.SetActive(false);
                            //toPayUtilitiesButton.SetActive(true);
                            toPayGroceriesButton.SetActive(true);
                            toPayTransportationButton.SetActive(true);
                            
                            break;
                        case 3:
                            weekTitle = "Week 03";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = "Month 01 - Week 03 Summary";
                            
                            payDayNow = true;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;

                            toWeekSummaryButton.SetActive(false);
                            toPayDayButton.SetActive(true);
                            toPayHousingButton.SetActive(false);
                            //toPayUtilitiesButton.SetActive(true);
                            toPayGroceriesButton.SetActive(true);
                            toPayTransportationButton.SetActive(true);

                            break;
                        case 4:
                            weekTitle = "Week 04";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = "Month 01 - Week 04 Summary";

                            payDayNow = false;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;

                            toWeekSummaryButton.SetActive(false);
                            toPayDayButton.SetActive(false);
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
                    monthSummaryTitleText.text = "Month 02 Summary";

                    rentDue = true;
                    utilitiesDue = true;
                    electricityDue = true;
                    waterDue = true;
                    communicationsDue = true;
                    entertainmentDue = true;
                    internetDue = true;

                    //Establishing & Resetting Variables Each Week
                    switch (m2)
                    {
                        case 1:
                            weekTitle = "Week 01";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = "Month 02 - Week 01 Summary";

                            payDayNow = true;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;

                            toWeekSummaryButton.SetActive(false);
                            toPayDayButton.SetActive(true);
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
                            weekTitle = "Week 02";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = "Month 02 - Week 02 Summary";

                            payDayNow = false;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;

                            toWeekSummaryButton.SetActive(false);
                            toPayDayButton.SetActive(false);
                            toPayHousingButton.SetActive(false);
                            //toPayUtilitiesButton.SetActive(true);
                            toPayGroceriesButton.SetActive(true);
                            toPayTransportationButton.SetActive(true);
                            
                            break;
                        case 3:
                            weekTitle = "Week 03";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = "Month 02 - Week 03 Summary";
                            
                            payDayNow = true;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;

                            toWeekSummaryButton.SetActive(false);
                            toPayDayButton.SetActive(true);
                            toPayHousingButton.SetActive(false);
                            //toPayUtilitiesButton.SetActive(true);
                            toPayGroceriesButton.SetActive(true);
                            toPayTransportationButton.SetActive(true);

                            break;
                        case 4:
                            weekTitle = "Week 04";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = "Month 02 - Week 04 Summary";

                            payDayNow = false;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;

                            toWeekSummaryButton.SetActive(false);
                            toPayDayButton.SetActive(false);
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
                    monthSummaryTitleText.text = "Month 03 Summary";

                    rentDue = true;
                    utilitiesDue = true;
                    electricityDue = true;
                    waterDue = true;
                    communicationsDue = true;
                    entertainmentDue = true;
                    internetDue = true;

                    //Establishing & Resetting Variables Each Week
                    switch (m3)
                    {
                        case 1:
                            weekTitle = "Week 01";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = "Month 03 - Week 01 Summary";

                            payDayNow = true;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;

                            toWeekSummaryButton.SetActive(false);
                            toPayDayButton.SetActive(true);
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
                            weekTitle = "Week 02";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = "Month 03 - Week 02 Summary";

                            payDayNow = false;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;

                            toWeekSummaryButton.SetActive(false);
                            toPayDayButton.SetActive(false);
                            toPayHousingButton.SetActive(false);
                            //toPayUtilitiesButton.SetActive(true);
                            toPayGroceriesButton.SetActive(true);
                            toPayTransportationButton.SetActive(true);
                            
                            break;
                        case 3:
                            weekTitle = "Week 03";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = "Month 03 - Week 03 Summary";
                            
                            payDayNow = true;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;

                            toWeekSummaryButton.SetActive(false);
                            toPayDayButton.SetActive(true);
                            toPayHousingButton.SetActive(false);
                            //toPayUtilitiesButton.SetActive(true);
                            toPayGroceriesButton.SetActive(true);
                            toPayTransportationButton.SetActive(true);

                            break;
                        case 4:
                            weekTitle = "Week 04";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = "Month 03 - Week 04 Summary";

                            payDayNow = false;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;
                            
                            toWeekSummaryButton.SetActive(false);
                            toPayDayButton.SetActive(false);
                            toPayHousingButton.SetActive(false);
                            //toPayUtilitiesButton.SetActive(true);
                            toPayGroceriesButton.SetActive(true);
                            toPayTransportationButton.SetActive(true);

                            break;
                    }

                    break;
                case 4:
                    monthNumber = 4;
                    monthTitle = "Month 04";
                    monthTitleText.text = monthTitle;
                    monthSummaryTitleText.text = "Month 04 Summary";

                    rentDue = true;
                    utilitiesDue = true;
                    electricityDue = true;
                    waterDue = true;
                    communicationsDue = true;
                    entertainmentDue = true;
                    internetDue = true;

                    //Establishing & Resetting Variables Each Week
                    switch (m4)
                    {
                        case 1:
                            weekTitle = "Week 01";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = "Month 04 - Week 01 Summary";

                            payDayNow = true;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;
                            
                            

                            toPayUtilitiesElectricityButton.SetActive(true);
                            toPayUtilitiesWaterButton.SetActive(true);
                            toPayUtilitiesCommunicationsButton.SetActive(true);
                            toPayUtilitiesEntertainmentButton.SetActive(true);
                            toPayUtilitiesInternetButton.SetActive(true);

                            break;
                        case 2:
                            weekTitle = "Week 02";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = "Month 04 - Week 02 Summary";

                            payDayNow = false;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;
                            
                            
                            
                            break;
                        case 3:
                            weekTitle = "Week 03";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = "Month 04 - Week 03 Summary";
                            
                            payDayNow = true;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;
                            
                            

                            break;
                        case 4:
                            weekTitle = "Week 04";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = "Month 04 - Week 04 Summary";

                            payDayNow = false;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;
                            
                            

                            break;
                    }

                    break;
                case 5:
                    monthNumber = 5;
                    monthTitle = "Month 05";
                    monthTitleText.text = monthTitle;
                    monthSummaryTitleText.text = "Month 05 Summary";

                    rentDue = true;
                    utilitiesDue = true;
                    electricityDue = true;
                    waterDue = true;
                    communicationsDue = true;
                    entertainmentDue = true;
                    internetDue = true;

                    //Establishing & Resetting Variables Each Week
                    switch (m5)
                    {
                        case 1:
                            weekTitle = "Week 01";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = "Month 05 - Week 01 Summary";

                            payDayNow = true;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;
                            
                            

                            toPayUtilitiesElectricityButton.SetActive(true);
                            toPayUtilitiesWaterButton.SetActive(true);
                            toPayUtilitiesCommunicationsButton.SetActive(true);
                            toPayUtilitiesEntertainmentButton.SetActive(true);
                            toPayUtilitiesInternetButton.SetActive(true);

                            break;
                        case 2:
                            weekTitle = "Week 02";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = "Month 05 - Week 02 Summary";

                            payDayNow = false;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;
                            
                            
                            
                            break;
                        case 3:
                            weekTitle = "Week 03";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = "Month 05 - Week 03 Summary";
                            
                            payDayNow = true;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;
                            
                            

                            break;
                        case 4:
                            weekTitle = "Week 04";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = "Month 05 - Week 04 Summary";

                            payDayNow = false;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;
                            
                            

                            break;
                    }

                    break;
                case 6:
                    monthNumber = 6;
                    monthTitle = "Month 06";
                    monthTitleText.text = monthTitle;
                    monthSummaryTitleText.text = "Month 06 Summary";

                    rentDue = true;
                    utilitiesDue = true;
                    electricityDue = true;
                    waterDue = true;
                    communicationsDue = true;
                    entertainmentDue = true;
                    internetDue = true;

                    //Establishing & Resetting Variables Each Week
                    switch (m6)
                    {
                        case 1:
                            weekTitle = "Week 01";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = "Month 06 - Week 01 Summary";

                            payDayNow = false;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;
                            
                            

                            toPayUtilitiesElectricityButton.SetActive(true);
                            toPayUtilitiesWaterButton.SetActive(true);
                            toPayUtilitiesCommunicationsButton.SetActive(true);
                            toPayUtilitiesEntertainmentButton.SetActive(true);
                            toPayUtilitiesInternetButton.SetActive(true);

                            break;
                        case 2:
                            weekTitle = "Week 02";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = "Month 06 - Week 02 Summary";

                            payDayNow = false;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;
                            
                            
                            
                            break;
                        case 3:
                            weekTitle = "Week 03";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = "Month 06 - Week 03 Summary";
                            
                            payDayNow = true;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;
                            
                            

                            break;
                        case 4:
                            weekTitle = "Week 04";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = "Month 06 - Week 04 Summary";

                            payDayNow = false;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;
                            
                            

                            break;
                    }

                    break;
                case 7:
                    monthNumber = 7;
                    monthTitle = "Month 07";
                    monthTitleText.text = monthTitle;
                    monthSummaryTitleText.text = "Month 07 Summary";

                    rentDue = true;
                    utilitiesDue = true;
                    electricityDue = true;
                    waterDue = true;
                    communicationsDue = true;
                    entertainmentDue = true;
                    internetDue = true;

                    //Establishing & Resetting Variables Each Week
                    switch (m7)
                    {
                        case 1:
                            weekTitle = "Week 01";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = "Month 07 - Week 01 Summary";

                            payDayNow = true;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;
                            
                            

                            toPayUtilitiesElectricityButton.SetActive(true);
                            toPayUtilitiesWaterButton.SetActive(true);
                            toPayUtilitiesCommunicationsButton.SetActive(true);
                            toPayUtilitiesEntertainmentButton.SetActive(true);
                            toPayUtilitiesInternetButton.SetActive(true);

                            break;
                        case 2:
                            weekTitle = "Week 02";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = "Month 07 - Week 02 Summary";

                            payDayNow = false;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;
                            
                            
                            
                            break;
                        case 3:
                            weekTitle = "Week 03";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = "Month 07 - Week 03 Summary";
                            
                            payDayNow = true;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;
                            
                            

                            break;
                        case 4:
                            weekTitle = "Week 04";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = "Month 07 - Week 04 Summary";

                            payDayNow = false;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;
                            
                            

                            break;
                    }

                    break;
                case 8:
                    monthNumber = 8;
                    monthTitle = "Month 08";
                    monthTitleText.text = monthTitle;
                    monthSummaryTitleText.text = "Month 08 Summary";

                    rentDue = true;
                    utilitiesDue = true;
                    electricityDue = true;
                    waterDue = true;
                    communicationsDue = true;
                    entertainmentDue = true;
                    internetDue = true;

                    //Establishing & Resetting Variables Each Week
                    switch (m8)
                    {
                        case 1:
                            weekTitle = "Week 01";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = "Month 08 - Week 01 Summary";

                            payDayNow = true;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;
                            
                            

                            toPayUtilitiesElectricityButton.SetActive(true);
                            toPayUtilitiesWaterButton.SetActive(true);
                            toPayUtilitiesCommunicationsButton.SetActive(true);
                            toPayUtilitiesEntertainmentButton.SetActive(true);
                            toPayUtilitiesInternetButton.SetActive(true);

                            break;
                        case 2:
                            weekTitle = "Week 02";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = "Month 08 - Week 02 Summary";

                            payDayNow = false;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;
                            
                            
                            
                            break;
                        case 3:
                            weekTitle = "Week 03";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = "Month 08 - Week 03 Summary";
                            
                            payDayNow = true;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;
                            
                            

                            break;
                        case 4:
                            weekTitle = "Week 04";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = "Month 08 - Week 04 Summary";

                            payDayNow = false;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;
                            
                            

                            break;
                    }

                    break;
                case 9:
                    monthNumber = 9;
                    monthTitle = "Month 09";
                    monthTitleText.text = monthTitle;
                    monthSummaryTitleText.text = "Month 09 Summary";

                    rentDue = true;
                    utilitiesDue = true;
                    electricityDue = true;
                    waterDue = true;
                    communicationsDue = true;
                    entertainmentDue = true;
                    internetDue = true;

                    //Establishing & Resetting Variables Each Week
                    switch (m9)
                    {
                        case 1:
                            weekTitle = "Week 01";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = "Month 09 - Week 01 Summary";

                            payDayNow = true;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;
                            
                            

                            toPayUtilitiesElectricityButton.SetActive(true);
                            toPayUtilitiesWaterButton.SetActive(true);
                            toPayUtilitiesCommunicationsButton.SetActive(true);
                            toPayUtilitiesEntertainmentButton.SetActive(true);
                            toPayUtilitiesInternetButton.SetActive(true);

                            break;
                        case 2:
                            weekTitle = "Week 02";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = "Month 09 - Week 02 Summary";

                            payDayNow = false;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;
                            
                            
                            
                            break;
                        case 3:
                            weekTitle = "Week 03";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = "Month 09 - Week 03 Summary";
                            
                            payDayNow = true;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;
                            
                            

                            break;
                        case 4:
                            weekTitle = "Week 04";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = "Month 09 - Week 04 Summary";

                            payDayNow = false;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;
                            
                            

                            break;
                    }

                    break;
                case 10:
                    monthNumber = 10;
                    monthTitle = "Month 10";
                    monthTitleText.text = monthTitle;
                    monthSummaryTitleText.text = "Month 10 Summary";

                    rentDue = true;
                    utilitiesDue = true;
                    electricityDue = true;
                    waterDue = true;
                    communicationsDue = true;
                    entertainmentDue = true;
                    internetDue = true;

                    //Establishing & Resetting Variables Each Week
                    switch (m10)
                    {
                        case 1:
                            weekTitle = "Week 01";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = "Month 10 - Week 01 Summary";

                            payDayNow = true;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;
                            
                            

                            toPayUtilitiesElectricityButton.SetActive(true);
                            toPayUtilitiesWaterButton.SetActive(true);
                            toPayUtilitiesCommunicationsButton.SetActive(true);
                            toPayUtilitiesEntertainmentButton.SetActive(true);
                            toPayUtilitiesInternetButton.SetActive(true);

                            break;
                        case 2:
                            weekTitle = "Week 02";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = "Month 10 - Week 02 Summary";

                            payDayNow = false;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;
                            
                            
                            
                            break;
                        case 3:
                            weekTitle = "Week 03";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = "Month 10 - Week 03 Summary";
                            
                            payDayNow = true;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;
                            
                            

                            break;
                        case 4:
                            weekTitle = "Week 04";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = "Month 10 - Week 04 Summary";

                            payDayNow = false;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;
                            
                            

                            break;
                    }

                    break;
                case 11:
                    monthNumber = 11;
                    monthTitle = "Month 11";
                    monthTitleText.text = monthTitle;
                    monthSummaryTitleText.text = "Month 11 Summary";

                    rentDue = true;
                    utilitiesDue = true;
                    electricityDue = true;
                    waterDue = true;
                    communicationsDue = true;
                    entertainmentDue = true;
                    internetDue = true;

                    //Establishing & Resetting Variables Each Week
                    switch (m11)
                    {
                        case 1:
                            weekTitle = "Week 01";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = "Month 11 - Week 01 Summary";

                            payDayNow = true;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;
                            
                            

                            toPayUtilitiesElectricityButton.SetActive(true);
                            toPayUtilitiesWaterButton.SetActive(true);
                            toPayUtilitiesCommunicationsButton.SetActive(true);
                            toPayUtilitiesEntertainmentButton.SetActive(true);
                            toPayUtilitiesInternetButton.SetActive(true);

                            break;
                        case 2:
                            weekTitle = "Week 02";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = "Month 11 - Week 02 Summary";

                            payDayNow = false;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;
                            
                            
                            
                            break;
                        case 3:
                            weekTitle = "Week 03";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = "Month 11 - Week 03 Summary";
                            
                            payDayNow = true;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;
                            
                            

                            break;
                        case 4:
                            weekTitle = "Week 04";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = "Month 11 - Week 04 Summary";

                            payDayNow = false;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;
                            
                            

                            break;
                    }

                    break;
                case 12:
                    monthNumber = 12;
                    monthTitle = "Month 12";
                    monthTitleText.text = monthTitle;
                    monthSummaryTitleText.text = "Month 12 Summary";

                    rentDue = true;
                    utilitiesDue = true;
                    electricityDue = true;
                    waterDue = true;
                    communicationsDue = true;
                    entertainmentDue = true;
                    internetDue = true;

                    //Establishing & Resetting Variables Each Week
                    switch (m12)
                    {
                        case 1:
                            weekTitle = "Week 01";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = "Month 12 - Week 01 Summary";

                            payDayNow = true;
                            //rentDue = true;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;
                            
                            

                            toPayUtilitiesElectricityButton.SetActive(true);
                            toPayUtilitiesWaterButton.SetActive(true);
                            toPayUtilitiesCommunicationsButton.SetActive(true);
                            toPayUtilitiesEntertainmentButton.SetActive(true);
                            toPayUtilitiesInternetButton.SetActive(true);

                            break;
                        case 2:
                            weekTitle = "Week 02";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = "Month 12 - Week 02 Summary";

                            payDayNow = false;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;
                            
                            
                            
                            break;
                        case 3:
                            weekTitle = "Week 03";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = "Month 12 - Week 03 Summary";
                            
                            payDayNow = true;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;
                            
                            

                            break;
                        case 4:
                            weekTitle = "Week 04";
                            weekTitleText.text = weekTitle;
                            weekSummaryTitleText.text = "Month 12 - Week 04 Summary";

                            payDayNow = false;
                            //rentDue = false;
                            //utilitiesDue = true;
                            groceriesDue = true;
                            transportationDue = true;
                            groceryComplete = false;
                            transportationComplete = false;
                            
                            toWeekSummaryButton.SetActive(false);
                            payTransportationButton.SetActive(true);
                            //payDayButton.SetActive(false);

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
        switch (randomEventCounter)
        {
            case 1:
                randomEventNumber = Random.Range(1, 5);
                RandomEvents2();
                break;
            case 2:
                randomEventNumber = Random.Range(1, 5);
                RandomEvents2();
                break;
            case 3:
                randomEventNumber = Random.Range(1, 5);
                RandomEvents2();
                break;
        }
    }
    public void RandomEvents2()
    {
        switch (randomEventNumber)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
        }
    }
    public void MainSimulationStatus()
    {
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
        payDayScreen1.SetActive(true);
    }
    public void ToPayHousing()
    {
        payRentScreen1.SetActive(true);
    }
    public void ToPayUtilities()
    {
        payUtilitiesScreen.SetActive(true);
    }
    public void ToPayUtilitiesElectricity()
    {
        payUtilitiesElectricityScreen.SetActive(true);

        payUtilitiesScreen.SetActive(false);
    }
    public void ToPayUtilitiesWater()
    {
        payUtilitiesWaterScreen.SetActive(true);

        payUtilitiesScreen.SetActive(false);
    }
    public void ToPayUtilitiesCommunications()
    {
        payUtilitiesCommunicationsScreen.SetActive(true);

        payUtilitiesScreen.SetActive(false);
    }
    public void ToPayUtilitiesEntertainment()
    {
        payUtilitiesEntertainmentScreen.SetActive(true);

        payUtilitiesScreen.SetActive(false);
    }
    public void ToPayUtilitiesInternet()
    {
        payUtilitiesInternetScreen.SetActive(true);

        payUtilitiesScreen.SetActive(false);
    }
    public void ToPayGroceries()
    {
        payGroceriesScreen.SetActive(true);
    }
    public void ToPayTransportation()
    {
        payTransportationScreen1.SetActive(true);
    }

    //Simulation Functions - Action Buttons
    public void CollectPayCheck()
    {
        payDayScreen1.SetActive(false);
        
        payDayScreen2.SetActive(true);

        payRecieved1990 = (biweeklySalary1990 * (1 - incomeTax1990));
        payRecieved2020 = (biweeklySalary2020 * (1 - incomeTax2020));

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
        payRentScreen2.SetActive(true);
        
        payRentScreen1.SetActive(false);
        //payHousingButton.SetActive(false);

        //payRent1990Text.SetActive(true);
        //payRent2020Text.SetActive(true);

        if (livingWithParents == true || livingWithRoommates == true || basicApartment == true || luxuryApartment == true)
        {
            rentPaid1990 = rentCost1990;
            rentPaid2020 = rentCost2020;
            
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
        payUtilitiesElectricity1990Button.SetActive(false);
        electricity1990PaidTextObject.SetActive(true);

        utilityElectricPaid1990 = Random.Range(50, 200);

        electricity1990PaidText.text = "Electricity Paid: $" + utilityElectricPaid1990;

        currentMoney1990 -= utilityElectricPaid1990;

        utilitiesPaid1990 += utilityElectricPaid1990;
        electricity1990Paid = true;
    }
    public void PayUtilitiesElectricity2020()
    {
        payUtilitiesElectricity2020Button.SetActive(false);
        electricity2020PaidTextObject.SetActive(true);

        utilityElectricPaid2020 = Random.Range(100, 300);

        electricity2020PaidText.text = "Electricity Paid: $" + utilityElectricPaid2020;

        currentMoney2020 -= utilityElectricPaid2020;

        utilitiesPaid2020 += utilityElectricPaid2020;
        electricity2020Paid = true;
    }
    public void PayUtilitiesWater1990()
    {
        payUtilitiesWater1990Button.SetActive(false);
        water1990PaidTextObject.SetActive(true);

        utilityWaterPaid1990 = Random.Range(10, 35);

        water1990PaidText.text = "Water Paid: $" + utilityWaterPaid1990;

        currentMoney1990 -= utilityWaterPaid1990;

        utilitiesPaid1990 += utilityWaterPaid1990;
        water1990Paid = true;
    }
    public void PayUtilitiesWater2020()
    {
        payUtilitiesWater2020Button.SetActive(false);
        water2020PaidTextObject.SetActive(true);

        utilityWaterPaid2020 = Random.Range(15, 50);

        water2020PaidText.text = "Water Paid: $" + utilityWaterPaid2020;

        currentMoney2020 -= utilityWaterPaid2020;

        utilitiesPaid2020 += utilityWaterPaid2020;
        water2020Paid = true;
    }
    public void PayUtilitiesCommunications1990()
    {
        payUtilitiesCommunications1990Button.SetActive(false);
        communications1990PaidTextObject.SetActive(true);

        utilityCommunicationsPaid1990 = utilityCommunicationsCost1990;

        communications1990PaidText.text = "Communication Paid: $" + utilityCommunicationsPaid1990;

        currentMoney1990 -= utilityCommunicationsPaid1990;

        utilitiesPaid1990 += utilityCommunicationsPaid1990;
        communications1990Paid = true;  
    }
    public void PayUtilitiesCommunications2020()
    {
        payUtilitiesCommunications2020Button.SetActive(false);
        communications2020PaidTextObject.SetActive(true);

        utilityCommunicationsPaid2020 = utilityCommunicationsCost2020;

        communications2020PaidText.text = "Communication Paid: $" + utilityCommunicationsPaid2020;

        currentMoney2020 -= utilityCommunicationsPaid2020;

        utilitiesPaid2020 += utilityCommunicationsPaid2020;
        communications2020Paid = true;  
    }
    public void PayUtilitiesEntertainment1990()
    {
        payUtilitiesEntertainment1990Button.SetActive(false);
        entertainment1990PaidTextObject.SetActive(true);

        utilityEntertainmentPaid1990 = utilityEntertainmentCost1990;

        entertainment1990PaidText.text = "Entertainment Paid: $" + utilityEntertainmentPaid1990;

        currentMoney1990 -= utilityEntertainmentPaid1990;

        utilitiesPaid1990 += utilityEntertainmentPaid1990;
        entertainment1990Paid = true;
    }
    public void PayUtilitiesEntertainment2020()
    {
        payUtilitiesEntertainment2020Button.SetActive(false);
        entertainment2020PaidTextObject.SetActive(true);

        utilityEntertainmentPaid2020 = utilityEntertainmentCost2020;

        entertainment2020PaidText.text = "Entertainment Paid: $" + utilityEntertainmentPaid2020;

        currentMoney2020 -= utilityEntertainmentPaid2020;

        utilitiesPaid2020 += utilityEntertainmentPaid2020;
        entertainment2020Paid = true;
    }
    public void PayUtilitiesInternet1990()
    {
        payUtilitiesInternet1990Button.SetActive(false);
        internet1990PaidTextObject.SetActive(true);

        utilityInternetPaid1990 = utilityInternetCost1990;

        internet1990PaidText.text = "Internet Paid: $" + utilityInternetPaid1990;

        currentMoney2020 -= utilityInternetPaid1990;

        utilitiesPaid1990 += utilityInternetPaid1990;
        internet1990Paid = true;
    }
    public void PayUtilitiesInternet2020()
    {
        payUtilitiesInternet2020Button.SetActive(false);
        internet2020PaidTextObject.SetActive(true);

        utilityInternetPaid2020 = utilityInternetCost2020;

        internet2020PaidText.text = "Internet Paid: $" + utilityInternetPaid2020;

        currentMoney2020 -= utilityInternetPaid2020;
        
        utilitiesPaid2020 += utilityInternetPaid2020;

        internet2020Paid = true;
    }
    public void PayGroceriesFastFood()
    {
        payGroceriesFastFoodScreen.SetActive(true);

        groceryCost1990 = 40.00;
        groceryCost2020 = 60.00;

        groceryPaid1990 = groceryCost1990;
        groceryPaid2020 = groceryCost2020;

        fastFood1990PaidText.text = "You paid $" + groceryPaid1990 + " for Fast Food this week!";
        fastFood2020PaidText.text = "You paid $" + groceryPaid2020 + " for Fast Food this week!";

        currentMoney1990 -= groceryPaid1990;
        currentMoney2020 -= groceryPaid2020;

        weekMoneyLoss1990 += groceryPaid1990;
        weekMoneyLoss2020 += groceryPaid2020;

        groceryComplete = true;
        
        payGroceriesScreen.SetActive(false);
        //payGroceriesFastFoodButton.SetActive(false);
        //payGroceriesCookingButton.SetActive(false);
        //payGroceriesEatingOutButton.SetActive(false);
    }
    public void PayGroceriesCooking()
    {
        payGroceriesCookingScreen.SetActive(true);

        groceryCost1990 = 70.00;
        groceryCost2020 = 100.00;

        groceryPaid1990 = groceryCost1990;
        groceryPaid2020 = groceryCost2020;

        cooking1990PaidText.text = "You paid $" + groceryPaid1990 + " for Cooking Food this week!";
        cooking2020PaidText.text = "You paid $" + groceryPaid2020 + " for Cooking Food this week!";

        currentMoney1990 -= groceryPaid1990;
        currentMoney2020 -= groceryPaid1990;

        weekMoneyLoss1990 += groceryPaid1990;
        weekMoneyLoss2020 += groceryPaid2020;

        groceryComplete = true;
        
        payGroceriesScreen.SetActive(false);
        //payGroceriesFastFoodButton.SetActive(false);
        //payGroceriesCookingButton.SetActive(false);
        //payGroceriesEatingOutButton.SetActive(false);
    }
    public void PayGroceriesEatingOut()
    {
        payGroceriesEatingOutScreen.SetActive(true);

        groceryCost1990 = 100.00;
        groceryCost2020 = 150.00;

        groceryPaid1990 = groceryCost1990;
        groceryPaid2020 = groceryCost2020;

        eatingOut1990PaidText.text = "You paid $" + groceryPaid1990 + " for Eating Out this week!";
        eatingOut2020PaidText.text = "You paid $" + groceryPaid2020 + " for Eating Out this week!";

        currentMoney1990 -= groceryPaid1990;
        currentMoney2020 -= groceryPaid2020;

        weekMoneyLoss1990 += groceryPaid1990;
        weekMoneyLoss2020 += groceryPaid2020;

        groceryComplete = true;
        
        payGroceriesScreen.SetActive(false);
        //payGroceriesFastFoodButton.SetActive(false);
        //payGroceriesCookingButton.SetActive(false);
        //payGroceriesEatingOutButton.SetActive(false);
    }
    public void PayTransportation()
    {
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
        randomEventScreen2.SetActive(false);
        randomEvent = false;
    }

    //Simulation Functions - Back Buttons
    public void BackFromPlayerStats()
    {
        playerStats1990Screen.SetActive(false);
        playerStats2020Screen.SetActive(false);
    }
    public void BackFromPayDay()
    {
        payDayScreen2.SetActive(false);

        MainSimulationStatus();
    }
    public void BackFromPayRent()
    {
        payRentScreen2.SetActive(false);

        MainSimulationStatus();

        rentDue = false;
        //randomEvent = true;
        randomEventCounter++;
        //RandomEvents1();

        toPayHousingButton.SetActive(false);

        if (housingComplete == true && utilitiesComplete == true && groceryComplete == true && transportationComplete == true)
        {
            toWeekSummaryButton.SetActive(true);
        }
    }
    public void BackFromPayUtilities()
    {
        payUtilitiesScreen.SetActive(false);

        MainSimulationStatus();

        if (m1 == 4 || m2 == 4 || m3 == 4 || m4 == 4 || m5 == 4 || m6 == 4 || m7 == 4 || m8 == 4 || m9 == 4 || m10 == 4 || m11 == 4 || m12 == 4)
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
        else if (m1 != 4 || m2 != 4 || m3 != 4 || m4 != 4 || m5 != 4 || m6 != 4 || m7 != 4 || m8 != 4 || m9 != 4 || m10 != 4 || m11 != 4 || m12 != 4)
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

        //randomEvent = true;
        randomEventCounter++;
        //RandomEvents1();

        toPayUtilitiesButton.SetActive(false);

        if (housingComplete == true && utilitiesComplete == true && groceryComplete == true && transportationComplete == true)
        {
            toWeekSummaryButton.SetActive(true);
        }

        //currentMoney1990 -= utilitiesPaid1990;
        //currentMoney2020 -= utilitiesPaid2020;

        weekMoneyLoss1990 += utilitiesPaid1990;
        weekMoneyLoss2020 += utilitiesPaid2020;
    }
    public void BackFromPayUtilitiesElectricity()
    {
        payUtilitiesElectricityScreen.SetActive(false);

        electricityComplete = true;

        payUtilitiesScreen.SetActive(true);
        toPayUtilitiesElectricityButton.SetActive(false);
    }
    public void BackFromPayUtilitiesWater()
    {
        payUtilitiesWaterScreen.SetActive(false);

        waterComplete = true;

        payUtilitiesScreen.SetActive(true);
        toPayUtilitiesWaterButton.SetActive(false);
    }
    public void BackFromPayUtilitiesCommunications()
    {
        payUtilitiesCommunicationsScreen.SetActive(false);

        communicationsComplete = true;

        payUtilitiesScreen.SetActive(true);
        toPayUtilitiesCommunicationsButton.SetActive(false);
    }
    public void BackFromPayUtilitiesEntertainment()
    {
        payUtilitiesEntertainmentScreen.SetActive(false);

        entertainmentComplete = true;

        payUtilitiesScreen.SetActive(true);
        toPayUtilitiesEntertainmentButton.SetActive(false);
    }
    public void BackFromPayUtilitiesInternet()
    {
        payUtilitiesInternetScreen.SetActive(false);

        internetComplete = true;

        payUtilitiesScreen.SetActive(true);
        toPayUtilitiesInternetButton.SetActive(false);
    }
    public void BackFromPayGroceries()
    {
        payGroceriesScreen.SetActive(false);
        payGroceriesFastFoodScreen.SetActive(false);
        payGroceriesCookingScreen.SetActive(false);
        payGroceriesEatingOutScreen.SetActive(false);

        MainSimulationStatus();

        //randomEvent = true;
        randomEventCounter++;
        RandomEvents1();

        toPayGroceriesButton.SetActive(false);

        if (housingComplete == true && utilitiesComplete == true && groceryComplete == true && transportationComplete == true)
        {
            toWeekSummaryButton.SetActive(true);
        }
    }
    public void BackFromPayTransportation()
    {
        payTransportationScreen2.SetActive(false);

        MainSimulationStatus();

        //randomEvent = true;
        randomEventCounter++;
        //RandomEvents1();

        toPayTransportationButton.SetActive(false);

        if (housingComplete == true && utilitiesComplete == true && groceryComplete == true && transportationComplete == true)
        {
            toWeekSummaryButton.SetActive(true);
        }
    }
    
    //The Final Summary
    //The Final Summary - Week Summary
    public void ToWeekSummary()
    {
        summarySection.SetActive(true);
        weekSummaryScreen.SetActive(true);

        mainSimulationScreen.SetActive(false);
        simulationSection.SetActive(false);

        WeekSummary();
    }
    public void WeekSummary()
    {
        //Shows Weekly Money Gained and Loss
        weekSummaryMoneyObtained1990Text.text = "Money Obtained: $" + weekMoneyObtained1990;
        weekSummaryMoneyObtained2020Text.text = "Money Obtained: $" + weekMoneyObtained2020;
        weekSummaryMoneyLoss1990Text.text = "Money Loss: $" + weekMoneyLoss1990;
        weekSummaryMoneyLoss2020Text.text = "Money Loss: $" + weekMoneyLoss2020;

        //Calculates Weekly Money Remaining
        weekMoneyRemaining1990 = weekMoneyObtained1990 - weekMoneyLoss1990;
        weekMoneyRemaining2020 = weekMoneyObtained2020 - weekMoneyLoss2020;

        //Shows Weekly Money Recieved
        weekSummaryMoneyRemaining1990Text.text = "Money Remaining: $" + weekMoneyRemaining1990;
        weekSummaryMoneyRemaining2020Text.text = "Money Remaining: $" + weekMoneyRemaining2020;

        //Adds Week Monetary Values to Month Monetary Values
        monthMoneyObtained1990 += weekMoneyObtained1990;
        monthMoneyObtained2020 += weekMoneyObtained2020;
        monthMoneyLoss1990 += weekMoneyLoss1990;
        monthMoneyLoss2020 += weekMoneyLoss2020;

        //Makes the Month Summary Section Available every 4 Weeks
        if (m1 == 4 || m2 == 4 || m3 == 4 || m4 == 4 || m5 == 5 || m6 == 6 || m7 == 7 || m8 == 8 || m9 == 9 || m10 == 10 || m11 == 11 || m12 == 12)
        {
            continueSimulationFromWeekButton.SetActive(false);
            toMonthSummaryButton.SetActive(true);
        }
    }
    public void ToWeekSummary1990()
    {
        weekSummary1990Screen.SetActive(true);
        WeekSummary1990();

        weekSummaryScreen.SetActive(false);
    }
    public void WeekSummary1990()
    {

    }
    public void ToWeekSummary2020()
    {
        weekSummary2020Screen.SetActive(true);
        WeekSummary2020();

        weekSummaryScreen.SetActive(false);
    }
    public void WeekSummary2020()
    {

    }
    public void BackToWeekSummary()
    {
        weekSummaryScreen.SetActive(true);

        weekSummary1990Screen.SetActive(false);
        weekSummary2020Screen.SetActive(false);
    }
    public void ToNextWeek()
    {
        // //Resets Week Monetary Collection Values
        // weekMoneyObtained1990 = 0.00;
        // weekMoneyObtained2020 = 0.00;
        // weekMoneyLoss1990 = 0.00;
        // weekMoneyLoss2020 = 0.00;
        // weekMoneyRemaining1990 = 0.00;
        // weekMoneyRemaining2020 = 0.00;
        
        simulationSection.SetActive(true);
        simulationStartScreen.SetActive(true);

        // continueSimulationFromWeekButton.SetActive(true);

        weekSummaryScreen.SetActive(false);
        summarySection.SetActive(false);

        WeekReset();
    }
    public void WeekReset()
    {
        //Increases the Week Counter by 1
        //m1++;
        //m2++;
        //m3++;
        //m4++;
        //m5++;
        //m6++;
        //m7++;
        //m8++;
        //m9++;
        //m10++;
        //m11++;
        //m12++;
        //Resets Week Monetary Collection Values
        weekMoneyObtained1990 = 0.00;
        weekMoneyObtained2020 = 0.00;
        weekMoneyLoss1990 = 0.00;
        weekMoneyLoss2020 = 0.00;
        weekMoneyRemaining1990 = 0.00;
        weekMoneyRemaining2020 = 0.00;

        //Resets Paid Monetary Values
        housingPaid1990 = 0.00;
        housingPaid2020 = 0.00;
        utilitiesPaid1990 = 0.00;
        utilitiesPaid2020 = 0.00;
        //utilityElectricPaid1990 = 0.00;
        //utilityElectricPaid2020 = 0.00;
        //utilityWaterPaid1990 = 0.00;
        //utilityWaterPaid2020 = 0.00;
        //utilityCommunicationsPaid1990 = 0.00;
        //utilityCommunicationsPaid2020 = 0.00;
        //utilityEntertainmentPaid1990 = 0.00;
        //utilityEntertainmentPaid2020 = 0.00;
        //utilityInternetPaid1990 = 0.00;
        //utilityInternetPaid2020 = 0.00;
        groceryPaid1990 = 0.00;
        groceryPaid2020 = 0.00;
        transportationPaid1990 = 0.00;
        transportationPaid2020 = 0.00;

        continueSimulationFromWeekButton.SetActive(true);
    }


    //The Final Summary - Month Summary
    public void ToMonthSummary()
    {
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

        //Shows Monthly Money Remaining
        monthSummaryMoneyRemaining1990Text.text = "Money Remaining: $" + monthMoneyRemaining1990;
        monthSummaryMoneyRemaining2020Text.text = "Money Remaining: $" + monthMoneyRemaining2020;

        //Status Text based on 1990 Value
        if (monthMoneyRemaining1990 >= 0)
        {
            monthSummaryStatus1990Text.text = "Doing good this month!";
        }
        else if (monthMoneyRemaining1990 < 0)
        {
            monthSummaryStatus1990Text.text = "Maybe next month will be better!";
        }

        //Status Text based on 2020 Value
        if (monthMoneyRemaining2020 >= 0)
        {
            monthSummaryStatus2020Text.text = "Doing good this month!";
        }
        else if (monthMoneyRemaining2020 < 0)
        {
            monthSummaryStatus2020Text.text = "Maybe next month will be better!";
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

                //Makes the Final Summary Section Available
                continueSimulationFromMonthButton.SetActive(false);
                toFinalSummaryButton.SetActive(true);
                break;
            case 4: 
                month04MoneyObtained1990 = monthMoneyObtained1990;
                month04MoneyObtained2020 = monthMoneyObtained2020;
                month04MoneyLoss1990 = monthMoneyLoss1990;
                month04MoneyLoss2020 = monthMoneyLoss2020;
                break;
            case 5:
                month05MoneyObtained1990 = monthMoneyObtained1990;
                month05MoneyObtained2020 = monthMoneyObtained2020;
                month05MoneyLoss1990 = monthMoneyLoss1990;
                month05MoneyLoss2020 = monthMoneyLoss2020;
                break;
            case 6: 
                month06MoneyObtained1990 = monthMoneyObtained1990;
                month06MoneyObtained2020 = monthMoneyObtained2020;
                month06MoneyLoss1990 = monthMoneyLoss1990;
                month06MoneyLoss2020 = monthMoneyLoss2020;
                break;
            case 7: 
                month07MoneyObtained1990 = monthMoneyObtained1990;
                month07MoneyObtained2020 = monthMoneyObtained2020;
                month07MoneyLoss1990 = monthMoneyLoss1990;
                month07MoneyLoss2020 = monthMoneyLoss2020;
                break;
            case 8:
                month08MoneyObtained1990 = monthMoneyObtained1990;
                month08MoneyObtained2020 = monthMoneyObtained2020;
                month08MoneyLoss1990 = monthMoneyLoss1990;
                month08MoneyLoss2020 = monthMoneyLoss2020;
                break;
            case 9:
                month09MoneyObtained1990 = monthMoneyObtained1990;
                month09MoneyObtained2020 = monthMoneyObtained2020;
                month09MoneyLoss1990 = monthMoneyLoss1990;
                month09MoneyLoss2020 = monthMoneyLoss2020;
                break;
            case 10:
                month10MoneyObtained1990 = monthMoneyObtained1990;
                month10MoneyObtained2020 = monthMoneyObtained2020;
                month10MoneyLoss1990 = monthMoneyLoss1990;
                month10MoneyLoss2020 = monthMoneyLoss2020;
                break;
            case 11:
                month11MoneyObtained1990 = monthMoneyObtained1990;
                month11MoneyObtained2020 = monthMoneyObtained2020;
                month11MoneyLoss1990 = monthMoneyLoss1990;
                month11MoneyLoss2020 = monthMoneyLoss2020;
                break;
            case 12:
                month12MoneyObtained1990 = monthMoneyObtained1990;
                month12MoneyObtained2020 = monthMoneyObtained2020;
                month12MoneyLoss1990 = monthMoneyLoss1990;
                month12MoneyLoss2020 = monthMoneyLoss2020;

                //Makes the Final Summary Section Available
                continueSimulationFromMonthButton.SetActive(false);
                toFinalSummaryButton.SetActive(true);
                break;
        }
    }
    public void ToMonthSummary1990()
    {
        monthSummary1990Screen.SetActive(true);
        MonthSummary1990();

        monthSummaryScreen.SetActive(false);
    }
    public void MonthSummary1990()
    {

    }
    public void ToMonthSummary2020()
    {
        monthSummary2020Screen.SetActive(true);
        MonthSummary2020();

        monthSummaryScreen.SetActive(false);
    }
    public void MonthSummary2020()
    {

    }
    public void BackToMonthSummary()
    {
        monthSummaryScreen.SetActive(true);

        monthSummary1990Screen.SetActive(false);
        monthSummary2020Screen.SetActive(false);
    }
    public void ToNextMonth()
    {
        toMonthSummaryButton.SetActive(false);
        monthSummaryScreen.SetActive(false);
        //monthSummary1990Screen.SetActive(false);
        //monthSummary2020Screen.SetActive(false);
        summarySection.SetActive(false);

        // //Increases Month Counter By 1 and Resets Week Counter to 1
        // m++;
        // m1 = 1;
        // m2 = 1;
        // m3 = 1;
        // m4 = 1;
        // m5 = 1;
        // m6 = 1;
        // m7 = 1;
        // m8 = 1;
        // m9 = 1;
        // m10 = 1;
        // m11 = 1;
        // m12 = 1;

        // //Resets Month Monetary Collection Values
        // monthMoneyObtained1990 = 0.00;
        // monthMoneyObtained2020 = 0.00;
        // monthMoneyLoss1990 = 0.00;
        // monthMoneyLoss2020 = 0.00;
        // monthMoneyRemaining1990 = 0.00;
        // monthMoneyRemaining2020 = 0.00;

        // //Resets Week Monetary Collection Values
        // weekMoneyObtained1990 = 0.00;
        // weekMoneyObtained2020 = 0.00;
        // weekMoneyLoss1990 = 0.00;
        // weekMoneyLoss2020 = 0.00;
        // weekMoneyRemaining1990 = 0.00;
        // weekMoneyRemaining2020 = 0.00;

        // //Resets Paid Monetary Values
        // rentPaid1990 = 0.00;
        // rentPaid2020 = 0.00;
        // utilitiesPaid1990 = 0.00;
        // utilitiesPaid2020 = 0.00;
        // utilityElectricPaid1990 = 0.00;
        // utilityElectricPaid2020 = 0.00;
        // utilityWaterPaid1990 = 0.00;
        // utilityWaterPaid2020 = 0.00;
        // utilityCommunicationsPaid1990 = 0.00;
        // utilityCommunicationsPaid2020 = 0.00;
        // utilityEntertainmentPaid1990 = 0.00;
        // utilityEntertainmentPaid2020 = 0.00;
        // utilityInternetPaid1990 = 0.00;
        // utilityInternetPaid2020 = 0.00;
        // groceryPaid1990 = 0.00;
        // groceryPaid2020 = 0.00;
        // transportationPaid1990 = 0.00;
        // transportationPaid2020 = 0.00;
        
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

        simulationSection.SetActive(true);
        simulationStartScreen.SetActive(true);

        MonthReset();
    }
    public void MonthReset()
    {
        //Increases Month Counter By 1 and Resets Week Counter to 0
        m++;
        m1 = 0;
        m2 = 0;
        m3 = 0;
        m4 = 0;
        m5 = 0;
        m6 = 0;
        m7 = 0;
        m8 = 0;
        m9 = 0;
        m10 = 0;
        m11 = 0;
        m12 = 0;

        //Resets Month Monetary Collection Values
        monthMoneyObtained1990 = 0.00;
        monthMoneyObtained2020 = 0.00;
        monthMoneyLoss1990 = 0.00;
        monthMoneyLoss2020 = 0.00;
        monthMoneyRemaining1990 = 0.00;
        monthMoneyRemaining2020 = 0.00;

        //Resets Week Monetary Collection Values
        weekMoneyObtained1990 = 0.00;
        weekMoneyObtained2020 = 0.00;
        weekMoneyLoss1990 = 0.00;
        weekMoneyLoss2020 = 0.00;
        weekMoneyRemaining1990 = 0.00;
        weekMoneyRemaining2020 = 0.00;

        //Resets Paid Monetary Values
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
        
        //Reset Completition Status
        electricityComplete = false;
        waterComplete = false;
        communicationsComplete = false;
        entertainmentComplete = false;
        internetComplete = false;
        housingComplete = false;
        utilitiesComplete = false;
        groceryComplete = false;
        transportationComplete = false;

        //Reset Utility Options
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


        continueSimulationFromWeekButton.SetActive(true);
        continueSimulationFromMonthButton.SetActive(true);
    }

    //Simulation Functions - Final Summary
    public void ToFinalSummary()
    {
        monthSummaryScreen.SetActive(false);
        //monthSummary1990Screen.SetActive(false);
        toFinalSummaryButton.SetActive(false);
        //monthSummary2020Screen.SetActive(false);

        // Calculate Yearly Money Gained & Loss
        finalMoneyObtained1990 = month01MoneyObtained1990 + month02MoneyObtained1990 + month03MoneyObtained1990;
        finalMoneyObtained2020 = month01MoneyObtained2020 + month02MoneyObtained2020 + month03MoneyObtained2020;
        finalMoneyLoss1990 = month01MoneyLoss1990 + month02MoneyLoss1990 + month03MoneyLoss1990;
        finalMoneyLoss2020 = month01MoneyLoss2020 + month02MoneyLoss2020 + month03MoneyLoss2020;
        
        finalSummaryScreen.SetActive(true);
        FinalSummary();
    }
    public void FinalSummary()
    {
        //Shows Final Money Gained and Loss
        finalSummaryMoneyObtained1990Text.text = "Money Obtained: $" + finalMoneyObtained1990;
        finalSummaryMoneyObtained2020Text.text = "Money Obtained: $" + finalMoneyObtained2020;
        finalSummaryMoneyLoss1990Text.text = "Money Loss: $" + finalMoneyLoss1990;
        finalSummaryMoneyLoss2020Text.text = "Money Loss: $" + finalMoneyLoss2020;

        //Calculates Final Money Remaining
        finalMoneyRemaining1990 = finalMoneyObtained1990 - finalMoneyLoss1990;
        finalMoneyRemaining2020 = finalMoneyObtained2020 - finalMoneyLoss2020;

        //Shows Final Money Remaining
        finalSummaryMoneyRemaining1990Text.text = "Money Remaining: $" + finalMoneyRemaining1990;
        finalSummaryMoneyRemaining2020Text.text = "Money Remaining: $" + finalMoneyRemaining2020;

        //Final Status Text based on 1990 Value
        if (finalMoneyRemaining1990 >= 0)
        {
            finalSummaryStatus1990Text.text = "Great Job! You managed to stay afloat this Quarter! But, can you do the same for next Quarter?";
        }
        else if (finalMoneyRemaining1990 < 0)
        {
            finalSummaryStatus1990Text.text = "How Unfortunate! It looks lke you are sinking pretty bad! Maybe things will be better in the next Quarter!";
        }

        //Final Status Text based on 2020 Value
        if (finalMoneyRemaining2020 >= 0)
        {
            finalSummaryStatus2020Text.text = "Great Job! You managed to stay afloat this Quarter! But, can you do the same for next Quarter?";
        }
        else if (finalMoneyRemaining2020 < 0)
        {
            finalSummaryStatus2020Text.text = "How Unfortunate! It looks lke you are sinking pretty bad! Maybe things will be better in the next Quarter!";
        }
    }
    public void GameComplete1()
    {
        //SceneManager.LoadScene(MainMenu);
    }
    public void GameComplete2()
    {
        Application.Quit();
    }
    public void QuitSimulation()
    {
        //SceneManager.LoadScene(MainMenu);
    }
}

