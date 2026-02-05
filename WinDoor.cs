using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinDoor : MonoBehaviour
{
    public int requiredObjectives = 8; // Change this to the number of objectives required to open the door
    private bool isOpen = false; // Flag to track if the door is already open

    private void OnTriggerEnter(Collider other)
    {
        if (isOpen) return; // If the door is already open, do nothing

        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();
        if (playerInventory != null && playerInventory.ObjectiveNumber >= requiredObjectives)
        {
            // Switch to the scene of your choice
            SceneManager.LoadScene("Victory");
        }
    }
}
