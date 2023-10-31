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
    public GameObject phdDegreeButton;

    //Game Buttons - Employment
    public GameObject cashierButton;
    public GameObject fryCookButton;
    public GameObject waiterButton;
    public GameObject teacherButton;
    public GameObject callCenterCustomerServiceButton;
    public GameObject callCenterLicensedSalesButton;
    public GameObject programmerButton;
    public GameObject doctorButton;

    // Game Buttons - Housing
    public GameObject livingWithParentsButton;
    public GameObject crappyApartmentButton;
    public GameObject basicApartmentButton;
    public GameObject luxuryApartmentButton;
    public GameObject basicHouseButton;

    //Game Buttons - Transportation
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
    public GameObject educationScreenPHDDegree;

    //Game Screens - Employment
    public GameObject jobScreen;
    public GameObject waiterScreen;
    public GameObject cashierScreen;
    public GameObject fryCookScreen;
    public GameObject callCenterCustomerServiceScreen;
    public GameObject teacherScreen;
    public GameObject callCenterLicensedSalesScreen;
    public GameObject programmerScreen;
    public GameObject doctorScreen;

    //Game Screens - Housing
    public GameObject housingScreen;
    public GameObject livingWithparentsScreen;
    public GameObject crappyApartmentScreen;
    public GameObject basicApartmentScreen;
    public GameObject luxuryApartmentScreen;
    public GameObject ownHouseScreen;

    //Game Screens - Transportation
    public GameObject transportationScreen;
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
    public GameObject introScreenSummary1990Screen;
    public GameObject introScreenSummary2020Screen;


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
    public bool phdDegree = false;

    //Game Setting Variables - Employment
    public bool cashier = false;
    public bool fryCook = false;
    public bool waiter = false;
    public bool teacher = false;
    public bool callCenterCustomerService = false;
    public bool callCenterLicensedSales = false;
    public bool programmer = false;
    public bool doctor = false;

    //Game Setting Variables - Housing
    public bool crappyApartment = false;
    public bool basicApartment = false;
    public bool luxuryApartment = false;
    public bool ownHouse = false;
    public bool livingWithParents = false;

    //Game Setting Variables - Transportation
    public bool usedCar = false;
    public bool newCar = false;
    public bool motorcycle = false;
    public bool bus = false;
    public bool train = false;


    //Game Intro Summary
    public Text summaryInitialMoney1990Text;
    public Text summaryInitialMoney2020Text;
    public Text summaryGenderText;
    public Text summaryRaceText;
    public Text summaryEducationText;
    public Text summaryJobText;
    public Text summaryJobPay1990Text;
    public Text summaryJobPay2020Text;
    public Text summaryHousingText;
    public Text summaryHousingRent1990Text;
    public Text summaryHousingRent2020Text;
    public Text summaryTransportationText;
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
    public double gasCost1990 = 0.00;
    public double gasCost2020 = 0.00;
    public double transportationCost1990 = 0.00;
    public double transportationCost2020 = 0.00;

    //Game Option Selection
    public string genderSelected;
    public string raceSelected;
    public string educationSelected;
    public string jobSelected;
    public string housingSelected;
    public string transportationSelected;

    //Other Variables
    public GameObject introGameController1;
    public int genderNow;
    public int raceNow;
    public int educationNow;
    public int jobNow;
    public int travelNow;
    public int houseNow;


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

        //Setting Up Summary of Game Stats
        summaryInitialMoney1990Text.text = "Initial Money: $" + initialMoney1990;
        summaryInitialMoney2020Text.text = "Initial Money: $" + initialMoney2020;
        summaryGenderText.text = "Gender Status: " + genderSelected;
        summaryRaceText.text = "Racial Status: $" + raceSelected;
        summaryEducationText.text = "Education Status: " + educationSelected;
        summaryJobText.text = "Employment Status: " + jobSelected;
        summaryJobPay1990Text.text = " - Bi-Weekly Salary: $" + biweeklySalary1990;
        summaryJobPay2020Text.text = " - Bi-Weekly Salary: $" + biweeklySalary2020;
        summaryHousingText.text = "Housing Status: " + housingSelected;
        summaryHousingRent1990Text.text = " - Monthly Rent: $" + rentCost1990;
        summaryHousingRent2020Text.text = " - Monthly Rent: $" + rentCost2020;
        summaryTransportationText.text = "Transportation Status: " + transportationSelected;
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
            educationScreenPHDDegree.SetActive(false);

            educationSelected = "No Degree";
            educationNow = 1;

            //Sets Available Jobs
            waiterButton.SetActive(true);
            cashierButton.SetActive(true);
            fryCookButton.SetActive(true);
            callCenterCustomerServiceButton.SetActive(true);
            teacherButton.SetActive(true);
            callCenterLicensedSalesButton.SetActive(true);
            programmerButton.SetActive(true);
            doctorButton.SetActive(true);
        }
        else if (hsDiploma == true)
        {
            //Changes Panel View
            educationScreen.SetActive(false);
            educationScreenNoDegree.SetActive(false);
            educationScreenHSDiploma.SetActive(true);
            educationScreenBachelorsDegree.SetActive(false);
            educationScreenMastersDegree.SetActive(false);
            educationScreenPHDDegree.SetActive(false);

            educationSelected = "High School Diploma";
            educationNow = 2;

            //Sets Available Jobs
            waiterButton.SetActive(true);
            cashierButton.SetActive(true);
            fryCookButton.SetActive(true);
            callCenterCustomerServiceButton.SetActive(true);
            teacherButton.SetActive(true);
            callCenterLicensedSalesButton.SetActive(true);
            programmerButton.SetActive(true);
            doctorButton.SetActive(true);
        }
        else if (bachelorsDegree == true)
        {
            //Changes Panel View
            educationScreen.SetActive(false);
            educationScreenNoDegree.SetActive(false);
            educationScreenHSDiploma.SetActive(false);
            educationScreenBachelorsDegree.SetActive(true);
            educationScreenMastersDegree.SetActive(false);
            educationScreenPHDDegree.SetActive(false);

            educationSelected = "Bachelor's Degree";
            educationNow = 3;

            //Sets Available Jobs
            waiterButton.SetActive(true);
            cashierButton.SetActive(true);
            fryCookButton.SetActive(true);
            callCenterCustomerServiceButton.SetActive(true);
            teacherButton.SetActive(true);
            callCenterLicensedSalesButton.SetActive(true);
            programmerButton.SetActive(true);
            doctorButton.SetActive(true);
        }
        else if (mastersDegree == true)
        {
            //Changes Panel View
            educationScreen.SetActive(false);
            educationScreenNoDegree.SetActive(false);
            educationScreenHSDiploma.SetActive(false);
            educationScreenBachelorsDegree.SetActive(false);
            educationScreenMastersDegree.SetActive(true);
            educationScreenPHDDegree.SetActive(false);

            educationSelected = "Master's Degreee";
            educationNow = 4;

            //Sets Available Jobs
            waiterButton.SetActive(true);
            cashierButton.SetActive(true);
            fryCookButton.SetActive(true);
            callCenterCustomerServiceButton.SetActive(true);
            teacherButton.SetActive(true);
            callCenterLicensedSalesButton.SetActive(true);
            programmerButton.SetActive(true);
            doctorButton.SetActive(true);
        }
        else if (phdDegree == true)
        {
            //Changes Panel View
            educationScreen.SetActive(false);
            educationScreenNoDegree.SetActive(false);
            educationScreenHSDiploma.SetActive(false);
            educationScreenBachelorsDegree.SetActive(false);
            educationScreenMastersDegree.SetActive(false);
            educationScreenPHDDegree.SetActive(true);

            educationSelected = "PhD";
            educationNow = 5;

            //Sets Available Jobs
            waiterButton.SetActive(true);
            cashierButton.SetActive(true);
            fryCookButton.SetActive(true);
            callCenterCustomerServiceButton.SetActive(true);
            teacherButton.SetActive(true);
            callCenterLicensedSalesButton.SetActive(true);
            programmerButton.SetActive(true);
            doctorButton.SetActive(true);
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
        phdDegree = true;
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
            callCenterCustomerServiceScreen.SetActive(false);
            teacherScreen.SetActive(false);
            callCenterLicensedSalesScreen.SetActive(false);
            programmerScreen.SetActive(false);
            doctorScreen.SetActive(false);

            jobSelected = "Waiter";
            jobNow = 1;

            //Setting Pay
            switch (jobNow)
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
            crappyApartmentButton.SetActive(true);
            basicApartmentButton.SetActive(true);
            luxuryApartmentButton.SetActive(true);
            basicHouseButton.SetActive(true);
        }
        else if (cashier == true)
        {
            //Changes Panel View
            jobScreen.SetActive(false);
            waiterScreen.SetActive(false);
            cashierScreen.SetActive(true);
            fryCookScreen.SetActive(false);
            callCenterCustomerServiceScreen.SetActive(false);
            teacherScreen.SetActive(false);
            callCenterLicensedSalesScreen.SetActive(false);
            programmerScreen.SetActive(false);
            doctorScreen.SetActive(false);

            jobSelected = "Cashier";
            jobNow = 2;

            //Setting Pay
            switch (jobNow)
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
            crappyApartmentButton.SetActive(true);
            basicApartmentButton.SetActive(true);
            luxuryApartmentButton.SetActive(true);
            basicHouseButton.SetActive(true);
        }
        else if (fryCook == true)
        {
            //Changes Panel View
            jobScreen.SetActive(false);
            waiterScreen.SetActive(false);
            cashierScreen.SetActive(false);
            fryCookScreen.SetActive(true);
            callCenterCustomerServiceScreen.SetActive(false);
            teacherScreen.SetActive(false);
            callCenterLicensedSalesScreen.SetActive(false);
            programmerScreen.SetActive(false);
            doctorScreen.SetActive(false);

            jobSelected = "Fry Cook";
            jobNow = 3;

            //Setting Pay
            switch (jobNow)
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
            crappyApartmentButton.SetActive(true);
            basicApartmentButton.SetActive(true);
            luxuryApartmentButton.SetActive(true);
            basicHouseButton.SetActive(true);
        }
        else if (callCenterCustomerService == true)
        {
            //Changes Panel View
            jobScreen.SetActive(false);
            waiterScreen.SetActive(false);
            cashierScreen.SetActive(false);
            fryCookScreen.SetActive(false);
            callCenterCustomerServiceScreen.SetActive(true);
            teacherScreen.SetActive(false);
            callCenterLicensedSalesScreen.SetActive(false);
            programmerScreen.SetActive(false);
            doctorScreen.SetActive(false);

            jobSelected = "Call Center Agent";
            jobNow = 4;

            //Setting Pay
            switch (jobNow)
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
            crappyApartmentButton.SetActive(true);
            basicApartmentButton.SetActive(true);
            luxuryApartmentButton.SetActive(true);
            basicHouseButton.SetActive(true);
        }
        else if (teacher == true)
        {
            //Changes Panel View
            jobScreen.SetActive(false);
            waiterScreen.SetActive(false);
            cashierScreen.SetActive(false);
            fryCookScreen.SetActive(false);
            callCenterCustomerServiceScreen.SetActive(false);
            teacherScreen.SetActive(true);
            callCenterLicensedSalesScreen.SetActive(false);
            programmerScreen.SetActive(false);
            doctorScreen.SetActive(false);

            jobSelected = "Teacher";
            jobNow = 5;

            //Setting Pay
            switch (jobNow)
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
            crappyApartmentButton.SetActive(true);
            basicApartmentButton.SetActive(true);
            luxuryApartmentButton.SetActive(true);
            basicHouseButton.SetActive(true);
        }
        else if (callCenterLicensedSales == true)
        {
            //Changes Panel View
            jobScreen.SetActive(false);
            waiterScreen.SetActive(false);
            cashierScreen.SetActive(false);
            fryCookScreen.SetActive(false);
            callCenterCustomerServiceScreen.SetActive(false);
            teacherScreen.SetActive(false);
            callCenterLicensedSalesScreen.SetActive(true);
            programmerScreen.SetActive(false);
            doctorScreen.SetActive(false);

            jobSelected = "Licensed Sales Agent";
            jobNow = 6;

            //Setting Pay
            switch (jobNow)
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
            crappyApartmentButton.SetActive(true);
            basicApartmentButton.SetActive(true);
            luxuryApartmentButton.SetActive(true);
            basicHouseButton.SetActive(true);
        }
        else if (programmer == true)
        {
            //Changes Panel View
            jobScreen.SetActive(false);
            waiterScreen.SetActive(false);
            cashierScreen.SetActive(false);
            fryCookScreen.SetActive(false);
            callCenterCustomerServiceScreen.SetActive(false);
            teacherScreen.SetActive(false);
            callCenterLicensedSalesScreen.SetActive(false);
            programmerScreen.SetActive(true);
            doctorScreen.SetActive(false);

            jobSelected = "Programmer";
            jobNow = 7;

            //Setting Pay
            switch (jobNow)
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
            crappyApartmentButton.SetActive(true);
            basicApartmentButton.SetActive(true);
            luxuryApartmentButton.SetActive(true);
            basicHouseButton.SetActive(true);
        }
        else if (doctor == true)
        {
            //Changes Panel View
            jobScreen.SetActive(false);
            waiterScreen.SetActive(false);
            cashierScreen.SetActive(false);
            fryCookScreen.SetActive(false);
            callCenterCustomerServiceScreen.SetActive(false);
            teacherScreen.SetActive(false);
            callCenterLicensedSalesScreen.SetActive(false);
            programmerScreen.SetActive(false);
            doctorScreen.SetActive(true);

            jobSelected = "Doctor";
            jobNow = 8;

            //Setting Pay
            switch (jobNow)
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
            crappyApartmentButton.SetActive(true);
            basicApartmentButton.SetActive(true);
            luxuryApartmentButton.SetActive(true);
            basicHouseButton.SetActive(true);
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

    public void ChooseJobCallCenterAgent()
    {
        callCenterCustomerService = true;
        ChooseJob();
    }

    public void ChooseJobTeacher()
    {
        teacher = true;
        ChooseJob();
    }

    public void ChooseJobCallCenterLicensedAgent()
    {
        callCenterLicensedSales = true;
        ChooseJob();
    }

    public void ChooseJobProgrammer()
    {
        programmer = true;
        ChooseJob();
    }

    public void ChooseJobDoctor()
    {
        doctor = true;
        ChooseJob();
    }



    //Selecting Housing
    public void ChooseHousing()
    {
        if (livingWithParents == true)
        {
            //Changing Panel View
            housingScreen.SetActive(false);
            livingWithparentsScreen.SetActive(true);
            crappyApartmentScreen.SetActive(false);
            basicApartmentScreen.SetActive(false);
            luxuryApartmentScreen.SetActive(false);
            ownHouseScreen.SetActive(false);

            housingSelected = "Living With Parents";
            houseNow = 1;

            rentCost1990 = 0.00;
            rentCost2020 = 0.00;
        }
        else if (crappyApartment == true)
        {
            //Changing Panel View
            housingScreen.SetActive(false);
            livingWithparentsScreen.SetActive(false);
            crappyApartmentScreen.SetActive(true);
            basicApartmentScreen.SetActive(false);
            luxuryApartmentScreen.SetActive(false);
            ownHouseScreen.SetActive(false);

            housingSelected = "Crappy Apartment";
            houseNow = 2;

            rentCost1990 = 0.00;
            rentCost2020 = 0.00;
        }
        else if (basicApartment == true)
        {
            //Changing Panel View
            housingScreen.SetActive(false);
            livingWithparentsScreen.SetActive(false);
            crappyApartmentScreen.SetActive(false);
            basicApartmentScreen.SetActive(true);
            luxuryApartmentScreen.SetActive(false);
            ownHouseScreen.SetActive(false);

            housingSelected = "Basic Apartment";
            houseNow = 3;

            rentCost1990 = 0.00;
            rentCost2020 = 0.00;
        }
        else if (luxuryApartment == true)
        {
            //Changing Panel View
            housingScreen.SetActive(false);
            livingWithparentsScreen.SetActive(false);
            crappyApartmentScreen.SetActive(false);
            basicApartmentScreen.SetActive(false);
            luxuryApartmentScreen.SetActive(true);
            ownHouseScreen.SetActive(false);

            housingSelected = "Luxury Apartment";
            houseNow = 4;

            rentCost1990 = 0.00;
            rentCost2020 = 0.00;
        }
        else if (ownHouse == true)
        {
            //Changing Panel View
            housingScreen.SetActive(false);
            livingWithparentsScreen.SetActive(false);
            crappyApartmentScreen.SetActive(false);
            basicApartmentScreen.SetActive(false);
            luxuryApartmentScreen.SetActive(false);
            ownHouseScreen.SetActive(true);

            housingSelected = "Own Home";
            houseNow = 5;

            rentCost1990 = 0.00;
            rentCost2020 = 0.00;
        }
    }
    
    public void ChooseHousingLivingWithParents()
    {
        livingWithParents = true;
        ChooseHousing();
    }
    public void ChooseHousingCrappyApartment()
    {
        crappyApartment = true;
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

    public void ChooseHousingOwnHouse()
    {
        ownHouse = true;
        ChooseHousing();
    }



    //Selecting Transportation
    public void ChooseTransportation()
    {
        if (usedCar == true)
        {
            transportationScreen.SetActive(false);
            usedCarScreen.SetActive(true);
            newCarScreen.SetActive(false);
            motorcycleScreen.SetActive(false);
            busScreen.SetActive(false);
            trainScreen.SetActive(false);

            transportationSelected = "Car";
            travelNow = 1;

            transportationCost1990 = 0.00;
            transportationCost2020 = 0.00;
        }
        else if (newCar == true)
        {
            transportationScreen.SetActive(false);
            usedCarScreen.SetActive(false);
            newCarScreen.SetActive(true);
            motorcycleScreen.SetActive(false);
            busScreen.SetActive(false);
            trainScreen.SetActive(false);

            transportationSelected = "New Car";
            travelNow = 2;

            transportationCost1990 = 0.00;
            transportationCost2020 = 0.00;
        }
        else if (motorcycle == true)
        {
            transportationScreen.SetActive(false);
            usedCarScreen.SetActive(false);
            newCarScreen.SetActive(false);
            motorcycleScreen.SetActive(true);
            busScreen.SetActive(false);
            trainScreen.SetActive(false);

            transportationSelected = "Motorcycle";
            travelNow = 3;

            transportationCost1990 = 0.00;
            transportationCost2020 = 0.00;
        }
        else if (bus == true)
        {
            transportationScreen.SetActive(false);
            usedCarScreen.SetActive(false);
            newCarScreen.SetActive(false);
            motorcycleScreen.SetActive(false);
            busScreen.SetActive(true);
            trainScreen.SetActive(false);

            transportationSelected = "City Bus";
            travelNow = 4;

            transportationCost1990 = 0.00;
            transportationCost2020 = 0.00;
        }
        if (train == true)
        {
            transportationScreen.SetActive(false);
            usedCarScreen.SetActive(false);
            newCarScreen.SetActive(false);
            motorcycleScreen.SetActive(false);
            busScreen.SetActive(false);
            trainScreen.SetActive(true);

            transportationSelected = "Train";
            travelNow = 5;

            transportationCost1990 = 0.00;
            transportationCost2020 = 0.00;
        }
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
        giftMoneyScreen2.SetActive(false);

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
        educationScreenPHDDegree.SetActive(false);

        jobScreen.SetActive(true);
    }

    //Move to Housing Selection Screen
    public void ToHousingScreen()
    {
        jobScreen.SetActive(false);
        waiterScreen.SetActive(false);
        cashierScreen.SetActive(false);
        fryCookScreen.SetActive(false);
        callCenterCustomerServiceScreen.SetActive(false);
        teacherScreen.SetActive(false);
        callCenterLicensedSalesScreen.SetActive(false);
        programmerScreen.SetActive(false);
        doctorScreen.SetActive(false);

        housingScreen.SetActive(true);
    }

    //Move to Transportation Selection Screen
    public void ToTransportationScreen()
    {
        housingScreen.SetActive(false);
        livingWithparentsScreen.SetActive(false);
        crappyApartmentScreen.SetActive(false);
        basicApartmentScreen.SetActive(false);
        luxuryApartmentScreen.SetActive(false);
        ownHouseScreen.SetActive(false);

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

    //Movee to Intro Summary Screen
    public void ToSummaryScreen()
    {
        giftMoneyScreen2.SetActive(false);

        introSummaryScreen.SetActive(true);
    }



    //Quit Game at end of level
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

