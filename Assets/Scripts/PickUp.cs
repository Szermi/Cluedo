using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public string itemName;

    public PlayerControler player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            player.itemList.Add(itemName);
            Destroy(gameObject);
        }
    }
}
