using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    // Variable to insert the plane GameObject
    public GameObject plane;
    // Offset variable cooridinates
    private Vector3 offset = new Vector3(22, 2, 2);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Set the position of the camera
        transform.position = plane.transform.position + offset;
    }
}
