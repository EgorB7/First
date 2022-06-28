using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyCheck : MonoBehaviour
{
    public GameObject key;
    public GameObject Stoper;
    
    
    // Start is called before the first frame update
    void Start()
    {
        Stoper.SetActive(true);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        key.SetActive(false);
        Stoper.SetActive(false);
       
        
        
    }
    public void OnCollisionExit2D(Collision2D  collision)
    {

    }




}
