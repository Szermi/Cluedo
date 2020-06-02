using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayImagesInInventory : MonoBehaviour
{
    public HeroController player;

    public GameObject inventory;

    //items
    public GameObject bottleImage;
    public GameObject hammerImage;
    public GameObject hacheImage;
    public GameObject knifeImage;
    public GameObject shovelImage;
    public GameObject ropeImage;

    //places
    public GameObject beachImage;
    public GameObject cementaryImage;
    public GameObject houseImage;
    public GameObject parkImage;
    public GameObject shedImage;
    public GameObject wellImage;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e"))
            inventory.SetActive(!inventory.active);

        launchItems();
        launchPlaces();

    }

    public void launchItems()
    {
        if (player.itemsList.Contains("Bottle"))
            bottleImage.SetActive(true);
        else
            bottleImage.SetActive(false);

        if (player.itemsList.Contains("Hammer"))
            hammerImage.SetActive(true);
        else
            hammerImage.SetActive(false);

        if (player.itemsList.Contains("Hache"))
            hacheImage.SetActive(true);
        else
            hacheImage.SetActive(false);

        if (player.itemsList.Contains("Knife"))
            knifeImage.SetActive(true);
        else
            knifeImage.SetActive(false);

        if (player.itemsList.Contains("Shovel"))
            shovelImage.SetActive(true);
        else
            shovelImage.SetActive(false);

        if (player.itemsList.Contains("Rope"))
            ropeImage.SetActive(true);
        else
            ropeImage.SetActive(false);

    }

    public void launchPlaces()
    {
        if (player.placesList.Contains("Beach"))
            beachImage.SetActive(true);
        else
            beachImage.SetActive(false);

        if (player.placesList.Contains("Cementary"))
            cementaryImage.SetActive(true);
        else
            cementaryImage.SetActive(false);

        if (player.placesList.Contains("House"))
            houseImage.SetActive(true);
        else
            houseImage.SetActive(false);

        if (player.placesList.Contains("Park"))
            parkImage.SetActive(true);
        else
            parkImage.SetActive(false);

        if (player.placesList.Contains("Shed"))
            shedImage.SetActive(true);
        else
            shedImage.SetActive(false);

        if (player.placesList.Contains("Well"))
            wellImage.SetActive(true);
        else
            wellImage.SetActive(false);
    }
}