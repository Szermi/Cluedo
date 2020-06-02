using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemPickingUp : MonoBehaviour
{
    public string itemName;

    public HeroController player;
    public Text text;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            player.itemsList.Add(itemName);
            text.text = "Przedmioty: " + player.itemsList.Count + "/6";
            Destroy(gameObject);



            Text textInfo = GameObject.Find("TextInfo").GetComponent<Text>();
            Animator anim = GameObject.Find("TextInfo").GetComponent<Animator>();
            switch (itemName)
            {
                case "Hammer":
                    {
                        textInfo.text = "Podniesiono młotek";
                        break;
                    }
                case "Hache":
                    {
                        textInfo.text = "Podniesiono siekierę";
                        break;
                    }
                case "Bottle":
                    {
                        textInfo.text = "Podniesiono butelkę";
                        break;
                    }
                case "Knife":
                    {
                        textInfo.text = "Podniesiono nóż";
                        break;
                    }
                case "Rope":
                    {
                        textInfo.text = "Podniesiono linę";
                        break;
                    }
                case "Shovel":
                    {
                        textInfo.text = "Podniesiono łopatę";
                        break;
                    }

            }
            anim.GetComponent<Animator>().Play("TextShowing");
        }
    }
}
