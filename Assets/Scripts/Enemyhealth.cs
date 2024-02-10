using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemyhealth : MonoBehaviour
{
    public int maxHealth = 100;
    int currentHealth;
    public GameObject coinPrefab;
    [SerializeField] HealthBarBehavior healthBar;


    void Start()
    {
        currentHealth = maxHealth;
        healthBar.UpdateHealthBar(currentHealth, maxHealth);
        healthBar = GetComponentInChildren<HealthBarBehavior>();
        
    }

   public void TakeDamage (int damage)
    {
        
        currentHealth -= damage;
        healthBar.UpdateHealthBar(currentHealth, maxHealth);
        if (currentHealth<= 0 )
        {
            Die();
            
        }
    }
    void Die()
    {
        Instantiate(coinPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
       
        
    }
    

}
