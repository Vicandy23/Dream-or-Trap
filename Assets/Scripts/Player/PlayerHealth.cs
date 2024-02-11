using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth = 100;
    float currentHealth;
    [SerializeField] HealthBarBehavior healthBar;
    public Text deathText;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.UpdateHealthBar(currentHealth, maxHealth);
        healthBar = GetComponentInChildren<HealthBarBehavior>();
        deathText.gameObject.SetActive(false);
    }


    public void Takedamage(float damage)
    {
        healthBar.UpdateHealthBar(currentHealth, maxHealth);
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
            ShowDeathMessage();
            
             RestartLevel();

        }
    }
    public void Heal(float ammount)
    {
        //currentHealth += ammount;
        //if (currentHealth> maxHealth)
        //{
        //    currentHealth = maxHealth;
        //}
        currentHealth = Mathf.Clamp(currentHealth + ammount, 0, maxHealth);



    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            Die();
            ShowDeathMessage();
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
   

    private void ShowDeathMessage()
    {
        deathText.gameObject.SetActive(true); 
        deathText.text = "You died";
       
    }
  
}

