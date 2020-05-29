using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemPickingUp : MonoBehaviour
{
    public string itemName;
    public static int counter = 0;

    public HeroController player;
    public Text text;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            counter++;
            text.text = "Przedmioty: " + counter.ToString() + "/6";
            player.itemList.Add(itemName);
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

            }
            anim.GetComponent<Animator>().Play("TextShowing");
        }
    }
}
