using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroCam : MonoBehaviour
{
    public float nomovetime;
    public float uptime;
    public float waittime;
    public float lighttime;
    public float introtime;
    public int num;
    public float time;
    public float speed;
    public List<float> times;
    public bool fx;
    public bool spaced;

    public Button PlayButton;

    private void Start()
    {
        times = new List<float> { uptime, waittime, lighttime, introtime };
        time = nomovetime;
        num = -1;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Cursor.visible = true;
            GameObject.Find("logo").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.Find("copy").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.Find("PlayButton").GetComponent<Image>().enabled = true;
            GameObject.Find("SettingsButton").GetComponent<Image>().enabled = true;
            GameObject.Find("QuitButton").GetComponent<Image>().enabled = true;
            GameObject.Find("quit").SetActive(true);
            
            GameObject.Find("space").GetComponent<SpriteRenderer>().enabled = false;
            GameObject.Find("logo").GetComponent<Animator>().SetBool("logo", true);
            Cursor.visible = true;
            spaced = true;
        }
            if (time < 0)
        {
            if (num == -1)
            {
                time = times[0];
            }
            if (num == 0)
            {
                time = times[1];
            }
            if (num == 1)
            {
                time = times[2];
            }
            if (num == 2)
            {
                time = times[3];
            }
            if (num == 4)
            {

            }
            else
            {
                num += 1;

            }
           
        }
       else
        {
            time -= Time.deltaTime;
        }


       if (num == 0)
        {
            transform.position += new Vector3(0, speed * Time.deltaTime, 0);
        }
       if (num == 2)
        {
            fx = GameObject.Find("visual_fx").GetComponent<SpriteRenderer>().enabled;
            if (fx == true)
            {
                GameObject.Find("visual_fx").GetComponent<SpriteRenderer>().enabled = false;
                GameObject.Find("visual_fx1").GetComponent<SpriteRenderer>().enabled = false;
                GameObject.Find("hero").GetComponent<SpriteRenderer>().enabled = false;

            }
            else
            {
                GameObject.Find("visual_fx").GetComponent<SpriteRenderer>().enabled = true;
                GameObject.Find("visual_fx1").GetComponent<SpriteRenderer>().enabled = true;
                GameObject.Find("hero").GetComponent<SpriteRenderer>().enabled = true;

            }
        }
        if (num == 3)
        {
            GameObject.Find("visual_fx").GetComponent<SpriteRenderer>().enabled = false;
            GameObject.Find("visual_fx1").GetComponent<SpriteRenderer>().enabled = false;
            if (spaced == false)
            {
                GameObject.Find("hero").GetComponent<SpriteRenderer>().enabled = true;
                GameObject.Find("logo").GetComponent<SpriteRenderer>().enabled = true;
                GameObject.Find("space").GetComponent<SpriteRenderer>().enabled = true;
                GameObject.Find("logo").GetComponent<Animator>().SetBool("logo", true);
            }
        
            
        }

        



    }
}
