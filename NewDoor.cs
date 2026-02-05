using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewDoor : MonoBehaviour
{
    [SerializeField] private Animator newDoor = null;

    private bool isOpen = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Monsters"))
        {
            if (!isOpen) // If the door is not already open
            {
                newDoor.Play("SlidingDoor", 0, 0.0f);
                isOpen = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Monsters"))
        {
            if (isOpen) // If the door is currently open
            {
                newDoor.Play("SlideDoorClose", 0, 0.0f);
                isOpen = false;
            }
        }
    }
}
