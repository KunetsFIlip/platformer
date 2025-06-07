using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3; // Максимальна кількість життів
    public int currentHealth; // Поточне здоров'я
    
    void Start()
    {
        currentHealth = maxHealth;
    }
    
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        
        // Перевіряємо, чи гравець помер
        if (currentHealth <= 0)
        {
            Die();
        }
        
        Debug.Log("Player health: " + currentHealth);
    }
    
    void Die()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        // Тут можна реалізувати логіку смерті гравця
        Debug.Log("Player died!");
        
        // Наприклад, перезавантажити рівень або показати екран game over
        // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
         Debug.Log("collision");
        if (collision.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(1);
        }
    }
     
}