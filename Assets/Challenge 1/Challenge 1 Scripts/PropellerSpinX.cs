using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpinX : MonoBehaviour
{

    // Propeller spin speed variable
    private float rotationSpeed = 10000.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        // Propeller spins by itself
        transform.Rotate(Vector3.forward * rotationSpeed *  Time.deltaTime);
    }
}
