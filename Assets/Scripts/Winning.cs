using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Winning : MonoBehaviour
{
    private int chosenItem = 0;
    private int chosenPlace = 0;
    private int chosenPerson = 0;
    private int counterToDisplay = 0; //test
    private GameObject image;
    Color whiteColor = new Color(1.0f, 1.0f, 1.0f, 1.0f);
    Color greenColor = new Color(0.2f, 1.0f, 0.0f, 1.0f);

    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            chosenItem = 0;
            chosenPlace = 0;
            chosenPerson = 0;
            clearAllSlots("ButtonItem");
            clearAllSlots("ButtonPlace");
            clearAllSlots("ButtonPerson");
        }
    }

    public void onButtonClick(GameObject received)
    {
        image = received;
        
        clearAllSlots(image.tag);
        updateChosenNumber();


        if (image.tag == "ButtonItem")
        {
            string lastPlaceName = getLastPlace();
            if (lastPlaceName != "Nie znaleziono") leaveSelectedSlot(lastPlaceName);

            string lastPersonName = getLastPerson();
            if (lastPersonName != "Nie znaleziono") leaveSelectedSlot(lastPersonName);
        }
        else if (image.tag == "ButtonPlace")
        {
            string lastItemName = getLastItem();
            if (lastItemName != "Nie znaleziono") leaveSelectedSlot(lastItemName);

            string lastPersonName = getLastPerson();
            if (lastPersonName != "Nie znaleziono") leaveSelectedSlot(lastPersonName);
        }
        else if (image.tag == "ButtonPerson")
        {
            string lastItemName = getLastItem();
            if (lastItemName != "Nie znaleziono") leaveSelectedSlot(lastItemName);

            string lastPlaceName = getLastPlace();
            if (lastPlaceName != "Nie znaleziono") leaveSelectedSlot(lastPlaceName);
        }



        print(counterToDisplay++ + ") " + chosenItem + " " + chosenPlace + " " + chosenPerson);
    }

    private void changeButtonColor(string name)
    {
        RawImage image = GameObject.Find(name).GetComponent<RawImage>();
        image.color = Color.green; 

    }
    
   

    private void clearAllSlots(string tag)
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag(tag);

        foreach (GameObject gameObject in objects)
        {
            gameObject.GetComponent<RawImage>().color = Color.white;
        }
    }
    

    private void leaveSelectedSlot(string name)
    {
        RawImage image = GameObject.Find(name).GetComponent<RawImage>();
        image.color = Color.green;
    }

    private string getLastItem()
    {
        switch (chosenItem)
        {
            case 1: { return "BottleImage"; }
            case 2: { return "HammerImage"; }
            case 3: { return "HacheImage"; }
            case 4: { return "KnifeImage"; }
            case 5: { return "ShovelImage"; }
            case 6: { return "RopeImage"; }
            default: { return "Nie znaleziono"; }
        }
    }

    private string getLastPlace()
    {
        switch (chosenPlace)
        {
            case 1: { return ("BeachImage"); }
            case 2: { return ("CementaryImage"); }
            case 3: { return ("HouseImage"); }
            case 4: { return ("ParkImage"); }
            case 5: { return ("ShedImage"); }
            case 6: { return ("WellImage"); }
            default: { return "Nie znaleziono"; }
        }
    }

    private string getLastPerson()
    {
        switch (chosenPerson)
        {
            case 1: { return ("PawelczakImage"); }
            case 2: { return ("ZoltowskiImage"); }
            case 3: { return ("PastorskiImage"); }
            case 4: { return ("KarmanImage"); }
            case 5: { return ("ZielinskiImage"); }
            case 6: { return ("BartoszakImage"); }
            default: { return "Nie znaleziono"; }
        }
    }

    private void updateChosenNumber()
    {
        image.GetComponent<RawImage>().color = Color.green;
        switch (image.name)
        {
            case "BottleImage": { chosenItem = 1; break; }
            case "HammerImage": { chosenItem = 2; break; }
            case "HacheImage": { chosenItem = 3; break; }
            case "KnifeImage": { chosenItem = 4; break; }
            case "ShovelImage": { chosenItem = 5; break; }
            case "RopeImage": { chosenItem = 6; break; }

            case "BeachImage": { chosenPlace = 1; break; }
            case "CementaryImage": { chosenPlace = 2; break; }
            case "HouseImage": { chosenPlace = 3; break; }
            case "ParkImage": { chosenPlace = 4; break; }
            case "ShedImage": { chosenPlace = 5; break; }
            case "WellImage": { chosenPlace = 6; break; }

            case "PawelczakImage": { chosenPerson = 1; break; }
            case "ZoltowskiImage": { chosenPerson = 2; break; }
            case "PastorskiImage": { chosenPerson = 3; break; }
            case "KarmanImage": { chosenPerson = 4; break; }
            case "ZielinskiImage": { chosenPerson = 5; break; }
            case "BartoszakImage": { chosenPerson = 6; break; }

            default: { print("Nie znaleziono nazwy"); break; }
        }
    }
 }
