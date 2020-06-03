using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMove : MonoBehaviour
{
    public Vector3 targetPosition = new Vector3(1.2f, -5.625f, -17.95f);
    public float speed;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GameObject Torch = GameObject.Find("OpenDoorTorch");
            Torch.transform.Rotate(20.0f, 00.0f, 0.0f, Space.Self);
            Vector3 move = new Vector3(0, -0.15f, 0);
            Torch.transform.position += move;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            GameObject Door = GameObject.Find("HouseDoorClick");
            Door.transform.localPosition = Vector3.Lerp(Door.transform.localPosition, targetPosition, Time.deltaTime * speed);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            GameObject Torch = GameObject.Find("OpenDoorTorch");
            Torch.transform.Rotate(-20.0f, 00.0f, 0.0f, Space.Self);
            Vector3 move = new Vector3(0, 0.15f, 0);
            Torch.transform.position += move;
        }
    }
}
