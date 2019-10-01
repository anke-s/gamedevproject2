using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gainerrfish : MonoBehaviour
{

    //public float speed;
    private Transform target;
    public float speed = 10.0f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;

    bool isFollowFish;
    //public Text countText;
    public GameObject countText;
    //private int score;

    #region Private Variables
    private float horizontalBound;
    private float verticalBound;
    private Vector2 startingPosition;
    #endregion


   
    private void Awake()
    {
        horizontalBound = 5f;
        verticalBound = 5f;
    }
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed * 4 / 5, 0);
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));


        startingPosition = new Vector2(Random.Range(-horizontalBound, horizontalBound),
            Random.Range(-verticalBound, verticalBound));

        transform.position = startingPosition;
        countText = GameObject.FindGameObjectsWithTag("Text")[0];
  

    }
   

    // Update is called once per frame
    void Update()
    {
        if ((isFollowFish) && Vector2.Distance(transform.position, target.position) > 2)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        }

        else if (transform.position.x < Camera.main.transform.position.x - screenBounds.x * 2)
        {
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isFollowFish = true;
            MovePlayer.updateScore();
            countText.GetComponent<Text>().text = MovePlayer.getScore().ToString();
        }
    }

   
}
