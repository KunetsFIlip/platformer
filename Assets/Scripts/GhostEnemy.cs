using UnityEngine;
using UnityEngine.SceneManagement;

public class GhostEnemy : MonoBehaviour
{
    [Header("Налаштування")]
    public float restartDelay = 1f; // Затримка перед перезапуском
    public GameObject deathEffect; // Ефект смерті (опціонально)
    public AudioClip deathSound; // Звук смерті (опціонально)

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Перевіряємо, чи це гравець
        if (collision.CompareTag("Player"))
        {
            // Відтворюємо ефект смерті (якщо є)
            if (deathEffect != null)
            {
                Instantiate(deathEffect, collision.transform.position, Quaternion.identity);
            }

            // Відтворюємо звук смерті (якщо є)
            if (deathSound != null)
            {
                AudioSource.PlayClipAtPoint(deathSound, transform.position);
            }

            // Вимкнути керування гравцем
            Player playerMovement = collision.GetComponent<Player>();
            if (playerMovement != null)
            {
                playerMovement.enabled = false;
            }

            // Запускаємо перезавантаження рівня з затримкою
            Invoke("RestartLevel", restartDelay);
        }
    }

    void RestartLevel()
    {
        // Отримуємо індекс поточної сцени і перезавантажуємо її
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}