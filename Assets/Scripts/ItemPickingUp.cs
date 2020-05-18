using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickingUp : MonoBehaviour
{
    public string itemName;

    public HeroController player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            player.itemList.Add(itemName);
            Destroy(gameObject);
        }
    }
}
