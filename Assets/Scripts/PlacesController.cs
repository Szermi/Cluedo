using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacesController : MonoBehaviour
{
    // lista dostępnych miejsc
    public enum Place
    {
        moving,
        shed,
        beach
    }

    public PlayerControler player;

    public Place place;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            player.place = place.ToString();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
            player.place = Place.moving.ToString();
    }
}
