using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MurderItemsController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the object
        this.transform.Rotate(0.0f, 0.0f, 1.0f, Space.Self);
    }
}
