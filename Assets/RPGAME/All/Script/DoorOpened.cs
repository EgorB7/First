using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpened : MonoBehaviour
{
    public GameObject DoorOpen;
    public GameObject DoorClose;
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        DoorOpen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
       
       
        
            DoorClose.SetActive(false);
            DoorOpen.SetActive(true);
        
           
      
          
      
            
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
       
       
    }
   
    
}
