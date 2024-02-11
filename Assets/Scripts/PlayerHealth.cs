using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    int currentHealth;
    [SerializeField] HealthBarBehavior healthBar;
    

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.UpdateHealthBar(currentHealth, maxHealth);
        healthBar = GetComponentInChildren<HealthBarBehavior>();
    }

    public void Takedamage(int damage)
    {
        healthBar.UpdateHealthBar(currentHealth, maxHealth);
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
            RestartLevel();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            Die();
            RestartLevel();
        }
    }
    void Die()
    {

        Destroy(gameObject);


    }
    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

