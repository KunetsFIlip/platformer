using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TouchingsObjects : MonoBehaviour
{
    [SerializeField] private int health;
    private Transform spawnPoint;
    private Rigidbody2D rb2d;
    //private UIHealthController  hpController;
    void Awake()
    {
        spawnPoint = GameObject.Find("PlayerSpawnPoint").transform;
        rb2d = GetComponent<Rigidbody2D>();
        //hpController = GetComponent<UiHealthController>();
    }
    void Start()
    {
        //hpController.SetUPHealthBar(health);  
    }
    void Damage(int value)
    {
        rb2d.velocity = Vector2.zero;
        rb2d.angularVelocity = 0;
        rb2d.isKinematic = true;
        transform.position = spawnPoint.position;
        health -= value;
        //Camera.main.GetComponent<CameraMovement>().MoveToStart();
        if (health <= 0)
        {
            SceneManager.LoadScene(0);

        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            //Damage(other.GetComponent<ObstacleSettings>().DamageValue);
        }
    }
}
