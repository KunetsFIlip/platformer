using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform player; // Посилання на трансформ гравця
    public float moveSpeed = 3f; // Швидкість руху ворога
    public int damage = 1; // Кількість життів, які забирає ворог
    
    private Rigidbody2D rb;
    private Vector2 movement;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        // Якщо не встановлено посилання на гравця, спробуємо знайти його автоматично
        if (player == null)
        {
            GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
            if (playerObject != null)
            {
                player = playerObject.transform;
            }
        }
    }

    void Update()
    {
        if (player != null)
        {
            // Розраховуємо напрямок до гравця
            Vector3 direction = player.position - transform.position;
            direction.Normalize();
            movement = direction;
        }
    }

    void FixedUpdate()
    {
        if (player != null)
        {
            // Рухаємо ворога до гравця
            MoveEnemy(movement);
        }
    }

    void MoveEnemy(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.fixedDeltaTime));
    }

    // void OnCollisionEnter2D(Collision2D collision)
    // {
    //     // Перевіряємо, чи це гравець
    //     if (collision.gameObject.CompareTag("Player"))
    //     {
            
    //             // Забираємо життя у гравця
    //             collision.gameObject.GetComponent<PlayerHealth>().TakeDamage(damage);
                
                
            
    //     }
    // }
}