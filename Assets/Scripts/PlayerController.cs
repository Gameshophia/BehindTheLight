using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Animator ani;
    public Rigidbody2D rb;
    public float moveSpeed;
    private float stopX, stopY;
    public DynamicJoystick dynamicJoystick;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();

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

      //  horizontalMove = Input.GetAxis("Horizontal");
       // verticalMove = Input.GetAxis("Vertical");
        horizontalMove = dynamicJoystick.Horizontal;
        verticalMove = dynamicJoystick.Vertical;
        //if (horizontalMove != 0)
      //  {
            rb.velocity = new Vector2(horizontalMove * moveSpeed, rb.velocity.y);
       // }

      //  if (verticalMove != 0)
     //   {
            rb.velocity = new Vector2(rb.velocity.x, verticalMove * moveSpeed);
        //  }
        if (rb.velocity != Vector2.zero)
        {
            ani.SetBool("isMove", true);
            stopX = horizontalMove;
            stopY = verticalMove;
        }
        else
        {
            ani.SetBool("isMove", false);
        }
        ani.SetFloat("horizontalMove", stopX);
        ani.SetFloat("verticalMove", stopY);

    }


}
