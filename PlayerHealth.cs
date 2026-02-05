using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    private GameManager gameManager;

    private void Start()
    {
        currentHealth = maxHealth;
        gameManager = FindObjectOfType<GameManager>();
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        // Check if player has died
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        // Call GameManager's PlayerDied method
        gameManager.PlayerDied();
    }
}


