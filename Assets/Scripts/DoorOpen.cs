using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    private bool isOpen;

    void Start()
    {
        isOpen = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && !isOpen)
        {
            isOpen = true;
            GameObject Door = GameObject.Find("ShedDoor");
            Door.transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);
            Vector3 move = new Vector3(1.0f, 0, 1.5f);
            Door.transform.position += move;           
        }
    }
}
