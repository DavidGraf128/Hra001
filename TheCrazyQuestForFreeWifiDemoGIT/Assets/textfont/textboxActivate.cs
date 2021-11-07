using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textboxActivate : MonoBehaviour
{
    public bool destroywhenactivated;
    public TextAsset thetext;
    public int startline;
    public int endline;
    public textloader thetextbox;
    // Start is called before the first frame update
    void Start()
    {
        thetextbox = FindObjectOfType<textloader>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            thetextbox.ReloadScript(thetext);
            thetextbox.currentline = startline;
            thetextbox.endline = endline;
        }
        if (destroywhenactivated)
        {
            Destroy(gameObject);
        }
    }
}
