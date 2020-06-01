using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayImagesInInventory : MonoBehaviour
{
    public HeroController player;

    public GameObject inventory;

    public GameObject bottleImage;
    public GameObject hammerImage;
    public GameObject hacheImage;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e"))
            inventory.SetActive(!inventory.active);


        //ItemsList
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

    }
}
