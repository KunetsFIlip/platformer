using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalCollector : MonoBehaviour
{
    private GameObject Canvas;
    void Start()
    {
        Canvas = GameObject.Find("Canvas");
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject); // Видаляється КРИСТАЛ, а не гравець
            Canvas.GetComponent<CrystalCounter>().AddCrystal();
        }
    }
}

