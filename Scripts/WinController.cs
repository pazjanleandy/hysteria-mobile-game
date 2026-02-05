using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinController : MonoBehaviour
{
    public int objectivesNeeded = 3; // Number of objectives needed to trigger victory
    public GameObject objectivePrefab; // Prefab of the objective to instantiate
    public Transform victoryLocation; // Location to teleport the player upon victory

    private int objectivesCollected = 0; // Counter for collected objectives

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Check if the collider is the player
        {
            // Increment the collected objectives counter
            objectivesCollected++;

            // Instantiate the objective prefab
            Instantiate(objectivePrefab, transform.position, Quaternion.identity);

            // Check if the player has collected enough objectives for victory
            if (objectivesCollected >= objectivesNeeded)
            {
                // Teleport the player to the victory location
                other.transform.position = victoryLocation.position;
            }
        }
    }
}
