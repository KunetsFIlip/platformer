using UnityEngine;

public class DeadlySpikes : MonoBehaviour
{
    [Header("Settings")]
    public bool respawnPlayer = true; // Чи повинен гравець респавнитися
    public float respawnDelay = 1f; // Затримка перед респавном
    public GameObject deathEffect; // Ефект смерті (опціонально)

    // private void OnTriggerEnter2D(Collider2D collision)
    // {
    //     // Перевіряємо, чи це гравець
    //     if (collision.CompareTag("Player"))
    //     {
    //         // Отримуємо компонент здоров'я гравця
    //         PlayerHealth playerHealth = collision.GetComponent<PlayerHealth>();
            
    //         if (playerHealth != null)
    //         {
    //             // Запускаємо ефект смерті (якщо є)
    //             if (deathEffect != null)
    //             {
    //                 Instantiate(deathEffect, collision.transform.position, Quaternion.identity);
    //             }

    //             // Вбиваємо гравця
    //             playerHealth.Die();

    //             // Респавнимо гравця (якщо ввімкнено)
    //             if (respawnPlayer)
    //             {
    //                 StartCoroutine(RespawnPlayer(collision.gameObject));
    //             }
    //         }
    //     }
    // }

    // IEnumerator RespawnPlayer(GameObject player)
    // {
    //     // Вимкнення гравця
    //     player.SetActive(false);
        
    //     // Очікування перед респавном
    //     yield return new WaitForSeconds(respawnDelay);
        
    //     // Респавн гравця
    //     if (player != null)
    //     {
    //         player.SetActive(true);
            
    //         // Отримуємо компонент здоров'я і відновлюємо його
    //         PlayerHealth health = player.GetComponent<PlayerHealth>();
    //         if (health != null)
    //         {
    //             health.Respawn();
    //         }
            
    //         // Поміщаємо гравця на точку респавну
    //         // Тут потрібно додати логіку для знаходження точки респавну
    //         // Наприклад:
    //         // player.transform.position = FindObjectOfType<CheckpointManager>().GetLastCheckpoint();
    //     }
    // }
}