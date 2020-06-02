using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRotation : MonoBehaviour
{
    public float x = 0.0f;
    public float y = 0.0f;
    public float z = 0.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the object
        this.transform.Rotate(x, y, z, Space.Self);
    }
}
