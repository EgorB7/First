using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{
    public GameObject panel;

    public Text dialog;
    public string[] message;
    public bool dialogstart = false;
    
    void Start()
    {
        message[0] = "Hello";
        message[1] = "Bye";
        panel.SetActive(false);
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            panel.SetActive(true);
            dialog.text = message[0];
            dialogstart = true;
            
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        panel.SetActive(false);
        dialogstart = false;
        
    }


    void Update()
    {
        if (dialogstart == true)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                dialog.text = message[1];
            }
            
        }
    }
}
