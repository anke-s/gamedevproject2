using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
   
    public float speed = 8.0f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;
    
    private Vector2 startingPosition;
    private Vector2 direction;


    private void Awake()
    {
        
        startingPosition = new Vector2(Random.Range(-8f, 8f),
            6f);

    }
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        transform.position = startingPosition;
        rb.velocity = new Vector2(-speed * 4 / 5, 0);
        direction = new Vector2( -startingPosition.x,
             -6f);

    }


    // Update is called once per frame
    void Update()
    {

        transform.position = Vector2.MoveTowards(transform.position, direction, speed * Time.deltaTime);

    }
    
}
