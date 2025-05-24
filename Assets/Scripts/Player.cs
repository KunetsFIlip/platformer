using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    //[SerializeFild] private float forceValue;
    //[SerializeFild] private float minSpeed;
    private Rigidbody2D rb2d;
    private Camera mainCamera;
    private Vector2 statrPosition;

    public bool canDrag;
    public bool isNonevisible;
    // Start is called before the first frame update
    void Start()
    {
        //rb2d.isKinematic = true;
    }
    void Awake()
    {
        mainCamera = Camera.main;
        rb2d = GetComponent<Rigidbody2D>();

    }
    void OnMouseDown()
    {
        //float playerSpeed = rb2d.velocity.magnitube;
        //if(playerSpeed < minSpeed)
        {
            canDrag = true;
            rb2d.isKinematic = true;
            rb2d.velocity = Vector2.zero;
            statrPosition = rb2d.position;

            //GameObject.Find("GameManager").GetComponent<ResultController>().StopTimer();
            isNonevisible = false;
        }
    }
    void OnMouseUP()
    {
        if (canDrag && !isNonevisible)
        {
            Vector2 currentPosition = rb2d.position;
        }
    }
    void OmMouseDrag()
    {
        if (canDrag && !isNonevisible)
        {
            Vector2 mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(mousePosition.x, mousePosition.y);
        }
        else if (canDrag && isNonevisible)
        {
            transform.position = statrPosition;
        }
    }
    void OecameInvisible()
    {
        isNonevisible = true;
    }
    void OriggerEnter2D(Collider2D collision)
    {
       // if (other.GameObject.CompareTag("Finish"))
        {
            //  Destroy(gameObject);
            //GameObject.Find("GameManager").GetComponent<ResultController>().StopTimer();
            //GameObject.Find("GameManager").GetComponent<ResultController>().SaveResul();
        }    
    }
}
