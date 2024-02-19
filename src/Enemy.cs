using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    // Method to take damage
    public void TakeDamage(int damage)
    {
        // Reduce health and check if the object is destroyed
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    // Method to heal the object
    public void Heal(int amount)
    {
        // Increase health, ensuring it doesn't exceed the maximum
        currentHealth = Mathf.Min(currentHealth + amount, maxHealth);
    }

    private void Die()
    {
        // TODO: Add death behavior (e.g., play destruction animation, disable collider, etc.)
        Destroy(gameObject);
    }
}
