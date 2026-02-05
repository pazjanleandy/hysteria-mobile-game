using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;

    private bool isOpen = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!isOpen) // If the door is not already open
            {
                myDoor.Play("DoorOpen", 0, 0.0f);
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
                myDoor.Play("DoorClose", 0, 0.0f);
                isOpen = false;
            }
        }
    }
}
