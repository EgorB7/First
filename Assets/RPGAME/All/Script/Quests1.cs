using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quests1 : MonoBehaviour
{
    public GameObject dia;
    public GameObject dia1;
    public GameObject dia2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        dia.SetActive(true);
        dia1.SetActive(true);
        dia2.SetActive(true);

    }
    public void OnCollisionExit2D(Collision2D collision)
    {
        dia.SetActive(false);
        dia1.SetActive(false);
        dia2.SetActive(false);
    }
}
