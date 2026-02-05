using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TutorialManager : MonoBehaviour
{
    public GameObject[] tutorialPanels;
    public string nextSceneName; // Name of the scene to transition to
    private int currentStep = 0;
    private bool canProgress = true; // To prevent multiple taps triggering multiple steps

    void Start()
    {
        ShowTutorialStep(currentStep);
    }

    void Update()
    {
        // Check if touch input is detected
        if (Input.touchCount > 0 && canProgress)
        {
            // Check if the touch phase is the beginning of a touch
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                NextStep();
            }
        }
    }

    public void NextStep()
    {
        HideTutorialStep(currentStep);
        currentStep++;
        if (currentStep < tutorialPanels.Length)
        {
            ShowTutorialStep(currentStep);
        }
        else
        {
            // End of tutorial, load next scene
            LoadNextScene(nextSceneName);
        }
        canProgress = false; // Prevent further progress until the next touch
        Invoke("ResetProgress", 0.5f); // Reset progress after a delay to avoid accidental taps
    }

    void ResetProgress()
    {
        canProgress = true;
    }

    void ShowTutorialStep(int stepIndex)
    {
        tutorialPanels[stepIndex].SetActive(true);
    }

    void HideTutorialStep(int stepIndex)
    {
        tutorialPanels[stepIndex].SetActive(false);
    }

    void LoadNextScene(string sceneName)
    {
        // Load the specified scene
        SceneManager.LoadScene(sceneName);
    }

}

