using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
        public int ObjectiveNumber { get; private set; }

        public UnityEvent<PlayerInventory> OnObjectivePickup;
        public void ObjectiveCollected()
        {
            ObjectiveNumber++;
            OnObjectivePickup.Invoke(this);
        }
    }


