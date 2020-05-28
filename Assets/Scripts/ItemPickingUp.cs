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
        }
    }
}
