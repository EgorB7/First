using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public GameObject chestC;
    public GameObject chestO;
    public GameObject chest1;
    public GameObject chest2;
    public GameObject chest3;
    // Start is called before the first frame update
    void Start()
    {
        chestO.SetActive(false);
}

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        chestC.SetActive(false);
        chestO.SetActive(true);
        chest1.SetActive(true);
        chest2.SetActive(true);
        chest3.SetActive(true);
        
       
}
    public void OnTriggerExit2D(Collider2D collision)
    {
        chestC.SetActive(true);
        chestO.SetActive(false);
        chest1.SetActive(false);
        chest2.SetActive(false);
        chest3.SetActive(false);
    }
}
