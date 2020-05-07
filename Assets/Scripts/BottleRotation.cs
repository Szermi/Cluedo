using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the object
        this.transform.Rotate(2.0f, 0.0f, 2.0f, Space.Self);
    }
}
