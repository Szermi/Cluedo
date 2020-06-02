using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlacesController : MonoBehaviour
{
    // lista dostępnych miejsc
    public enum Place
    {
        Moving,
        Well,
        Shed,
        Beach,
        House,
        Cementary,
        Park
    }

    public HeroController player;

    public Place place;
    public Text text;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            player.placesList.Add(place.ToString());
            text.text = "Miejsca: " + player.placesList.Count + "/6";
            player.place = place.ToString();
            print(place.ToString());

            Text textInfo = GameObject.Find("TextInfo").GetComponent<Text>();
            Animator anim = GameObject.Find("TextInfo").GetComponent<Animator>();


            switch (place.ToString())
            {
                case "Shed":
                    {
                        textInfo.text = "Odwiedzono szopę";
                        break;
                    }
                case "House":
                    {
                        textInfo.text = "Odwiedzono opuszczony dom";
                        break;
                    }
                case "Well":
                    {
                        textInfo.text = "Odwiedzono studnię";
                        break;
                    }
                case "Cementary":
                    {
                        textInfo.text = "Odwiedzono cmentarz";
                        break;
                    }
                case "Beach":
                    {
                        textInfo.text = "Odwiedzono plażę";
                        break;
                    }
                case "Park":
                    {
                        textInfo.text = "Odwiedzono park";
                        break;
                    }
            }
            //StartCoroutine(Move(anim));


            anim.GetComponent<Animator>().Play("TextShowing");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
            player.place = Place.Moving.ToString();
    }

    IEnumerator Move(Animator anim)
    {
        while(anim.GetCurrentAnimatorStateInfo(0).IsName("TextShowing"))
        {
            yield return new WaitForSeconds(anim.GetCurrentAnimatorStateInfo(0).length + anim.GetCurrentAnimatorStateInfo(0).normalizedTime);
        }
    }
}
