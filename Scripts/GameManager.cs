using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void PlayerDied()
    {
        // Call this method whenever the player dies
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
}
