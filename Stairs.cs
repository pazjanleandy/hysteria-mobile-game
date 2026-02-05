using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stairs : MonoBehaviour
{
    public float rampAngleThreshold = 30f; // Adjust this angle threshold as per your ramp's inclination

    void Update()
    {
        // Cast a ray downward from the player's position
        if (Physics.Raycast(transform.position, -Vector3.up, out RaycastHit hit))
        {
            // Check if the ray hit the ramp
            if (Vector3.Angle(hit.normal, Vector3.up) > rampAngleThreshold)
            {
                // Player is on the ramp, adjust their movement or behavior here
                Debug.Log("Player is on the ramp!");
            }
        }
    }
}
