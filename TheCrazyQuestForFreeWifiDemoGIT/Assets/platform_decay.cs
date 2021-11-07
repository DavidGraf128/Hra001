using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform_decay : MonoBehaviour
{
    public Animator anim;
    public BoxCollider2D box;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(anim.GetBool("break") == true)
        {
            if(time > 0)
            {
                time -= Time.deltaTime;
            }
            else
            {
                box.enabled = false;
            }
        }
    }
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
            anim.SetBool("break", true);
        
    }
}
