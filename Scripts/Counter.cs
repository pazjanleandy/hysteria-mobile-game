using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{
    private TextMeshProUGUI collectObj;
    private int totalObjectives = 8; // Total number of objectives
    public int fontSize = 40;

    private void Start()
    {
        collectObj = GetComponent<TextMeshProUGUI>();
        collectObj.fontSize = fontSize;
    }

    public void UpdateCollectObj(PlayerInventory inventory)
    {
        // Display current objective number and total number of objectives
        collectObj.text = $"{inventory.ObjectiveNumber}/{totalObjectives}";
    }
}
