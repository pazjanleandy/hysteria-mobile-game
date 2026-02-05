using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectiveCount : MonoBehaviour
{
    int ObjectCount;

    public void IncrementObjectiveCount()
    {
        ObjectCount++;
        GetComponent<TextMeshProUGUI>().text = $"Objectives Found: {ObjectCount}";
    }
}
