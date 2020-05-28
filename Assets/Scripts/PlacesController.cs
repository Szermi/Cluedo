using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlacesController : MonoBehaviour
{
    public static int counter = 0;
    // lista dostępnych miejsc
    public enum Place
    {
        moving,
        well,
        shed,
        beach,
        house,
        cementary,
        park
    }

    public HeroController player;

    public Place place;
    public Text text;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            counter++;
            text.text = "Miejsca: " + counter.ToString() + "/6";
            player.place = place.ToString();
            print(place.ToString());
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
            player.place = Place.moving.ToString();
    }
}
