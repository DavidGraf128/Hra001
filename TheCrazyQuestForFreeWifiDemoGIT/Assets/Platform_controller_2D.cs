using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_controller_2D : MonoBehaviour
{
    private Rigidbody2D rb;
    public Animator animator;
    public  float Speed;
    public Transform Pos;
    public bool Up;
    public bool Down;
    public bool Right;
    public bool Left;
    public bool Starts;
    public bool Stop;
    public bool up;
    public bool down;
    public bool right;
    public bool left;

    public float CheckRadius;
    public LayerMask WhatIsUp;
    public LayerMask WhatIsDown;
    public LayerMask WhatIsRight;
    public LayerMask WhatIsLeft;
    public LayerMask PlayerLayer;
    public LayerMask WhatIsStop;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        //checking
        Up = Physics2D.OverlapCircle(Pos.position, CheckRadius, WhatIsUp);
        Down = Physics2D.OverlapCircle(Pos.position, CheckRadius, WhatIsDown);
        Right = Physics2D.OverlapCircle(Pos.position, CheckRadius, WhatIsRight);
        Left = Physics2D.OverlapCircle(Pos.position, CheckRadius, WhatIsLeft);
        Starts = Physics2D.OverlapCircle(Pos.position, CheckRadius, PlayerLayer);
        Stop = Physics2D.OverlapCircle(Pos.position, CheckRadius, WhatIsStop);
        if (Stop == false)
        {
            if (Up == true)
            {
                up = true;
                down = false;
                right = false;
                left = false;
            }
            else if (Down == true)
            {
                up = false;
                down = true;
                right = false;
                left = false;
            }
            else if (Right == true)
            {
                up = false;
                down = false;
                right = true;
                left = false;
            }
            else if (Left == true)
            {
                up = false;
                down = false; 
                right = false;
                left = true;
            }
            else if (Starts == true)
            {
                if (rb.velocity.x == 0 && rb.velocity.y == 0)
                {
                    up = true;
                }
                
            }
        }
        else
        {
            up = false;
            down = false;
            right = false;
            left = false;
        }



        //movement
       if (up == true)
        {
            rb.velocity = new Vector2(0, Speed);
        }
       else if (down == true)
        {
            rb.velocity = new Vector2(0, -Speed);
        }
        else if (right == true)
        {
            rb.velocity = new Vector2(Speed, 0);
        }
        else if (left == true)
        {
            rb.velocity = new Vector2(-Speed, 0);
        }
       else
        {
            rb.velocity = new Vector2(0, 0);
        }
    }
}
