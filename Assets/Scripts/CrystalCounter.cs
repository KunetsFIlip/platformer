using UnityEngine;
using UnityEngine.UI;

public class CrystalCounter : MonoBehaviour
{

    [Header("Settings")]
    public int crystalCount = 0; // Лічильник кристалів (може збільшуватися до нескінченності)
    public Text crystalText;

    void Awake()
    {
        
    }

    void Start()
    {
        UpdateUI(); // Оновлюємо UI при старті
    }

    public void AddCrystal()
    {
        crystalCount++; // Збільшуємо лічильник на 1
        UpdateUI();
        
        // Тут можна додати додаткові ефекти або звук
        Debug.Log("Кристалів зібрано: " + crystalCount);
    }

    void UpdateUI()
    {
        if (crystalText != null)
        {
            crystalText.text = "Кристали: " + crystalCount.ToString();
        }
    }

    // Метод для скидання лічильника (опціонально)
    public void ResetCounter()
    {
        crystalCount = 0;
        UpdateUI();
    }
}