using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textloader : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject textbox;
    public Text thetext;

    public int currentline;
    public int endline;

    public Movement_wall_drone1 player;

    public TextAsset txtfile;
    public string[] txtlines;

    public bool cando;
    public bool stopplr;


    public bool IsActive;
    // Start is called before the first frame update
    void Start()
    {
        cando = true;
        if(IsActive == true)
        {
            Enabletxt();
        }
        else
        {
            Disabletxt();
        }
       player = FindObjectOfType<Movement_wall_drone1>();
       if(txtfile != null)
        {
            txtlines = (txtfile.text.Split('\n'));
        }
       if(endline == 0)
        {
            endline = txtlines.Length - 1;
        }

    }
     void Update()
    {
        if (!IsActive)
        {
            return;
        }
        thetext.text = txtlines[currentline];
        if (Input.GetKeyDown(KeyCode.Return))
        {
            currentline += 1;
        }
        if (currentline > endline)
        {
            Disabletxt();
        }




    }
    public void Enabletxt()
    {
        cando = false;
        textbox.SetActive(true);
        IsActive = true;
        player.Speed = 0;
        player.Canmove = false;
        
        rb.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
    }
    public void Disabletxt()
    {
        cando = true;
        textbox.SetActive(false);
        IsActive = false;
        player.Speed = 0;
        player.Canmove = true;
        
        rb.constraints = RigidbodyConstraints2D.None;
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }
    public void ReloadScript(TextAsset thetext)
    {
        if(thetext != null)
        {
            txtlines = new string[1];
            txtlines = (thetext.text.Split('\n'));
        }
    }
}
