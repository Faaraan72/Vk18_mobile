using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anirot : MonoBehaviour { 

    public float rotationSpeed = 30f; // Rotation speed in degrees per second

    private void Update()
    {
        // Rotate the object around its center
        transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
    }
}


