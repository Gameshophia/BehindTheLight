using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
   public Animation ani;
    public Rigidbody2D rb;
   public float moveSpeed;
   // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        float horizontalMove;
        float verticalMove;

        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");

        if(horizontalMove != 0)
        {
            rb.velocity = new Vector2(horizontalMove * moveSpeed,rb.velocity.y);
        }

        if (verticalMove != 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, verticalMove * moveSpeed);
        }
    }
}
