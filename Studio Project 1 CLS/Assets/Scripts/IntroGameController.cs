using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;

public class IntroGameController : MonoBehaviour
{
    //Game Buttons
    //Game Buttons - Gender
    public GameObject maleButton;
    public GameObject femaleButton;
    public GameObject otherGenderButton;

    //Game Buttons - Race/Nationality
    public GameObject europeanDescentButton;
    public GameObject africanDescentButton;
    public GameObject nativeAmericanDescentButton;
    public GameObject hispanicDescentButton;
    public GameObject asianDescentButton;
    public GameObject otherDescentButton;

    //Game Buttons - Education
    public GameObject noDegreeButton;
    public GameObject hsDiplomaButton;
    public GameObject bachelorsDegreeButton;
    public GameObject mastersDegreeButton;
    public GameObject advancedDegreeButton;

    //Game Buttons - Employment
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

    // Game Buttons - Housing
    public GameObject livingWithParentsButton;
    public GameObject livingWithRoommatesButton;
    public GameObject basicApartmentButton;
    public GameObject luxuryApartmentButton;
    public GameObject basicHouseButton;
    public GameObject luxuryHouseButton;

    //Game Buttons - Utilities
    public GameObject utilitiesElectricButton;
    public GameObject utilitiesWaterButton;
    public GameObject utiliiesCommunicationsButton;
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
    public GameObject mb50Internet2020Button;
    public GameObject mb100Internet2020Button;
    public GameObject mb200Internet2020Button;

    //Game Buttons - Transportation
    public GameObject bicycleButton;
    public GameObject usedCarButton;
    public GameObject newCarButton;
    public GameObject motorcycleButton;
    public GameObject busButton;
    public GameObject trainButton;

    //Game Buttons - Gift Money
    public GameObject giftMoneyButton;

    //Game Buttons - Summary
    public GameObject summaryButton1990;
    public GameObject summaryButton2020;

    
    //Game Screens
    //Game Screens - Welcome
    public GameObject welcomeScreen;

    //Game Screens - Gender
    public GameObject genderScreen;
    public GameObject maleScreen;
    public GameObject femaleScreen;
    public GameObject otherGenderScreen;

    //Game Screens - Race
    public GameObject raceScreen;
    public GameObject europeanDescentScreen;
    public GameObject africanDescentScreen;
    public GameObject nativeAmericanDescentScreen;
    public GameObject hispanicDescentScreen;
    public GameObject asianDescentScreen;
    public GameObject otherDescentScreen;

    //Game Screens - Educations
    public GameObject educationScreen;
    public GameObject educationScreenNoDegree;
    public GameObject educationScreenHSDiploma;
    public GameObject educationScreenBachelorsDegree;
    public GameObject educationScreenMastersDegree;
    public GameObject educationScreenAdvancedDegree;

    //Game Screens - Employment
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

    //Game Screens - Housing
    public GameObject housingScreen;
    public GameObject livingWithParentsScreen;
    public GameObject livingWithRoommatesScreen;
    public GameObject basicApartmentScreen;
    public GameObject luxuryApartmentScreen;
    public GameObject basicHouseScreen;
    public GameObject luxuryHouseScreen;

    //Game Screens - Utilities
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
    public GameObject mb50Internet2020Screen;
    public GameObject mb100Internet2020Screen;
    public GameObject mb200Internet2020Screen;

    //Game Screens - Transportation
    public GameObject transportationScreen;
    public GameObject bicycleScreen;
    public GameObject usedCarScreen;
    public GameObject newCarScreen;
    public GameObject motorcycleScreen;
    public GameObject busScreen;
    public GameObject trainScreen;

    //Game Screens - Gift Money
    public GameObject giftMoneyScreen1;
    public GameObject giftMoneyScreen2;
    
    //Game Screens - Summary
    public GameObject introSummaryScreen;
    public GameObject introSummary1990Screen;
    public GameObject introSummary2020Screen;


    //Game Setting Variables
    //Game Setting Variables - Gender
    public bool maleGender = false;
    public bool femaleGender = false;
    public bool otherGender = false;

    //Game Setting Variables - Race
    public bool europeanDescent = false;
    public bool africanDescent = false;
    public bool nativeAmericanDescent = false;
    public bool hispanicDescent =  false;
    public bool asianDescent = false;
    public bool otherDescent = false;

    //Game Setting Variables - Education
    public bool noDegree = false;
    public bool hsDiploma = false;
    public bool bachelorsDegree = false;
    public bool mastersDegree = false;
    public bool advancedDegree = false;

    //Game Setting Variables - Employment
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

    //Game Setting Variables - Housing
    public bool livingWithParents = false;
    public bool livingWithRoommates = false;
    public bool basicApartment = false;
    public bool luxuryApartment = false;
    public bool basicHouse = false;
    public bool luxuryHouse = false;

    //Game Setting Variables - Utilities
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
    public bool mb50Internet = false;
    public bool mb100Internet = false;
    public bool mb200Internet = false;

    //Game Setting Variables - Transportation
    public bool bicycle = false;
    public bool usedCar = false;
    public bool newCar = false;
    public bool motorcycle = false;
    public bool bus = false;
    public bool train = false;


    //Game Intro Summary
    public Text summaryInitialMoney1990Text;
    public Text summaryInitialMoney2020Text;
    public Text summaryGender1990Text;
    public Text summaryGender2020Text;
    public Text summaryRace1990Text;
    public Text summaryRace2020Text;
    public Text summaryEducation1990Text;
    public Text summaryEducation2020Text;
    public Text summaryJob1990Text;
    public Text summaryJob2020Text;
    public Text summaryJobPay1990Text;
    public Text summaryJobPay2020Text;
    public Text summaryHousing1990Text;
    public Text summaryHousing2020Text;
    public Text summaryHousingRent1990Text;
    public Text summaryHousingRent2020Text;
    public Text summaryUtilities1990Text;
    public Text summaryUtilities2020Text;
    public Text summaryUtilitiesCost1990Text;
    public Text summaryUtilitiesCost2020Text;
    public Text summaryTransportation1990Text;
    public Text summaryTransportation2020Text;
    public Text summaryTransportationCost1990Text;
    public Text summaryTransportationCost2020Text;
    public Text summaryGift1990Text;
    public Text summaryGift2020Text;
    public Text summaryCurrentMoney1990Text;
    public Text summaryCurrentMoney2020Text;

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
    public double gasCost1990 = 0.00;
    public double gasCost2020 = 0.00;
    public double transportationCost1990 = 0.00;
    public double transportationCost2020 = 0.00;

    //Utility Monetary Variables
    public double utilityElectricCost1990 = 0.00;
    public double utilityElectricCost2020 = 0.00;
    public double utilityWaterCost1990 = 0.00;
    public double utilityWaterCost2020 = 0.00;
    public double utilityCommunicationsCost1990 = 0.00;
    public double utilityCommunicationsCost2020 = 0.00;
    public double utilityEntertainmentCost1990 = 0.00;
    public double utilityEntertainmentCost2020 = 0.00;
    public double utilityInternetCost2020 = 0.00;


    //Game Option Selection
    public string genderSelected;
    public string raceSelected;
    public string educationSelected;
    public string jobSelected;
    public string housingSelected;
    public string transportationSelected;

    //Utility Selection
    public string utilityElectric1990Selected;
    public string utilityElectric2020Selected;
    public string utilityWater1990Selected;
    public string utilityWater2020Selected;
    public string utilityCommunications1990Selected;
    public string utilityCommunications2020Selected;
    public string utilityEntertainment1990Selected;
    public string utilityEntertainment2020Selected;
    public string utilityInternet2020Selected;

    //Other Variables
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
        currentMoney1990 = initialMoney1990 + giftMoney;
        currentMoney2020 = initialMoney2020 + giftMoney;

        //Updating Utility Cost
        utilitiesCost1990 = utilityElectricCost1990 + utilityWaterCost1990 + utilityCommunicationsCost1990 + utilityEntertainmentCost1990;
        utilitiesCost2020 = utilityElectricCost2020 + utilityWaterCost2020 + utilityCommunicationsCost2020 + utilityEntertainmentCost2020 + utilityInternetCost2020;

        //Setting Up Summary of Game Stats
        summaryInitialMoney1990Text.text = "Initial Money: $" + initialMoney1990;
        summaryInitialMoney2020Text.text = "Initial Money: $" + initialMoney2020;
        summaryGender1990Text.text = "Gender Status: " + genderSelected;
        summaryGender2020Text.text = "Gender Status: " + genderSelected;
        summaryRace1990Text.text = "Racial Status: $" + raceSelected;
        summaryRace2020Text.text = "Racial Status: $" + raceSelected;
        summaryEducation1990Text.text = "Education Status: " + educationSelected;
        summaryEducation2020Text.text = "Education Status: " + educationSelected;
        summaryJob1990Text.text = "Employment Status: " + jobSelected;
        summaryJob2020Text.text = "Employment Status: " + jobSelected;
        summaryJobPay1990Text.text = " - Bi-Weekly Salary: $" + biweeklySalary1990;
        summaryJobPay2020Text.text = " - Bi-Weekly Salary: $" + biweeklySalary2020;
        summaryHousing1990Text.text = "Housing Status: " + housingSelected;
        summaryHousing2020Text.text = "Housing Status: " + housingSelected;
        if (basicHouse == false && luxuryHouse == false)
        {
            summaryHousingRent1990Text.text = " - Monthly Rent: $" + rentCost1990;
            summaryHousingRent2020Text.text = " - Monthly Rent: $" + rentCost2020;
        }
        else if (basicHouse == true || luxuryHouse == true)
        {
            summaryHousingRent1990Text.text = " - Monthly Mortgage: $" + mortgageCost1990;
            summaryHousingRent2020Text.text = " - Monthly Mortgage: $" + mortgageCost2020;
        }
        //summaryUtilities1990Text.text = "Utilities Selected: " + utilityElectric1990Selected + ", " + utilityWater1990Selected + ", " + utilityCommunications1990Selected + ", " + utilityEntertainment1990Selected;
        //summaryUtilities2020Text.text = "Utilities Selected: " + utilityElectric2020Selected + ", " + utilityWater2020Selected + ", " + utilityCommunications2020Selected + ", " + utilityEntertainment2020Selected + ", " + utilityInternet2020Selected;
        //summaryUtilitiesCost1990Text.text = " - Monthly Utilities: $" + utilitiesCost1990;
        //summaryUtilitiesCost2020Text.text = " - Monthly Utilities: $" + utilitiesCost2020;
        summaryTransportation1990Text.text = "Transportation Status: " + transportationSelected;
        summaryTransportation2020Text.text = "Transportation Status: " + transportationSelected;
        summaryTransportationCost1990Text.text = " - Weekly Transportation Cost: $" + transportationCost1990;
        summaryTransportationCost2020Text.text = " - Weekly Transportation Cost: $" + transportationCost2020;
        summaryGift1990Text.text = "Gift Received: $" + giftMoney;
        summaryGift2020Text.text = "Gift Received: $" + giftMoney;
        summaryCurrentMoney1990Text.text = "Current Money: $" + currentMoney1990;
        summaryCurrentMoney2020Text.text = "Current Money: $" + currentMoney2020;
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
            teacherButton.SetActive(true);
            licensedSalesAgentButton.SetActive(true);
            programmerButton.SetActive(true);
            unknownJobButton.SetActive(true);
            doctorButton.SetActive(true);
            lawyerButton.SetActive(true);
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
            programmerButton.SetActive(true);
            unknownJobButton.SetActive(true);
            doctorButton.SetActive(true);
            lawyerButton.SetActive(true);
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
            unknownJobButton.SetActive(true);
            doctorButton.SetActive(true);
            lawyerButton.SetActive(true);
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
            unknownJobButton.SetActive(true);
            doctorButton.SetActive(true);
            lawyerButton.SetActive(true);
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
                    biweeklySalary1990 = 0.00;
                    biweeklySalary2020 = 0.00;
                    break;
            }

            //Sets Available Housing
            livingWithParentsButton.SetActive(true);
            livingWithRoommatesButton.SetActive(true);
            basicApartmentButton.SetActive(true);
            luxuryApartmentButton.SetActive(true);
            basicHouseButton.SetActive(true);
            luxuryHouseButton.SetActive(true);
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
                    biweeklySalary1990 = 0.00;
                    biweeklySalary2020 = 0.00;
                    break;
            }

            //Sets Available Housing
            livingWithParentsButton.SetActive(true);
            livingWithRoommatesButton.SetActive(true);
            basicApartmentButton.SetActive(true);
            luxuryApartmentButton.SetActive(true);
            basicHouseButton.SetActive(true);
            luxuryHouseButton.SetActive(true);
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
                    biweeklySalary1990 = 0.00;
                    biweeklySalary2020 = 0.00;
                    break;
            }

            //Sets Available Housing
            livingWithParentsButton.SetActive(true);
            livingWithRoommatesButton.SetActive(true);
            basicApartmentButton.SetActive(true);
            luxuryApartmentButton.SetActive(true);
            basicHouseButton.SetActive(true);
            luxuryHouseButton.SetActive(true);
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
                    biweeklySalary1990 = 0.00;
                    biweeklySalary2020 = 0.00;
                    break;
            }

            //Sets Available Housing
            livingWithParentsButton.SetActive(true);
            livingWithRoommatesButton.SetActive(true);
            basicApartmentButton.SetActive(true);
            luxuryApartmentButton.SetActive(true);
            basicHouseButton.SetActive(true);
            luxuryHouseButton.SetActive(true);
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
                    biweeklySalary1990 = 0.00;
                    biweeklySalary2020 = 0.00;
                    break;
                case 4:
                    biweeklySalary1990 = 0.00;
                    biweeklySalary2020 = 0.00;
                    break;
                case 5:
                    biweeklySalary1990 = 0.00;
                    biweeklySalary2020 = 0.00;
                    break;
            }

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
                    biweeklySalary1990 = 0.00;
                    biweeklySalary2020 = 0.00;
                    break;
            }

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
                    biweeklySalary1990 = 0.00;
                    biweeklySalary2020 = 0.00;
                    break;
            }

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
                    biweeklySalary1990 = 0.00;
                    biweeklySalary2020 = 0.00;
                    break;
            }

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
                    biweeklySalary1990 = 0.00;
                    biweeklySalary2020 = 0.00;
                    break;
            }

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
                    biweeklySalary1990 = 0.00;
                    biweeklySalary2020 = 0.00;
                    break;
            }

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
                rentCost1990 = 0.00;
                rentCost2020 = 0.00;
                break;
            case 2:
                rentCost1990 = 0.00;
                rentCost2020 = 0.00;
                break;
            case 3:
                rentCost1990 = 0.00;
                rentCost2020 = 0.00;
                break;
            case 4:
                rentCost1990 = 0.00;
                rentCost2020 = 0.00;
                break;
            case 5:
                mortgageCost1990 = 0.00;
                mortgageCost2020 = 0.00;
                break;
            case 6:
                mortgageCost1990 = 0.00;
                mortgageCost2020 = 0.00;
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
        utilityElectric1990Selected = "Electric";
        utilityElectric2020Selected = "Electric";
        utilityElectricCost1990 = Random.Range(50, 300);
        utilityElectricCost2020 = Random.Range(50, 300);
        utilitiesElectricScreen.SetActive(true);
        utilitiesScreen.SetActive(false);
    }

    public void ChooseUtilitiesWater()
    {
        utilityWater = true;
        utilityWater1990Selected = "Water";
        utilityWater2020Selected = "Water";
        utilityWaterCost1990 = Random.Range(0, 10);
        utilityWaterCost2020 = Random.Range(0, 10);
        utilitiesWaterScreen.SetActive(true);
        utilitiesScreen.SetActive(false);
    }

    public void ChooseUtilitiesCommunications()
    {
        utilitiesCommunicationsScreen.SetActive(true);

        utilitiesScreen.SetActive(false);
    }

    public void ChooseUtilitiesCommunicationsHousePhone1990()
    {
        utilityCommunications1990 = true;
        housePhone1990 = true;
        utilityCommunications1990Selected = "House Phone";
        utilityCommunicationsCost1990 = 0.00;
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
        utilityCommunicationsCost2020 = 0.00;
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
        utilityCommunicationsCost1990 = 0.00;
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
        utilityCommunicationsCost2020 = 0.00;
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
        utilityCommunicationsCost2020 = 0.00;
        unlimitedCellPhone2020Screen.SetActive(true);
        utilitiesCommunicationsScreen.SetActive(false);
        housePhone2020Button.SetActive(false);
        basicCellPhone2020Button.SetActive(false);
        BackFromCommunications();
    }

    public void ChooseUtilitiesEntertainment()
    {
        utilitiesEntertainmentScreen.SetActive(true);

        utilitiesScreen.SetActive(false);
    }

    public void ChooseUtilitiesEntertainmentBasicCable1990()
    {
        utilityEntertainment1990 = true;
        basicCable1990 = true;
        utilityEntertainment1990Selected = "Basic Cable";
        utilityEntertainmentCost1990 = 0.00;
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
        utilityEntertainmentCost2020 = 0.00;
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
        utilityEntertainmentCost1990 = 0.00;
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
        utilityEntertainmentCost2020 = 0.00;
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
        utilityEntertainmentCost2020 = 0.00;
        streamingService2020Screen.SetActive(true);
        utilitiesEntertainmentScreen.SetActive(false);
        basicCable2020Button.SetActive(false);
        premiumCable2020Button.SetActive(false);
        BackFromEntertainment();
    }

    public void ChooseUtilitiesInternet()
    {
        utilitiesInternetScreen.SetActive(true);

        utilitiesScreen.SetActive(false);
    }

    public void ChooseUtilitiesInternet50MB()
    {
        utilityInternet2020 = true;
        mb50Internet = true;
        utilityInternet2020Selected = "50MB/s Internet";
        utilityInternetCost2020 = 0.00;
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
        utilityInternetCost2020 = 0.00;
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
        utilityInternet2020Selected = "20MB/s Internet";
        utilityInternetCost2020 = 0.00;
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

        utilitiesScreen.SetActive(true);
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
            travelNow = 1;
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
            travelNow = 2;
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
            travelNow = 3;
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
            travelNow = 4;
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
            travelNow = 5;
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
            travelNow = 6;
        }

        switch (travelNow)
        {
            case 1:
                transportationCost1990 = 0.00;
                transportationCost2020 = 0.00;
                break;
            case 2:
                transportationCost1990 = 0.00;
                transportationCost2020 = 0.00;
                break;
            case 3:
                transportationCost1990 = 0.00;
                transportationCost2020 = 0.00;
                break;
            case 4:
                transportationCost1990 = 0.00;
                transportationCost2020 = 0.00;
                break;
            case 5:
                transportationCost1990 = 0.00;
                transportationCost2020 = 0.00;
                break;
            case 6:
                transportationCost1990 = 0.00;
                transportationCost2020 = 0.00;
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

    
    //Select GIft Money
    public void ChooseGift()
    {
        giftMoneyScreen1.SetActive(false);
        giftMoneyScreen2.SetActive(true);

        //Random giftrand1 = new Random();
        //giftMoney = giftrand1.Next(1001);

        giftMoney = Random.Range(0, 1000);
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

    //Move to Intro Summary Screen
    public void ToSummaryScreen()
    {
        giftMoneyScreen2.SetActive(false);

        introSummaryScreen.SetActive(true);
    }

    public void ToSummaryScreen1990()
    {
        introSummaryScreen.SetActive(false);

        introSummary1990Screen.SetActive(true);
        introSummary2020Screen.SetActive(false);
    }

    public void ToSummaryScreen2020()
    {
        introSummaryScreen.SetActive(false);

        introSummary1990Screen.SetActive(false);
        introSummary2020Screen.SetActive(true);
    }

    public void ReturnToSummaryScreen()
    {
        introSummaryScreen.SetActive(true);

        introSummary1990Screen.SetActive(false);
        introSummary2020Screen.SetActive(false);
    }



    //Quit Game at end of Level
    public void QuitGame()
    {
        //SceneManager.LoadScene(MainMenu);
    }

    //Move to Month 01 - Week 01
    public void Week01()
    {
        //SceneManager.LoadScene(Week01);
    }
}

